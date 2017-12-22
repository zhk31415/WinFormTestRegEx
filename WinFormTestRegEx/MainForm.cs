using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Extentions;

namespace WinFormTestRegEx
{
    public partial class MainForm : BaseForm
    {
        /// <summary>
        /// 是否默认开启console窗体
        /// </summary>
        public static bool ConsoleWinForm = System.Configuration.ConfigurationManager.AppSettings["consoleWinForm"] ==
                                            "true";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new Thread(p =>
            {
                Thread.Sleep(10);
                if (this.IsDisposed) return;
                this.Invoke(new EventHandler(delegate
                {
                    tsmStep_Click(null, null);//单独写,窗体焦点会是当前页面,而不是设置页面

                    //加载文件内容
                    if (!string.IsNullOrEmpty(Config.LoadHtml) && System.IO.File.Exists(Config.LoadHtml))
                    {
                        var html = System.IO.File.ReadAllText(Config.LoadHtml);
                        geckoWebBrowser.LoadHtml(html, @"http://www.baidu.com");
                    }

                    this.niMain.Text = this.Text;
                }));
            }).Start();

            if (ConsoleWinForm)
            {
                ConsoleForm.Default.Show();
            }
        }

        private static AboutForm _aboutForm = null;

        private void tsmAbout_Click(object sender, EventArgs e)
        {
            if (_aboutForm == null || _aboutForm.IsDisposed) _aboutForm = new AboutForm();
            _aboutForm.StartPosition = FormStartPosition.CenterScreen;
            _aboutForm.Show();
            _aboutForm.Activate();
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo_Click(btnGo, e);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            geckoWebBrowser.Navigate(txtUrl.Text);
        }

        private StepForm _stepForm = null;

        private void tsmStep_Click(object sender, EventArgs e)
        {
            //if (_stepForm == null || _stepForm.IsDisposed) 
            if (_stepForm != null && _stepForm.IsDisposed == false)
            {
                _stepForm.Close();
                _stepForm.Dispose();
            }
            _stepForm = new StepForm(this);
            _stepForm.StartPosition = FormStartPosition.CenterScreen;
            _stepForm.Show();
            _stepForm.Activate();
        }

        private void tsmConsole_Click(object sender, EventArgs e)
        {
            ConsoleForm.Default.ShowOrHide();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(txtUrl.Text);
            ConsoleForm.WriteLine(txtUrl.Text);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ConsoleHelper.FreeConsole();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if (_aboutForm != null) _aboutForm.Dispose();
            if (_stepForm != null) _stepForm.Dispose();
            ConsoleForm.Default.Hide();

            this.Hide();
            tsmiShowWinForm.Text = @"显示";
            niMain.ShowBalloonTip(5000);
        }

        private void niMain_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                this.Show();
                ConsoleForm.Default.Show();
                tsmiShowWinForm.Text = @"隐藏";
            }
            else
            {
                this.Close();
                //tsmiShowWinForm.Text = @"显示";
            }
        }

        private void tsmiClick(object sender, EventArgs e)
        {
            var o = sender as ToolStripMenuItem;
            if (o == null) return;
            if (o == tsmiShowWinForm)
            {
                niMain_DoubleClick(sender, e);
            }
            else if (o == tsmiExit)
            {
                Esc();
            }
        }

        private void Esc()
        {
            niMain.Visible = false;
            this.Close();
            Application.ExitThread();
            Application.Exit();
        }
    }
}
