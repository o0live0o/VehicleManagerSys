namespace VehicleManagerSys.Main.CustomForms
{
    partial class ComprehensiveUploadSettingForm
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
            this.flatField1 = new CI.Controls.FlatField();
            this.settingFiller = new CI.UIComponents.Filler.EntityFiller();
            this.flatField2 = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.flatField4 = new CI.Controls.FlatField();
            this.txtAreaCode = new CI.Controls.FlatField();
            this.flatField6 = new CI.Controls.FlatField();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAJ_Y = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dgvImgType = new System.Windows.Forms.DataGridView();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetectLine = new System.Windows.Forms.DataGridView();
            this.colLocalLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetectLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDetectLineC = new System.Windows.Forms.CheckBox();
            this.txtImgPath = new CI.Controls.FlatField();
            this.dgvOperator = new System.Windows.Forms.DataGridView();
            this.colOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDeletePicType = new EASkins.Ami_Button_2();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteLineType = new EASkins.Ami_Button_2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAreaSelect = new EASkins.Ami_Button_1();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnPicPathSelect = new EASkins.Ami_Button_1();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSave = new EASkins.Emi_Button_2();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteAuthor = new EASkins.Ami_Button_2();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImgType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetectLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperator)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flatField1
            // 
            this.flatField1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "上传地址: ";
            this.flatField1.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField1.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("url", ""));
            this.flatField1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField1.Location = new System.Drawing.Point(28, 83);
            this.flatField1.Name = "flatField1";
            this.flatField1.Size = new System.Drawing.Size(922, 31);
            this.flatField1.TabIndex = 7;
            // 
            // flatField2
            // 
            this.flatField2.BackColor = System.Drawing.Color.Transparent;
            this.flatField2.Caption = "检测机构名称:";
            this.flatField2.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField2.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField2, new CI.UIComponents.Filler.TextEntry("Company", ""));
            this.flatField2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField2.Location = new System.Drawing.Point(20, 25);
            this.flatField2.Name = "flatField2";
            this.flatField2.Size = new System.Drawing.Size(382, 31);
            this.flatField2.TabIndex = 8;
            // 
            // flatField3
            // 
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "检测机构编码:";
            this.flatField3.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("CompanyId", ""));
            this.flatField3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.Location = new System.Drawing.Point(20, 61);
            this.flatField3.Name = "flatField3";
            this.flatField3.Size = new System.Drawing.Size(382, 31);
            this.flatField3.TabIndex = 8;
            // 
            // flatField4
            // 
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "用户账号: ";
            this.flatField4.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField4, new CI.UIComponents.Filler.TextEntry("UserCode", ""));
            this.flatField4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.Location = new System.Drawing.Point(20, 97);
            this.flatField4.Name = "flatField4";
            this.flatField4.Size = new System.Drawing.Size(382, 31);
            this.flatField4.TabIndex = 8;
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.BackColor = System.Drawing.Color.Transparent;
            this.txtAreaCode.Caption = "行政区域: ";
            this.txtAreaCode.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtAreaCode.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.txtAreaCode, new CI.UIComponents.Filler.TextEntry("AdministrativeAera", ""));
            this.txtAreaCode.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtAreaCode.Location = new System.Drawing.Point(20, 133);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Size = new System.Drawing.Size(332, 31);
            this.txtAreaCode.TabIndex = 8;
            // 
            // flatField6
            // 
            this.flatField6.BackColor = System.Drawing.Color.Transparent;
            this.flatField6.Caption = "密钥:     ";
            this.flatField6.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField6.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField6, new CI.UIComponents.Filler.TextEntry("Key", ""));
            this.flatField6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField6.Location = new System.Drawing.Point(20, 169);
            this.flatField6.Name = "flatField6";
            this.flatField6.Size = new System.Drawing.Size(382, 31);
            this.flatField6.TabIndex = 8;
            // 
            // textBox1
            // 
            this.settingFiller.SetEntityField(this.textBox1, new CI.UIComponents.Filler.TextEntry("X_Station", ""));
            this.textBox1.Location = new System.Drawing.Point(122, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 23);
            this.textBox1.TabIndex = 0;
            // 
            // txtAJ_Y
            // 
            this.settingFiller.SetEntityField(this.txtAJ_Y, new CI.UIComponents.Filler.TextEntry("Y_Station", ""));
            this.txtAJ_Y.Location = new System.Drawing.Point(230, 47);
            this.txtAJ_Y.Name = "txtAJ_Y";
            this.txtAJ_Y.Size = new System.Drawing.Size(85, 23);
            this.txtAJ_Y.TabIndex = 23;
            // 
            // textBox2
            // 
            this.settingFiller.SetEntityField(this.textBox2, new CI.UIComponents.Filler.TextEntry("X_AJ", ""));
            this.textBox2.Location = new System.Drawing.Point(122, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(85, 23);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.settingFiller.SetEntityField(this.textBox3, new CI.UIComponents.Filler.TextEntry("Y_AJ", ""));
            this.textBox3.Location = new System.Drawing.Point(230, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(85, 23);
            this.textBox3.TabIndex = 23;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.settingFiller.SetEntityField(this.checkBox3, new CI.UIComponents.Filler.CheckBoxEntry("UseImgChange_Station"));
            this.checkBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.checkBox3.Location = new System.Drawing.Point(329, 48);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(93, 25);
            this.checkBox3.TabIndex = 37;
            this.checkBox3.Text = "启用转换";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.settingFiller.SetEntityField(this.checkBox1, new CI.UIComponents.Filler.CheckBoxEntry("UseImgChange_AJ"));
            this.checkBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.checkBox1.Location = new System.Drawing.Point(329, 97);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 25);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "启用转换";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // dgvImgType
            // 
            this.dgvImgType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImgType.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvImgType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImgType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colName,
            this.colType});
            this.dgvImgType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingFiller.SetEntityField(this.dgvImgType, new CI.UIComponents.Filler.CGridEntry("ImgList", new CI.UIComponents.Filler.ColumnMember[] {
                new CI.UIComponents.Filler.ColumnMember("colKey", "ImgKey"),
                new CI.UIComponents.Filler.ColumnMember("colName", "ImgName"),
                new CI.UIComponents.Filler.ColumnMember("colType", "ImgType")}));
            this.dgvImgType.Location = new System.Drawing.Point(3, 25);
            this.dgvImgType.Name = "dgvImgType";
            this.dgvImgType.RowHeadersVisible = false;
            this.dgvImgType.RowTemplate.Height = 23;
            this.dgvImgType.Size = new System.Drawing.Size(481, 187);
            this.dgvImgType.TabIndex = 37;
            // 
            // colKey
            // 
            this.colKey.DataPropertyName = "ImgKey";
            this.colKey.FillWeight = 40.22486F;
            this.colKey.HeaderText = "代码";
            this.colKey.Name = "colKey";
            // 
            // colName
            // 
            this.colName.DataPropertyName = "ImgName";
            this.colName.FillWeight = 214.0899F;
            this.colName.HeaderText = "名称";
            this.colName.Name = "colName";
            // 
            // colType
            // 
            this.colType.DataPropertyName = "ImgType";
            this.colType.FillWeight = 45.68528F;
            this.colType.HeaderText = "类型";
            this.colType.Name = "colType";
            // 
            // dgvDetectLine
            // 
            this.dgvDetectLine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetectLine.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetectLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetectLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colLocalLine,
            this.colDetectLine,
            this.Column1});
            this.dgvDetectLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingFiller.SetEntityField(this.dgvDetectLine, new CI.UIComponents.Filler.CGridEntry("Lines", new CI.UIComponents.Filler.ColumnMember[] {
                new CI.UIComponents.Filler.ColumnMember("colLocalLine", "LocalLine"),
                new CI.UIComponents.Filler.ColumnMember("colDetectLine", "DetectLine"),
                new CI.UIComponents.Filler.ColumnMember("Column1", "Coefficient")}));
            this.dgvDetectLine.Location = new System.Drawing.Point(3, 25);
            this.dgvDetectLine.Name = "dgvDetectLine";
            this.dgvDetectLine.RowHeadersVisible = false;
            this.dgvDetectLine.RowTemplate.Height = 23;
            this.dgvDetectLine.Size = new System.Drawing.Size(280, 184);
            this.dgvDetectLine.TabIndex = 0;
            // 
            // colLocalLine
            // 
            this.colLocalLine.DataPropertyName = "LocalLine";
            this.colLocalLine.HeaderText = "本地线号";
            this.colLocalLine.Name = "colLocalLine";
            // 
            // colDetectLine
            // 
            this.colDetectLine.DataPropertyName = "DetectLine";
            this.colDetectLine.HeaderText = "综检线号";
            this.colDetectLine.Name = "colDetectLine";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Coefficient";
            this.Column1.HeaderText = "系数";
            this.Column1.Name = "Column1";
            // 
            // bDetectLineC
            // 
            this.bDetectLineC.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.bDetectLineC.AutoSize = true;
            this.settingFiller.SetEntityField(this.bDetectLineC, new CI.UIComponents.Filler.CheckBoxEntry("DetectLineC"));
            this.bDetectLineC.Location = new System.Drawing.Point(5, 7);
            this.bDetectLineC.Name = "bDetectLineC";
            this.bDetectLineC.Size = new System.Drawing.Size(93, 25);
            this.bDetectLineC.TabIndex = 10;
            this.bDetectLineC.Text = "启用转换";
            this.bDetectLineC.UseVisualStyleBackColor = true;
            // 
            // txtImgPath
            // 
            this.txtImgPath.BackColor = System.Drawing.Color.Transparent;
            this.txtImgPath.Caption = "图片路径: ";
            this.txtImgPath.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtImgPath.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.txtImgPath, new CI.UIComponents.Filler.TextEntry("ImagePath", ""));
            this.txtImgPath.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtImgPath.Location = new System.Drawing.Point(10, 145);
            this.txtImgPath.Name = "txtImgPath";
            this.txtImgPath.Size = new System.Drawing.Size(362, 31);
            this.txtImgPath.TabIndex = 8;
            // 
            // dgvOperator
            // 
            this.dgvOperator.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperator.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvOperator.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperator.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOperator});
            this.dgvOperator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingFiller.SetEntityField(this.dgvOperator, new CI.UIComponents.Filler.CGridEntry("Operators", new CI.UIComponents.Filler.ColumnMember[] {
                new CI.UIComponents.Filler.ColumnMember("colOperator", "Operator")}));
            this.dgvOperator.Location = new System.Drawing.Point(3, 25);
            this.dgvOperator.Name = "dgvOperator";
            this.dgvOperator.RowHeadersVisible = false;
            this.dgvOperator.RowTemplate.Height = 23;
            this.dgvOperator.Size = new System.Drawing.Size(132, 184);
            this.dgvOperator.TabIndex = 2;
            // 
            // colOperator
            // 
            this.colOperator.DataPropertyName = "Operator";
            this.colOperator.HeaderText = "授权签字人";
            this.colOperator.Name = "colOperator";
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox2.AutoSize = true;
            this.settingFiller.SetEntityField(this.checkBox2, new CI.UIComponents.Filler.CheckBoxEntry("UploadSign"));
            this.checkBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.checkBox2.Location = new System.Drawing.Point(33, 610);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(125, 25);
            this.checkBox2.TabIndex = 37;
            this.checkBox2.Text = "上传签字照片";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.dgvImgType);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(30, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 255);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "照片种类  类型：1-综检结论图片 2-安检结论图片";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDeletePicType);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 212);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(481, 40);
            this.panel3.TabIndex = 38;
            // 
            // btnDeletePicType
            // 
            this.btnDeletePicType.BackColor = System.Drawing.Color.Transparent;
            this.btnDeletePicType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeletePicType.Image = null;
            this.btnDeletePicType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletePicType.Location = new System.Drawing.Point(376, 5);
            this.btnDeletePicType.Name = "btnDeletePicType";
            this.btnDeletePicType.Size = new System.Drawing.Size(97, 30);
            this.btnDeletePicType.TabIndex = 0;
            this.btnDeletePicType.Text = "删 除";
            this.btnDeletePicType.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDeletePicType.Click += new System.EventHandler(this.btnDeletePicType_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox3.Controls.Add(this.dgvDetectLine);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.groupBox3.Location = new System.Drawing.Point(523, 343);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 252);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "检测线号";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteLineType);
            this.panel2.Controls.Add(this.bDetectLineC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnDeleteLineType
            // 
            this.btnDeleteLineType.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteLineType.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteLineType.Image = null;
            this.btnDeleteLineType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteLineType.Location = new System.Drawing.Point(104, 6);
            this.btnDeleteLineType.Name = "btnDeleteLineType";
            this.btnDeleteLineType.Size = new System.Drawing.Size(97, 30);
            this.btnDeleteLineType.TabIndex = 0;
            this.btnDeleteLineType.Text = "删 除";
            this.btnDeleteLineType.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteLineType.Click += new System.EventHandler(this.btnDeleteLineType_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.btnAreaSelect);
            this.groupBox2.Controls.Add(this.flatField2);
            this.groupBox2.Controls.Add(this.flatField6);
            this.groupBox2.Controls.Add(this.flatField3);
            this.groupBox2.Controls.Add(this.flatField4);
            this.groupBox2.Controls.Add(this.txtAreaCode);
            this.groupBox2.Location = new System.Drawing.Point(30, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 217);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "上传信息";
            // 
            // btnAreaSelect
            // 
            this.btnAreaSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnAreaSelect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAreaSelect.Image = null;
            this.btnAreaSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAreaSelect.Location = new System.Drawing.Point(358, 133);
            this.btnAreaSelect.Name = "btnAreaSelect";
            this.btnAreaSelect.Size = new System.Drawing.Size(48, 30);
            this.btnAreaSelect.TabIndex = 40;
            this.btnAreaSelect.Text = "……";
            this.btnAreaSelect.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAreaSelect.Click += new System.EventHandler(this.btnAreaSelect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.btnPicPathSelect);
            this.groupBox4.Controls.Add(this.txtImgPath);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.checkBox3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtAJ_Y);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(500, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 217);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "图片信息";
            // 
            // btnPicPathSelect
            // 
            this.btnPicPathSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnPicPathSelect.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPicPathSelect.Image = null;
            this.btnPicPathSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPicPathSelect.Location = new System.Drawing.Point(378, 145);
            this.btnPicPathSelect.Name = "btnPicPathSelect";
            this.btnPicPathSelect.Size = new System.Drawing.Size(48, 30);
            this.btnPicPathSelect.TabIndex = 40;
            this.btnPicPathSelect.Text = "……";
            this.btnPicPathSelect.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPicPathSelect.Click += new System.EventHandler(this.btnPicPathSelect_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 21);
            this.label5.TabIndex = 38;
            this.label5.Text = "工位图片尺寸:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "安检图片尺寸:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(838, 601);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 40);
            this.btnSave.TabIndex = 44;
            this.btnSave.Text = "保 存";
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox5.Controls.Add(this.dgvOperator);
            this.groupBox5.Controls.Add(this.panel1);
            this.groupBox5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.groupBox5.Location = new System.Drawing.Point(812, 343);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(138, 252);
            this.groupBox5.TabIndex = 45;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "授权签字人";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteAuthor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAuthor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteAuthor.Image = null;
            this.btnDeleteAuthor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(19, 5);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(97, 30);
            this.btnDeleteAuthor.TabIndex = 0;
            this.btnDeleteAuthor.Text = "删 除";
            this.btnDeleteAuthor.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.checkBox4.Location = new System.Drawing.Point(164, 610);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(141, 25);
            this.checkBox4.TabIndex = 46;
            this.checkBox4.Text = "默认外检全合格";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.Visible = false;
            // 
            // ComprehensiveUploadSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanMove = false;
            this.ClientSize = new System.Drawing.Size(979, 647);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flatField1);
            this.Name = "ComprehensiveUploadSettingForm";
            this.Text = "ComprehensiveUploadSettingForm";
            this.Title = "综检上传配置";
            this.Controls.SetChildIndex(this.flatField1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.checkBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.groupBox5, 0);
            this.Controls.SetChildIndex(this.checkBox4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImgType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetectLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperator)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CI.Controls.FlatField flatField1;
        private CI.UIComponents.Filler.EntityFiller settingFiller;
        private CI.Controls.FlatField flatField2;
        private CI.Controls.FlatField flatField6;
        private CI.Controls.FlatField txtAreaCode;
        private CI.Controls.FlatField flatField4;
        private CI.Controls.FlatField flatField3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtAJ_Y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvImgType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDetectLine;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox bDetectLineC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private CI.Controls.FlatField txtImgPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private EASkins.Ami_Button_2 btnDeletePicType;
        private EASkins.Ami_Button_2 btnDeleteLineType;
        private EASkins.Emi_Button_2 btnSave;
        private EASkins.Ami_Button_1 btnPicPathSelect;
        private EASkins.Ami_Button_1 btnAreaSelect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgvOperator;
        private System.Windows.Forms.Panel panel1;
        private EASkins.Ami_Button_2 btnDeleteAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetectLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}