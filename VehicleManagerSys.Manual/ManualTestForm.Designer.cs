namespace VehicleManagerSys.Manual
{
    partial class ManualTestForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ucRadioButton2 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton1 = new HZH_Controls.Controls.UCRadioButton();
            this.btnStart = new EASkins.Ami_Button_1();
            this.btnEnd = new EASkins.Ami_Button_1();
            this.ami_HeaderLabel1 = new EASkins.Ami_HeaderLabel();
            this.labNetNo = new EASkins.Ami_Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucRadioButton3 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton4 = new HZH_Controls.Controls.UCRadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ucRadioButton5 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton6 = new HZH_Controls.Controls.UCRadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ucRadioButton7 = new HZH_Controls.Controls.UCRadioButton();
            this.ucRadioButton8 = new HZH_Controls.Controls.UCRadioButton();
            this.combUsers = new HZH_Controls.Controls.UCCombox();
            this.ami_HeaderLabel3 = new EASkins.Ami_HeaderLabel();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ucRadioButton2);
            this.groupBox3.Controls.Add(this.ucRadioButton1);
            this.groupBox3.Location = new System.Drawing.Point(30, 262);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 70);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "转向系";
            // 
            // ucRadioButton2
            // 
            this.ucRadioButton2.Checked = false;
            this.ucRadioButton2.GroupName = null;
            this.ucRadioButton2.Location = new System.Drawing.Point(121, 20);
            this.ucRadioButton2.Name = "ucRadioButton2";
            this.ucRadioButton2.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton2.TabIndex = 0;
            this.ucRadioButton2.TextValue = "不合格";
            // 
            // ucRadioButton1
            // 
            this.ucRadioButton1.Checked = true;
            this.ucRadioButton1.GroupName = null;
            this.ucRadioButton1.Location = new System.Drawing.Point(17, 20);
            this.ucRadioButton1.Name = "ucRadioButton1";
            this.ucRadioButton1.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton1.TabIndex = 0;
            this.ucRadioButton1.TextValue = "合格";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStart.Image = null;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(63, 211);
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
            this.btnEnd.Location = new System.Drawing.Point(335, 211);
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
            this.ami_HeaderLabel1.Location = new System.Drawing.Point(26, 104);
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
            this.labNetNo.Location = new System.Drawing.Point(139, 104);
            this.labNetNo.Name = "labNetNo";
            this.labNetNo.Size = new System.Drawing.Size(185, 20);
            this.labNetNo.TabIndex = 12;
            this.labNetNo.Text = "0000000000000000000000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ucRadioButton3);
            this.groupBox1.Controls.Add(this.ucRadioButton4);
            this.groupBox1.Location = new System.Drawing.Point(285, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "传动系";
            // 
            // ucRadioButton3
            // 
            this.ucRadioButton3.Checked = false;
            this.ucRadioButton3.GroupName = null;
            this.ucRadioButton3.Location = new System.Drawing.Point(121, 20);
            this.ucRadioButton3.Name = "ucRadioButton3";
            this.ucRadioButton3.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton3.TabIndex = 0;
            this.ucRadioButton3.TextValue = "不合格";
            // 
            // ucRadioButton4
            // 
            this.ucRadioButton4.Checked = true;
            this.ucRadioButton4.GroupName = null;
            this.ucRadioButton4.Location = new System.Drawing.Point(17, 20);
            this.ucRadioButton4.Name = "ucRadioButton4";
            this.ucRadioButton4.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton4.TabIndex = 0;
            this.ucRadioButton4.TextValue = "合格";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ucRadioButton5);
            this.groupBox2.Controls.Add(this.ucRadioButton6);
            this.groupBox2.Location = new System.Drawing.Point(30, 345);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 70);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "单选/复选";
            // 
            // ucRadioButton5
            // 
            this.ucRadioButton5.Checked = false;
            this.ucRadioButton5.GroupName = null;
            this.ucRadioButton5.Location = new System.Drawing.Point(121, 20);
            this.ucRadioButton5.Name = "ucRadioButton5";
            this.ucRadioButton5.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton5.TabIndex = 0;
            this.ucRadioButton5.TextValue = "不合格";
            // 
            // ucRadioButton6
            // 
            this.ucRadioButton6.Checked = true;
            this.ucRadioButton6.GroupName = null;
            this.ucRadioButton6.Location = new System.Drawing.Point(17, 20);
            this.ucRadioButton6.Name = "ucRadioButton6";
            this.ucRadioButton6.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton6.TabIndex = 0;
            this.ucRadioButton6.TextValue = "合格";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ucRadioButton7);
            this.groupBox4.Controls.Add(this.ucRadioButton8);
            this.groupBox4.Location = new System.Drawing.Point(285, 345);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(217, 70);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "单选/复选";
            // 
            // ucRadioButton7
            // 
            this.ucRadioButton7.Checked = false;
            this.ucRadioButton7.GroupName = null;
            this.ucRadioButton7.Location = new System.Drawing.Point(121, 20);
            this.ucRadioButton7.Name = "ucRadioButton7";
            this.ucRadioButton7.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton7.TabIndex = 0;
            this.ucRadioButton7.TextValue = "不合格";
            // 
            // ucRadioButton8
            // 
            this.ucRadioButton8.Checked = true;
            this.ucRadioButton8.GroupName = null;
            this.ucRadioButton8.Location = new System.Drawing.Point(17, 20);
            this.ucRadioButton8.Name = "ucRadioButton8";
            this.ucRadioButton8.Size = new System.Drawing.Size(89, 30);
            this.ucRadioButton8.TabIndex = 0;
            this.ucRadioButton8.TextValue = "合格";
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
            this.combUsers.Location = new System.Drawing.Point(143, 158);
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
            this.ami_HeaderLabel3.Location = new System.Drawing.Point(60, 161);
            this.ami_HeaderLabel3.Name = "ami_HeaderLabel3";
            this.ami_HeaderLabel3.Size = new System.Drawing.Size(77, 20);
            this.ami_HeaderLabel3.TabIndex = 11;
            this.ami_HeaderLabel3.Text = "检验人：";
            this.ami_HeaderLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManualTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 443);
            this.Controls.Add(this.combUsers);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labNetNo);
            this.Controls.Add(this.ami_HeaderLabel3);
            this.Controls.Add(this.ami_HeaderLabel1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.IsShowCloseBtn = true;
            this.IsShowMaskDialog = false;
            this.Name = "ManualTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManualTestForm";
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.btnStart, 0);
            this.Controls.SetChildIndex(this.btnEnd, 0);
            this.Controls.SetChildIndex(this.ami_HeaderLabel1, 0);
            this.Controls.SetChildIndex(this.ami_HeaderLabel3, 0);
            this.Controls.SetChildIndex(this.labNetNo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.Controls.SetChildIndex(this.combUsers, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton2;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton1;
        private EASkins.Ami_Button_1 btnStart;
        private EASkins.Ami_Button_1 btnEnd;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel1;
        private EASkins.Ami_Label labNetNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton3;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton5;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton6;
        private System.Windows.Forms.GroupBox groupBox4;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton7;
        private HZH_Controls.Controls.UCRadioButton ucRadioButton8;
        private HZH_Controls.Controls.UCCombox combUsers;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel3;
    }
}