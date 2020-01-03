namespace VehicleManagerSys.Main.CustomForms
{
    partial class LoginForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.labDbSetting = new EASkins.Ami_LinkLabel();
            this.labWarn = new System.Windows.Forms.Label();
            this.txtPwd = new HZH_Controls.Controls.UCTextBoxEx();
            this.txtUser = new HZH_Controls.Controls.UCTextBoxEx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucSplitLine_V1 = new HZH_Controls.Controls.UCSplitLine_V();
            this.btnOK = new HZH_Controls.Controls.UCBtnExt();
            this.btnCancel = new HZH_Controls.Controls.UCBtnExt();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.labDbSetting);
            this.panel3.Controls.Add(this.labWarn);
            this.panel3.Controls.Add(this.txtPwd);
            this.panel3.Controls.Add(this.txtUser);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(414, 206);
            this.panel3.TabIndex = 7;
            // 
            // labDbSetting
            // 
            this.labDbSetting.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(20)))));
            this.labDbSetting.AutoSize = true;
            this.labDbSetting.BackColor = System.Drawing.Color.Transparent;
            this.labDbSetting.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.labDbSetting.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.labDbSetting.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.labDbSetting.Location = new System.Drawing.Point(44, 164);
            this.labDbSetting.Name = "labDbSetting";
            this.labDbSetting.Size = new System.Drawing.Size(89, 20);
            this.labDbSetting.TabIndex = 2;
            this.labDbSetting.TabStop = true;
            this.labDbSetting.Text = "数据库配置";
            this.labDbSetting.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(119)))), ((int)(((byte)(70)))));
            this.labDbSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labDbSetting_LinkClicked);
            // 
            // labWarn
            // 
            this.labWarn.AutoSize = true;
            this.labWarn.ForeColor = System.Drawing.Color.Red;
            this.labWarn.Location = new System.Drawing.Point(75, 136);
            this.labWarn.Name = "labWarn";
            this.labWarn.Size = new System.Drawing.Size(0, 17);
            this.labWarn.TabIndex = 1;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.Color.Transparent;
            this.txtPwd.ConerRadius = 5;
            this.txtPwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPwd.CusPasswrodChar = '*';
            this.txtPwd.DecLength = 2;
            this.txtPwd.FillColor = System.Drawing.Color.Empty;
            this.txtPwd.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txtPwd.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPwd.InputText = "";
            this.txtPwd.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtPwd.IsFocusColor = true;
            this.txtPwd.IsRadius = true;
            this.txtPwd.IsShowClearBtn = true;
            this.txtPwd.IsShowKeyboard = false;
            this.txtPwd.IsShowRect = true;
            this.txtPwd.IsShowSearchBtn = false;
            this.txtPwd.KeyBoardType = HZH_Controls.Controls.KeyBoardType.Null;
            this.txtPwd.Location = new System.Drawing.Point(49, 82);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPwd.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtPwd.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Padding = new System.Windows.Forms.Padding(5);
            this.txtPwd.PromptColor = System.Drawing.Color.Gray;
            this.txtPwd.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPwd.PromptText = "密码";
            this.txtPwd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtPwd.RectWidth = 1;
            this.txtPwd.RegexPattern = "";
            this.txtPwd.Size = new System.Drawing.Size(322, 42);
            this.txtPwd.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Transparent;
            this.txtUser.ConerRadius = 5;
            this.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUser.CusPasswrodChar = '\0';
            this.txtUser.DecLength = 2;
            this.txtUser.FillColor = System.Drawing.Color.Empty;
            this.txtUser.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.txtUser.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.InputText = "";
            this.txtUser.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtUser.IsFocusColor = true;
            this.txtUser.IsRadius = true;
            this.txtUser.IsShowClearBtn = true;
            this.txtUser.IsShowKeyboard = false;
            this.txtUser.IsShowRect = true;
            this.txtUser.IsShowSearchBtn = false;
            this.txtUser.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txtUser.Location = new System.Drawing.Point(48, 22);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUser.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtUser.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtUser.Name = "txtUser";
            this.txtUser.Padding = new System.Windows.Forms.Padding(5);
            this.txtUser.PromptColor = System.Drawing.Color.Gray;
            this.txtUser.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUser.PromptText = "用户名";
            this.txtUser.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtUser.RectWidth = 1;
            this.txtUser.RegexPattern = "";
            this.txtUser.Size = new System.Drawing.Size(322, 42);
            this.txtUser.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ucSplitLine_V1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnOK, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 267);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(414, 62);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // ucSplitLine_V1
            // 
            this.ucSplitLine_V1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucSplitLine_V1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSplitLine_V1.Location = new System.Drawing.Point(206, 15);
            this.ucSplitLine_V1.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.ucSplitLine_V1.Name = "ucSplitLine_V1";
            this.ucSplitLine_V1.Size = new System.Drawing.Size(1, 32);
            this.ucSplitLine_V1.TabIndex = 0;
            this.ucSplitLine_V1.TabStop = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnOK.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.btnOK.BtnText = "登录";
            this.btnOK.ConerRadius = 5;
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.EnabledMouseEffect = true;
            this.btnOK.FillColor = System.Drawing.Color.White;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnOK.IsRadius = false;
            this.btnOK.IsShowRect = false;
            this.btnOK.IsShowTips = false;
            this.btnOK.Location = new System.Drawing.Point(0, 0);
            this.btnOK.Margin = new System.Windows.Forms.Padding(0);
            this.btnOK.Name = "btnOK";
            this.btnOK.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnOK.RectWidth = 1;
            this.btnOK.Size = new System.Drawing.Size(206, 62);
            this.btnOK.TabIndex = 0;
            this.btnOK.TabStop = false;
            this.btnOK.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnOK.TipsText = "";
            this.btnOK.BtnClick += new System.EventHandler(this.btnOK_BtnClick);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(119)))), ((int)(((byte)(232)))));
            this.btnCancel.BtnText = "退出";
            this.btnCancel.ConerRadius = 5;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.EnabledMouseEffect = true;
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnCancel.IsRadius = false;
            this.btnCancel.IsShowRect = false;
            this.btnCancel.IsShowTips = false;
            this.btnCancel.Location = new System.Drawing.Point(207, 0);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.btnCancel.RectWidth = 1;
            this.btnCancel.Size = new System.Drawing.Size(207, 62);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TabStop = false;
            this.btnCancel.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnCancel.TipsText = "";
            this.btnCancel.BtnClick += new System.EventHandler(this.btnCancel_BtnClick);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 329);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Title = "用户登录";
            this.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private HZH_Controls.Controls.UCSplitLine_V ucSplitLine_V1;
        private HZH_Controls.Controls.UCBtnExt btnOK;
        private HZH_Controls.Controls.UCBtnExt btnCancel;
        private HZH_Controls.Controls.UCTextBoxEx txtPwd;
        private HZH_Controls.Controls.UCTextBoxEx txtUser;
        private System.Windows.Forms.Label labWarn;
        private EASkins.Ami_LinkLabel labDbSetting;
    }
}