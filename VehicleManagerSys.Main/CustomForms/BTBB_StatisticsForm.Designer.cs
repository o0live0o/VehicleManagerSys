namespace VehicleManagerSys.Main.CustomForms
{
    partial class BTBB_StatisticsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVin = new EASkins.Ami_TextBox();
            this.btnSearch = new EASkins.Ami_Button_2();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dtStart = new HZH_Controls.Controls.UCDatePickerExt();
            this.dtEnd = new HZH_Controls.Controls.UCDatePickerExt();
            this.ami_HeaderLabel1 = new EASkins.Ami_HeaderLabel();
            this.combStatus = new EASkins.Ami_ComboBox();
            this.labCount = new EASkins.Ami_HeaderLabel();
            this.btnExport = new EASkins.Ami_Button_2();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.combStatus);
            this.panel1.Controls.Add(this.ami_HeaderLabel1);
            this.panel1.Controls.Add(this.dtEnd);
            this.panel1.Controls.Add(this.dtStart);
            this.panel1.Controls.Add(this.txtVin);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 56);
            this.panel1.TabIndex = 7;
            // 
            // txtVin
            // 
            this.txtVin.BackColor = System.Drawing.Color.Transparent;
            this.txtVin.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtVin.ForeColor = System.Drawing.Color.DimGray;
            this.txtVin.Location = new System.Drawing.Point(648, 19);
            this.txtVin.MaxLength = 32767;
            this.txtVin.Multiline = false;
            this.txtVin.Name = "txtVin";
            this.txtVin.ReadOnly = false;
            this.txtVin.Size = new System.Drawing.Size(154, 28);
            this.txtVin.TabIndex = 1;
            this.txtVin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtVin.UseSystemPasswordChar = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Image = null;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(822, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "查  询";
            this.btnSearch.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.ColumnHeadersHeight = 35;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column5,
            this.Column4});
            this.dgv.Location = new System.Drawing.Point(0, 154);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(133)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1014, 443);
            this.dgv.TabIndex = 8;
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // dtStart
            // 
            this.dtStart.BackColor = System.Drawing.Color.White;
            this.dtStart.ConerRadius = 5;
            this.dtStart.CurrentTime = new System.DateTime(2020, 4, 30, 15, 52, 43, 0);
            this.dtStart.FillColor = System.Drawing.Color.Transparent;
            this.dtStart.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtStart.IsRadius = true;
            this.dtStart.IsShowRect = false;
            this.dtStart.Location = new System.Drawing.Point(13, 12);
            this.dtStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtStart.Name = "dtStart";
            this.dtStart.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dtStart.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dtStart.RectWidth = 1;
            this.dtStart.Size = new System.Drawing.Size(222, 39);
            this.dtStart.TabIndex = 2;
            this.dtStart.TimeFontSize = 20;
            this.dtStart.TimeType = HZH_Controls.Controls.DateTimePickerType.Date;
            // 
            // dtEnd
            // 
            this.dtEnd.BackColor = System.Drawing.Color.White;
            this.dtEnd.ConerRadius = 5;
            this.dtEnd.CurrentTime = new System.DateTime(2020, 4, 30, 15, 52, 43, 0);
            this.dtEnd.FillColor = System.Drawing.Color.Transparent;
            this.dtEnd.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dtEnd.IsRadius = true;
            this.dtEnd.IsShowRect = false;
            this.dtEnd.Location = new System.Drawing.Point(262, 12);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dtEnd.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dtEnd.RectWidth = 1;
            this.dtEnd.Size = new System.Drawing.Size(222, 39);
            this.dtEnd.TabIndex = 3;
            this.dtEnd.TimeFontSize = 20;
            this.dtEnd.TimeType = HZH_Controls.Controls.DateTimePickerType.Date;
            // 
            // ami_HeaderLabel1
            // 
            this.ami_HeaderLabel1.AutoSize = true;
            this.ami_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ami_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ami_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.ami_HeaderLabel1.Location = new System.Drawing.Point(238, 22);
            this.ami_HeaderLabel1.Name = "ami_HeaderLabel1";
            this.ami_HeaderLabel1.Size = new System.Drawing.Size(15, 20);
            this.ami_HeaderLabel1.TabIndex = 4;
            this.ami_HeaderLabel1.Text = "-";
            // 
            // combStatus
            // 
            this.combStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combStatus.DropDownHeight = 100;
            this.combStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combStatus.FormattingEnabled = true;
            this.combStatus.HoverSelectionColor = System.Drawing.Color.Empty;
            this.combStatus.IntegralHeight = false;
            this.combStatus.ItemHeight = 20;
            this.combStatus.Items.AddRange(new object[] {
            "全部",
            "未上传",
            "上传成功",
            "上传失败"});
            this.combStatus.Location = new System.Drawing.Point(491, 19);
            this.combStatus.Name = "combStatus";
            this.combStatus.Size = new System.Drawing.Size(135, 26);
            this.combStatus.StartIndex = 0;
            this.combStatus.TabIndex = 5;
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.BackColor = System.Drawing.Color.Transparent;
            this.labCount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.labCount.Location = new System.Drawing.Point(2, 126);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(145, 20);
            this.labCount.TabIndex = 9;
            this.labCount.Text = "共查询到 0 条信息";
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnExport.Image = null;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(917, 19);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 30);
            this.btnExport.TabIndex = 0;
            this.btnExport.Text = "导  出";
            this.btnExport.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VIN";
            this.Column3.HeaderText = "VIN";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "XXGKBH";
            this.Column1.HeaderText = "信息公开编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TESTNO";
            this.Column2.HeaderText = "报告编号";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "OTESTDATE";
            this.Column6.HeaderText = "检测日期";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "STATUS";
            this.Column5.HeaderText = "状态";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CREATEDATE";
            this.Column4.HeaderText = "上传日期";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // BTBB_StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanMove = false;
            this.ClientSize = new System.Drawing.Size(1014, 599);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.panel1);
            this.Name = "BTBB_StatisticsForm";
            this.Text = "ComprehensiveTestForm";
            this.Title = "上传统计";
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            this.Controls.SetChildIndex(this.labCount, 0);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private EASkins.Ami_Button_2 btnSearch;
        private EASkins.Ami_TextBox txtVin;
        private EASkins.Ami_ComboBox combStatus;
        private EASkins.Ami_HeaderLabel ami_HeaderLabel1;
        private HZH_Controls.Controls.UCDatePickerExt dtEnd;
        private HZH_Controls.Controls.UCDatePickerExt dtStart;
        private EASkins.Ami_HeaderLabel labCount;
        private EASkins.Ami_Button_2 btnExport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}