namespace WinFormTestRegEx
{
    partial class ConsoleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWrite = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtWrite
            // 
            this.txtWrite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWrite.Location = new System.Drawing.Point(0, 0);
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.ReadOnly = true;
            this.txtWrite.Size = new System.Drawing.Size(611, 319);
            this.txtWrite.TabIndex = 0;
            this.txtWrite.Text = "";
            // 
            // ConsoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 319);
            this.Controls.Add(this.txtWrite);
            this.Name = "ConsoleForm";
            this.ShowInTaskbar = false;
            this.Text = "ConsoleForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConsoleForm_FormClosing);
            this.Load += new System.EventHandler(this.ConsoleForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtWrite;

    }
}