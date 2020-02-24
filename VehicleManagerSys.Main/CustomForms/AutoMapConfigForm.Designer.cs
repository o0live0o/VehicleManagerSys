namespace VehicleManagerSys.Main.CustomForms
{
    partial class AutoMapConfigForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.emi_Separator1 = new EASkins.Emi_Separator();
            this.combFileName = new EASkins.Ami_ComboBox();
            this.emi_Button_21 = new EASkins.Emi_Button_2();
            this.emi_Button_22 = new EASkins.Emi_Button_2();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.settingFiller = new CI.UIComponents.Filler.EntityFiller();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // emi_Separator1
            // 
            this.emi_Separator1.Location = new System.Drawing.Point(0, 94);
            this.emi_Separator1.Name = "emi_Separator1";
            this.emi_Separator1.Size = new System.Drawing.Size(844, 10);
            this.emi_Separator1.TabIndex = 7;
            this.emi_Separator1.Text = "emi_Separator1";
            // 
            // combFileName
            // 
            this.combFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.combFileName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combFileName.DropDownHeight = 100;
            this.combFileName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combFileName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.combFileName.FormattingEnabled = true;
            this.combFileName.HoverSelectionColor = System.Drawing.Color.Empty;
            this.combFileName.IntegralHeight = false;
            this.combFileName.ItemHeight = 20;
            this.combFileName.Location = new System.Drawing.Point(12, 67);
            this.combFileName.Name = "combFileName";
            this.combFileName.Size = new System.Drawing.Size(218, 26);
            this.combFileName.StartIndex = 0;
            this.combFileName.TabIndex = 8;
            // 
            // emi_Button_21
            // 
            this.emi_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.emi_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.emi_Button_21.ForeColor = System.Drawing.Color.White;
            this.emi_Button_21.Image = null;
            this.emi_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emi_Button_21.Location = new System.Drawing.Point(647, 67);
            this.emi_Button_21.Name = "emi_Button_21";
            this.emi_Button_21.Size = new System.Drawing.Size(84, 28);
            this.emi_Button_21.TabIndex = 9;
            this.emi_Button_21.Text = "新建";
            this.emi_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // emi_Button_22
            // 
            this.emi_Button_22.BackColor = System.Drawing.Color.Transparent;
            this.emi_Button_22.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.emi_Button_22.ForeColor = System.Drawing.Color.White;
            this.emi_Button_22.Image = null;
            this.emi_Button_22.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.emi_Button_22.Location = new System.Drawing.Point(748, 67);
            this.emi_Button_22.Name = "emi_Button_22";
            this.emi_Button_22.Size = new System.Drawing.Size(84, 28);
            this.emi_Button_22.TabIndex = 9;
            this.emi_Button_22.Text = "保存";
            this.emi_Button_22.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dgv
            // 
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv.ColumnHeadersHeight = 35;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dgv.Location = new System.Drawing.Point(-1, 99);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(230)))), ((int)(((byte)(133)))));
            this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.RowTemplate.Height = 30;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(846, 454);
            this.dgv.TabIndex = 10;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SrcName";
            this.Column3.HeaderText = "原字段";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "OptName";
            this.Column1.HeaderText = "目标字段";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Remark";
            this.Column2.HeaderText = "备注";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // AutoMapConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 554);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.emi_Button_22);
            this.Controls.Add(this.emi_Button_21);
            this.Controls.Add(this.combFileName);
            this.Controls.Add(this.emi_Separator1);
            this.Name = "AutoMapConfigForm";
            this.Text = "AutoMapConfigForm";
            this.Shown += new System.EventHandler(this.AutoMapConfigForm_Shown);
            this.Controls.SetChildIndex(this.emi_Separator1, 0);
            this.Controls.SetChildIndex(this.combFileName, 0);
            this.Controls.SetChildIndex(this.emi_Button_21, 0);
            this.Controls.SetChildIndex(this.emi_Button_22, 0);
            this.Controls.SetChildIndex(this.dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private EASkins.Emi_Separator emi_Separator1;
        private EASkins.Ami_ComboBox combFileName;
        private EASkins.Emi_Button_2 emi_Button_21;
        private EASkins.Emi_Button_2 emi_Button_22;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private CI.UIComponents.Filler.EntityFiller settingFiller;
    }
}