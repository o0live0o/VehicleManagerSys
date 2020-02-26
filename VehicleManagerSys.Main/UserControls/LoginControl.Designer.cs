namespace VehicleManagerSys.Main.UserControls
{
    partial class LoginControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flatField12 = new CI.Controls.FlatField();
            this.btnClear = new EASkins.Ami_Button_2();
            this.btnSave = new EASkins.Emi_Button_2();
            this.btnSearch = new EASkins.Emi_Button_2();
            this.combQueryPlateType = new EASkins.Emi_ComboBox();
            this.txtQueryPlateNo = new EASkins.Controls.MaterialSingleLineTextField();
            this.combQueryAera = new EASkins.Emi_ComboBox();
            this.ami_Separator1 = new EASkins.Ami_Separator();
            this.txtHasObd = new CI.Controls.FlatField();
            this.txtStandardType = new CI.Controls.FlatField();
            this.txtHasDpf = new CI.Controls.FlatField();
            this.flatField10 = new CI.Controls.FlatField();
            this.flatField2 = new CI.Controls.FlatField();
            this.flatField5 = new CI.Controls.FlatField();
            this.flatField11 = new CI.Controls.FlatField();
            this.flatField8 = new CI.Controls.FlatField();
            this.flatField6 = new CI.Controls.FlatField();
            this.flatField4 = new CI.Controls.FlatField();
            this.flatField1 = new CI.Controls.FlatField();
            this.txtZBZL = new CI.Controls.FlatField();
            this.txtHasScr = new CI.Controls.FlatField();
            this.flatField9 = new CI.Controls.FlatField();
            this.txtGYFS = new CI.Controls.FlatField();
            this.flatField7 = new CI.Controls.FlatField();
            this.txtJylb = new CI.Controls.FlatField();
            this.txtJQFS = new CI.Controls.FlatField();
            this.txtBSQXS = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.txtQDXS = new CI.Controls.FlatField();
            this.txtCYS = new CI.Controls.FlatField();
            this.txtRLLB = new CI.Controls.FlatField();
            this.txtXH = new CI.Controls.FlatField();
            this.txtLJXSLC = new CI.Controls.FlatField();
            this.txtZZL = new CI.Controls.FlatField();
            this.txtSYXZ = new CI.Controls.FlatField();
            this.txtPP = new CI.Controls.FlatField();
            this.txtCCRQ = new CI.Controls.FlatField();
            this.txtVIN = new CI.Controls.FlatField();
            this.txtCLZL = new CI.Controls.FlatField();
            this.txtCCDJRQ = new CI.Controls.FlatField();
            this.txtHPYS = new CI.Controls.FlatField();
            this.txtHPZL = new CI.Controls.FlatField();
            this.txtHPHM = new CI.Controls.FlatField();
            this.flatField14 = new CI.Controls.FlatField();
            this.flatField16 = new CI.Controls.FlatField();
            this.txtHasEgr = new CI.Controls.FlatField();
            this.txtHasHCL = new CI.Controls.FlatField();
            this.txtDK = new CI.Controls.FlatField();
            this.flatField20 = new CI.Controls.FlatField();
            this.txtCloseStableSys = new CI.Controls.FlatField();
            this.txtVehicleStatus = new CI.Controls.FlatField();
            this.flatField23 = new CI.Controls.FlatField();
            this.flatField24 = new CI.Controls.FlatField();
            this.txtRYZF = new CI.Controls.FlatField();
            this.txtHasCHZHQ = new CI.Controls.FlatField();
            this.flatField27 = new CI.Controls.FlatField();
            this.flatField28 = new CI.Controls.FlatField();
            this.txtEnterTown = new CI.Controls.FlatField();
            this.flatField32 = new CI.Controls.FlatField();
            this.flatField33 = new CI.Controls.FlatField();
            this.flatField34 = new CI.Controls.FlatField();
            this.flatField35 = new CI.Controls.FlatField();
            this.flatField36 = new CI.Controls.FlatField();
            this.flatField37 = new CI.Controls.FlatField();
            this.vehicleFiller = new CI.UIComponents.Filler.EntityFiller();
            this.txtCountry = new CI.Controls.FlatField();
            this.flatField38 = new CI.Controls.FlatField();
            this.txtSignType = new CI.Controls.FlatField();
            this.txtEmissionStandard = new CI.Controls.FlatField();
            this.loginFiller = new CI.UIComponents.Filler.EntityFiller();
            this.netFiller = new CI.UIComponents.Filler.EntityFiller();
            this.flatField30 = new CI.Controls.FlatField();
            this.selectorFiller = new CI.UIComponents.Filler.EntityFiller();
            this.btnSend = new EASkins.Emi_Button_2();
            this.validator1 = new CI.UIComponents.Validate.Validator();
            this.SuspendLayout();
            // 
            // flatField12
            // 
            this.flatField12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField12.BackColor = System.Drawing.Color.Transparent;
            this.flatField12.Caption = "发动机号: ";
            this.flatField12.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField12.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField12, new CI.UIComponents.Filler.TextEntry("FDJH", ""));
            this.vehicleFiller.SetEntityField(this.flatField12, new CI.UIComponents.Filler.TextEntry("EngineNumber", ""));
            this.netFiller.SetEntityField(this.flatField12, new CI.UIComponents.Filler.TextEntry("FDJH", ""));
            this.flatField12.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField12.Location = new System.Drawing.Point(618, 317);
            this.flatField12.Name = "flatField12";
            this.flatField12.Size = new System.Drawing.Size(237, 31);
            this.flatField12.TabIndex = 117;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnClear.Image = null;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(690, 52);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 23);
            this.btnClear.TabIndex = 116;
            this.btnClear.Text = "清 空";
            this.btnClear.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(866, 52);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 23);
            this.btnSave.TabIndex = 114;
            this.btnSave.Text = "保 存";
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = null;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(778, 52);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 23);
            this.btnSearch.TabIndex = 113;
            this.btnSearch.Text = "查  询";
            this.btnSearch.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.combQueryPlateType.Location = new System.Drawing.Point(455, 49);
            this.combQueryPlateType.Margin = new System.Windows.Forms.Padding(2);
            this.combQueryPlateType.MaxDropDownItems = 10;
            this.combQueryPlateType.Name = "combQueryPlateType";
            this.combQueryPlateType.Size = new System.Drawing.Size(129, 26);
            this.combQueryPlateType.StartIndex = 0;
            this.combQueryPlateType.TabIndex = 112;
            this.combQueryPlateType.Visible = false;
            // 
            // txtQueryPlateNo
            // 
            this.txtQueryPlateNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQueryPlateNo.Depth = 0;
            this.txtQueryPlateNo.Hint = "号牌号码";
            this.txtQueryPlateNo.Location = new System.Drawing.Point(233, 52);
            this.txtQueryPlateNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueryPlateNo.MaxLength = 32767;
            this.txtQueryPlateNo.MouseState = EASkins.MouseState.HOVER;
            this.txtQueryPlateNo.Name = "txtQueryPlateNo";
            this.txtQueryPlateNo.PasswordChar = '\0';
            this.txtQueryPlateNo.SelectedText = "";
            this.txtQueryPlateNo.SelectionLength = 0;
            this.txtQueryPlateNo.SelectionStart = 0;
            this.txtQueryPlateNo.Size = new System.Drawing.Size(198, 23);
            this.txtQueryPlateNo.TabIndex = 110;
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
            this.combQueryAera.Location = new System.Drawing.Point(154, 49);
            this.combQueryAera.Margin = new System.Windows.Forms.Padding(2);
            this.combQueryAera.Name = "combQueryAera";
            this.combQueryAera.Size = new System.Drawing.Size(71, 26);
            this.combQueryAera.StartIndex = 0;
            this.combQueryAera.TabIndex = 111;
            // 
            // ami_Separator1
            // 
            this.ami_Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ami_Separator1.Location = new System.Drawing.Point(-66, 80);
            this.ami_Separator1.Name = "ami_Separator1";
            this.ami_Separator1.Size = new System.Drawing.Size(1193, 10);
            this.ami_Separator1.TabIndex = 109;
            this.ami_Separator1.Text = "ami_Separator1";
            // 
            // txtHasObd
            // 
            this.txtHasObd.AlwaysShowDropDownStyle = true;
            this.txtHasObd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHasObd.BackColor = System.Drawing.Color.Transparent;
            this.txtHasObd.Caption = "是否有OBD:";
            this.txtHasObd.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasObd.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtHasObd, new CI.UIComponents.Filler.TextEntry("", "IsOBD"));
            this.selectorFiller.SetEntityField(this.txtHasObd, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHasObd, new CI.UIComponents.Filler.TextEntry("HasOBDTxt", "HasOBD"));
            this.netFiller.SetEntityField(this.txtHasObd, new CI.UIComponents.Filler.TextEntry("", "SFYOBD"));
            this.txtHasObd.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasObd.Location = new System.Drawing.Point(618, 463);
            this.txtHasObd.Name = "txtHasObd";
            this.txtHasObd.Size = new System.Drawing.Size(237, 31);
            this.txtHasObd.TabIndex = 99;
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
            this.vehicleFiller.SetEntityField(this.txtStandardType, new CI.UIComponents.Filler.TextEntry("LimitTypeText", "LimitType"));
            this.netFiller.SetEntityField(this.txtStandardType, new CI.UIComponents.Filler.TextEntry("", "XZFL"));
            this.txtStandardType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtStandardType.Location = new System.Drawing.Point(869, 500);
            this.txtStandardType.Name = "txtStandardType";
            this.txtStandardType.ReadOnly = true;
            this.txtStandardType.Size = new System.Drawing.Size(237, 31);
            this.txtStandardType.TabIndex = 108;
            // 
            // txtHasDpf
            // 
            this.txtHasDpf.AlwaysShowDropDownStyle = true;
            this.txtHasDpf.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHasDpf.BackColor = System.Drawing.Color.Transparent;
            this.txtHasDpf.Caption = "是否有DPF:";
            this.txtHasDpf.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasDpf.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtHasDpf, new CI.UIComponents.Filler.TextEntry("IsDPF", "IsDPFDH"));
            this.selectorFiller.SetEntityField(this.txtHasDpf, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.netFiller.SetEntityField(this.txtHasDpf, new CI.UIComponents.Filler.TextEntry("", "SFYDPF"));
            this.txtHasDpf.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasDpf.Location = new System.Drawing.Point(618, 426);
            this.txtHasDpf.Name = "txtHasDpf";
            this.txtHasDpf.Size = new System.Drawing.Size(237, 31);
            this.txtHasDpf.TabIndex = 102;
            // 
            // flatField10
            // 
            this.flatField10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField10.BackColor = System.Drawing.Color.Transparent;
            this.flatField10.Caption = "额定功率: ";
            this.flatField10.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField10.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField10, new CI.UIComponents.Filler.TextEntry("EDGL", ""));
            this.vehicleFiller.SetEntityField(this.flatField10, new CI.UIComponents.Filler.TextEntry("Power", ""));
            this.netFiller.SetEntityField(this.flatField10, new CI.UIComponents.Filler.TextEntry("FDJEDGL", ""));
            this.flatField10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField10.Location = new System.Drawing.Point(340, 214);
            this.flatField10.Name = "flatField10";
            this.flatField10.Size = new System.Drawing.Size(237, 31);
            this.flatField10.TabIndex = 85;
            // 
            // flatField2
            // 
            this.flatField2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField2.BackColor = System.Drawing.Color.Transparent;
            this.flatField2.Caption = "发动机型号:";
            this.flatField2.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField2.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField2, new CI.UIComponents.Filler.TextEntry("FDJXH", ""));
            this.vehicleFiller.SetEntityField(this.flatField2, new CI.UIComponents.Filler.TextEntry("EngineModel", ""));
            this.netFiller.SetEntityField(this.flatField2, new CI.UIComponents.Filler.TextEntry("FDJXH", ""));
            this.flatField2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField2.Location = new System.Drawing.Point(869, 319);
            this.flatField2.Name = "flatField2";
            this.flatField2.Size = new System.Drawing.Size(237, 31);
            this.flatField2.TabIndex = 97;
            // 
            // flatField5
            // 
            this.flatField5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField5.BackColor = System.Drawing.Color.Transparent;
            this.flatField5.Caption = "DPF型号:  ";
            this.flatField5.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField5.CaptionWidth = 0;
            this.flatField5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField5.Location = new System.Drawing.Point(869, 426);
            this.flatField5.Name = "flatField5";
            this.flatField5.Size = new System.Drawing.Size(237, 31);
            this.flatField5.TabIndex = 103;
            // 
            // flatField11
            // 
            this.flatField11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField11.BackColor = System.Drawing.Color.Transparent;
            this.flatField11.Caption = "联系电话: ";
            this.flatField11.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField11.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField11, new CI.UIComponents.Filler.TextEntry("LXDH", ""));
            this.vehicleFiller.SetEntityField(this.flatField11, new CI.UIComponents.Filler.TextEntry("OwnerPhone", ""));
            this.netFiller.SetEntityField(this.flatField11, new CI.UIComponents.Filler.TextEntry("CZDH", ""));
            this.flatField11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField11.Location = new System.Drawing.Point(869, 391);
            this.flatField11.Name = "flatField11";
            this.flatField11.Size = new System.Drawing.Size(237, 31);
            this.flatField11.TabIndex = 106;
            // 
            // flatField8
            // 
            this.flatField8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField8.BackColor = System.Drawing.Color.Transparent;
            this.flatField8.Caption = "所有人:   ";
            this.flatField8.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField8.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField8, new CI.UIComponents.Filler.TextEntry("SYR", ""));
            this.vehicleFiller.SetEntityField(this.flatField8, new CI.UIComponents.Filler.TextEntry("Owner", ""));
            this.netFiller.SetEntityField(this.flatField8, new CI.UIComponents.Filler.TextEntry("", "CZ"));
            this.flatField8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField8.Location = new System.Drawing.Point(340, 354);
            this.flatField8.Name = "flatField8";
            this.flatField8.Size = new System.Drawing.Size(237, 31);
            this.flatField8.TabIndex = 105;
            // 
            // flatField6
            // 
            this.flatField6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField6.BackColor = System.Drawing.Color.Transparent;
            this.flatField6.Caption = "车辆生产企业:";
            this.flatField6.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField6.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField6, new CI.UIComponents.Filler.TextEntry("CLZZCS", ""));
            this.vehicleFiller.SetEntityField(this.flatField6, new CI.UIComponents.Filler.TextEntry("Manufacturer", ""));
            this.netFiller.SetEntityField(this.flatField6, new CI.UIComponents.Filler.TextEntry("CLSCCS", ""));
            this.flatField6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField6.Location = new System.Drawing.Point(64, 426);
            this.flatField6.Name = "flatField6";
            this.flatField6.Size = new System.Drawing.Size(237, 31);
            this.flatField6.TabIndex = 104;
            // 
            // flatField4
            // 
            this.flatField4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "SCR型号:  ";
            this.flatField4.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField4, new CI.UIComponents.Filler.TextEntry("SCRFModel", ""));
            this.flatField4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.Location = new System.Drawing.Point(340, 463);
            this.flatField4.Name = "flatField4";
            this.flatField4.Size = new System.Drawing.Size(237, 31);
            this.flatField4.TabIndex = 101;
            // 
            // flatField1
            // 
            this.flatField1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "催化装换器型号:";
            this.flatField1.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField1.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("CatalyticConverterModel", ""));
            this.netFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("CHZHQXH", ""));
            this.flatField1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField1.Location = new System.Drawing.Point(869, 609);
            this.flatField1.Name = "flatField1";
            this.flatField1.Size = new System.Drawing.Size(237, 31);
            this.flatField1.TabIndex = 98;
            // 
            // txtZBZL
            // 
            this.txtZBZL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtZBZL.BackColor = System.Drawing.Color.Transparent;
            this.txtZBZL.Caption = "整备质量: ";
            this.txtZBZL.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtZBZL.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtZBZL, new CI.UIComponents.Filler.TextEntry("ZBZL", ""));
            this.vehicleFiller.SetEntityField(this.txtZBZL, new CI.UIComponents.Filler.TextEntry("KerbWeight", ""));
            this.netFiller.SetEntityField(this.txtZBZL, new CI.UIComponents.Filler.TextEntry("ZBZL", ""));
            this.txtZBZL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtZBZL.Location = new System.Drawing.Point(64, 321);
            this.txtZBZL.Name = "txtZBZL";
            this.txtZBZL.Size = new System.Drawing.Size(237, 31);
            this.txtZBZL.TabIndex = 95;
            // 
            // txtHasScr
            // 
            this.txtHasScr.AlwaysShowDropDownStyle = true;
            this.txtHasScr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHasScr.BackColor = System.Drawing.Color.Transparent;
            this.txtHasScr.Caption = "是否有SCR:";
            this.txtHasScr.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasScr.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtHasScr, new CI.UIComponents.Filler.TextEntry("IsSCR", "IsSCRDH"));
            this.selectorFiller.SetEntityField(this.txtHasScr, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHasScr, new CI.UIComponents.Filler.TextEntry("HasSCRTxt", "HasSCR"));
            this.txtHasScr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasScr.Location = new System.Drawing.Point(64, 463);
            this.txtHasScr.Name = "txtHasScr";
            this.txtHasScr.Size = new System.Drawing.Size(237, 31);
            this.txtHasScr.TabIndex = 100;
            // 
            // flatField9
            // 
            this.flatField9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField9.BackColor = System.Drawing.Color.Transparent;
            this.flatField9.Caption = "额定转速: ";
            this.flatField9.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField9.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField9, new CI.UIComponents.Filler.TextEntry("EDZS", ""));
            this.vehicleFiller.SetEntityField(this.flatField9, new CI.UIComponents.Filler.TextEntry("RatedSpeed", ""));
            this.netFiller.SetEntityField(this.flatField9, new CI.UIComponents.Filler.TextEntry("FDJEDZS", ""));
            this.flatField9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField9.Location = new System.Drawing.Point(869, 253);
            this.flatField9.Name = "flatField9";
            this.flatField9.Size = new System.Drawing.Size(237, 31);
            this.flatField9.TabIndex = 92;
            // 
            // txtGYFS
            // 
            this.txtGYFS.AlwaysShowDropDownStyle = true;
            this.txtGYFS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGYFS.BackColor = System.Drawing.Color.Transparent;
            this.txtGYFS.Caption = "供油方式: ";
            this.txtGYFS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtGYFS.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtGYFS, new CI.UIComponents.Filler.TextEntry("GYFS", "GYFSDH"));
            this.selectorFiller.SetEntityField(this.txtGYFS, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtGYFS, new CI.UIComponents.Filler.TextEntry("FuelSupplyTypeTxt", "FuelSupplyType"));
            this.netFiller.SetEntityField(this.txtGYFS, new CI.UIComponents.Filler.TextEntry("", "GYFSDM"));
            this.txtGYFS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtGYFS.Location = new System.Drawing.Point(616, 286);
            this.txtGYFS.Name = "txtGYFS";
            this.txtGYFS.ReadOnly = true;
            this.txtGYFS.Size = new System.Drawing.Size(237, 31);
            this.txtGYFS.Style = CI.Controls.FieldStyle.DropDown;
            this.txtGYFS.TabIndex = 91;
            // 
            // flatField7
            // 
            this.flatField7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField7.BackColor = System.Drawing.Color.Transparent;
            this.flatField7.Caption = "排量(L):  ";
            this.flatField7.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField7.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField7, new CI.UIComponents.Filler.TextEntry("pl", ""));
            this.netFiller.SetEntityField(this.flatField7, new CI.UIComponents.Filler.TextEntry("FDJPL", ""));
            this.flatField7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField7.Location = new System.Drawing.Point(340, 286);
            this.flatField7.Name = "flatField7";
            this.flatField7.Size = new System.Drawing.Size(237, 31);
            this.flatField7.TabIndex = 90;
            // 
            // txtJylb
            // 
            this.txtJylb.AlwaysShowDropDownStyle = true;
            this.txtJylb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtJylb.BackColor = System.Drawing.Color.Transparent;
            this.txtJylb.Caption = "检验类别: ";
            this.txtJylb.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtJylb.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtJylb, new CI.UIComponents.Filler.TextEntry("JYLB", "JYLBDH"));
            this.selectorFiller.SetEntityField(this.txtJylb, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtJylb, new CI.UIComponents.Filler.TextEntry("DetectTypeTxt", "DetectType"));
            this.netFiller.SetEntityField(this.txtJylb, new CI.UIComponents.Filler.TextEntry("", "JCLXDM"));
            this.txtJylb.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtJylb.Location = new System.Drawing.Point(340, 426);
            this.txtJylb.Name = "txtJylb";
            this.txtJylb.ReadOnly = true;
            this.txtJylb.Size = new System.Drawing.Size(237, 31);
            this.txtJylb.TabIndex = 107;
            // 
            // txtJQFS
            // 
            this.txtJQFS.AlwaysShowDropDownStyle = true;
            this.txtJQFS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtJQFS.BackColor = System.Drawing.Color.Transparent;
            this.txtJQFS.Caption = "进气方式: ";
            this.txtJQFS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtJQFS.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtJQFS, new CI.UIComponents.Filler.TextEntry("JQFS", "JQFSDH"));
            this.selectorFiller.SetEntityField(this.txtJQFS, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtJQFS, new CI.UIComponents.Filler.TextEntry("IntakeTypeTxt", "IntakeType"));
            this.netFiller.SetEntityField(this.txtJQFS, new CI.UIComponents.Filler.TextEntry("", "JQFSDM"));
            this.txtJQFS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtJQFS.Location = new System.Drawing.Point(64, 286);
            this.txtJQFS.Name = "txtJQFS";
            this.txtJQFS.ReadOnly = true;
            this.txtJQFS.Size = new System.Drawing.Size(237, 31);
            this.txtJQFS.TabIndex = 89;
            // 
            // txtBSQXS
            // 
            this.txtBSQXS.AlwaysShowDropDownStyle = true;
            this.txtBSQXS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBSQXS.BackColor = System.Drawing.Color.Transparent;
            this.txtBSQXS.Caption = "变速箱形式:";
            this.txtBSQXS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtBSQXS.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtBSQXS, new CI.UIComponents.Filler.TextEntry("BSXLX", "BSXLXDH"));
            this.selectorFiller.SetEntityField(this.txtBSQXS, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtBSQXS, new CI.UIComponents.Filler.TextEntry("TransmissionTypeTxt", "TransmissionType"));
            this.netFiller.SetEntityField(this.txtBSQXS, new CI.UIComponents.Filler.TextEntry("", "BSXXSDM"));
            this.txtBSQXS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtBSQXS.Location = new System.Drawing.Point(616, 251);
            this.txtBSQXS.Name = "txtBSQXS";
            this.txtBSQXS.ReadOnly = true;
            this.txtBSQXS.Size = new System.Drawing.Size(237, 31);
            this.txtBSQXS.TabIndex = 88;
            // 
            // flatField3
            // 
            this.flatField3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "发动机生产厂:";
            this.flatField3.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("FDJSCC", ""));
            this.vehicleFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("EngineManufacturer", ""));
            this.netFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("FDJSCCS", ""));
            this.flatField3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.Location = new System.Drawing.Point(64, 214);
            this.flatField3.Name = "flatField3";
            this.flatField3.Size = new System.Drawing.Size(237, 31);
            this.flatField3.TabIndex = 84;
            // 
            // txtQDXS
            // 
            this.txtQDXS.AlwaysShowDropDownStyle = true;
            this.txtQDXS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQDXS.BackColor = System.Drawing.Color.Transparent;
            this.txtQDXS.Caption = "驱动形式: ";
            this.txtQDXS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtQDXS.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtQDXS, new CI.UIComponents.Filler.TextEntry("QDXS", "QDXSDH"));
            this.selectorFiller.SetEntityField(this.txtQDXS, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtQDXS, new CI.UIComponents.Filler.TextEntry("DriveTypeTxt", "DriveType"));
            this.netFiller.SetEntityField(this.txtQDXS, new CI.UIComponents.Filler.TextEntry("", "QDFSDM"));
            this.txtQDXS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtQDXS.Location = new System.Drawing.Point(869, 286);
            this.txtQDXS.Name = "txtQDXS";
            this.txtQDXS.ReadOnly = true;
            this.txtQDXS.Size = new System.Drawing.Size(237, 31);
            this.txtQDXS.Style = CI.Controls.FieldStyle.DropDown;
            this.txtQDXS.TabIndex = 93;
            // 
            // txtCYS
            // 
            this.txtCYS.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCYS.BackColor = System.Drawing.Color.Transparent;
            this.txtCYS.Caption = "核载人数: ";
            this.txtCYS.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCYS.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtCYS, new CI.UIComponents.Filler.TextEntry("", "CYS"));
            this.vehicleFiller.SetEntityField(this.txtCYS, new CI.UIComponents.Filler.TextEntry("PassengerAmount", ""));
            this.netFiller.SetEntityField(this.txtCYS, new CI.UIComponents.Filler.TextEntry("SJCYS", ""));
            this.txtCYS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCYS.Location = new System.Drawing.Point(64, 251);
            this.txtCYS.Name = "txtCYS";
            this.txtCYS.Size = new System.Drawing.Size(237, 31);
            this.txtCYS.TabIndex = 86;
            // 
            // txtRLLB
            // 
            this.txtRLLB.AlwaysShowDropDownStyle = true;
            this.txtRLLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRLLB.BackColor = System.Drawing.Color.Transparent;
            this.txtRLLB.Caption = "燃料类别: ";
            this.txtRLLB.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRLLB.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtRLLB, new CI.UIComponents.Filler.TextEntry("RLLB", "RLLBDH"));
            this.selectorFiller.SetEntityField(this.txtRLLB, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtRLLB, new CI.UIComponents.Filler.TextEntry("FuelTypeTxt", "FuelType"));
            this.netFiller.SetEntityField(this.txtRLLB, new CI.UIComponents.Filler.TextEntry("", "RLLBDM"));
            this.txtRLLB.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRLLB.Location = new System.Drawing.Point(340, 251);
            this.txtRLLB.Name = "txtRLLB";
            this.txtRLLB.ReadOnly = true;
            this.txtRLLB.Size = new System.Drawing.Size(237, 31);
            this.txtRLLB.Style = CI.Controls.FieldStyle.DropDown;
            this.txtRLLB.TabIndex = 87;
            // 
            // txtXH
            // 
            this.txtXH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtXH.BackColor = System.Drawing.Color.Transparent;
            this.txtXH.Caption = "型号:";
            this.txtXH.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtXH.CaptionLength = 5;
            this.txtXH.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtXH, new CI.UIComponents.Filler.TextEntry("XH", ""));
            this.vehicleFiller.SetEntityField(this.txtXH, new CI.UIComponents.Filler.TextEntry("Model", ""));
            this.netFiller.SetEntityField(this.txtXH, new CI.UIComponents.Filler.TextEntry("CLXH", ""));
            this.txtXH.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtXH.Location = new System.Drawing.Point(869, 181);
            this.txtXH.Name = "txtXH";
            this.txtXH.Size = new System.Drawing.Size(237, 31);
            this.txtXH.TabIndex = 83;
            // 
            // txtLJXSLC
            // 
            this.txtLJXSLC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLJXSLC.BackColor = System.Drawing.Color.Transparent;
            this.txtLJXSLC.Caption = "累计行驶里程:";
            this.txtLJXSLC.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLJXSLC.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtLJXSLC, new CI.UIComponents.Filler.TextEntry("LJXSLC", ""));
            this.vehicleFiller.SetEntityField(this.txtLJXSLC, new CI.UIComponents.Filler.TextEntry("Mileage", ""));
            this.netFiller.SetEntityField(this.txtLJXSLC, new CI.UIComponents.Filler.TextEntry("LCBDS", ""));
            this.txtLJXSLC.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtLJXSLC.Location = new System.Drawing.Point(869, 144);
            this.txtLJXSLC.Name = "txtLJXSLC";
            this.txtLJXSLC.Size = new System.Drawing.Size(237, 31);
            this.txtLJXSLC.TabIndex = 96;
            // 
            // txtZZL
            // 
            this.txtZZL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtZZL.BackColor = System.Drawing.Color.Transparent;
            this.txtZZL.Caption = "总质量:   ";
            this.txtZZL.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtZZL.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtZZL, new CI.UIComponents.Filler.TextEntry("ZZL", ""));
            this.vehicleFiller.SetEntityField(this.txtZZL, new CI.UIComponents.Filler.TextEntry("TotalWeight", ""));
            this.netFiller.SetEntityField(this.txtZZL, new CI.UIComponents.Filler.TextEntry("ZDZZL", ""));
            this.txtZZL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtZZL.Location = new System.Drawing.Point(340, 317);
            this.txtZZL.Name = "txtZZL";
            this.txtZZL.Size = new System.Drawing.Size(237, 31);
            this.txtZZL.TabIndex = 94;
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
            this.loginFiller.SetEntityField(this.txtSYXZ, new CI.UIComponents.Filler.TextEntry("SYXZ", "SYXZDH"));
            this.selectorFiller.SetEntityField(this.txtSYXZ, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtSYXZ, new CI.UIComponents.Filler.TextEntry("UseTypeTxt", "UseType"));
            this.netFiller.SetEntityField(this.txtSYXZ, new CI.UIComponents.Filler.TextEntry("", "SYXZDM"));
            this.txtSYXZ.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSYXZ.Location = new System.Drawing.Point(616, 146);
            this.txtSYXZ.Name = "txtSYXZ";
            this.txtSYXZ.ReadOnly = true;
            this.txtSYXZ.Size = new System.Drawing.Size(237, 31);
            this.txtSYXZ.TabIndex = 79;
            // 
            // txtPP
            // 
            this.txtPP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPP.BackColor = System.Drawing.Color.Transparent;
            this.txtPP.Caption = "品牌:     ";
            this.txtPP.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPP.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtPP, new CI.UIComponents.Filler.TextEntry("PP", ""));
            this.vehicleFiller.SetEntityField(this.txtPP, new CI.UIComponents.Filler.TextEntry("Brand", ""));
            this.netFiller.SetEntityField(this.txtPP, new CI.UIComponents.Filler.TextEntry("CLPP", ""));
            this.txtPP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtPP.Location = new System.Drawing.Point(616, 181);
            this.txtPP.Name = "txtPP";
            this.txtPP.Size = new System.Drawing.Size(237, 31);
            this.txtPP.TabIndex = 82;
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
            this.loginFiller.SetEntityField(this.txtCCRQ, new CI.UIComponents.Filler.TextEntry("CCRQ", ""));
            this.selectorFiller.SetEntityField(this.txtCCRQ, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtCCRQ, new CI.UIComponents.Filler.TextEntry("ManufactureDate", ""));
            this.netFiller.SetEntityField(this.txtCCRQ, new CI.UIComponents.Filler.TextEntry("", "CCRQ"));
            this.txtCCRQ.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCCRQ.Format = "yyyy-MM-dd";
            this.txtCCRQ.Location = new System.Drawing.Point(340, 181);
            this.txtCCRQ.Name = "txtCCRQ";
            this.txtCCRQ.ReadOnly = true;
            this.txtCCRQ.Size = new System.Drawing.Size(237, 31);
            this.txtCCRQ.Style = CI.Controls.FieldStyle.DropDown;
            this.txtCCRQ.TabIndex = 81;
            // 
            // txtVIN
            // 
            this.txtVIN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVIN.BackColor = System.Drawing.Color.Transparent;
            this.txtVIN.Caption = "VIN: ";
            this.txtVIN.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtVIN.CaptionLength = 5;
            this.txtVIN.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtVIN, new CI.UIComponents.Filler.TextEntry("VIN", ""));
            this.vehicleFiller.SetEntityField(this.txtVIN, new CI.UIComponents.Filler.TextEntry("VIN", ""));
            this.netFiller.SetEntityField(this.txtVIN, new CI.UIComponents.Filler.TextEntry("CLSBDH", ""));
            this.txtVIN.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtVIN.Location = new System.Drawing.Point(64, 146);
            this.txtVIN.Name = "txtVIN";
            this.txtVIN.Size = new System.Drawing.Size(237, 31);
            this.txtVIN.TabIndex = 77;
            this.validator1.SetTaget(this.txtVIN, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
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
            this.loginFiller.SetEntityField(this.txtCLZL, new CI.UIComponents.Filler.TextEntry("CLZL", "CLZLDH"));
            this.selectorFiller.SetEntityField(this.txtCLZL, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtCLZL, new CI.UIComponents.Filler.TextEntry("VehicleTypeTxt", "VehicleType"));
            this.netFiller.SetEntityField(this.txtCLZL, new CI.UIComponents.Filler.TextEntry("", "CLLXDM"));
            this.txtCLZL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCLZL.Location = new System.Drawing.Point(340, 146);
            this.txtCLZL.Name = "txtCLZL";
            this.txtCLZL.ReadOnly = true;
            this.txtCLZL.Size = new System.Drawing.Size(237, 31);
            this.txtCLZL.Style = CI.Controls.FieldStyle.DropDown;
            this.txtCLZL.TabIndex = 78;
            // 
            // txtCCDJRQ
            // 
            this.txtCCDJRQ.AlwaysShowDropDownStyle = true;
            this.txtCCDJRQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCCDJRQ.BackColor = System.Drawing.Color.Transparent;
            this.txtCCDJRQ.Caption = "初始登记日期:";
            this.txtCCDJRQ.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCCDJRQ.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtCCDJRQ, new CI.UIComponents.Filler.TextEntry("CCDJRQ", ""));
            this.selectorFiller.SetEntityField(this.txtCCDJRQ, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtCCDJRQ, new CI.UIComponents.Filler.TextEntry("RegisterDate", ""));
            this.netFiller.SetEntityField(this.txtCCDJRQ, new CI.UIComponents.Filler.TextEntry("", "ZCDJRQ"));
            this.txtCCDJRQ.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCCDJRQ.Format = "yyyy-MM-dd";
            this.txtCCDJRQ.Location = new System.Drawing.Point(64, 181);
            this.txtCCDJRQ.Name = "txtCCDJRQ";
            this.txtCCDJRQ.ReadOnly = true;
            this.txtCCDJRQ.Size = new System.Drawing.Size(237, 31);
            this.txtCCDJRQ.Style = CI.Controls.FieldStyle.DropDown;
            this.txtCCDJRQ.TabIndex = 80;
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
            this.loginFiller.SetEntityField(this.txtHPYS, new CI.UIComponents.Filler.TextEntry("HPYS", "HPYSDH"));
            this.selectorFiller.SetEntityField(this.txtHPYS, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHPYS, new CI.UIComponents.Filler.TextEntry("PlateColorTxt", "PlateColor"));
            this.netFiller.SetEntityField(this.txtHPYS, new CI.UIComponents.Filler.TextEntry("", "HPYSDM"));
            this.txtHPYS.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPYS.Location = new System.Drawing.Point(340, 111);
            this.txtHPYS.Name = "txtHPYS";
            this.txtHPYS.ReadOnly = true;
            this.txtHPYS.Size = new System.Drawing.Size(237, 31);
            this.txtHPYS.TabIndex = 75;
            // 
            // txtHPZL
            // 
            this.txtHPZL.AlwaysShowDropDownStyle = true;
            this.txtHPZL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHPZL.BackColor = System.Drawing.Color.Transparent;
            this.txtHPZL.Caption = "号牌种类: ";
            this.txtHPZL.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPZL.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtHPZL, new CI.UIComponents.Filler.TextEntry("HPZL", "HPZLDH"));
            this.selectorFiller.SetEntityField(this.txtHPZL, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHPZL, new CI.UIComponents.Filler.TextEntry("PlateTypeTxt", "PlateType"));
            this.netFiller.SetEntityField(this.txtHPZL, new CI.UIComponents.Filler.TextEntry("", "HPZLDM"));
            this.txtHPZL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPZL.Location = new System.Drawing.Point(616, 111);
            this.txtHPZL.Name = "txtHPZL";
            this.txtHPZL.ReadOnly = true;
            this.txtHPZL.Size = new System.Drawing.Size(237, 31);
            this.txtHPZL.Style = CI.Controls.FieldStyle.DropDown;
            this.txtHPZL.TabIndex = 76;
            // 
            // txtHPHM
            // 
            this.txtHPHM.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHPHM.BackColor = System.Drawing.Color.Transparent;
            this.txtHPHM.Caption = "号牌号码: ";
            this.txtHPHM.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPHM.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.txtHPHM, new CI.UIComponents.Filler.TextEntry("HPHM", ""));
            this.vehicleFiller.SetEntityField(this.txtHPHM, new CI.UIComponents.Filler.TextEntry("PlateNo", ""));
            this.netFiller.SetEntityField(this.txtHPHM, new CI.UIComponents.Filler.TextEntry("HPHM", ""));
            this.txtHPHM.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHPHM.Location = new System.Drawing.Point(64, 111);
            this.txtHPHM.Name = "txtHPHM";
            this.txtHPHM.Size = new System.Drawing.Size(237, 31);
            this.txtHPHM.TabIndex = 74;
            this.validator1.SetTaget(this.txtHPHM, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // flatField14
            // 
            this.flatField14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField14.BackColor = System.Drawing.Color.Transparent;
            this.flatField14.Caption = "地址:     ";
            this.flatField14.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField14.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField14, new CI.UIComponents.Filler.TextEntry("LXDZ", ""));
            this.vehicleFiller.SetEntityField(this.flatField14, new CI.UIComponents.Filler.TextEntry("OwnerAddress", ""));
            this.netFiller.SetEntityField(this.flatField14, new CI.UIComponents.Filler.TextEntry("CZDZ", ""));
            this.flatField14.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField14.Location = new System.Drawing.Point(618, 391);
            this.flatField14.Name = "flatField14";
            this.flatField14.Size = new System.Drawing.Size(237, 31);
            this.flatField14.TabIndex = 119;
            // 
            // flatField16
            // 
            this.flatField16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField16.BackColor = System.Drawing.Color.Transparent;
            this.flatField16.Caption = "基准质量: ";
            this.flatField16.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField16.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField16, new CI.UIComponents.Filler.TextEntry("BasicWeight", ""));
            this.netFiller.SetEntityField(this.flatField16, new CI.UIComponents.Filler.TextEntry("JZZL", ""));
            this.flatField16.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField16.Location = new System.Drawing.Point(869, 111);
            this.flatField16.Name = "flatField16";
            this.flatField16.Size = new System.Drawing.Size(237, 31);
            this.flatField16.TabIndex = 121;
            // 
            // txtHasEgr
            // 
            this.txtHasEgr.AlwaysShowDropDownStyle = true;
            this.txtHasEgr.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHasEgr.BackColor = System.Drawing.Color.Transparent;
            this.txtHasEgr.Caption = "是否有EGR:";
            this.txtHasEgr.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasEgr.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtHasEgr, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHasEgr, new CI.UIComponents.Filler.TextEntry("HasEGRTxt", "HasEGR"));
            this.netFiller.SetEntityField(this.txtHasEgr, new CI.UIComponents.Filler.TextEntry("", "SFYEGR"));
            this.txtHasEgr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasEgr.Location = new System.Drawing.Point(64, 500);
            this.txtHasEgr.Name = "txtHasEgr";
            this.txtHasEgr.Size = new System.Drawing.Size(237, 31);
            this.txtHasEgr.TabIndex = 122;
            // 
            // txtHasHCL
            // 
            this.txtHasHCL.AlwaysShowDropDownStyle = true;
            this.txtHasHCL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHasHCL.BackColor = System.Drawing.Color.Transparent;
            this.txtHasHCL.Caption = "是否有后处理装置:";
            this.txtHasHCL.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasHCL.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtHasHCL, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHasHCL, new CI.UIComponents.Filler.TextEntry("HasTreatmentDeviceTxt", "HasTreatmentDevice"));
            this.netFiller.SetEntityField(this.txtHasHCL, new CI.UIComponents.Filler.TextEntry("", "SFYHCLZZ"));
            this.txtHasHCL.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasHCL.Location = new System.Drawing.Point(64, 611);
            this.txtHasHCL.Name = "txtHasHCL";
            this.txtHasHCL.Size = new System.Drawing.Size(237, 31);
            this.txtHasHCL.TabIndex = 123;
            // 
            // txtDK
            // 
            this.txtDK.AlwaysShowDropDownStyle = true;
            this.txtDK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDK.BackColor = System.Drawing.Color.Transparent;
            this.txtDK.Caption = "是否电控: ";
            this.txtDK.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtDK.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtDK, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.netFiller.SetEntityField(this.txtDK, new CI.UIComponents.Filler.TextEntry("", "SFDK"));
            this.txtDK.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtDK.Location = new System.Drawing.Point(869, 216);
            this.txtDK.Name = "txtDK";
            this.txtDK.Size = new System.Drawing.Size(237, 31);
            this.txtDK.TabIndex = 124;
            // 
            // flatField20
            // 
            this.flatField20.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField20.BackColor = System.Drawing.Color.Transparent;
            this.flatField20.Caption = "气缸数:   ";
            this.flatField20.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField20.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField20, new CI.UIComponents.Filler.TextEntry("QGS", ""));
            this.vehicleFiller.SetEntityField(this.flatField20, new CI.UIComponents.Filler.TextEntry("NumOfCylinder", ""));
            this.netFiller.SetEntityField(this.flatField20, new CI.UIComponents.Filler.TextEntry("QGS", ""));
            this.flatField20.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField20.Location = new System.Drawing.Point(616, 214);
            this.flatField20.Name = "flatField20";
            this.flatField20.Size = new System.Drawing.Size(237, 31);
            this.flatField20.TabIndex = 125;
            // 
            // txtCloseStableSys
            // 
            this.txtCloseStableSys.AlwaysShowDropDownStyle = true;
            this.txtCloseStableSys.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCloseStableSys.BackColor = System.Drawing.Color.Transparent;
            this.txtCloseStableSys.Caption = "是否能关闭车身稳定系统:";
            this.txtCloseStableSys.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCloseStableSys.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtCloseStableSys, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtCloseStableSys, new CI.UIComponents.Filler.TextEntry("CloseStabilitySysTxt", "CloseStabilitySys"));
            this.netFiller.SetEntityField(this.txtCloseStableSys, new CI.UIComponents.Filler.TextEntry("", "SFNGBESP"));
            this.txtCloseStableSys.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCloseStableSys.Location = new System.Drawing.Point(340, 572);
            this.txtCloseStableSys.Name = "txtCloseStableSys";
            this.txtCloseStableSys.Size = new System.Drawing.Size(237, 31);
            this.txtCloseStableSys.TabIndex = 126;
            // 
            // txtVehicleStatus
            // 
            this.txtVehicleStatus.AlwaysShowDropDownStyle = true;
            this.txtVehicleStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtVehicleStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtVehicleStatus.Caption = "车辆状态: ";
            this.txtVehicleStatus.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtVehicleStatus.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtVehicleStatus, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtVehicleStatus, new CI.UIComponents.Filler.TextEntry("VehicleStatusTxt", "VehicleStatus"));
            this.netFiller.SetEntityField(this.txtVehicleStatus, new CI.UIComponents.Filler.TextEntry("", "JDCZTDM"));
            this.txtVehicleStatus.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtVehicleStatus.Location = new System.Drawing.Point(64, 537);
            this.txtVehicleStatus.Name = "txtVehicleStatus";
            this.txtVehicleStatus.Size = new System.Drawing.Size(237, 31);
            this.txtVehicleStatus.TabIndex = 127;
            // 
            // flatField23
            // 
            this.flatField23.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField23.BackColor = System.Drawing.Color.Transparent;
            this.flatField23.Caption = "车辆序号: ";
            this.flatField23.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField23.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField23, new CI.UIComponents.Filler.TextEntry("VehicleSerialNo", ""));
            this.netFiller.SetEntityField(this.flatField23, new CI.UIComponents.Filler.TextEntry("JDCXH", ""));
            this.flatField23.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField23.Location = new System.Drawing.Point(340, 537);
            this.flatField23.Name = "flatField23";
            this.flatField23.Size = new System.Drawing.Size(237, 31);
            this.flatField23.TabIndex = 128;
            // 
            // flatField24
            // 
            this.flatField24.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField24.BackColor = System.Drawing.Color.Transparent;
            this.flatField24.Caption = "轮胎气压: ";
            this.flatField24.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField24.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField24, new CI.UIComponents.Filler.TextEntry("LTQY", ""));
            this.vehicleFiller.SetEntityField(this.flatField24, new CI.UIComponents.Filler.TextEntry("TirePressure", ""));
            this.netFiller.SetEntityField(this.flatField24, new CI.UIComponents.Filler.TextEntry("QDLTQY", ""));
            this.flatField24.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField24.Location = new System.Drawing.Point(64, 354);
            this.flatField24.Name = "flatField24";
            this.flatField24.Size = new System.Drawing.Size(237, 31);
            this.flatField24.TabIndex = 129;
            // 
            // txtRYZF
            // 
            this.txtRYZF.AlwaysShowDropDownStyle = true;
            this.txtRYZF.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtRYZF.BackColor = System.Drawing.Color.Transparent;
            this.txtRYZF.Caption = "是否有燃油蒸发控制装置:";
            this.txtRYZF.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRYZF.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtRYZF, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtRYZF, new CI.UIComponents.Filler.TextEntry("EVAPControlTxt", "EVAPControl"));
            this.netFiller.SetEntityField(this.txtRYZF, new CI.UIComponents.Filler.TextEntry("", "SFYRYZFKZZZ"));
            this.txtRYZF.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtRYZF.Location = new System.Drawing.Point(869, 572);
            this.txtRYZF.Name = "txtRYZF";
            this.txtRYZF.Size = new System.Drawing.Size(237, 31);
            this.txtRYZF.TabIndex = 130;
            // 
            // txtHasCHZHQ
            // 
            this.txtHasCHZHQ.AlwaysShowDropDownStyle = true;
            this.txtHasCHZHQ.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHasCHZHQ.BackColor = System.Drawing.Color.Transparent;
            this.txtHasCHZHQ.Caption = "是否有催化转化器:";
            this.txtHasCHZHQ.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasCHZHQ.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtHasCHZHQ, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtHasCHZHQ, new CI.UIComponents.Filler.TextEntry("HasCatalyticConverterTxt", "HasCatalyticConverter"));
            this.netFiller.SetEntityField(this.txtHasCHZHQ, new CI.UIComponents.Filler.TextEntry("", "SFYCHZHQ"));
            this.txtHasCHZHQ.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtHasCHZHQ.Location = new System.Drawing.Point(616, 611);
            this.txtHasCHZHQ.Name = "txtHasCHZHQ";
            this.txtHasCHZHQ.Size = new System.Drawing.Size(237, 31);
            this.txtHasCHZHQ.TabIndex = 131;
            // 
            // flatField27
            // 
            this.flatField27.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField27.BackColor = System.Drawing.Color.Transparent;
            this.flatField27.Caption = "燃油规格: ";
            this.flatField27.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField27.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField27, new CI.UIComponents.Filler.TextEntry("RYBH", ""));
            this.vehicleFiller.SetEntityField(this.flatField27, new CI.UIComponents.Filler.TextEntry("FuelSpecification", ""));
            this.netFiller.SetEntityField(this.flatField27, new CI.UIComponents.Filler.TextEntry("RYGG", ""));
            this.flatField27.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField27.Location = new System.Drawing.Point(618, 354);
            this.flatField27.Name = "flatField27";
            this.flatField27.Size = new System.Drawing.Size(237, 31);
            this.flatField27.TabIndex = 132;
            // 
            // flatField28
            // 
            this.flatField28.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField28.BackColor = System.Drawing.Color.Transparent;
            this.flatField28.Caption = "所属辖区: ";
            this.flatField28.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField28.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField28, new CI.UIComponents.Filler.TextEntry("Jurisdiction", ""));
            this.netFiller.SetEntityField(this.flatField28, new CI.UIComponents.Filler.TextEntry("SSXQ", ""));
            this.flatField28.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField28.Location = new System.Drawing.Point(869, 537);
            this.flatField28.Name = "flatField28";
            this.flatField28.Size = new System.Drawing.Size(237, 31);
            this.flatField28.TabIndex = 133;
            // 
            // txtEnterTown
            // 
            this.txtEnterTown.AlwaysShowDropDownStyle = true;
            this.txtEnterTown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEnterTown.BackColor = System.Drawing.Color.Transparent;
            this.txtEnterTown.Caption = "是否进入城镇:";
            this.txtEnterTown.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtEnterTown.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtEnterTown, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtEnterTown, new CI.UIComponents.Filler.TextEntry("IsEntryTownTxt", "IsEntryTown"));
            this.netFiller.SetEntityField(this.txtEnterTown, new CI.UIComponents.Filler.TextEntry("", "SFJRCZ"));
            this.txtEnterTown.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtEnterTown.Location = new System.Drawing.Point(616, 574);
            this.txtEnterTown.Name = "txtEnterTown";
            this.txtEnterTown.Size = new System.Drawing.Size(237, 31);
            this.txtEnterTown.TabIndex = 136;
            // 
            // flatField32
            // 
            this.flatField32.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField32.BackColor = System.Drawing.Color.Transparent;
            this.flatField32.Caption = "发动机冲程数:";
            this.flatField32.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField32.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField32, new CI.UIComponents.Filler.TextEntry("FDJCC", ""));
            this.vehicleFiller.SetEntityField(this.flatField32, new CI.UIComponents.Filler.TextEntry("NumOfStroke", ""));
            this.netFiller.SetEntityField(this.flatField32, new CI.UIComponents.Filler.TextEntry("FDJCCS", ""));
            this.flatField32.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField32.Location = new System.Drawing.Point(869, 354);
            this.flatField32.Name = "flatField32";
            this.flatField32.Size = new System.Drawing.Size(237, 31);
            this.flatField32.TabIndex = 137;
            // 
            // flatField33
            // 
            this.flatField33.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField33.BackColor = System.Drawing.Color.Transparent;
            this.flatField33.Caption = "档位数:   ";
            this.flatField33.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField33.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField33, new CI.UIComponents.Filler.TextEntry("DWS", ""));
            this.vehicleFiller.SetEntityField(this.flatField33, new CI.UIComponents.Filler.TextEntry("NumOfGear", ""));
            this.netFiller.SetEntityField(this.flatField33, new CI.UIComponents.Filler.TextEntry("DWS", ""));
            this.flatField33.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField33.Location = new System.Drawing.Point(64, 389);
            this.flatField33.Name = "flatField33";
            this.flatField33.Size = new System.Drawing.Size(237, 31);
            this.flatField33.TabIndex = 138;
            // 
            // flatField34
            // 
            this.flatField34.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField34.BackColor = System.Drawing.Color.Transparent;
            this.flatField34.Caption = "电动机型号:";
            this.flatField34.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField34.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField34, new CI.UIComponents.Filler.TextEntry("DDJXH", ""));
            this.vehicleFiller.SetEntityField(this.flatField34, new CI.UIComponents.Filler.TextEntry("ElectricMotorsModel", ""));
            this.netFiller.SetEntityField(this.flatField34, new CI.UIComponents.Filler.TextEntry("DDJXH", ""));
            this.flatField34.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField34.Location = new System.Drawing.Point(340, 391);
            this.flatField34.Name = "flatField34";
            this.flatField34.Size = new System.Drawing.Size(237, 31);
            this.flatField34.TabIndex = 139;
            // 
            // flatField35
            // 
            this.flatField35.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField35.BackColor = System.Drawing.Color.Transparent;
            this.flatField35.Caption = "电池容量: ";
            this.flatField35.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField35.CaptionWidth = 0;
            this.loginFiller.SetEntityField(this.flatField35, new CI.UIComponents.Filler.TextEntry("DCRL", ""));
            this.vehicleFiller.SetEntityField(this.flatField35, new CI.UIComponents.Filler.TextEntry("BatteryCapacity", ""));
            this.netFiller.SetEntityField(this.flatField35, new CI.UIComponents.Filler.TextEntry("DCRL", ""));
            this.flatField35.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField35.Location = new System.Drawing.Point(64, 574);
            this.flatField35.Name = "flatField35";
            this.flatField35.Size = new System.Drawing.Size(237, 31);
            this.flatField35.TabIndex = 140;
            // 
            // flatField36
            // 
            this.flatField36.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField36.BackColor = System.Drawing.Color.Transparent;
            this.flatField36.Caption = "储能装置型号:";
            this.flatField36.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField36.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField36, new CI.UIComponents.Filler.TextEntry("StroageDeviceModel", ""));
            this.netFiller.SetEntityField(this.flatField36, new CI.UIComponents.Filler.TextEntry("CNZZXH", ""));
            this.flatField36.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField36.Location = new System.Drawing.Point(340, 500);
            this.flatField36.Name = "flatField36";
            this.flatField36.Size = new System.Drawing.Size(237, 31);
            this.flatField36.TabIndex = 141;
            // 
            // flatField37
            // 
            this.flatField37.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField37.BackColor = System.Drawing.Color.Transparent;
            this.flatField37.Caption = "后处理装置型号:";
            this.flatField37.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField37.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField37, new CI.UIComponents.Filler.TextEntry("TreatmentDeviceModel", ""));
            this.netFiller.SetEntityField(this.flatField37, new CI.UIComponents.Filler.TextEntry("HCLZZXH", ""));
            this.flatField37.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField37.Location = new System.Drawing.Point(340, 609);
            this.flatField37.Name = "flatField37";
            this.flatField37.Size = new System.Drawing.Size(237, 31);
            this.flatField37.TabIndex = 142;
            // 
            // txtCountry
            // 
            this.txtCountry.AlwaysShowDropDownStyle = true;
            this.txtCountry.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCountry.BackColor = System.Drawing.Color.Transparent;
            this.txtCountry.Caption = "国别:     ";
            this.txtCountry.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCountry.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtCountry, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtCountry, new CI.UIComponents.Filler.TextEntry("CountryTxt", "Country"));
            this.netFiller.SetEntityField(this.txtCountry, new CI.UIComponents.Filler.TextEntry("", "GBDM"));
            this.txtCountry.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtCountry.Location = new System.Drawing.Point(618, 537);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(237, 31);
            this.txtCountry.TabIndex = 136;
            // 
            // flatField38
            // 
            this.flatField38.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField38.BackColor = System.Drawing.Color.Transparent;
            this.flatField38.Caption = "底盘型号: ";
            this.flatField38.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField38.CaptionWidth = 0;
            this.vehicleFiller.SetEntityField(this.flatField38, new CI.UIComponents.Filler.TextEntry("ChassisModel", ""));
            this.netFiller.SetEntityField(this.flatField38, new CI.UIComponents.Filler.TextEntry("DPXH", ""));
            this.flatField38.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField38.Location = new System.Drawing.Point(340, 646);
            this.flatField38.Name = "flatField38";
            this.flatField38.Size = new System.Drawing.Size(237, 31);
            this.flatField38.TabIndex = 143;
            // 
            // txtSignType
            // 
            this.txtSignType.AlwaysShowDropDownStyle = true;
            this.txtSignType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSignType.BackColor = System.Drawing.Color.Transparent;
            this.txtSignType.Caption = "环保分类标志:";
            this.txtSignType.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSignType.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtSignType, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtSignType, new CI.UIComponents.Filler.TextEntry("ClassifyMarkTxt", "ClassifyMark"));
            this.netFiller.SetEntityField(this.txtSignType, new CI.UIComponents.Filler.TextEntry("", "HBFLBZDM"));
            this.txtSignType.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSignType.Location = new System.Drawing.Point(869, 463);
            this.txtSignType.Name = "txtSignType";
            this.txtSignType.ReadOnly = true;
            this.txtSignType.Size = new System.Drawing.Size(237, 31);
            this.txtSignType.TabIndex = 108;
            // 
            // txtEmissionStandard
            // 
            this.txtEmissionStandard.AlwaysShowDropDownStyle = true;
            this.txtEmissionStandard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmissionStandard.BackColor = System.Drawing.Color.Transparent;
            this.txtEmissionStandard.Caption = "排放标准: ";
            this.txtEmissionStandard.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtEmissionStandard.CaptionWidth = 0;
            this.selectorFiller.SetEntityField(this.txtEmissionStandard, new CI.UIComponents.Filler.TextEntry("Name", "Code"));
            this.vehicleFiller.SetEntityField(this.txtEmissionStandard, new CI.UIComponents.Filler.TextEntry("EmissionStandardTxt", "EmissionStandard"));
            this.netFiller.SetEntityField(this.txtEmissionStandard, new CI.UIComponents.Filler.TextEntry("", "GBDM"));
            this.txtEmissionStandard.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtEmissionStandard.Location = new System.Drawing.Point(618, 500);
            this.txtEmissionStandard.Name = "txtEmissionStandard";
            this.txtEmissionStandard.Size = new System.Drawing.Size(237, 31);
            this.txtEmissionStandard.TabIndex = 144;
            // 
            // flatField30
            // 
            this.flatField30.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField30.BackColor = System.Drawing.Color.Transparent;
            this.flatField30.Caption = "单车轴重: ";
            this.flatField30.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField30.CaptionWidth = 0;
            this.netFiller.SetEntityField(this.flatField30, new CI.UIComponents.Filler.TextEntry("DCZZ", ""));
            this.flatField30.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField30.Location = new System.Drawing.Point(64, 648);
            this.flatField30.Name = "flatField30";
            this.flatField30.Size = new System.Drawing.Size(237, 31);
            this.flatField30.TabIndex = 143;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = null;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(954, 52);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(74, 23);
            this.btnSend.TabIndex = 114;
            this.btnSend.Text = "发 送";
            this.btnSend.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtEmissionStandard);
            this.Controls.Add(this.flatField38);
            this.Controls.Add(this.flatField30);
            this.Controls.Add(this.flatField37);
            this.Controls.Add(this.flatField36);
            this.Controls.Add(this.flatField35);
            this.Controls.Add(this.flatField34);
            this.Controls.Add(this.flatField33);
            this.Controls.Add(this.flatField32);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtEnterTown);
            this.Controls.Add(this.flatField28);
            this.Controls.Add(this.flatField27);
            this.Controls.Add(this.txtHasCHZHQ);
            this.Controls.Add(this.txtRYZF);
            this.Controls.Add(this.flatField24);
            this.Controls.Add(this.flatField23);
            this.Controls.Add(this.txtVehicleStatus);
            this.Controls.Add(this.txtCloseStableSys);
            this.Controls.Add(this.flatField20);
            this.Controls.Add(this.txtDK);
            this.Controls.Add(this.txtHasHCL);
            this.Controls.Add(this.txtHasEgr);
            this.Controls.Add(this.flatField16);
            this.Controls.Add(this.flatField14);
            this.Controls.Add(this.flatField12);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.combQueryPlateType);
            this.Controls.Add(this.txtQueryPlateNo);
            this.Controls.Add(this.combQueryAera);
            this.Controls.Add(this.ami_Separator1);
            this.Controls.Add(this.txtHasObd);
            this.Controls.Add(this.txtSignType);
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
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(1127, 721);
            this.ResumeLayout(false);

        }

        #endregion

        private CI.Controls.FlatField flatField12;
        private EASkins.Ami_Button_2 btnClear;
        private EASkins.Emi_Button_2 btnSave;
        private EASkins.Emi_Button_2 btnSearch;
        private EASkins.Emi_ComboBox combQueryPlateType;
        private EASkins.Controls.MaterialSingleLineTextField txtQueryPlateNo;
        private EASkins.Emi_ComboBox combQueryAera;
        private EASkins.Ami_Separator ami_Separator1;
        private CI.Controls.FlatField txtHasObd;
        private CI.Controls.FlatField txtStandardType;
        private CI.Controls.FlatField txtHasDpf;
        private CI.Controls.FlatField flatField10;
        private CI.Controls.FlatField flatField2;
        private CI.Controls.FlatField flatField5;
        private CI.Controls.FlatField flatField11;
        private CI.Controls.FlatField flatField8;
        private CI.Controls.FlatField flatField6;
        private CI.Controls.FlatField flatField4;
        private CI.Controls.FlatField flatField1;
        private CI.Controls.FlatField txtZBZL;
        private CI.Controls.FlatField txtHasScr;
        private CI.Controls.FlatField flatField9;
        private CI.Controls.FlatField txtGYFS;
        private CI.Controls.FlatField flatField7;
        private CI.Controls.FlatField txtJylb;
        private CI.Controls.FlatField txtJQFS;
        private CI.Controls.FlatField txtBSQXS;
        private CI.Controls.FlatField flatField3;
        private CI.Controls.FlatField txtQDXS;
        private CI.Controls.FlatField txtCYS;
        private CI.Controls.FlatField txtRLLB;
        private CI.Controls.FlatField txtXH;
        private CI.Controls.FlatField txtLJXSLC;
        private CI.Controls.FlatField txtZZL;
        private CI.Controls.FlatField txtSYXZ;
        private CI.Controls.FlatField txtPP;
        private CI.Controls.FlatField txtCCRQ;
        private CI.Controls.FlatField txtVIN;
        private CI.Controls.FlatField txtCLZL;
        private CI.Controls.FlatField txtCCDJRQ;
        private CI.Controls.FlatField txtHPYS;
        private CI.Controls.FlatField txtHPZL;
        private CI.Controls.FlatField txtHPHM;
        private CI.Controls.FlatField flatField14;
        private CI.Controls.FlatField flatField16;
        private CI.Controls.FlatField txtHasEgr;
        private CI.Controls.FlatField txtHasHCL;
        private CI.Controls.FlatField txtDK;
        private CI.Controls.FlatField flatField20;
        private CI.Controls.FlatField txtCloseStableSys;
        private CI.Controls.FlatField txtVehicleStatus;
        private CI.Controls.FlatField flatField23;
        private CI.Controls.FlatField flatField24;
        private CI.Controls.FlatField txtRYZF;
        private CI.Controls.FlatField txtHasCHZHQ;
        private CI.Controls.FlatField flatField27;
        private CI.Controls.FlatField flatField28;
        private CI.Controls.FlatField txtEnterTown;
        private CI.Controls.FlatField flatField32;
        private CI.Controls.FlatField flatField33;
        private CI.Controls.FlatField flatField34;
        private CI.Controls.FlatField flatField35;
        private CI.Controls.FlatField flatField36;
        private CI.Controls.FlatField flatField37;
        private CI.UIComponents.Filler.EntityFiller vehicleFiller;
        private CI.UIComponents.Filler.EntityFiller loginFiller;
        private CI.UIComponents.Filler.EntityFiller netFiller;
        private CI.Controls.FlatField txtCountry;
        private CI.Controls.FlatField flatField30;
        private CI.Controls.FlatField flatField38;
        private CI.Controls.FlatField txtSignType;
        private CI.UIComponents.Filler.EntityFiller selectorFiller;
        private CI.Controls.FlatField txtEmissionStandard;
        private EASkins.Emi_Button_2 btnSend;
        private CI.UIComponents.Validate.Validator validator1;
    }
}
