using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Gecko;

namespace WinFormTestRegEx
{
    public class Program
    {
        //Enable remote debugger, so that you can debug web pages in geckofx via firefox:
        //1. Set your firefox's pref 'devtools.debugger.remote-enabled' to true, via 'about:config' page.
        //2. In firefox, go to Tools > Web Developer > Connect..., keep localhost:6000, click connect, confirm the dialog from geckofx.
        static bool RemoteDebuggerEnabled = false;

        [STAThread]
        public static void Main(string[] args)
        {
            #region FF浏览器的
            // If you want to customize the GeckoFx PromptService then 
            // you will need make a class that implements some or all of nsIPrompt, 
            // nsIAuthPrompt2, and nsIAuthPrompt interfaces and
            // set the PromptFactory.PromptServiceCreator delegate. for example:
            // PromptFactory.PromptServiceCreator = () => new MyPromptService();
            // Gecko.PromptService already implements those interfaces, and may be sub-classed.

            string xulrunnerPath = XULRunnerLocator.GetXULRunnerLocation();
            //xulrunnerPath = @"C:\mozilla-central\obj-i686-pc-mingw32\dist\bin";
#if GTK		
			if (!Environment.GetEnvironmentVariable("LD_LIBRARY_PATH").Contains(xulrunnerPath))
				throw new ApplicationException(String.Format("LD_LIBRARY_PATH must contain {0}", xulrunnerPath));			
#endif
            Xpcom.Initialize(xulrunnerPath);
            // Uncomment the follow line to enable error page
            GeckoPreferences.User["browser.xul.error_pages.enabled"] = true;

            GeckoPreferences.User["gfx.font_rendering.graphite.enabled"] = true;

            GeckoPreferences.User["full-screen-api.enabled"] = true;

#if DEBUG
            if (RemoteDebuggerEnabled)
                StartDebugServer();
#endif

            Application.ApplicationExit += (sender, e) =>
            {
                Xpcom.Shutdown();
            };
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var mainForm = new MainForm();
            Gecko.LauncherDialog.Download += (s, e) => LauncherDialog_Download(mainForm, s, e);

            //Application.Idle += (s, e) => Console.WriteLine(SynchronizationContext.Current); 
            #endregion
            
            #region 抓异常的

            //处理未捕获的异常
            //Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //处理UI线程异常   
            Application.ThreadException += Application_ThreadException;
            //处理非UI线程异常
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException; 

            #endregion
            
            Application.Run(mainForm);
        }

        #region FF浏览器的
        static void RegisterChromeDir(string dir)
        {
            var chromeDir = (nsIFile)Xpcom.NewNativeLocalFile(dir);
            var chromeFile = chromeDir.Clone();
            chromeFile.Append(new nsAString("chrome.manifest"));
            Xpcom.ComponentRegistrar.AutoRegister(chromeFile);
            Xpcom.ComponentManager.AddBootstrappedManifestLocation(chromeDir);
        }

        static void StartDebugServer()
        {
            GeckoPreferences.User["devtools.debugger.remote-enabled"] = true;

            //see <geckofx_src>/chrome dir
            RegisterChromeDir(Path.GetFullPath(Path.Combine(XULRunnerLocator.GetXULRunnerLocation(), "../../chrome")));

            var browser = new GeckoWebBrowser();
            browser.NavigationError += (s, e) =>
            {
                Console.Error.WriteLine("StartDebugServer error: 0x" + e.ErrorCode.ToString("X"));
                browser.Dispose();
            };
            browser.DocumentCompleted += (s, e) =>
            {
                Console.WriteLine("StartDebugServer completed");
                browser.Dispose();
            };
            //see <geckofx_src>/chrome/debugger-server.html
            browser.Navigate("chrome://geckofx/content/debugger-server.html");
        }

        // From Timothy N in https://bitbucket.org/geckofx/geckofx-29.0/issue/34/how-to-download-files-using-this-engine
        static void LauncherDialog_Download(IWin32Window owner, object sender, LauncherDialogEvent e)
        {
            uint flags = (uint)nsIWebBrowserPersistConsts.PERSIST_FLAGS_NO_CONVERSION |
                (uint)nsIWebBrowserPersistConsts.PERSIST_FLAGS_REPLACE_EXISTING_FILES |
                (uint)nsIWebBrowserPersistConsts.PERSIST_FLAGS_BYPASS_CACHE;
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = e.Filename;
            if (sfd.ShowDialog(owner) == DialogResult.OK)
            {
                // the part that do the download, may be used for automation, or when the source URI is known, or after a parse of the dom :
                string url = e.Url;  //url to download
                string fullpath = sfd.FileName; //destination file absolute path
                nsIWebBrowserPersist persist = Xpcom.GetService<nsIWebBrowserPersist>("@mozilla.org/embedding/browser/nsWebBrowserPersist;1");
                nsIURI source = IOService.CreateNsIUri(url);
                nsIURI dest = IOService.CreateNsIUri(new Uri(fullpath).AbsoluteUri);
                persist.SetPersistFlagsAttribute(flags);
#if PORT_GECKO45
				persist.SaveURI(source, null, null, null, null, (nsISupports)dest, null);
#endif
                // file is saved - asynchronous call
                // need to try to have a temp name while the file is downloaded eg filename.ext.geckodownload (one of the SaveURI option)
            }
        }
        #endregion

        #region 抓异常的

        ///<summary>
        ///  这就是我们要在发生未处理异常时处理的方法，我这是写出错详细信息到文本，如出错后弹出一个漂亮的出错提示窗体，给大家做个参考
        ///  做法很多，可以是把出错详细信息记录到文本、数据库，发送出错邮件到作者信箱或出错后重新初始化等等
        ///  这就是仁者见仁智者见智，大家自己做了。
        ///</summary>
        ///<param name="sender"> </param>
        ///<param name="e"> </param>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            var ex = e.Exception;
            if (ex != null)
            {
                MessageBox.Show(ex.Message, @"异常信息");
                return;
            }
            MessageBox.Show(@"系统出现未知异常，请重启系统！");
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            var ex = e.ExceptionObject as Exception;
            if (ex != null)
            {
                MessageBox.Show(ex.Message, @"异常信息");
                return;
            }

            MessageBox.Show(@"系统出现未知异常，请重启系统！");
        }

        #endregion
    }
}
