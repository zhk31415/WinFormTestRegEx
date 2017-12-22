using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormTestRegEx
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseForm";
            this.ResumeLayout(false);

        }

        protected void ShowMsg(string msg)
        {
            MessageBox.Show(msg, @"提示");
        }

        protected DialogResult ShowConfirm(string msg)
        {
            DialogResult dr = MessageBox.Show(msg, @"提示", MessageBoxButtons.YesNo);
            return dr;
        }
    }
}
