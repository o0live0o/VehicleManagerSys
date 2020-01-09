namespace VehicleManagerSys.Main.Controls
{
    partial class CaptureElo
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureElo));
            this.exchangeUpDown = new System.Windows.Forms.Button();
            this.turnRight = new System.Windows.Forms.Button();
            this.exchangeLeftRight = new System.Windows.Forms.Button();
            this.turnLeft = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.selectMode = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.selectDevice = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.selectResolution = new System.Windows.Forms.ComboBox();
            this.openProperty = new System.Windows.Forms.Button();
            this.shoot = new System.Windows.Forms.Button();
            this.closeVideo = new System.Windows.Forms.Button();
            this.openVideo = new System.Windows.Forms.Button();
            this.combImgList = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eloamThumbnail = new AxeloamComLib.AxEloamThumbnail();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eloamView = new AxeloamComLib.AxEloamView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnTime = new System.Windows.Forms.Button();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eloamThumbnail)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eloamView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // exchangeUpDown
            // 
            this.exchangeUpDown.Location = new System.Drawing.Point(221, 138);
            this.exchangeUpDown.Name = "exchangeUpDown";
            this.exchangeUpDown.Size = new System.Drawing.Size(62, 30);
            this.exchangeUpDown.TabIndex = 70;
            this.exchangeUpDown.Text = "上下";
            this.exchangeUpDown.UseVisualStyleBackColor = true;
            this.exchangeUpDown.Click += new System.EventHandler(this.exchangeUpDown_Click);
            // 
            // turnRight
            // 
            this.turnRight.Location = new System.Drawing.Point(85, 138);
            this.turnRight.Name = "turnRight";
            this.turnRight.Size = new System.Drawing.Size(62, 30);
            this.turnRight.TabIndex = 69;
            this.turnRight.Text = "右转";
            this.turnRight.UseVisualStyleBackColor = true;
            this.turnRight.Click += new System.EventHandler(this.turnRight_Click);
            // 
            // exchangeLeftRight
            // 
            this.exchangeLeftRight.Location = new System.Drawing.Point(153, 138);
            this.exchangeLeftRight.Name = "exchangeLeftRight";
            this.exchangeLeftRight.Size = new System.Drawing.Size(62, 30);
            this.exchangeLeftRight.TabIndex = 68;
            this.exchangeLeftRight.Text = "左右";
            this.exchangeLeftRight.UseVisualStyleBackColor = true;
            this.exchangeLeftRight.Click += new System.EventHandler(this.exchangeLeftRight_Click);
            // 
            // turnLeft
            // 
            this.turnLeft.Location = new System.Drawing.Point(17, 138);
            this.turnLeft.Name = "turnLeft";
            this.turnLeft.Size = new System.Drawing.Size(62, 30);
            this.turnLeft.TabIndex = 67;
            this.turnLeft.Text = "左转";
            this.turnLeft.UseVisualStyleBackColor = true;
            this.turnLeft.Click += new System.EventHandler(this.turnLeft_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.selectMode);
            this.groupBox12.Location = new System.Drawing.Point(153, 52);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(130, 48);
            this.groupBox12.TabIndex = 60;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "视频模式：";
            // 
            // selectMode
            // 
            this.selectMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectMode.FormattingEnabled = true;
            this.selectMode.Location = new System.Drawing.Point(8, 20);
            this.selectMode.Name = "selectMode";
            this.selectMode.Size = new System.Drawing.Size(113, 20);
            this.selectMode.TabIndex = 10;
            this.selectMode.SelectedIndexChanged += new System.EventHandler(this.selectMode_SelectedIndexChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.selectDevice);
            this.groupBox11.Location = new System.Drawing.Point(17, 52);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(130, 48);
            this.groupBox11.TabIndex = 59;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "设备列表：";
            // 
            // selectDevice
            // 
            this.selectDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectDevice.FormattingEnabled = true;
            this.selectDevice.Location = new System.Drawing.Point(8, 20);
            this.selectDevice.Name = "selectDevice";
            this.selectDevice.Size = new System.Drawing.Size(113, 20);
            this.selectDevice.TabIndex = 10;
            this.selectDevice.SelectedIndexChanged += new System.EventHandler(this.selectDevice_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.selectResolution);
            this.groupBox1.Location = new System.Drawing.Point(298, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 48);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "分辨率：";
            // 
            // selectResolution
            // 
            this.selectResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectResolution.FormattingEnabled = true;
            this.selectResolution.Location = new System.Drawing.Point(8, 20);
            this.selectResolution.Name = "selectResolution";
            this.selectResolution.Size = new System.Drawing.Size(113, 20);
            this.selectResolution.TabIndex = 10;
            // 
            // openProperty
            // 
            this.openProperty.Location = new System.Drawing.Point(298, 108);
            this.openProperty.Name = "openProperty";
            this.openProperty.Size = new System.Drawing.Size(130, 23);
            this.openProperty.TabIndex = 57;
            this.openProperty.Text = "属性";
            this.openProperty.UseVisualStyleBackColor = true;
            this.openProperty.Click += new System.EventHandler(this.openProperty_Click);
            // 
            // shoot
            // 
            this.shoot.Location = new System.Drawing.Point(365, 13);
            this.shoot.Name = "shoot";
            this.shoot.Size = new System.Drawing.Size(63, 23);
            this.shoot.TabIndex = 56;
            this.shoot.Text = "拍摄";
            this.shoot.UseVisualStyleBackColor = true;
            this.shoot.Click += new System.EventHandler(this.shoot_Click);
            // 
            // closeVideo
            // 
            this.closeVideo.Location = new System.Drawing.Point(153, 108);
            this.closeVideo.Name = "closeVideo";
            this.closeVideo.Size = new System.Drawing.Size(130, 23);
            this.closeVideo.TabIndex = 55;
            this.closeVideo.Text = "关闭视频";
            this.closeVideo.UseVisualStyleBackColor = true;
            this.closeVideo.Click += new System.EventHandler(this.closeVideo_Click);
            // 
            // openVideo
            // 
            this.openVideo.Location = new System.Drawing.Point(17, 108);
            this.openVideo.Name = "openVideo";
            this.openVideo.Size = new System.Drawing.Size(130, 23);
            this.openVideo.TabIndex = 54;
            this.openVideo.Text = "打开视频";
            this.openVideo.UseVisualStyleBackColor = true;
            this.openVideo.Click += new System.EventHandler(this.openVideo_Click);
            // 
            // combImgList
            // 
            this.combImgList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combImgList.FormattingEnabled = true;
            this.combImgList.Location = new System.Drawing.Point(17, 16);
            this.combImgList.Name = "combImgList";
            this.combImgList.Size = new System.Drawing.Size(323, 20);
            this.combImgList.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.eloamThumbnail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 537);
            this.panel1.TabIndex = 79;
            // 
            // eloamThumbnail
            // 
            this.eloamThumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eloamThumbnail.Enabled = true;
            this.eloamThumbnail.Location = new System.Drawing.Point(0, 0);
            this.eloamThumbnail.Name = "eloamThumbnail";
            this.eloamThumbnail.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("eloamThumbnail.OcxState")));
            this.eloamThumbnail.Size = new System.Drawing.Size(124, 537);
            this.eloamThumbnail.TabIndex = 78;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.eloamView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(437, 351);
            this.panel2.TabIndex = 80;
            // 
            // eloamView
            // 
            this.eloamView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eloamView.Enabled = true;
            this.eloamView.Location = new System.Drawing.Point(0, 0);
            this.eloamView.Name = "eloamView";
            this.eloamView.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("eloamView.OcxState")));
            this.eloamView.Size = new System.Drawing.Size(437, 351);
            this.eloamView.TabIndex = 78;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(565, 537);
            this.splitContainer1.SplitterDistance = 437;
            this.splitContainer1.TabIndex = 81;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnTime);
            this.splitContainer2.Panel2.Controls.Add(this.combImgList);
            this.splitContainer2.Panel2.Controls.Add(this.openVideo);
            this.splitContainer2.Panel2.Controls.Add(this.exchangeUpDown);
            this.splitContainer2.Panel2.Controls.Add(this.closeVideo);
            this.splitContainer2.Panel2.Controls.Add(this.turnRight);
            this.splitContainer2.Panel2.Controls.Add(this.shoot);
            this.splitContainer2.Panel2.Controls.Add(this.exchangeLeftRight);
            this.splitContainer2.Panel2.Controls.Add(this.openProperty);
            this.splitContainer2.Panel2.Controls.Add(this.turnLeft);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox12);
            this.splitContainer2.Panel2.Controls.Add(this.groupBox11);
            this.splitContainer2.Size = new System.Drawing.Size(437, 537);
            this.splitContainer2.SplitterDistance = 351;
            this.splitContainer2.TabIndex = 81;
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(298, 137);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(130, 30);
            this.btnTime.TabIndex = 79;
            this.btnTime.Text = "显示时间";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // CaptureElo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "CaptureElo";
            this.Size = new System.Drawing.Size(565, 537);
            this.Load += new System.EventHandler(this.CaptureEloam_Load);
            this.groupBox12.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eloamThumbnail)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eloamView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exchangeUpDown;
        private System.Windows.Forms.Button turnRight;
        private System.Windows.Forms.Button exchangeLeftRight;
        private System.Windows.Forms.Button turnLeft;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.ComboBox selectMode;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.ComboBox selectDevice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox selectResolution;
        private System.Windows.Forms.Button openProperty;
        private System.Windows.Forms.Button shoot;
        private System.Windows.Forms.Button closeVideo;
        private System.Windows.Forms.Button openVideo;
        private System.Windows.Forms.ComboBox combImgList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnTime;
        private AxeloamComLib.AxEloamThumbnail eloamThumbnail;
        private AxeloamComLib.AxEloamView eloamView;

    }
}
