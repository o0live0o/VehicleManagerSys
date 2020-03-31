namespace VehicleManagerSys.Main.CustomForms
{
    partial class VehicleLoginForm
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
            this.txtHPHM = new CI.Controls.FlatField();
            this.txtHPZL = new CI.Controls.FlatField();
            this.selectorFiller = new CI.UIComponents.Filler.EntityFiller();
            this.txtHPYS = new CI.Controls.FlatField();
            this.txtSYXZ = new CI.Controls.FlatField();
            this.txtCLZL = new CI.Controls.FlatField();
            this.txtHasScr = new CI.Controls.FlatField();
            this.txtGYFS = new CI.Controls.FlatField();
            this.txtJQFS = new CI.Controls.FlatField();
            this.txtBSQXS = new CI.Controls.FlatField();
            this.txtQDXS = new CI.Controls.FlatField();
            this.txtRLLB = new CI.Controls.FlatField();
            this.txtHasDpf = new CI.Controls.FlatField();
            this.txtHasObd = new CI.Controls.FlatField();
            this.txtJylb = new CI.Controls.FlatField();
            this.txtStandardType = new CI.Controls.FlatField();
            this.txtPP = new CI.Controls.FlatField();
            this.txtCCRQ = new CI.Controls.FlatField();
            this.txtVIN = new CI.Controls.FlatField();
            this.txtCCDJRQ = new CI.Controls.FlatField();
            this.flatField9 = new CI.Controls.FlatField();
            this.flatField7 = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.txtCYS = new CI.Controls.FlatField();
            this.txtXH = new CI.Controls.FlatField();
            this.txtLJXSLC = new CI.Controls.FlatField();
            this.txtZZL = new CI.Controls.FlatField();
            this.txtZBZL = new CI.Controls.FlatField();
            this.flatField2 = new CI.Controls.FlatField();
            this.flatField10 = new CI.Controls.FlatField();
            this.flatField4 = new CI.Controls.FlatField();
            this.flatField5 = new CI.Controls.FlatField();
            this.ami_Separator1 = new EASkins.Ami_Separator();
            this.txtQueryPlateNo = new EASkins.Controls.MaterialSingleLineTextField();
            this.combQueryAera = new EASkins.Emi_ComboBox();
            this.combQueryPlateType = new EASkins.Emi_ComboBox();
            this.btnSearch = new EASkins.Emi_Button_2();
            this.btnSave = new EASkins.Emi_Button_2();
            this.dgvCheckItem = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.vehicleFiller = new CI.UIComponents.Filler.EntityFiller();
            this.flatField1 = new CI.Controls.FlatField();
            this.flatField6 = new CI.Controls.FlatField();
            this.flatField8 = new CI.Controls.FlatField();
            this.flatField11 = new CI.Controls.FlatField();
            this.flatField12 = new CI.Controls.FlatField();
            this.btnClear = new EASkins.Ami_Button_2();
            this.validator1 = new CI.UIComponents.Validate.Validator();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckItem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHPHM
            // 
            this.txtHPHM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHPHM.BackColor = System.Drawing.Color.Transparent;
            this.txtHPHM.Caption = "号牌号码: ";
            this.txtHPHM.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPHM.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.txtHPHM, new CI.UIComponents.Filler.TextEntry("HPHM", ""));
            this.txtHPHM.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPHM.Location = new System.Drawing.Point(47, 136);
            this.txtHPHM.Name = "txtHPHM";
            this.txtHPHM.Size = new System.Drawing.Size(237, 31);
            this.txtHPHM.TabIndex = 0;
            this.validator1.SetTaget(this.txtHPHM, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("号牌号码不能为空！", "")))}));
            // 
            // txtHPZL
            // 
            this.txtHPZL.AlwaysShowDropDownStyle = true;
            this.txtHPZL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHPZL.BackColor = System.Drawing.Color.Transparent;
            this.txtHPZL.Caption = "号牌种类: ";
            this.txtHPZL.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPZL.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtHPZL, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHPZL, new CI.UIComponents.Filler.TextEntry("HPZL", "HPZLDH"));
            this.txtHPZL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPZL.Location = new System.Drawing.Point(599, 136);
            this.txtHPZL.Name = "txtHPZL";
            this.txtHPZL.ReadOnly = true;
            this.txtHPZL.Size = new System.Drawing.Size(237, 31);
            this.txtHPZL.Style = CI.Controls.FieldStyle.DropDown;
            this.txtHPZL.TabIndex = 2;
            this.validator1.SetTaget(this.txtHPZL, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtHPYS
            // 
            this.txtHPYS.AlwaysShowDropDownStyle = true;
            this.txtHPYS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHPYS.BackColor = System.Drawing.Color.Transparent;
            this.txtHPYS.Caption = "号牌颜色: ";
            this.txtHPYS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPYS.CaptionLength = 5;
            this.txtHPYS.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtHPYS, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHPYS, new CI.UIComponents.Filler.TextEntry("HPYS", "HPYSDH"));
            this.txtHPYS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPYS.Location = new System.Drawing.Point(323, 136);
            this.txtHPYS.Name = "txtHPYS";
            this.txtHPYS.ReadOnly = true;
            this.txtHPYS.Size = new System.Drawing.Size(237, 31);
            this.txtHPYS.TabIndex = 1;
            this.validator1.SetTaget(this.txtHPYS, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtSYXZ
            // 
            this.txtSYXZ.AlwaysShowDropDownStyle = true;
            this.txtSYXZ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSYXZ.BackColor = System.Drawing.Color.Transparent;
            this.txtSYXZ.Caption = "使用性质: ";
            this.txtSYXZ.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSYXZ.CaptionLength = 5;
            this.txtSYXZ.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtSYXZ, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtSYXZ, new CI.UIComponents.Filler.TextEntry("SYXZ", "SYXZDH"));
            this.txtSYXZ.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSYXZ.Location = new System.Drawing.Point(599, 171);
            this.txtSYXZ.Name = "txtSYXZ";
            this.txtSYXZ.ReadOnly = true;
            this.txtSYXZ.Size = new System.Drawing.Size(237, 31);
            this.txtSYXZ.TabIndex = 5;
            this.validator1.SetTaget(this.txtSYXZ, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtCLZL
            // 
            this.txtCLZL.AlwaysShowDropDownStyle = true;
            this.txtCLZL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCLZL.BackColor = System.Drawing.Color.Transparent;
            this.txtCLZL.Caption = "车辆种类: ";
            this.txtCLZL.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCLZL.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtCLZL, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtCLZL, new CI.UIComponents.Filler.TextEntry("CLZL", "CLZLDH"));
            this.txtCLZL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCLZL.Location = new System.Drawing.Point(323, 171);
            this.txtCLZL.Name = "txtCLZL";
            this.txtCLZL.ReadOnly = true;
            this.txtCLZL.Size = new System.Drawing.Size(237, 31);
            this.txtCLZL.Style = CI.Controls.FieldStyle.DropDown;
            this.txtCLZL.TabIndex = 4;
            this.validator1.SetTaget(this.txtCLZL, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtHasScr
            // 
            this.txtHasScr.AlwaysShowDropDownStyle = true;
            this.txtHasScr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHasScr.BackColor = System.Drawing.Color.Transparent;
            this.txtHasScr.Caption = "是否有SCR:";
            this.txtHasScr.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasScr.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtHasScr, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHasScr, new CI.UIComponents.Filler.TextEntry("IsSCR", "IsSCRDH"));
            this.txtHasScr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasScr.Location = new System.Drawing.Point(599, 416);
            this.txtHasScr.Name = "txtHasScr";
            this.txtHasScr.Size = new System.Drawing.Size(237, 31);
            this.txtHasScr.TabIndex = 26;
            // 
            // txtGYFS
            // 
            this.txtGYFS.AlwaysShowDropDownStyle = true;
            this.txtGYFS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGYFS.BackColor = System.Drawing.Color.Transparent;
            this.txtGYFS.Caption = "供油方式: ";
            this.txtGYFS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtGYFS.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtGYFS, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtGYFS, new CI.UIComponents.Filler.TextEntry("GYFS", "GYFSDH"));
            this.txtGYFS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtGYFS.Location = new System.Drawing.Point(599, 311);
            this.txtGYFS.Name = "txtGYFS";
            this.txtGYFS.ReadOnly = true;
            this.txtGYFS.Size = new System.Drawing.Size(237, 31);
            this.txtGYFS.Style = CI.Controls.FieldStyle.DropDown;
            this.txtGYFS.TabIndex = 17;
            // 
            // txtJQFS
            // 
            this.txtJQFS.AlwaysShowDropDownStyle = true;
            this.txtJQFS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtJQFS.BackColor = System.Drawing.Color.Transparent;
            this.txtJQFS.Caption = "进气方式: ";
            this.txtJQFS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtJQFS.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtJQFS, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtJQFS, new CI.UIComponents.Filler.TextEntry("JQFS", "JQFSDH"));
            this.txtJQFS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtJQFS.Location = new System.Drawing.Point(47, 311);
            this.txtJQFS.Name = "txtJQFS";
            this.txtJQFS.ReadOnly = true;
            this.txtJQFS.Size = new System.Drawing.Size(237, 31);
            this.txtJQFS.TabIndex = 15;
            this.validator1.SetTaget(this.txtJQFS, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtBSQXS
            // 
            this.txtBSQXS.AlwaysShowDropDownStyle = true;
            this.txtBSQXS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBSQXS.BackColor = System.Drawing.Color.Transparent;
            this.txtBSQXS.Caption = "变速箱形式:";
            this.txtBSQXS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtBSQXS.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtBSQXS, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtBSQXS, new CI.UIComponents.Filler.TextEntry("BSXLX", "BSXLXDH"));
            this.txtBSQXS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtBSQXS.Location = new System.Drawing.Point(599, 276);
            this.txtBSQXS.Name = "txtBSQXS";
            this.txtBSQXS.ReadOnly = true;
            this.txtBSQXS.Size = new System.Drawing.Size(237, 31);
            this.txtBSQXS.TabIndex = 14;
            // 
            // txtQDXS
            // 
            this.txtQDXS.AlwaysShowDropDownStyle = true;
            this.txtQDXS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQDXS.BackColor = System.Drawing.Color.Transparent;
            this.txtQDXS.Caption = "驱动形式: ";
            this.txtQDXS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtQDXS.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtQDXS, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtQDXS, new CI.UIComponents.Filler.TextEntry("QDXS", "QDXSDH"));
            this.txtQDXS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtQDXS.Location = new System.Drawing.Point(323, 346);
            this.txtQDXS.Name = "txtQDXS";
            this.txtQDXS.ReadOnly = true;
            this.txtQDXS.Size = new System.Drawing.Size(237, 31);
            this.txtQDXS.Style = CI.Controls.FieldStyle.DropDown;
            this.txtQDXS.TabIndex = 19;
            this.validator1.SetTaget(this.txtQDXS, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtRLLB
            // 
            this.txtRLLB.AlwaysShowDropDownStyle = true;
            this.txtRLLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRLLB.BackColor = System.Drawing.Color.Transparent;
            this.txtRLLB.Caption = "燃料类别: ";
            this.txtRLLB.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRLLB.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtRLLB, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtRLLB, new CI.UIComponents.Filler.TextEntry("RLLB", "RLLBDH"));
            this.txtRLLB.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRLLB.Location = new System.Drawing.Point(323, 276);
            this.txtRLLB.Name = "txtRLLB";
            this.txtRLLB.ReadOnly = true;
            this.txtRLLB.Size = new System.Drawing.Size(237, 31);
            this.txtRLLB.Style = CI.Controls.FieldStyle.DropDown;
            this.txtRLLB.TabIndex = 13;
            this.validator1.SetTaget(this.txtRLLB, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtHasDpf
            // 
            this.txtHasDpf.AlwaysShowDropDownStyle = true;
            this.txtHasDpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHasDpf.BackColor = System.Drawing.Color.Transparent;
            this.txtHasDpf.Caption = "是否有DPF:";
            this.txtHasDpf.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasDpf.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtHasDpf, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHasDpf, new CI.UIComponents.Filler.TextEntry("IsDPF", "IsDPFDH"));
            this.txtHasDpf.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasDpf.Location = new System.Drawing.Point(323, 451);
            this.txtHasDpf.Name = "txtHasDpf";
            this.txtHasDpf.Size = new System.Drawing.Size(237, 31);
            this.txtHasDpf.TabIndex = 28;
            // 
            // txtHasObd
            // 
            this.txtHasObd.AlwaysShowDropDownStyle = true;
            this.txtHasObd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHasObd.BackColor = System.Drawing.Color.Transparent;
            this.txtHasObd.Caption = "是否有OBD:";
            this.txtHasObd.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasObd.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtHasObd, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHasObd, new CI.UIComponents.Filler.TextEntry("", "IsOBD"));
            this.txtHasObd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasObd.Location = new System.Drawing.Point(323, 416);
            this.txtHasObd.Name = "txtHasObd";
            this.txtHasObd.Size = new System.Drawing.Size(237, 31);
            this.txtHasObd.TabIndex = 25;
            // 
            // txtJylb
            // 
            this.txtJylb.AlwaysShowDropDownStyle = true;
            this.txtJylb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtJylb.BackColor = System.Drawing.Color.Transparent;
            this.txtJylb.Caption = "检验类别: ";
            this.txtJylb.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtJylb.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtJylb, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtJylb, new CI.UIComponents.Filler.TextEntry("JYLB", "JYLBDH"));
            this.txtJylb.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtJylb.Location = new System.Drawing.Point(47, 525);
            this.txtJylb.Name = "txtJylb";
            this.txtJylb.ReadOnly = true;
            this.txtJylb.Size = new System.Drawing.Size(237, 31);
            this.txtJylb.TabIndex = 33;
            this.validator1.SetTaget(this.txtJylb, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtStandardType
            // 
            this.txtStandardType.AlwaysShowDropDownStyle = true;
            this.txtStandardType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStandardType.BackColor = System.Drawing.Color.Transparent;
            this.txtStandardType.Caption = "限值类型: ";
            this.txtStandardType.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtStandardType.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtStandardType, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtStandardType, new CI.UIComponents.Filler.TextEntry("StandardText", "StandardType"));
            this.txtStandardType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtStandardType.Location = new System.Drawing.Point(323, 525);
            this.txtStandardType.Name = "txtStandardType";
            this.txtStandardType.ReadOnly = true;
            this.txtStandardType.Size = new System.Drawing.Size(237, 31);
            this.txtStandardType.TabIndex = 34;
            // 
            // txtPP
            // 
            this.txtPP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPP.BackColor = System.Drawing.Color.Transparent;
            this.txtPP.Caption = "品牌:     ";
            this.txtPP.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPP.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.txtPP, new CI.UIComponents.Filler.TextEntry("PP", ""));
            this.txtPP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPP.Location = new System.Drawing.Point(599, 206);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(237, 31);
            this.txtPP.TabIndex = 8;
            this.validator1.SetTaget(this.txtPP, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtCCRQ
            // 
            this.txtCCRQ.AlwaysShowDropDownStyle = true;
            this.txtCCRQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCCRQ.BackColor = System.Drawing.Color.Transparent;
            this.txtCCRQ.Caption = "出厂日期: ";
            this.txtCCRQ.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCCRQ.CaptionWidth = 0;
            this.txtCCRQ.DataType = CI.Controls.FieldDataType.DateTime;
            this.vehicleFiller.SetEntityField(this.txtCCRQ, new CI.UIComponents.Filler.TextEntry("CCRQ", ""));
            this.txtCCRQ.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCCRQ.Format = "yyyy-MM-dd";
            this.txtCCRQ.Location = new System.Drawing.Point(323, 206);
            this.txtCCRQ.Name = "txtCCRQ";
            this.txtCCRQ.ReadOnly = true;
            this.txtCCRQ.Size = new System.Drawing.Size(237, 31);
            this.txtCCRQ.Style = CI.Controls.FieldStyle.DropDown;
            this.txtCCRQ.TabIndex = 7;
            this.validator1.SetTaget(this.txtCCRQ, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtVIN
            // 
            this.txtVIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVIN.BackColor = System.Drawing.Color.Transparent;
            this.txtVIN.Caption = "VIN: ";
            this.txtVIN.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtVIN.CaptionLength = 5;
            this.txtVIN.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.txtVIN, new CI.UIComponents.Filler.TextEntry("VIN", ""));
            this.txtVIN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtVIN.Location = new System.Drawing.Point(47, 171);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(237, 31);
            this.txtVIN.TabIndex = 3;
            this.validator1.SetTaget(this.txtVIN, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("VIN不能不为空！", "")))}));
            // 
            // txtCCDJRQ
            // 
            this.txtCCDJRQ.AlwaysShowDropDownStyle = true;
            this.txtCCDJRQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCCDJRQ.BackColor = System.Drawing.Color.Transparent;
            this.txtCCDJRQ.Caption = "初始登记日期:";
            this.txtCCDJRQ.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCCDJRQ.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.txtCCDJRQ, new CI.UIComponents.Filler.TextEntry("CCDJRQ", ""));
            this.txtCCDJRQ.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCCDJRQ.Format = "yyyy-MM-dd";
            this.txtCCDJRQ.Location = new System.Drawing.Point(47, 206);
            this.txtCCDJRQ.Name = "txtCCDJRQ";
            this.txtCCDJRQ.ReadOnly = true;
            this.txtCCDJRQ.Size = new System.Drawing.Size(237, 31);
            this.txtCCDJRQ.Style = CI.Controls.FieldStyle.DropDown;
            this.txtCCDJRQ.TabIndex = 6;
            this.validator1.SetTaget(this.txtCCDJRQ, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // flatField9
            // 
            this.flatField9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField9.BackColor = System.Drawing.Color.Transparent;
            this.flatField9.Caption = "额定转速: ";
            this.flatField9.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField9.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField9, new CI.UIComponents.Filler.TextEntry("EDZS", ""));
            this.flatField9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField9.Location = new System.Drawing.Point(47, 346);
            this.flatField9.Name = "flatField9";
            this.flatField9.Size = new System.Drawing.Size(237, 31);
            this.flatField9.TabIndex = 18;
            this.validator1.SetTaget(this.flatField9, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // flatField7
            // 
            this.flatField7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField7.BackColor = System.Drawing.Color.Transparent;
            this.flatField7.Caption = "排量:     ";
            this.flatField7.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField7.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField7, new CI.UIComponents.Filler.TextEntry("FDJPL", ""));
            this.flatField7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField7.Location = new System.Drawing.Point(323, 311);
            this.flatField7.Name = "flatField7";
            this.flatField7.Size = new System.Drawing.Size(237, 31);
            this.flatField7.TabIndex = 16;
            this.validator1.SetTaget(this.flatField7, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // flatField3
            // 
            this.flatField3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "发动机生产厂:";
            this.flatField3.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("FDJZZCS", ""));
            this.flatField3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.Location = new System.Drawing.Point(323, 241);
            this.flatField3.Name = "flatField3";
            this.flatField3.Size = new System.Drawing.Size(237, 31);
            this.flatField3.TabIndex = 10;
            this.validator1.SetTaget(this.flatField3, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtCYS
            // 
            this.txtCYS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCYS.BackColor = System.Drawing.Color.Transparent;
            this.txtCYS.Caption = "核载人数: ";
            this.txtCYS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCYS.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.txtCYS, new CI.UIComponents.Filler.TextEntry("CYS", ""));
            this.txtCYS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCYS.Location = new System.Drawing.Point(47, 276);
            this.txtCYS.Name = "txtCYS";
            this.txtCYS.Size = new System.Drawing.Size(237, 31);
            this.txtCYS.TabIndex = 12;
            this.validator1.SetTaget(this.txtCYS, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtXH
            // 
            this.txtXH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtXH.BackColor = System.Drawing.Color.Transparent;
            this.txtXH.Caption = "型号:";
            this.txtXH.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtXH.CaptionLength = 5;
            this.txtXH.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.txtXH, new CI.UIComponents.Filler.TextEntry("XH", ""));
            this.txtXH.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtXH.Location = new System.Drawing.Point(47, 241);
            this.txtXH.Name = "txtXH";
            this.txtXH.Size = new System.Drawing.Size(237, 31);
            this.txtXH.TabIndex = 9;
            this.validator1.SetTaget(this.txtXH, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtLJXSLC
            // 
            this.txtLJXSLC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLJXSLC.BackColor = System.Drawing.Color.Transparent;
            this.txtLJXSLC.Caption = "累计行驶里程:";
            this.txtLJXSLC.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLJXSLC.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.txtLJXSLC, new CI.UIComponents.Filler.TextEntry("LJXSLC", ""));
            this.txtLJXSLC.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLJXSLC.Location = new System.Drawing.Point(323, 381);
            this.txtLJXSLC.Name = "txtLJXSLC";
            this.txtLJXSLC.Size = new System.Drawing.Size(237, 31);
            this.txtLJXSLC.TabIndex = 22;
            this.validator1.SetTaget(this.txtLJXSLC, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtZZL
            // 
            this.txtZZL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtZZL.BackColor = System.Drawing.Color.Transparent;
            this.txtZZL.Caption = "总质量:   ";
            this.txtZZL.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtZZL.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.txtZZL, new CI.UIComponents.Filler.TextEntry("ZZL", ""));
            this.txtZZL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtZZL.Location = new System.Drawing.Point(599, 346);
            this.txtZZL.Name = "txtZZL";
            this.txtZZL.Size = new System.Drawing.Size(237, 31);
            this.txtZZL.TabIndex = 20;
            this.validator1.SetTaget(this.txtZZL, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // txtZBZL
            // 
            this.txtZBZL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtZBZL.BackColor = System.Drawing.Color.Transparent;
            this.txtZBZL.Caption = "整备质量: ";
            this.txtZBZL.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtZBZL.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.txtZBZL, new CI.UIComponents.Filler.TextEntry("ZBZL", ""));
            this.txtZBZL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtZBZL.Location = new System.Drawing.Point(47, 381);
            this.txtZBZL.Name = "txtZBZL";
            this.txtZBZL.Size = new System.Drawing.Size(237, 31);
            this.txtZBZL.TabIndex = 21;
            this.validator1.SetTaget(this.txtZBZL, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // flatField2
            // 
            this.flatField2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField2.BackColor = System.Drawing.Color.Transparent;
            this.flatField2.Caption = "发动机型号:";
            this.flatField2.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField2.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField2, new CI.UIComponents.Filler.TextEntry("FDJXH", ""));
            this.flatField2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField2.Location = new System.Drawing.Point(599, 381);
            this.flatField2.Name = "flatField2";
            this.flatField2.Size = new System.Drawing.Size(237, 31);
            this.flatField2.TabIndex = 23;
            this.validator1.SetTaget(this.flatField2, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // flatField10
            // 
            this.flatField10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField10.BackColor = System.Drawing.Color.Transparent;
            this.flatField10.Caption = "额定功率: ";
            this.flatField10.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField10.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField10, new CI.UIComponents.Filler.TextEntry("EDGL", ""));
            this.flatField10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField10.Location = new System.Drawing.Point(599, 241);
            this.flatField10.Name = "flatField10";
            this.flatField10.Size = new System.Drawing.Size(237, 31);
            this.flatField10.TabIndex = 11;
            this.validator1.SetTaget(this.flatField10, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // flatField4
            // 
            this.flatField4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "SCR型号:  ";
            this.flatField4.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField4, new CI.UIComponents.Filler.TextEntry("SCRXH", ""));
            this.flatField4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.Location = new System.Drawing.Point(47, 451);
            this.flatField4.Name = "flatField4";
            this.flatField4.Size = new System.Drawing.Size(237, 31);
            this.flatField4.TabIndex = 27;
            // 
            // flatField5
            // 
            this.flatField5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField5.BackColor = System.Drawing.Color.Transparent;
            this.flatField5.Caption = "DPF型号:  ";
            this.flatField5.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField5.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField5, new CI.UIComponents.Filler.TextEntry("DPFXH", ""));
            this.flatField5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField5.Location = new System.Drawing.Point(599, 451);
            this.flatField5.Name = "flatField5";
            this.flatField5.Size = new System.Drawing.Size(237, 31);
            this.flatField5.TabIndex = 29;
            // 
            // ami_Separator1
            // 
            this.ami_Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ami_Separator1.Location = new System.Drawing.Point(0, 105);
            this.ami_Separator1.Name = "ami_Separator1";
            this.ami_Separator1.Size = new System.Drawing.Size(1092, 10);
            this.ami_Separator1.TabIndex = 64;
            this.ami_Separator1.Text = "ami_Separator1";
            // 
            // txtQueryPlateNo
            // 
            this.txtQueryPlateNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQueryPlateNo.Depth = 0;
            this.txtQueryPlateNo.Hint = "号牌号码";
            this.txtQueryPlateNo.Location = new System.Drawing.Point(216, 77);
            this.txtQueryPlateNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueryPlateNo.MaxLength = 32767;
            this.txtQueryPlateNo.MouseState = EASkins.MouseState.HOVER;
            this.txtQueryPlateNo.Name = "txtQueryPlateNo";
            this.txtQueryPlateNo.PasswordChar = '\0';
            this.txtQueryPlateNo.SelectedText = "";
            this.txtQueryPlateNo.SelectionLength = 0;
            this.txtQueryPlateNo.SelectionStart = 0;
            this.txtQueryPlateNo.Size = new System.Drawing.Size(198, 23);
            this.txtQueryPlateNo.TabIndex = 65;
            this.txtQueryPlateNo.TabStop = false;
            this.txtQueryPlateNo.UseSystemPasswordChar = false;
            // 
            // combQueryAera
            // 
            this.combQueryAera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combQueryAera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combQueryAera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combQueryAera.DropDownHeight = 100;
            this.combQueryAera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combQueryAera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combQueryAera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combQueryAera.FormattingEnabled = true;
            this.combQueryAera.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.combQueryAera.IntegralHeight = false;
            this.combQueryAera.ItemHeight = 20;
            this.combQueryAera.Items.AddRange(new object[] {
            "京",
            "",
            "辽",
            "冀",
            "津",
            "贵",
            "黑",
            "吉",
            "蒙",
            "新",
            "川",
            "云",
            "沪",
            "渝",
            "甘",
            "青",
            "陕",
            "宁",
            "豫",
            "晋",
            "皖",
            "鄂",
            "湘",
            "苏",
            "黔",
            "滇",
            "桂",
            "藏",
            "浙",
            "赣",
            "粤",
            "闽",
            "台",
            "琼",
            "港",
            "澳",
            "鲁",
            "内"});
            this.combQueryAera.Location = new System.Drawing.Point(137, 74);
            this.combQueryAera.Margin = new System.Windows.Forms.Padding(2);
            this.combQueryAera.Name = "combQueryAera";
            this.combQueryAera.Size = new System.Drawing.Size(71, 26);
            this.combQueryAera.StartIndex = 0;
            this.combQueryAera.TabIndex = 66;
            // 
            // combQueryPlateType
            // 
            this.combQueryPlateType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combQueryPlateType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combQueryPlateType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combQueryPlateType.DropDownHeight = 170;
            this.combQueryPlateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combQueryPlateType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combQueryPlateType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combQueryPlateType.FormattingEnabled = true;
            this.combQueryPlateType.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.combQueryPlateType.IntegralHeight = false;
            this.combQueryPlateType.ItemHeight = 20;
            this.combQueryPlateType.Items.AddRange(new object[] {
            "小型汽车",
            "大型汽车",
            "警用汽车",
            "使馆汽车",
            "领馆汽车",
            "境外汽车",
            "外籍汽车",
            "教练汽车",
            "试验汽车",
            "农用运输车",
            "拖拉机",
            "挂车",
            "临时入境汽车",
            "临时行驶车",
            "两、三轮摩托车",
            "轻便摩托车",
            "使馆摩托车",
            "领馆摩托车",
            "境外摩托车",
            "外籍摩托车",
            "教练摩托车",
            "试验摩托车",
            "临时入境摩托车",
            "警用摩托"});
            this.combQueryPlateType.Location = new System.Drawing.Point(438, 74);
            this.combQueryPlateType.Margin = new System.Windows.Forms.Padding(2);
            this.combQueryPlateType.MaxDropDownItems = 10;
            this.combQueryPlateType.Name = "combQueryPlateType";
            this.combQueryPlateType.Size = new System.Drawing.Size(129, 26);
            this.combQueryPlateType.StartIndex = 0;
            this.combQueryPlateType.TabIndex = 67;
            this.combQueryPlateType.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = null;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(764, 77);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 68;
            this.btnSearch.Text = "查  询";
            this.btnSearch.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(852, 77);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 23);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "发 送";
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvCheckItem
            // 
            this.dgvCheckItem.AllowUserToAddRows = false;
            this.dgvCheckItem.AllowUserToDeleteRows = false;
            this.dgvCheckItem.AllowUserToResizeColumns = false;
            this.dgvCheckItem.AllowUserToResizeRows = false;
            this.dgvCheckItem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvCheckItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCheckItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCheckItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheckItem.ColumnHeadersHeight = 40;
            this.dgvCheckItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvCheckItem.EnableHeadersVisualStyles = false;
            this.dgvCheckItem.GridColor = System.Drawing.Color.White;
            this.dgvCheckItem.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dgvCheckItem.Location = new System.Drawing.Point(851, 136);
            this.dgvCheckItem.Name = "dgvCheckItem";
            this.dgvCheckItem.RowHeadersVisible = false;
            this.dgvCheckItem.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgvCheckItem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheckItem.RowTemplate.Height = 23;
            this.dgvCheckItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckItem.Size = new System.Drawing.Size(194, 371);
            this.dgvCheckItem.TabIndex = 71;
            this.dgvCheckItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckItem_CellClick);
            this.dgvCheckItem.SelectionChanged += new System.EventHandler(this.dgvCheckItem_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ItemName";
            this.Column1.FillWeight = 159.3909F;
            this.Column1.HeaderText = "检验项目";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "IsCheck";
            this.Column2.FillWeight = 40.60914F;
            this.Column2.HeaderText = "";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // flatField1
            // 
            this.flatField1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "催化装换器型号:";
            this.flatField1.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField1.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("CHZHQXH", ""));
            this.flatField1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField1.Location = new System.Drawing.Point(47, 416);
            this.flatField1.Name = "flatField1";
            this.flatField1.Size = new System.Drawing.Size(237, 31);
            this.flatField1.TabIndex = 24;
            // 
            // flatField6
            // 
            this.flatField6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField6.BackColor = System.Drawing.Color.Transparent;
            this.flatField6.Caption = "车辆生产企业:";
            this.flatField6.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField6.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField6, new CI.UIComponents.Filler.TextEntry("CLZZCS", ""));
            this.flatField6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField6.Location = new System.Drawing.Point(47, 488);
            this.flatField6.Name = "flatField6";
            this.flatField6.Size = new System.Drawing.Size(237, 31);
            this.flatField6.TabIndex = 30;
            this.validator1.SetTaget(this.flatField6, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // flatField8
            // 
            this.flatField8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField8.BackColor = System.Drawing.Color.Transparent;
            this.flatField8.Caption = "所有人:   ";
            this.flatField8.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField8.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField8, new CI.UIComponents.Filler.TextEntry("SYR", ""));
            this.flatField8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField8.Location = new System.Drawing.Point(323, 488);
            this.flatField8.Name = "flatField8";
            this.flatField8.Size = new System.Drawing.Size(237, 31);
            this.flatField8.TabIndex = 31;
            this.validator1.SetTaget(this.flatField8, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // flatField11
            // 
            this.flatField11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField11.BackColor = System.Drawing.Color.Transparent;
            this.flatField11.Caption = "联系电话: ";
            this.flatField11.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField11.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField11, new CI.UIComponents.Filler.TextEntry("LXDH", ""));
            this.flatField11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField11.Location = new System.Drawing.Point(599, 488);
            this.flatField11.Name = "flatField11";
            this.flatField11.Size = new System.Drawing.Size(237, 31);
            this.flatField11.TabIndex = 32;
            this.validator1.SetTaget(this.flatField11, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // flatField12
            // 
            this.flatField12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField12.BackColor = System.Drawing.Color.Transparent;
            this.flatField12.Caption = "发动机号: ";
            this.flatField12.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField12.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField12, new CI.UIComponents.Filler.TextEntry("FDJH", ""));
            this.flatField12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField12.Location = new System.Drawing.Point(599, 525);
            this.flatField12.Name = "flatField12";
            this.flatField12.Size = new System.Drawing.Size(237, 31);
            this.flatField12.TabIndex = 73;
            this.validator1.SetTaget(this.flatField12, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClear.Image = null;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(673, 77);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 23);
            this.btnClear.TabIndex = 72;
            this.btnClear.Text = "清 空";
            this.btnClear.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // VehicleLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1093, 614);
            this.Controls.Add(this.flatField12);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvCheckItem);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.combQueryPlateType);
            this.Controls.Add(this.txtQueryPlateNo);
            this.Controls.Add(this.combQueryAera);
            this.Controls.Add(this.ami_Separator1);
            this.Controls.Add(this.txtHasObd);
            this.Controls.Add(this.txtStandardType);
            this.Controls.Add(this.txtHasDpf);
            this.Controls.Add(this.flatField10);
            this.Controls.Add(this.flatField2);
            this.Controls.Add(this.flatField5);
            this.Controls.Add(this.flatField11);
            this.Controls.Add(this.flatField8);
            this.Controls.Add(this.flatField6);
            this.Controls.Add(this.flatField4);
            this.Controls.Add(this.flatField1);
            this.Controls.Add(this.txtZBZL);
            this.Controls.Add(this.txtHasScr);
            this.Controls.Add(this.flatField9);
            this.Controls.Add(this.txtGYFS);
            this.Controls.Add(this.flatField7);
            this.Controls.Add(this.txtJylb);
            this.Controls.Add(this.txtJQFS);
            this.Controls.Add(this.txtBSQXS);
            this.Controls.Add(this.flatField3);
            this.Controls.Add(this.txtQDXS);
            this.Controls.Add(this.txtCYS);
            this.Controls.Add(this.txtRLLB);
            this.Controls.Add(this.txtXH);
            this.Controls.Add(this.txtLJXSLC);
            this.Controls.Add(this.txtZZL);
            this.Controls.Add(this.txtSYXZ);
            this.Controls.Add(this.txtPP);
            this.Controls.Add(this.txtCCRQ);
            this.Controls.Add(this.txtVIN);
            this.Controls.Add(this.txtCLZL);
            this.Controls.Add(this.txtCCDJRQ);
            this.Controls.Add(this.txtHPYS);
            this.Controls.Add(this.txtHPZL);
            this.Controls.Add(this.txtHPHM);
            this.Name = "VehicleLoginForm";
            this.Text = "VehicleLoginForm";
            this.Title = "环保登录";
            this.Shown += new System.EventHandler(this.VehicleLoginForm_Shown);
            this.Controls.SetChildIndex(this.txtHPHM, 0);
            this.Controls.SetChildIndex(this.txtHPZL, 0);
            this.Controls.SetChildIndex(this.txtHPYS, 0);
            this.Controls.SetChildIndex(this.txtCCDJRQ, 0);
            this.Controls.SetChildIndex(this.txtCLZL, 0);
            this.Controls.SetChildIndex(this.txtVIN, 0);
            this.Controls.SetChildIndex(this.txtCCRQ, 0);
            this.Controls.SetChildIndex(this.txtPP, 0);
            this.Controls.SetChildIndex(this.txtSYXZ, 0);
            this.Controls.SetChildIndex(this.txtZZL, 0);
            this.Controls.SetChildIndex(this.txtLJXSLC, 0);
            this.Controls.SetChildIndex(this.txtXH, 0);
            this.Controls.SetChildIndex(this.txtRLLB, 0);
            this.Controls.SetChildIndex(this.txtCYS, 0);
            this.Controls.SetChildIndex(this.txtQDXS, 0);
            this.Controls.SetChildIndex(this.flatField3, 0);
            this.Controls.SetChildIndex(this.txtBSQXS, 0);
            this.Controls.SetChildIndex(this.txtJQFS, 0);
            this.Controls.SetChildIndex(this.txtJylb, 0);
            this.Controls.SetChildIndex(this.flatField7, 0);
            this.Controls.SetChildIndex(this.txtGYFS, 0);
            this.Controls.SetChildIndex(this.flatField9, 0);
            this.Controls.SetChildIndex(this.txtHasScr, 0);
            this.Controls.SetChildIndex(this.txtZBZL, 0);
            this.Controls.SetChildIndex(this.flatField1, 0);
            this.Controls.SetChildIndex(this.flatField4, 0);
            this.Controls.SetChildIndex(this.flatField6, 0);
            this.Controls.SetChildIndex(this.flatField8, 0);
            this.Controls.SetChildIndex(this.flatField11, 0);
            this.Controls.SetChildIndex(this.flatField5, 0);
            this.Controls.SetChildIndex(this.flatField2, 0);
            this.Controls.SetChildIndex(this.flatField10, 0);
            this.Controls.SetChildIndex(this.txtHasDpf, 0);
            this.Controls.SetChildIndex(this.txtStandardType, 0);
            this.Controls.SetChildIndex(this.txtHasObd, 0);
            this.Controls.SetChildIndex(this.ami_Separator1, 0);
            this.Controls.SetChildIndex(this.combQueryAera, 0);
            this.Controls.SetChildIndex(this.txtQueryPlateNo, 0);
            this.Controls.SetChildIndex(this.combQueryPlateType, 0);
            this.Controls.SetChildIndex(this.btnSearch, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.dgvCheckItem, 0);
            this.Controls.SetChildIndex(this.btnClear, 0);
            this.Controls.SetChildIndex(this.flatField12, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CI.Controls.FlatField txtHPHM;
        private CI.Controls.FlatField txtHPZL;
        private CI.UIComponents.Filler.EntityFiller selectorFiller;
        private CI.Controls.FlatField txtHPYS;
        private CI.Controls.FlatField txtSYXZ;
        private CI.Controls.FlatField txtPP;
        private CI.Controls.FlatField txtCCRQ;
        private CI.Controls.FlatField txtVIN;
        private CI.Controls.FlatField txtCLZL;
        private CI.Controls.FlatField txtCCDJRQ;
        private CI.Controls.FlatField txtHasScr;
        private CI.Controls.FlatField flatField9;
        private CI.Controls.FlatField txtGYFS;
        private CI.Controls.FlatField flatField7;
        private CI.Controls.FlatField txtJQFS;
        private CI.Controls.FlatField txtBSQXS;
        private CI.Controls.FlatField flatField3;
        private CI.Controls.FlatField txtQDXS;
        private CI.Controls.FlatField txtCYS;
        private CI.Controls.FlatField txtRLLB;
        private CI.Controls.FlatField txtXH;
        private CI.Controls.FlatField txtLJXSLC;
        private CI.Controls.FlatField txtZZL;
        private CI.Controls.FlatField txtZBZL;
        private CI.Controls.FlatField flatField2;
        private CI.Controls.FlatField flatField10;
        private CI.Controls.FlatField flatField4;
        private CI.Controls.FlatField flatField5;
        private CI.Controls.FlatField txtHasDpf;
        private EASkins.Ami_Separator ami_Separator1;
        private EASkins.Controls.MaterialSingleLineTextField txtQueryPlateNo;
        private EASkins.Emi_ComboBox combQueryAera;
        private EASkins.Emi_ComboBox combQueryPlateType;
        private EASkins.Emi_Button_2 btnSearch;
        private EASkins.Emi_Button_2 btnSave;
        private System.Windows.Forms.DataGridView dgvCheckItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private CI.UIComponents.Filler.EntityFiller vehicleFiller;
        private CI.Controls.FlatField txtHasObd;
        private CI.Controls.FlatField flatField1;
        private EASkins.Ami_Button_2 btnClear;
        private CI.UIComponents.Validate.Validator validator1;
        private CI.Controls.FlatField flatField6;
        private CI.Controls.FlatField flatField8;
        private CI.Controls.FlatField flatField11;
        private CI.Controls.FlatField txtJylb;
        private CI.Controls.FlatField txtStandardType;
        private CI.Controls.FlatField flatField12;
    }
}