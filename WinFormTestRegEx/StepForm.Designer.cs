namespace WinFormTestRegEx
{
    partial class StepForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabListType = new System.Windows.Forms.TabControl();
            this.tabListType1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.tabListType2 = new System.Windows.Forms.TabPage();
            this.cmbMulti2 = new System.Windows.Forms.ComboBox();
            this.cmbMulti = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatternUrl2 = new System.Windows.Forms.TextBox();
            this.txtPatternUrl = new System.Windows.Forms.TextBox();
            this.txtUrl2 = new System.Windows.Forms.TextBox();
            this.txtNumAdd = new System.Windows.Forms.TextBox();
            this.txtNumEnd = new System.Windows.Forms.TextBox();
            this.txtNumStart = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.idColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PropertyNameColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromSourceColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PatternColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MultiColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Pattern2Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Multi2Column1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EnumSaveTypeColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OpDateColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemarkColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R1Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R2Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R3Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R4Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R5Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R6Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R7Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R8Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R9Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R10Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsbMain = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lsbUrl = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbContent = new System.Windows.Forms.GroupBox();
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnStartUrl = new System.Windows.Forms.Button();
            this.btnStartGetData = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnStartUrlFromPage = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbWebTypeId = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbData = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.tabListType.SuspendLayout();
            this.tabListType1.SuspendLayout();
            this.tabListType2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.gbContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tabListType);
            this.groupBox1.Controls.Add(this.txtNumAdd);
            this.groupBox1.Controls.Add(this.txtNumEnd);
            this.groupBox1.Controls.Add(this.txtNumStart);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(119, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "列表数据获取";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(276, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "{num}加入到链接中";
            // 
            // tabListType
            // 
            this.tabListType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabListType.Controls.Add(this.tabListType1);
            this.tabListType.Controls.Add(this.tabListType2);
            this.tabListType.Location = new System.Drawing.Point(6, 42);
            this.tabListType.Name = "tabListType";
            this.tabListType.SelectedIndex = 0;
            this.tabListType.Size = new System.Drawing.Size(478, 119);
            this.tabListType.TabIndex = 4;
            // 
            // tabListType1
            // 
            this.tabListType1.Controls.Add(this.label2);
            this.tabListType1.Controls.Add(this.txtUrl);
            this.tabListType1.Location = new System.Drawing.Point(4, 22);
            this.tabListType1.Name = "tabListType1";
            this.tabListType1.Padding = new System.Windows.Forms.Padding(3);
            this.tabListType1.Size = new System.Drawing.Size(470, 93);
            this.tabListType1.TabIndex = 0;
            this.tabListType1.Text = "方式1";
            this.tabListType1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "网址(带http://开头):";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(141, 29);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(325, 21);
            this.txtUrl.TabIndex = 2;
            // 
            // tabListType2
            // 
            this.tabListType2.Controls.Add(this.cmbMulti2);
            this.tabListType2.Controls.Add(this.cmbMulti);
            this.tabListType2.Controls.Add(this.label12);
            this.tabListType2.Controls.Add(this.label11);
            this.tabListType2.Controls.Add(this.label8);
            this.tabListType2.Controls.Add(this.txtPatternUrl2);
            this.tabListType2.Controls.Add(this.txtPatternUrl);
            this.tabListType2.Controls.Add(this.txtUrl2);
            this.tabListType2.Location = new System.Drawing.Point(4, 22);
            this.tabListType2.Name = "tabListType2";
            this.tabListType2.Padding = new System.Windows.Forms.Padding(3);
            this.tabListType2.Size = new System.Drawing.Size(470, 93);
            this.tabListType2.TabIndex = 1;
            this.tabListType2.Text = "方式2";
            this.tabListType2.UseVisualStyleBackColor = true;
            // 
            // cmbMulti2
            // 
            this.cmbMulti2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMulti2.FormattingEnabled = true;
            this.cmbMulti2.Location = new System.Drawing.Point(409, 66);
            this.cmbMulti2.Name = "cmbMulti2";
            this.cmbMulti2.Size = new System.Drawing.Size(54, 20);
            this.cmbMulti2.TabIndex = 6;
            // 
            // cmbMulti
            // 
            this.cmbMulti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMulti.FormattingEnabled = true;
            this.cmbMulti.Location = new System.Drawing.Point(409, 32);
            this.cmbMulti.Name = "cmbMulti";
            this.cmbMulti.Size = new System.Drawing.Size(54, 20);
            this.cmbMulti.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "正则内容里再次正则";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "内容里取链接地址正则";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "网址(带http://开头):";
            // 
            // txtPatternUrl2
            // 
            this.txtPatternUrl2.Location = new System.Drawing.Point(138, 66);
            this.txtPatternUrl2.Name = "txtPatternUrl2";
            this.txtPatternUrl2.Size = new System.Drawing.Size(265, 21);
            this.txtPatternUrl2.TabIndex = 5;
            // 
            // txtPatternUrl
            // 
            this.txtPatternUrl.Location = new System.Drawing.Point(137, 32);
            this.txtPatternUrl.Name = "txtPatternUrl";
            this.txtPatternUrl.Size = new System.Drawing.Size(266, 21);
            this.txtPatternUrl.TabIndex = 5;
            // 
            // txtUrl2
            // 
            this.txtUrl2.Location = new System.Drawing.Point(137, 3);
            this.txtUrl2.Name = "txtUrl2";
            this.txtUrl2.Size = new System.Drawing.Size(325, 21);
            this.txtUrl2.TabIndex = 5;
            // 
            // txtNumAdd
            // 
            this.txtNumAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumAdd.Location = new System.Drawing.Point(232, 15);
            this.txtNumAdd.Name = "txtNumAdd";
            this.txtNumAdd.Size = new System.Drawing.Size(34, 21);
            this.txtNumAdd.TabIndex = 3;
            // 
            // txtNumEnd
            // 
            this.txtNumEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumEnd.Location = new System.Drawing.Point(142, 15);
            this.txtNumEnd.Name = "txtNumEnd";
            this.txtNumEnd.Size = new System.Drawing.Size(44, 21);
            this.txtNumEnd.TabIndex = 3;
            // 
            // txtNumStart
            // 
            this.txtNumStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumStart.Location = new System.Drawing.Point(72, 15);
            this.txtNumStart.Name = "txtNumStart";
            this.txtNumStart.Size = new System.Drawing.Size(44, 21);
            this.txtNumStart.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "到";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "增量:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "数字范围:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "名称:";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Location = new System.Drawing.Point(158, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 21);
            this.txtName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvMain);
            this.groupBox2.Location = new System.Drawing.Point(119, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据具体内容获取设置";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn1,
            this.PropertyNameColumn1,
            this.FromSourceColumn1,
            this.PatternColumn1,
            this.MultiColumn1,
            this.Pattern2Column1,
            this.Multi2Column1,
            this.EnumSaveTypeColumn1,
            this.OpDateColumn1,
            this.RemarkColumn1,
            this.R1Column1,
            this.R2Column1,
            this.R3Column1,
            this.R4Column1,
            this.R5Column1,
            this.R6Column1,
            this.R7Column1,
            this.R8Column1,
            this.R9Column1,
            this.R10Column1});
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 17);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(482, 170);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvMain_DataError);
            // 
            // idColumn1
            // 
            this.idColumn1.DataPropertyName = "Id";
            this.idColumn1.HeaderText = "主键";
            this.idColumn1.Name = "idColumn1";
            this.idColumn1.Visible = false;
            // 
            // PropertyNameColumn1
            // 
            this.PropertyNameColumn1.DataPropertyName = "PropertyName";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            this.PropertyNameColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.PropertyNameColumn1.HeaderText = "属性名称";
            this.PropertyNameColumn1.Name = "PropertyNameColumn1";
            this.PropertyNameColumn1.ReadOnly = true;
            // 
            // FromSourceColumn1
            // 
            this.FromSourceColumn1.DataPropertyName = "FromSource";
            this.FromSourceColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.FromSourceColumn1.HeaderText = "数据来源";
            this.FromSourceColumn1.Name = "FromSourceColumn1";
            // 
            // PatternColumn1
            // 
            this.PatternColumn1.DataPropertyName = "Pattern";
            this.PatternColumn1.HeaderText = "正则";
            this.PatternColumn1.Name = "PatternColumn1";
            // 
            // MultiColumn1
            // 
            this.MultiColumn1.DataPropertyName = "Multi";
            this.MultiColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.MultiColumn1.HeaderText = "单/多";
            this.MultiColumn1.Name = "MultiColumn1";
            this.MultiColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MultiColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Pattern2Column1
            // 
            this.Pattern2Column1.DataPropertyName = "Pattern2";
            this.Pattern2Column1.HeaderText = "正则2";
            this.Pattern2Column1.Name = "Pattern2Column1";
            // 
            // Multi2Column1
            // 
            this.Multi2Column1.DataPropertyName = "Multi2";
            this.Multi2Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.Multi2Column1.HeaderText = "单/多2";
            this.Multi2Column1.Name = "Multi2Column1";
            this.Multi2Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Multi2Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EnumSaveTypeColumn1
            // 
            this.EnumSaveTypeColumn1.DataPropertyName = "EnumSaveType";
            this.EnumSaveTypeColumn1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.EnumSaveTypeColumn1.HeaderText = "存入方式";
            this.EnumSaveTypeColumn1.Name = "EnumSaveTypeColumn1";
            this.EnumSaveTypeColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // OpDateColumn1
            // 
            this.OpDateColumn1.DataPropertyName = "OpDate";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            this.OpDateColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.OpDateColumn1.HeaderText = "创建时间";
            this.OpDateColumn1.Name = "OpDateColumn1";
            this.OpDateColumn1.ReadOnly = true;
            // 
            // RemarkColumn1
            // 
            this.RemarkColumn1.DataPropertyName = "Remark";
            this.RemarkColumn1.HeaderText = "备注";
            this.RemarkColumn1.Name = "RemarkColumn1";
            // 
            // R1Column1
            // 
            this.R1Column1.DataPropertyName = "R1";
            this.R1Column1.HeaderText = "R1";
            this.R1Column1.Name = "R1Column1";
            // 
            // R2Column1
            // 
            this.R2Column1.DataPropertyName = "R2";
            this.R2Column1.HeaderText = "R2";
            this.R2Column1.Name = "R2Column1";
            // 
            // R3Column1
            // 
            this.R3Column1.DataPropertyName = "R3";
            this.R3Column1.HeaderText = "R3";
            this.R3Column1.Name = "R3Column1";
            // 
            // R4Column1
            // 
            this.R4Column1.DataPropertyName = "R4";
            this.R4Column1.HeaderText = "R4";
            this.R4Column1.Name = "R4Column1";
            // 
            // R5Column1
            // 
            this.R5Column1.DataPropertyName = "R5";
            this.R5Column1.HeaderText = "R5";
            this.R5Column1.Name = "R5Column1";
            // 
            // R6Column1
            // 
            this.R6Column1.DataPropertyName = "R6";
            this.R6Column1.HeaderText = "R6";
            this.R6Column1.Name = "R6Column1";
            // 
            // R7Column1
            // 
            this.R7Column1.DataPropertyName = "R7";
            this.R7Column1.HeaderText = "R7";
            this.R7Column1.Name = "R7Column1";
            // 
            // R8Column1
            // 
            this.R8Column1.DataPropertyName = "R8";
            this.R8Column1.HeaderText = "R8";
            this.R8Column1.Name = "R8Column1";
            // 
            // R9Column1
            // 
            this.R9Column1.DataPropertyName = "R9";
            this.R9Column1.HeaderText = "R9";
            this.R9Column1.Name = "R9Column1";
            // 
            // R10Column1
            // 
            this.R10Column1.DataPropertyName = "R10";
            this.R10Column1.HeaderText = "R10";
            this.R10Column1.Name = "R10Column1";
            // 
            // lsbMain
            // 
            this.lsbMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsbMain.FormattingEnabled = true;
            this.lsbMain.ItemHeight = 12;
            this.lsbMain.Location = new System.Drawing.Point(12, 35);
            this.lsbMain.Name = "lsbMain";
            this.lsbMain.Size = new System.Drawing.Size(99, 376);
            this.lsbMain.TabIndex = 3;
            this.lsbMain.SelectedIndexChanged += new System.EventHandler(this.lsbMain_SelectedIndexChanged);
            this.lsbMain.DoubleClick += new System.EventHandler(this.lsbUrl_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "名称";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(793, 429);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存(&s)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lsbUrl
            // 
            this.lsbUrl.FormattingEnabled = true;
            this.lsbUrl.ItemHeight = 12;
            this.lsbUrl.Location = new System.Drawing.Point(6, 16);
            this.lsbUrl.Name = "lsbUrl";
            this.lsbUrl.Size = new System.Drawing.Size(249, 172);
            this.lsbUrl.TabIndex = 5;
            this.lsbUrl.DoubleClick += new System.EventHandler(this.lsbUrl_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lsbUrl);
            this.groupBox3.Location = new System.Drawing.Point(613, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 194);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "URL列表数据集合";
            // 
            // gbContent
            // 
            this.gbContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContent.Controls.Add(this.txtMain);
            this.gbContent.Location = new System.Drawing.Point(613, 233);
            this.gbContent.Name = "gbContent";
            this.gbContent.Size = new System.Drawing.Size(268, 190);
            this.gbContent.TabIndex = 1;
            this.gbContent.TabStop = false;
            this.gbContent.Text = "数据具体内容获取";
            // 
            // txtMain
            // 
            this.txtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMain.Location = new System.Drawing.Point(3, 17);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(262, 170);
            this.txtMain.TabIndex = 0;
            this.txtMain.Text = "";
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.Location = new System.Drawing.Point(793, 204);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 9;
            this.btnGo.Text = "跳转到(&g)";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnStartUrl
            // 
            this.btnStartUrl.Location = new System.Drawing.Point(119, 204);
            this.btnStartUrl.Name = "btnStartUrl";
            this.btnStartUrl.Size = new System.Drawing.Size(186, 23);
            this.btnStartUrl.TabIndex = 4;
            this.btnStartUrl.Text = "开始获取URL列表数据集合(&5)";
            this.btnStartUrl.UseVisualStyleBackColor = true;
            this.btnStartUrl.Click += new System.EventHandler(this.btnStartUrl_Click);
            // 
            // btnStartGetData
            // 
            this.btnStartGetData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartGetData.Location = new System.Drawing.Point(488, 429);
            this.btnStartGetData.Name = "btnStartGetData";
            this.btnStartGetData.Size = new System.Drawing.Size(119, 23);
            this.btnStartGetData.TabIndex = 4;
            this.btnStartGetData.Text = "开始抓取数据(&6)";
            this.btnStartGetData.UseVisualStyleBackColor = true;
            this.btnStartGetData.Click += new System.EventHandler(this.btnStartGetData_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(69, 6);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(42, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "刷新";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnStartUrlFromPage
            // 
            this.btnStartUrlFromPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartUrlFromPage.Location = new System.Drawing.Point(474, 204);
            this.btnStartUrlFromPage.Name = "btnStartUrlFromPage";
            this.btnStartUrlFromPage.Size = new System.Drawing.Size(133, 23);
            this.btnStartUrlFromPage.TabIndex = 4;
            this.btnStartUrlFromPage.Text = "方式2页面里抓取(&R)";
            this.btnStartUrlFromPage.UseVisualStyleBackColor = true;
            this.btnStartUrlFromPage.Click += new System.EventHandler(this.btnStartUrlFromPage_Click);
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDel.Location = new System.Drawing.Point(69, 429);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(42, 23);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(12, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(617, 209);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 12);
            this.lblResult.TabIndex = 1;
            // 
            // cmbWebTypeId
            // 
            this.cmbWebTypeId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbWebTypeId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWebTypeId.FormattingEnabled = true;
            this.cmbWebTypeId.Location = new System.Drawing.Point(358, 8);
            this.cmbWebTypeId.Name = "cmbWebTypeId";
            this.cmbWebTypeId.Size = new System.Drawing.Size(56, 20);
            this.cmbWebTypeId.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "网站类型:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "存储数据表:";
            // 
            // cmbData
            // 
            this.cmbData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbData.FormattingEnabled = true;
            this.cmbData.Location = new System.Drawing.Point(489, 8);
            this.cmbData.Name = "cmbData";
            this.cmbData.Size = new System.Drawing.Size(118, 20);
            this.cmbData.TabIndex = 6;
            this.cmbData.SelectedIndexChanged += new System.EventHandler(this.cmbData_SelectedIndexChanged);
            // 
            // StepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmbData);
            this.Controls.Add(this.cmbWebTypeId);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnStartGetData);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnStartUrlFromPage);
            this.Controls.Add(this.btnStartUrl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lsbMain);
            this.Controls.Add(this.gbContent);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "StepForm";
            this.ShowInTaskbar = false;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.StepForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabListType.ResumeLayout(false);
            this.tabListType1.ResumeLayout(false);
            this.tabListType1.PerformLayout();
            this.tabListType2.ResumeLayout(false);
            this.tabListType2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.gbContent.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lsbMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lsbUrl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox gbContent;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtNumStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabListType;
        private System.Windows.Forms.TabPage tabListType1;
        private System.Windows.Forms.TabPage tabListType2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUrl2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnStartUrl;
        private System.Windows.Forms.Button btnStartGetData;
        private System.Windows.Forms.TextBox txtPatternUrl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPatternUrl2;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.ComboBox cmbMulti;
        private System.Windows.Forms.ComboBox cmbMulti2;
        private System.Windows.Forms.Button btnStartUrlFromPage;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbWebTypeId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbData;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyNameColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn FromSourceColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatternColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn MultiColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pattern2Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn Multi2Column1;
        private System.Windows.Forms.DataGridViewComboBoxColumn EnumSaveTypeColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpDateColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RemarkColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R1Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R2Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R3Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R4Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R5Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R6Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R7Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R8Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R9Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn R10Column1;
        private System.Windows.Forms.RichTextBox txtMain;
    }
}