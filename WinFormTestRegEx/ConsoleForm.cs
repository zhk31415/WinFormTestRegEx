using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormTestRegEx
{
    public partial class ConsoleForm : BaseForm
    {
        public ConsoleForm()
        {
            InitializeComponent();
        }

        private static ConsoleForm _default;

        public static ConsoleForm Default
        {
            get
            {
                if (_default == null) _default = new ConsoleForm();
                return _default;
            }
        }

        private void ConsoleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        public void ShowOrHide()
        {
            //ConsoleForm.Default.WindowState = FormWindowState.Normal;
            if (this.Visible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }
        }

        public static void WriteLine(string content)
        {
            Default.txtWrite.Text += content + "\r\n";
        }

        private void ConsoleForm_Load(object sender, EventArgs e)
        {
        }
    }
}
