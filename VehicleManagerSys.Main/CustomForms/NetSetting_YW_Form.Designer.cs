namespace VehicleManagerSys.Main.CustomForms
{
    partial class NetSetting_YW_Form
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
            this.flatField2 = new CI.Controls.FlatField();
            this.flatField1 = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.settingFiller = new CI.UIComponents.Filler.EntityFiller();
            this.btnSave = new EASkins.Ami_Button_2();
            this.flatField4 = new CI.Controls.FlatField();
            this.SuspendLayout();
            // 
            // flatField2
            // 
            this.flatField2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField2.BackColor = System.Drawing.Color.Transparent;
            this.flatField2.Caption = "检测站编号:";
            this.flatField2.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField2.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField2, new CI.UIComponents.Filler.TextEntry("StationNo", ""));
            this.flatField2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField2.Location = new System.Drawing.Point(211, 99);
            this.flatField2.Name = "flatField2";
            this.flatField2.Size = new System.Drawing.Size(382, 31);
            this.flatField2.TabIndex = 9;
            // 
            // flatField1
            // 
            this.flatField1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "接口序列号:";
            this.flatField1.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField1.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("SerialNumber", ""));
            this.flatField1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField1.Location = new System.Drawing.Point(211, 148);
            this.flatField1.Name = "flatField1";
            this.flatField1.Size = new System.Drawing.Size(382, 31);
            this.flatField1.TabIndex = 10;
            // 
            // flatField3
            // 
            this.flatField3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "Url:      ";
            this.flatField3.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("Url", ""));
            this.flatField3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField3.Location = new System.Drawing.Point(211, 195);
            this.flatField3.Name = "flatField3";
            this.flatField3.Size = new System.Drawing.Size(382, 31);
            this.flatField3.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.Image = null;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(496, 317);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "保 存";
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flatField4
            // 
            this.flatField4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "线号:     ";
            this.flatField4.CaptionFont = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField4, new CI.UIComponents.Filler.TextEntry("LineNo", ""));
            this.flatField4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.flatField4.Location = new System.Drawing.Point(211, 247);
            this.flatField4.Name = "flatField4";
            this.flatField4.Size = new System.Drawing.Size(382, 31);
            this.flatField4.TabIndex = 11;
            // 
            // NetSetting_YW_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanMove = false;
            this.ClientSize = new System.Drawing.Size(784, 495);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.flatField4);
            this.Controls.Add(this.flatField3);
            this.Controls.Add(this.flatField1);
            this.Controls.Add(this.flatField2);
            this.Name = "NetSetting_YW_Form";
            this.Text = "DbSettingForm";
            this.Title = "环保联网配置(云网)";
            this.Load += new System.EventHandler(this.DbSettingForm_Load);
            this.Controls.SetChildIndex(this.flatField2, 0);
            this.Controls.SetChildIndex(this.flatField1, 0);
            this.Controls.SetChildIndex(this.flatField3, 0);
            this.Controls.SetChildIndex(this.flatField4, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private CI.Controls.FlatField flatField2;
        private CI.Controls.FlatField flatField1;
        private CI.Controls.FlatField flatField3;
        private CI.UIComponents.Filler.EntityFiller settingFiller;
        private EASkins.Ami_Button_2 btnSave;
        private CI.Controls.FlatField flatField4;
    }
}