namespace VehicleManagerSys.Main.CustomForms
{
    partial class InputLambdaForm
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
            this.txtLambda_Up = new HZH_Controls.Controls.UCTextBoxEx();
            this.txtLambda_Down = new HZH_Controls.Controls.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConfirm = new HZH_Controls.Controls.UCBtnExt();
            this.SuspendLayout();
            // 
            // txtLambda_Up
            // 
            this.txtLambda_Up.BackColor = System.Drawing.Color.Transparent;
            this.txtLambda_Up.ConerRadius = 5;
            this.txtLambda_Up.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLambda_Up.CusPasswrodChar = '\0';
            this.txtLambda_Up.DecLength = 2;
            this.txtLambda_Up.FillColor = System.Drawing.Color.Empty;
            this.txtLambda_Up.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txtLambda_Up.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLambda_Up.InputText = "1.05";
            this.txtLambda_Up.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtLambda_Up.IsFocusColor = true;
            this.txtLambda_Up.IsRadius = true;
            this.txtLambda_Up.IsShowClearBtn = true;
            this.txtLambda_Up.IsShowKeyboard = false;
            this.txtLambda_Up.IsShowRect = true;
            this.txtLambda_Up.IsShowSearchBtn = false;
            this.txtLambda_Up.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txtLambda_Up.Location = new System.Drawing.Point(38, 103);
            this.txtLambda_Up.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLambda_Up.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtLambda_Up.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtLambda_Up.Name = "txtLambda_Up";
            this.txtLambda_Up.Padding = new System.Windows.Forms.Padding(5);
            this.txtLambda_Up.PromptColor = System.Drawing.Color.Gray;
            this.txtLambda_Up.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLambda_Up.PromptText = "过量空气系数上限";
            this.txtLambda_Up.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtLambda_Up.RectWidth = 1;
            this.txtLambda_Up.RegexPattern = "";
            this.txtLambda_Up.Size = new System.Drawing.Size(322, 42);
            this.txtLambda_Up.TabIndex = 7;
            // 
            // txtLambda_Down
            // 
            this.txtLambda_Down.BackColor = System.Drawing.Color.Transparent;
            this.txtLambda_Down.ConerRadius = 5;
            this.txtLambda_Down.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLambda_Down.CusPasswrodChar = '\0';
            this.txtLambda_Down.DecLength = 2;
            this.txtLambda_Down.FillColor = System.Drawing.Color.Empty;
            this.txtLambda_Down.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txtLambda_Down.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLambda_Down.InputText = "0.95";
            this.txtLambda_Down.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtLambda_Down.IsFocusColor = true;
            this.txtLambda_Down.IsRadius = true;
            this.txtLambda_Down.IsShowClearBtn = true;
            this.txtLambda_Down.IsShowKeyboard = false;
            this.txtLambda_Down.IsShowRect = true;
            this.txtLambda_Down.IsShowSearchBtn = false;
            this.txtLambda_Down.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txtLambda_Down.Location = new System.Drawing.Point(38, 180);
            this.txtLambda_Down.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLambda_Down.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtLambda_Down.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtLambda_Down.Name = "txtLambda_Down";
            this.txtLambda_Down.Padding = new System.Windows.Forms.Padding(5);
            this.txtLambda_Down.PromptColor = System.Drawing.Color.Gray;
            this.txtLambda_Down.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLambda_Down.PromptText = "过量空气系数下限";
            this.txtLambda_Down.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtLambda_Down.RectWidth = 1;
            this.txtLambda_Down.RegexPattern = "";
            this.txtLambda_Down.Size = new System.Drawing.Size(322, 42);
            this.txtLambda_Down.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "过量空气系数上限";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(38, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "过量空气系数下限";
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
            // InputLambdaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 320);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLambda_Down);
            this.Controls.Add(this.txtLambda_Up);
            this.Name = "InputLambdaForm";
            this.Text = "InputLambdaForm";
            this.Title = "双怠速过量空气系数";
            this.Controls.SetChildIndex(this.txtLambda_Up, 0);
            this.Controls.SetChildIndex(this.txtLambda_Down, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnConfirm, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HZH_Controls.Controls.UCTextBoxEx txtLambda_Up;
        private HZH_Controls.Controls.UCTextBoxEx txtLambda_Down;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCBtnExt btnConfirm;
    }
}