namespace VehicleManagerSys.Main.CustomForms
{
    partial class YunWangReCheckOptForm
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
            this.txtTestNo = new HZH_Controls.Controls.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new HZH_Controls.Controls.UCBtnExt();
            this.btnCancel = new HZH_Controls.Controls.UCBtnExt();
            this.chkAppearence = new HZH_Controls.Controls.UCCheckBox();
            this.SuspendLayout();
            // 
            // txtTestNo
            // 
            this.txtTestNo.BackColor = System.Drawing.Color.Transparent;
            this.txtTestNo.ConerRadius = 5;
            this.txtTestNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTestNo.CusPasswrodChar = '\0';
            this.txtTestNo.DecLength = 2;
            this.txtTestNo.Enabled = false;
            this.txtTestNo.FillColor = System.Drawing.Color.Empty;
            this.txtTestNo.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txtTestNo.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTestNo.InputText = "";
            this.txtTestNo.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtTestNo.IsFocusColor = true;
            this.txtTestNo.IsRadius = true;
            this.txtTestNo.IsShowClearBtn = false;
            this.txtTestNo.IsShowKeyboard = false;
            this.txtTestNo.IsShowRect = true;
            this.txtTestNo.IsShowSearchBtn = false;
            this.txtTestNo.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.txtTestNo.Location = new System.Drawing.Point(38, 103);
            this.txtTestNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTestNo.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtTestNo.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtTestNo.Name = "txtTestNo";
            this.txtTestNo.Padding = new System.Windows.Forms.Padding(5);
            this.txtTestNo.PromptColor = System.Drawing.Color.Gray;
            this.txtTestNo.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTestNo.PromptText = "过量空气系数上限";
            this.txtTestNo.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtTestNo.RectWidth = 1;
            this.txtTestNo.RegexPattern = "";
            this.txtTestNo.Size = new System.Drawing.Size(322, 42);
            this.txtTestNo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "检测流水号";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.BtnForeColor = System.Drawing.Color.White;
            this.btnConfirm.BtnText = "确 定";
            this.btnConfirm.ConerRadius = 10;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.EnabledMouseEffect = true;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.IsRadius = true;
            this.btnConfirm.IsShowRect = false;
            this.btnConfirm.IsShowTips = false;
            this.btnConfirm.Location = new System.Drawing.Point(241, 246);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.RectColor = System.Drawing.Color.Gainsboro;
            this.btnConfirm.RectWidth = 1;
            this.btnConfirm.Size = new System.Drawing.Size(119, 46);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.TabStop = false;
            this.btnConfirm.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnConfirm.TipsText = "";
            this.btnConfirm.BtnClick += new System.EventHandler(this.btnConfirm_BtnClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.BtnForeColor = System.Drawing.Color.White;
            this.btnCancel.BtnText = "取 消";
            this.btnCancel.ConerRadius = 10;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.EnabledMouseEffect = true;
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.IsRadius = true;
            this.btnCancel.IsShowRect = false;
            this.btnCancel.IsShowTips = false;
            this.btnCancel.Location = new System.Drawing.Point(105, 246);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RectColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.RectWidth = 1;
            this.btnCancel.Size = new System.Drawing.Size(119, 46);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.TabStop = false;
            this.btnCancel.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnCancel.TipsText = "";
            this.btnCancel.BtnClick += new System.EventHandler(this.btnCancel_BtnClick);
            // 
            // chkAppearence
            // 
            this.chkAppearence.BackColor = System.Drawing.Color.Transparent;
            this.chkAppearence.Checked = false;
            this.chkAppearence.Location = new System.Drawing.Point(38, 176);
            this.chkAppearence.Name = "chkAppearence";
            this.chkAppearence.Padding = new System.Windows.Forms.Padding(1);
            this.chkAppearence.Size = new System.Drawing.Size(233, 30);
            this.chkAppearence.TabIndex = 19;
            this.chkAppearence.TextValue = "是否复检外观";
            // 
            // YunWangReCheckOptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 320);
            this.Controls.Add(this.chkAppearence);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTestNo);
            this.Name = "YunWangReCheckOptForm";
            this.Text = "InputLambdaForm";
            this.Title = "";
            this.Controls.SetChildIndex(this.txtTestNo, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnConfirm, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.chkAppearence, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCTextBoxEx txtTestNo;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCBtnExt btnConfirm;
        private HZH_Controls.Controls.UCBtnExt btnCancel;
        private HZH_Controls.Controls.UCCheckBox chkAppearence;
    }
}