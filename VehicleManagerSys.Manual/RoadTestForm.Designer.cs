namespace VehicleManagerSys.Manual
{
    partial class RoadTestForm
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
            this.btnStart = new EASkins.Ami_Button_1();
            this.btnEnd = new EASkins.Ami_Button_1();
            this.ami_HeaderLabel1 = new EASkins.Ami_HeaderLabel();
            this.labNetNo = new EASkins.Ami_Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ucRadioButton7 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton8 = new HZH_Controls.Controls.UCRadioButton();
            this.combUsers = new HZH_Controls.Controls.UCCombox();
            this.ami_HeaderLabel3 = new EASkins.Ami_HeaderLabel();
            this.vehicleFiller = new CI.UIComponents.Filler.EntityFiller();
            this.netFiller = new CI.UIComponents.Filler.EntityFiller();
            this.loginFiller = new CI.UIComponents.Filler.EntityFiller();
            this.validator1 = new CI.UIComponents.Validate.Validator();
            this.txtSpeed = new CI.Controls.FlatField();
            this.ucRadioButton1 = new HZH_Controls.Controls.UCRadioButton();
            this.txt = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.flatField4 = new CI.Controls.FlatField();
            this.flatField5 = new CI.Controls.FlatField();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucRadioButton3 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton4 = new HZH_Controls.Controls.UCRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStartPark = new EASkins.Ami_Button_1();
            this.btnEndPark = new EASkins.Ami_Button_1();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ucRadioButton5 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton6 = new HZH_Controls.Controls.UCRadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ucRadioButton2 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton9 = new HZH_Controls.Controls.UCRadioButton();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStart.Image = null;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(198, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 30);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "开    始";
            this.btnStart.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEnd.Image = null;
            this.btnEnd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnd.Location = new System.Drawing.Point(398, 22);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(143, 30);
            this.btnEnd.TabIndex = 10;
            this.btnEnd.Text = "结     束";
            this.btnEnd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // ami_HeaderLabel1
            // 
            this.ami_HeaderLabel1.AutoSize = true;
            this.ami_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ami_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel1.Location = new System.Drawing.Point(117, 90);
            this.ami_HeaderLabel1.Name = "ami_HeaderLabel1";
            this.ami_HeaderLabel1.Size = new System.Drawing.Size(111, 20);
            this.ami_HeaderLabel1.TabIndex = 11;
            this.ami_HeaderLabel1.Text = "联网流水号：";
            // 
            // labNetNo
            // 
            this.labNetNo.AutoSize = true;
            this.labNetNo.BackColor = System.Drawing.Color.Transparent;
            this.labNetNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labNetNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labNetNo.Location = new System.Drawing.Point(230, 90);
            this.labNetNo.Name = "labNetNo";
            this.labNetNo.Size = new System.Drawing.Size(185, 20);
            this.labNetNo.TabIndex = 12;
            this.labNetNo.Text = "0000000000000000000000";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ucRadioButton1);
            this.groupBox4.Controls.Add(this.ucRadioButton7);
            this.groupBox4.Controls.Add(this.ucRadioButton8);
            this.groupBox4.Location = new System.Drawing.Point(6, 169);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(345, 70);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "路试制动跑偏情况";
            // 
            // ucRadioButton7
            // 
            this.ucRadioButton7.Checked = false;
            this.ucRadioButton7.GroupName = null;
            this.ucRadioButton7.Location = new System.Drawing.Point(121, 20);
            this.ucRadioButton7.Name = "ucRadioButton7";
            this.ucRadioButton7.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton7.TabIndex = 0;
            this.ucRadioButton7.TextValue = "左跑偏";
            // 
            // ucRadioButton8
            // 
            this.ucRadioButton8.Checked = true;
            this.ucRadioButton8.GroupName = null;
            this.ucRadioButton8.Location = new System.Drawing.Point(17, 20);
            this.ucRadioButton8.Name = "ucRadioButton8";
            this.ucRadioButton8.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton8.TabIndex = 0;
            this.ucRadioButton8.TextValue = "为跑偏";
            // 
            // combUsers
            // 
            this.combUsers.BackColor = System.Drawing.Color.Transparent;
            this.combUsers.BackColorExt = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.combUsers.BoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combUsers.ConerRadius = 5;
            this.combUsers.DropPanelHeight = -1;
            this.combUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.combUsers.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.combUsers.IsRadius = false;
            this.combUsers.IsShowRect = true;
            this.combUsers.ItemWidth = 70;
            this.combUsers.Location = new System.Drawing.Point(569, 81);
            this.combUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combUsers.Name = "combUsers";
            this.combUsers.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.combUsers.RectWidth = 1;
            this.combUsers.SelectedIndex = -1;
            this.combUsers.SelectedValue = "";
            this.combUsers.Size = new System.Drawing.Size(173, 32);
            this.combUsers.Source = null;
            this.combUsers.TabIndex = 16;
            this.combUsers.TextValue = null;
            this.combUsers.TriangleColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            // 
            // ami_HeaderLabel3
            // 
            this.ami_HeaderLabel3.AutoSize = true;
            this.ami_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ami_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel3.Location = new System.Drawing.Point(473, 90);
            this.ami_HeaderLabel3.Name = "ami_HeaderLabel3";
            this.ami_HeaderLabel3.Size = new System.Drawing.Size(77, 20);
            this.ami_HeaderLabel3.TabIndex = 11;
            this.ami_HeaderLabel3.Text = "检验人：";
            this.ami_HeaderLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSpeed.BackColor = System.Drawing.Color.Transparent;
            this.txtSpeed.Caption = "路试制动初速度(km/h):";
            this.txtSpeed.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSpeed.CaptionWidth = 0;
            this.txtSpeed.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txtSpeed.Location = new System.Drawing.Point(16, 58);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(345, 31);
            this.txtSpeed.TabIndex = 21;
            // 
            // ucRadioButton1
            // 
            this.ucRadioButton1.Checked = false;
            this.ucRadioButton1.GroupName = null;
            this.ucRadioButton1.Location = new System.Drawing.Point(229, 20);
            this.ucRadioButton1.Name = "ucRadioButton1";
            this.ucRadioButton1.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton1.TabIndex = 0;
            this.ucRadioButton1.TextValue = "右跑偏";
            // 
            // txt
            // 
            this.txt.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt.BackColor = System.Drawing.Color.Transparent;
            this.txt.Caption = "路试制动距离(m):";
            this.txt.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.txt.CaptionWidth = 0;
            this.txt.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt.Location = new System.Drawing.Point(408, 58);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(345, 31);
            this.txt.TabIndex = 21;
            // 
            // flatField3
            // 
            this.flatField3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "MFDD数据(m/s²):";
            this.flatField3.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.CaptionWidth = 0;
            this.flatField3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.Location = new System.Drawing.Point(408, 95);
            this.flatField3.Name = "flatField3";
            this.flatField3.Size = new System.Drawing.Size(345, 31);
            this.flatField3.TabIndex = 21;
            // 
            // flatField4
            // 
            this.flatField4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "路试制动试车道宽(m):";
            this.flatField4.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.CaptionWidth = 0;
            this.flatField4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.Location = new System.Drawing.Point(16, 132);
            this.flatField4.Name = "flatField4";
            this.flatField4.Size = new System.Drawing.Size(345, 31);
            this.flatField4.TabIndex = 21;
            // 
            // flatField5
            // 
            this.flatField5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField5.BackColor = System.Drawing.Color.Transparent;
            this.flatField5.Caption = "路试制动协调时间(s):";
            this.flatField5.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField5.CaptionWidth = 0;
            this.flatField5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField5.Location = new System.Drawing.Point(16, 95);
            this.flatField5.Name = "flatField5";
            this.flatField5.Size = new System.Drawing.Size(345, 31);
            this.flatField5.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucRadioButton3);
            this.groupBox1.Controls.Add(this.ucRadioButton4);
            this.groupBox1.Location = new System.Drawing.Point(398, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 70);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "路试制动判定";
            // 
            // ucRadioButton3
            // 
            this.ucRadioButton3.Checked = false;
            this.ucRadioButton3.GroupName = null;
            this.ucRadioButton3.Location = new System.Drawing.Point(192, 22);
            this.ucRadioButton3.Name = "ucRadioButton3";
            this.ucRadioButton3.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton3.TabIndex = 0;
            this.ucRadioButton3.TextValue = "不合格";
            // 
            // ucRadioButton4
            // 
            this.ucRadioButton4.Checked = true;
            this.ucRadioButton4.GroupName = null;
            this.ucRadioButton4.Location = new System.Drawing.Point(75, 22);
            this.ucRadioButton4.Name = "ucRadioButton4";
            this.ucRadioButton4.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton4.TabIndex = 0;
            this.ucRadioButton4.TextValue = "合格";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.btnEnd);
            this.groupBox2.Controls.Add(this.txtSpeed);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txt);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.flatField3);
            this.groupBox2.Controls.Add(this.flatField4);
            this.groupBox2.Controls.Add(this.flatField5);
            this.groupBox2.Location = new System.Drawing.Point(44, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 257);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "路试行车制动";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.btnEndPark);
            this.groupBox3.Controls.Add(this.btnStartPark);
            this.groupBox3.Location = new System.Drawing.Point(44, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 171);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "路试坡道驻车";
            // 
            // btnStartPark
            // 
            this.btnStartPark.BackColor = System.Drawing.Color.Transparent;
            this.btnStartPark.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStartPark.Image = null;
            this.btnStartPark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartPark.Location = new System.Drawing.Point(190, 36);
            this.btnStartPark.Name = "btnStartPark";
            this.btnStartPark.Size = new System.Drawing.Size(143, 30);
            this.btnStartPark.TabIndex = 11;
            this.btnStartPark.Text = "开    始";
            this.btnStartPark.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnStartPark.Click += new System.EventHandler(this.btnStartPark_Click);
            // 
            // btnEndPark
            // 
            this.btnEndPark.BackColor = System.Drawing.Color.Transparent;
            this.btnEndPark.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnEndPark.Image = null;
            this.btnEndPark.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndPark.Location = new System.Drawing.Point(398, 36);
            this.btnEndPark.Name = "btnEndPark";
            this.btnEndPark.Size = new System.Drawing.Size(143, 30);
            this.btnEndPark.TabIndex = 12;
            this.btnEndPark.Text = "结     束";
            this.btnEndPark.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnEndPark.Click += new System.EventHandler(this.btnEndPark_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ucRadioButton5);
            this.groupBox5.Controls.Add(this.ucRadioButton6);
            this.groupBox5.Location = new System.Drawing.Point(6, 83);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(345, 70);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "路试驻车坡道";
            // 
            // ucRadioButton5
            // 
            this.ucRadioButton5.Checked = false;
            this.ucRadioButton5.GroupName = null;
            this.ucRadioButton5.Location = new System.Drawing.Point(184, 22);
            this.ucRadioButton5.Name = "ucRadioButton5";
            this.ucRadioButton5.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton5.TabIndex = 0;
            this.ucRadioButton5.TextValue = "15%";
            // 
            // ucRadioButton6
            // 
            this.ucRadioButton6.Checked = true;
            this.ucRadioButton6.GroupName = null;
            this.ucRadioButton6.Location = new System.Drawing.Point(50, 22);
            this.ucRadioButton6.Name = "ucRadioButton6";
            this.ucRadioButton6.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton6.TabIndex = 0;
            this.ucRadioButton6.TextValue = "20%";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ucRadioButton2);
            this.groupBox6.Controls.Add(this.ucRadioButton9);
            this.groupBox6.Location = new System.Drawing.Point(398, 83);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(345, 70);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "不少于2min坡道驻车情况";
            // 
            // ucRadioButton2
            // 
            this.ucRadioButton2.Checked = false;
            this.ucRadioButton2.GroupName = null;
            this.ucRadioButton2.Location = new System.Drawing.Point(192, 22);
            this.ucRadioButton2.Name = "ucRadioButton2";
            this.ucRadioButton2.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton2.TabIndex = 0;
            this.ucRadioButton2.TextValue = "溜坡";
            // 
            // ucRadioButton9
            // 
            this.ucRadioButton9.Checked = true;
            this.ucRadioButton9.GroupName = null;
            this.ucRadioButton9.Location = new System.Drawing.Point(75, 22);
            this.ucRadioButton9.Name = "ucRadioButton9";
            this.ucRadioButton9.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton9.TabIndex = 0;
            this.ucRadioButton9.TextValue = "不溜坡";
            // 
            // RoadTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 602);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.combUsers);
            this.Controls.Add(this.labNetNo);
            this.Controls.Add(this.ami_HeaderLabel3);
            this.Controls.Add(this.ami_HeaderLabel1);
            this.IsShowCloseBtn = true;
            this.IsShowMaskDialog = false;
            this.Name = "RoadTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManualTestForm";
            this.Controls.SetChildIndex(this.ami_HeaderLabel1, 0);
            this.Controls.SetChildIndex(this.ami_HeaderLabel3, 0);
            this.Controls.SetChildIndex(this.labNetNo, 0);
            this.Controls.SetChildIndex(this.combUsers, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EASkins.Ami_Button_1 btnStart;
        private EASkins.Ami_Button_1 btnEnd;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel1;
        private EASkins.Ami_Label labNetNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton7;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton8;
        private HZH_Controls.Controls.UCCombox combUsers;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel3;
        private CI.UIComponents.Filler.EntityFiller vehicleFiller;
        private CI.UIComponents.Filler.EntityFiller netFiller;
        private CI.UIComponents.Filler.EntityFiller loginFiller;
        private CI.UIComponents.Validate.Validator validator1;
        private CI.Controls.FlatField txtSpeed;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton1;
        private CI.Controls.FlatField txt;
        private CI.Controls.FlatField flatField3;
        private CI.Controls.FlatField flatField4;
        private CI.Controls.FlatField flatField5;
        private System.Windows.Forms.GroupBox groupBox1;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton3;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private EASkins.Ami_Button_1 btnEndPark;
        private EASkins.Ami_Button_1 btnStartPark;
        private System.Windows.Forms.GroupBox groupBox5;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton5;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton6;
        private System.Windows.Forms.GroupBox groupBox6;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton2;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton9;
    }
}