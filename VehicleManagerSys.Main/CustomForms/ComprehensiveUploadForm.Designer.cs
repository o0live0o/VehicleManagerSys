namespace VehicleManagerSys.Main.CustomForms
{
    partial class ComprehensiveUploadForm
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
            this.ami_HeaderLabel1 = new EASkins.Ami_HeaderLabel();
            this.ami_HeaderLabel2 = new EASkins.Ami_HeaderLabel();
            this.labTestNo = new EASkins.Ami_Label();
            this.labTestNoNet = new EASkins.Ami_Label();
            this.chkTrust = new EASkins.Controls.MaterialCheckBox();
            this.btnUpload = new EASkins.Emi_Button_2();
            this.txtUploadLog = new System.Windows.Forms.RichTextBox();
            this.combAuthor = new EASkins.Ami_ComboBox();
            this.labOperator = new EASkins.Ami_HeaderLabel();
            this.captureElo1 = new VehicleManagerSys.Main.Controls.CaptureElo();
            this.SuspendLayout();
            // 
            // ami_HeaderLabel1
            // 
            this.ami_HeaderLabel1.AutoSize = true;
            this.ami_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ami_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel1.Location = new System.Drawing.Point(24, 74);
            this.ami_HeaderLabel1.Name = "ami_HeaderLabel1";
            this.ami_HeaderLabel1.Size = new System.Drawing.Size(111, 20);
            this.ami_HeaderLabel1.TabIndex = 8;
            this.ami_HeaderLabel1.Text = "检测流水号：";
            // 
            // ami_HeaderLabel2
            // 
            this.ami_HeaderLabel2.AutoSize = true;
            this.ami_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ami_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel2.Location = new System.Drawing.Point(24, 136);
            this.ami_HeaderLabel2.Name = "ami_HeaderLabel2";
            this.ami_HeaderLabel2.Size = new System.Drawing.Size(111, 20);
            this.ami_HeaderLabel2.TabIndex = 8;
            this.ami_HeaderLabel2.Text = "联网流水号：";
            // 
            // labTestNo
            // 
            this.labTestNo.AutoSize = true;
            this.labTestNo.BackColor = System.Drawing.Color.Transparent;
            this.labTestNo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labTestNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.labTestNo.Location = new System.Drawing.Point(24, 101);
            this.labTestNo.Name = "labTestNo";
            this.labTestNo.Size = new System.Drawing.Size(89, 20);
            this.labTestNo.TabIndex = 10;
            this.labTestNo.Text = "1234567890";
            // 
            // labTestNoNet
            // 
            this.labTestNoNet.AutoSize = true;
            this.labTestNoNet.BackColor = System.Drawing.Color.Transparent;
            this.labTestNoNet.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labTestNoNet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.labTestNoNet.Location = new System.Drawing.Point(24, 166);
            this.labTestNoNet.Name = "labTestNoNet";
            this.labTestNoNet.Size = new System.Drawing.Size(89, 20);
            this.labTestNoNet.TabIndex = 10;
            this.labTestNoNet.Text = "1234567890";
            // 
            // chkTrust
            // 
            this.chkTrust.AutoSize = true;
            this.chkTrust.Checked = true;
            this.chkTrust.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrust.Depth = 0;
            this.chkTrust.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkTrust.Location = new System.Drawing.Point(28, 204);
            this.chkTrust.Margin = new System.Windows.Forms.Padding(0);
            this.chkTrust.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkTrust.MouseState = EASkins.MouseState.HOVER;
            this.chkTrust.Name = "chkTrust";
            this.chkTrust.Ripple = true;
            this.chkTrust.Size = new System.Drawing.Size(211, 30);
            this.chkTrust.TabIndex = 13;
            this.chkTrust.Text = "道路运输货车采信安检数据";
            this.chkTrust.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Image = null;
            this.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.Location = new System.Drawing.Point(24, 339);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(207, 40);
            this.btnUpload.TabIndex = 14;
            this.btnUpload.Text = "上  传";
            this.btnUpload.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtUploadLog
            // 
            this.txtUploadLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUploadLog.Location = new System.Drawing.Point(24, 401);
            this.txtUploadLog.Name = "txtUploadLog";
            this.txtUploadLog.ReadOnly = true;
            this.txtUploadLog.Size = new System.Drawing.Size(339, 388);
            this.txtUploadLog.TabIndex = 15;
            this.txtUploadLog.Text = "";
            // 
            // combAuthor
            // 
            this.combAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combAuthor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combAuthor.DropDownHeight = 100;
            this.combAuthor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combAuthor.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.combAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combAuthor.FormattingEnabled = true;
            this.combAuthor.HoverSelectionColor = System.Drawing.Color.Empty;
            this.combAuthor.IntegralHeight = false;
            this.combAuthor.ItemHeight = 25;
            this.combAuthor.Location = new System.Drawing.Point(24, 291);
            this.combAuthor.Name = "combAuthor";
            this.combAuthor.Size = new System.Drawing.Size(207, 31);
            this.combAuthor.StartIndex = 0;
            this.combAuthor.TabIndex = 17;
            // 
            // labOperator
            // 
            this.labOperator.AutoSize = true;
            this.labOperator.BackColor = System.Drawing.Color.Transparent;
            this.labOperator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labOperator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labOperator.Location = new System.Drawing.Point(24, 258);
            this.labOperator.Name = "labOperator";
            this.labOperator.Size = new System.Drawing.Size(111, 20);
            this.labOperator.TabIndex = 18;
            this.labOperator.Text = "授权签字员：";
            // 
            // captureElo1
            // 
            this.captureElo1.CapturePath = null;
            this.captureElo1.Location = new System.Drawing.Point(369, 60);
            this.captureElo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.captureElo1.Name = "captureElo1";
            this.captureElo1.Size = new System.Drawing.Size(886, 736);
            this.captureElo1.TabIndex = 19;
            this.captureElo1.VehicleNo = null;
            // 
            // ComprehensiveUploadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanMove = false;
            this.ClientSize = new System.Drawing.Size(1265, 801);
            this.Controls.Add(this.captureElo1);
            this.Controls.Add(this.labOperator);
            this.Controls.Add(this.combAuthor);
            this.Controls.Add(this.txtUploadLog);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.chkTrust);
            this.Controls.Add(this.labTestNoNet);
            this.Controls.Add(this.labTestNo);
            this.Controls.Add(this.ami_HeaderLabel2);
            this.Controls.Add(this.ami_HeaderLabel1);
            this.IsShowCloseBtn = true;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "ComprehensiveUploadForm";
            this.Text = "上  传";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComprehensiveUploadForm_FormClosing);
            this.Shown += new System.EventHandler(this.ComprehensiveUploadForm_Shown);
            this.Controls.SetChildIndex(this.ami_HeaderLabel1, 0);
            this.Controls.SetChildIndex(this.ami_HeaderLabel2, 0);
            this.Controls.SetChildIndex(this.labTestNo, 0);
            this.Controls.SetChildIndex(this.labTestNoNet, 0);
            this.Controls.SetChildIndex(this.chkTrust, 0);
            this.Controls.SetChildIndex(this.btnUpload, 0);
            this.Controls.SetChildIndex(this.txtUploadLog, 0);
            this.Controls.SetChildIndex(this.combAuthor, 0);
            this.Controls.SetChildIndex(this.labOperator, 0);
            this.Controls.SetChildIndex(this.captureElo1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EASkins.Ami_HeaderLabel ami_HeaderLabel1;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel2;
        private EASkins.Ami_Label labTestNo;
        private EASkins.Ami_Label labTestNoNet;
        private EASkins.Controls.MaterialCheckBox chkTrust;
        private EASkins.Emi_Button_2 btnUpload;
        private System.Windows.Forms.RichTextBox txtUploadLog;
        private EASkins.Ami_ComboBox combAuthor;
        private EASkins.Ami_HeaderLabel labOperator;
        private Controls.CaptureElo captureElo1;
        //private Controls.CaptureElo captureElo1;
    }
}