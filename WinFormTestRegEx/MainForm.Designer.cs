namespace WinFormTestRegEx
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGo = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.geckoWebBrowser = new Gecko.GeckoWebBrowser();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmStep = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsole = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnTest = new System.Windows.Forms.Button();
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShowWinForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msMain.SuspendLayout();
            this.cmsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(746, 28);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "go(&g)";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(12, 28);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(724, 21);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "www.baidu.com";
            this.txtUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyUp);
            // 
            // geckoWebBrowser
            // 
            this.geckoWebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.geckoWebBrowser.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser.Location = new System.Drawing.Point(0, 83);
            this.geckoWebBrowser.Name = "geckoWebBrowser";
            this.geckoWebBrowser.Size = new System.Drawing.Size(829, 289);
            this.geckoWebBrowser.TabIndex = 0;
            this.geckoWebBrowser.UseHttpActivityObserver = false;
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.SystemColors.Control;
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStep,
            this.tsmConsole,
            this.tsmAbout});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(829, 25);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmStep
            // 
            this.tsmStep.Name = "tsmStep";
            this.tsmStep.Size = new System.Drawing.Size(44, 21);
            this.tsmStep.Text = "设置";
            this.tsmStep.Click += new System.EventHandler(this.tsmStep_Click);
            // 
            // tsmConsole
            // 
            this.tsmConsole.Name = "tsmConsole";
            this.tsmConsole.Size = new System.Drawing.Size(56, 21);
            this.tsmConsole.Text = "控制台";
            this.tsmConsole.Click += new System.EventHandler(this.tsmConsole_Click);
            // 
            // tsmAbout
            // 
            this.tsmAbout.Name = "tsmAbout";
            this.tsmAbout.Size = new System.Drawing.Size(44, 21);
            this.tsmAbout.Text = "关于";
            this.tsmAbout.Click += new System.EventHandler(this.tsmAbout_Click);
            // 
            // BtnTest
            // 
            this.BtnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnTest.Location = new System.Drawing.Point(12, 55);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(75, 23);
            this.BtnTest.TabIndex = 2;
            this.BtnTest.Text = "Test(&t)";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // niMain
            // 
            this.niMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niMain.BalloonTipText = "我在这里";
            this.niMain.BalloonTipTitle = "提示";
            this.niMain.ContextMenuStrip = this.cmsMain;
            this.niMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niMain.Icon")));
            this.niMain.Visible = true;
            this.niMain.DoubleClick += new System.EventHandler(this.niMain_DoubleClick);
            // 
            // cmsMain
            // 
            this.cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShowWinForm,
            this.tsmiExit});
            this.cmsMain.Name = "cmsMain";
            this.cmsMain.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiShowWinForm
            // 
            this.tsmiShowWinForm.Name = "tsmiShowWinForm";
            this.tsmiShowWinForm.Size = new System.Drawing.Size(100, 22);
            this.tsmiShowWinForm.Text = "隐藏";
            this.tsmiShowWinForm.Click += new System.EventHandler(this.tsmiClick);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(100, 22);
            this.tsmiExit.Text = "退出";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 371);
            this.Controls.Add(this.BtnTest);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.geckoWebBrowser);
            this.Controls.Add(this.msMain);
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "测试正则";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.cmsMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmStep;
        private System.Windows.Forms.ToolStripMenuItem tsmAbout;
        public Gecko.GeckoWebBrowser geckoWebBrowser;
        public System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.ToolStripMenuItem tsmConsole;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.ContextMenuStrip cmsMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowWinForm;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
    }
}

