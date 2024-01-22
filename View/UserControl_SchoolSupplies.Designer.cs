namespace BARAQUIL_OOP_FinalProject.View
{
    partial class UserControl_SchoolSupplies
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_SchoolColor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SchoolName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_SchoolPackby = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_SchoolForwho = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_SchoolColor
            // 
            this.textBox_SchoolColor.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_SchoolColor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SchoolColor.Location = new System.Drawing.Point(70, 14);
            this.textBox_SchoolColor.Name = "textBox_SchoolColor";
            this.textBox_SchoolColor.Size = new System.Drawing.Size(173, 24);
            this.textBox_SchoolColor.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Color:";
            // 
            // textBox_SchoolName
            // 
            this.textBox_SchoolName.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_SchoolName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SchoolName.Location = new System.Drawing.Point(70, 54);
            this.textBox_SchoolName.Name = "textBox_SchoolName";
            this.textBox_SchoolName.Size = new System.Drawing.Size(173, 24);
            this.textBox_SchoolName.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name:";
            // 
            // comboBox_SchoolPackby
            // 
            this.comboBox_SchoolPackby.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_SchoolPackby.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SchoolPackby.FormattingEnabled = true;
            this.comboBox_SchoolPackby.Items.AddRange(new object[] {
            "Single",
            "Pair",
            "Bundle"});
            this.comboBox_SchoolPackby.Location = new System.Drawing.Point(70, 97);
            this.comboBox_SchoolPackby.Name = "comboBox_SchoolPackby";
            this.comboBox_SchoolPackby.Size = new System.Drawing.Size(173, 25);
            this.comboBox_SchoolPackby.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Pack By:";
            // 
            // comboBox_SchoolForwho
            // 
            this.comboBox_SchoolForwho.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_SchoolForwho.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SchoolForwho.FormattingEnabled = true;
            this.comboBox_SchoolForwho.Items.AddRange(new object[] {
            "Students",
            "Workers",
            "Others",
            "Everyone"});
            this.comboBox_SchoolForwho.Location = new System.Drawing.Point(70, 138);
            this.comboBox_SchoolForwho.Name = "comboBox_SchoolForwho";
            this.comboBox_SchoolForwho.Size = new System.Drawing.Size(173, 25);
            this.comboBox_SchoolForwho.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "For:";
            // 
            // UserControl_SchoolSupplies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_SchoolForwho);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_SchoolPackby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_SchoolName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_SchoolColor);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_SchoolSupplies";
            this.Size = new System.Drawing.Size(260, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_SchoolColor;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_SchoolName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox_SchoolPackby;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox_SchoolForwho;
        private System.Windows.Forms.Label label4;
    }
}
