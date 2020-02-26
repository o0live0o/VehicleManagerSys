namespace VehicleManagerSys.Main.CustomForms
{
    partial class ValChangeOptForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new HZH_Controls.Controls.UCBtnExt();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.entityFiller = new CI.UIComponents.Filler.EntityFiller();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.validator1 = new CI.UIComponents.Validate.Validator();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(38, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(38, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "联网名称";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnSave.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.BtnForeColor = System.Drawing.Color.White;
            this.btnSave.BtnText = "保 存";
            this.btnSave.ConerRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.EnabledMouseEffect = true;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IsRadius = true;
            this.btnSave.IsShowRect = false;
            this.btnSave.IsShowTips = false;
            this.btnSave.Location = new System.Drawing.Point(383, 331);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.RectColor = System.Drawing.Color.Gainsboro;
            this.btnSave.RectWidth = 1;
            this.btnSave.Size = new System.Drawing.Size(119, 46);
            this.btnSave.TabIndex = 17;
            this.btnSave.TabStop = false;
            this.btnSave.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnSave.TipsText = "";
            this.btnSave.BtnClick += new System.EventHandler(this.btnSave_BtnClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(38, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "类型";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(298, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "代号";
            // 
            // textBox1
            // 
            this.entityFiller.SetEntityField(this.textBox1, new CI.UIComponents.Filler.TextEntry("LocalName", ""));
            this.textBox1.Location = new System.Drawing.Point(42, 112);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 23);
            this.textBox1.TabIndex = 26;
            // 
            // textBox2
            // 
            this.entityFiller.SetEntityField(this.textBox2, new CI.UIComponents.Filler.TextEntry("NetName", ""));
            this.textBox2.Location = new System.Drawing.Point(42, 196);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(200, 23);
            this.textBox2.TabIndex = 26;
            // 
            // textBox3
            // 
            this.entityFiller.SetEntityField(this.textBox3, new CI.UIComponents.Filler.TextEntry("DefineType", ""));
            this.textBox3.Location = new System.Drawing.Point(42, 274);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(200, 23);
            this.textBox3.TabIndex = 26;
            this.validator1.SetTaget(this.textBox3, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // textBox4
            // 
            this.entityFiller.SetEntityField(this.textBox4, new CI.UIComponents.Filler.TextEntry("LocalCode", ""));
            this.textBox4.Location = new System.Drawing.Point(302, 112);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(200, 23);
            this.textBox4.TabIndex = 26;
            this.validator1.SetTaget(this.textBox4, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // textBox5
            // 
            this.entityFiller.SetEntityField(this.textBox5, new CI.UIComponents.Filler.TextEntry("NetCode", ""));
            this.textBox5.Location = new System.Drawing.Point(302, 196);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 23);
            this.textBox5.TabIndex = 26;
            this.validator1.SetTaget(this.textBox5, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RequiredFieldValidator("不能为空！", "")))}));
            // 
            // textBox6
            // 
            this.entityFiller.SetEntityField(this.textBox6, new CI.UIComponents.Filler.TextEntry("Remark", ""));
            this.textBox6.Location = new System.Drawing.Point(302, 274);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 23);
            this.textBox6.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.Location = new System.Drawing.Point(298, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "联网代号";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.Location = new System.Drawing.Point(298, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "备注";
            // 
            // ValChangeOptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 401);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ValChangeOptForm";
            this.Text = "InputLambdaForm";
            this.Title = "字段配置";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.textBox6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCBtnExt btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private CI.UIComponents.Filler.EntityFiller entityFiller;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private CI.UIComponents.Validate.Validator validator1;
    }
}