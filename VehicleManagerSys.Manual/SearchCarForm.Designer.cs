namespace VehicleManagerSys.Manual
{
    partial class SearchCarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchCarForm));
            this.combQueryAera = new EASkins.Ami_ComboBox();
            this.txtQueryVIN = new EASkins.Controls.MaterialSingleLineTextField();
            this.ami_HeaderLabel2 = new EASkins.Ami_HeaderLabel();
            this.combQueryPlateType = new EASkins.Emi_ComboBox();
            this.txtQueryPlateNo = new EASkins.Controls.MaterialSingleLineTextField();
            this.btnRefresh = new EASkins.Ami_Button_2();
            this.ami_HeaderLabel1 = new EASkins.Ami_HeaderLabel();
            this.labLwlsh = new EASkins.Ami_LinkLabel();
            this.labTips = new EASkins.Controls.MaterialLabel();
            this.btnStart = new EASkins.Emi_Button_1();
            this.btnRoadTest = new EASkins.Emi_Button_1();
            this.SuspendLayout();
            // 
            // combQueryAera
            // 
            this.combQueryAera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combQueryAera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combQueryAera.DropDownHeight = 200;
            this.combQueryAera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combQueryAera.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combQueryAera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combQueryAera.FormattingEnabled = true;
            this.combQueryAera.HoverSelectionColor = System.Drawing.Color.Empty;
            this.combQueryAera.IntegralHeight = false;
            this.combQueryAera.ItemHeight = 25;
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
            "鲁"});
            this.combQueryAera.Location = new System.Drawing.Point(52, 91);
            this.combQueryAera.Name = "combQueryAera";
            this.combQueryAera.Size = new System.Drawing.Size(68, 31);
            this.combQueryAera.StartIndex = 0;
            this.combQueryAera.TabIndex = 0;
            // 
            // txtQueryVIN
            // 
            this.txtQueryVIN.Depth = 0;
            this.txtQueryVIN.Hint = "VIN";
            this.txtQueryVIN.Location = new System.Drawing.Point(142, 136);
            this.txtQueryVIN.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueryVIN.MaxLength = 32767;
            this.txtQueryVIN.MouseState = EASkins.MouseState.HOVER;
            this.txtQueryVIN.Name = "txtQueryVIN";
            this.txtQueryVIN.PasswordChar = '\0';
            this.txtQueryVIN.SelectedText = "";
            this.txtQueryVIN.SelectionLength = 0;
            this.txtQueryVIN.SelectionStart = 0;
            this.txtQueryVIN.Size = new System.Drawing.Size(198, 23);
            this.txtQueryVIN.TabIndex = 24;
            this.txtQueryVIN.TabStop = false;
            this.txtQueryVIN.UseSystemPasswordChar = false;
            // 
            // ami_HeaderLabel2
            // 
            this.ami_HeaderLabel2.AutoSize = true;
            this.ami_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel2.Font = new System.Drawing.Font("宋体", 9F);
            this.ami_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel2.Location = new System.Drawing.Point(383, 98);
            this.ami_HeaderLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ami_HeaderLabel2.Name = "ami_HeaderLabel2";
            this.ami_HeaderLabel2.Size = new System.Drawing.Size(65, 12);
            this.ami_HeaderLabel2.TabIndex = 23;
            this.ami_HeaderLabel2.Text = "号牌种类：";
            // 
            // combQueryPlateType
            // 
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
            this.combQueryPlateType.Location = new System.Drawing.Point(452, 91);
            this.combQueryPlateType.Margin = new System.Windows.Forms.Padding(2);
            this.combQueryPlateType.MaxDropDownItems = 10;
            this.combQueryPlateType.Name = "combQueryPlateType";
            this.combQueryPlateType.Size = new System.Drawing.Size(129, 26);
            this.combQueryPlateType.StartIndex = 0;
            this.combQueryPlateType.TabIndex = 22;
            // 
            // txtQueryPlateNo
            // 
            this.txtQueryPlateNo.Depth = 0;
            this.txtQueryPlateNo.Hint = "号牌号码";
            this.txtQueryPlateNo.Location = new System.Drawing.Point(142, 94);
            this.txtQueryPlateNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtQueryPlateNo.MaxLength = 32767;
            this.txtQueryPlateNo.MouseState = EASkins.MouseState.HOVER;
            this.txtQueryPlateNo.Name = "txtQueryPlateNo";
            this.txtQueryPlateNo.PasswordChar = '\0';
            this.txtQueryPlateNo.SelectedText = "";
            this.txtQueryPlateNo.SelectionLength = 0;
            this.txtQueryPlateNo.SelectionStart = 0;
            this.txtQueryPlateNo.Size = new System.Drawing.Size(198, 23);
            this.txtQueryPlateNo.TabIndex = 21;
            this.txtQueryPlateNo.TabStop = false;
            this.txtQueryPlateNo.UseSystemPasswordChar = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Image = null;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(495, 129);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 30);
            this.btnRefresh.TabIndex = 25;
            this.btnRefresh.Text = "查 询";
            this.btnRefresh.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ami_HeaderLabel1
            // 
            this.ami_HeaderLabel1.AutoSize = true;
            this.ami_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ami_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel1.Location = new System.Drawing.Point(58, 267);
            this.ami_HeaderLabel1.Name = "ami_HeaderLabel1";
            this.ami_HeaderLabel1.Size = new System.Drawing.Size(98, 20);
            this.ami_HeaderLabel1.TabIndex = 26;
            this.ami_HeaderLabel1.Text = "联网流水号:";
            // 
            // labLwlsh
            // 
            this.labLwlsh.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.labLwlsh.AutoSize = true;
            this.labLwlsh.BackColor = System.Drawing.Color.Transparent;
            this.labLwlsh.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labLwlsh.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.labLwlsh.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.labLwlsh.Location = new System.Drawing.Point(175, 267);
            this.labLwlsh.Name = "labLwlsh";
            this.labLwlsh.Size = new System.Drawing.Size(153, 20);
            this.labLwlsh.TabIndex = 27;
            this.labLwlsh.TabStop = true;
            this.labLwlsh.Text = "000000000000000000";
            this.labLwlsh.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            // 
            // labTips
            // 
            this.labTips.AutoSize = true;
            this.labTips.Depth = 0;
            this.labTips.Font = new System.Drawing.Font("Roboto", 11F);
            this.labTips.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labTips.Location = new System.Drawing.Point(67, 197);
            this.labTips.MouseState = EASkins.MouseState.HOVER;
            this.labTips.Name = "labTips";
            this.labTips.Size = new System.Drawing.Size(89, 19);
            this.labTips.TabIndex = 28;
            this.labTips.Text = "查询成功！";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStart.Image = null;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(52, 336);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(166, 40);
            this.btnStart.TabIndex = 29;
            this.btnStart.Text = "动态底盘";
            this.btnStart.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRoadTest
            // 
            this.btnRoadTest.BackColor = System.Drawing.Color.Transparent;
            this.btnRoadTest.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRoadTest.Image = null;
            this.btnRoadTest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoadTest.Location = new System.Drawing.Point(385, 336);
            this.btnRoadTest.Name = "btnRoadTest";
            this.btnRoadTest.Size = new System.Drawing.Size(166, 40);
            this.btnRoadTest.TabIndex = 29;
            this.btnRoadTest.Text = "路试";
            this.btnRoadTest.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRoadTest.Click += new System.EventHandler(this.btnRoadTest_Click);
            // 
            // SearchCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 443);
            this.Controls.Add(this.btnRoadTest);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labTips);
            this.Controls.Add(this.labLwlsh);
            this.Controls.Add(this.ami_HeaderLabel1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtQueryVIN);
            this.Controls.Add(this.ami_HeaderLabel2);
            this.Controls.Add(this.combQueryPlateType);
            this.Controls.Add(this.txtQueryPlateNo);
            this.Controls.Add(this.combQueryAera);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchCarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "车辆查询";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EASkins.Ami_ComboBox combQueryAera;
        private EASkins.Controls.MaterialSingleLineTextField txtQueryVIN;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel2;
        private EASkins.Emi_ComboBox combQueryPlateType;
        private EASkins.Controls.MaterialSingleLineTextField txtQueryPlateNo;
        private EASkins.Ami_Button_2 btnRefresh;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel1;
        private EASkins.Ami_LinkLabel labLwlsh;
        private EASkins.Controls.MaterialLabel labTips;
        private EASkins.Emi_Button_1 btnStart;
        private EASkins.Emi_Button_1 btnRoadTest;
    }
}