namespace BARAQUIL_OOP_FinalProject.View
{
    partial class UserControl_Sports
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
            this.textBox_SportsItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_SportsPackby = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_SportsStatus = new System.Windows.Forms.ComboBox();
            this.textBox_SportsColor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_SportsItem
            // 
            this.textBox_SportsItem.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_SportsItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SportsItem.Location = new System.Drawing.Point(66, 18);
            this.textBox_SportsItem.Name = "textBox_SportsItem";
            this.textBox_SportsItem.Size = new System.Drawing.Size(173, 24);
            this.textBox_SportsItem.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Item:";
            // 
            // comboBox_SportsPackby
            // 
            this.comboBox_SportsPackby.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_SportsPackby.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SportsPackby.FormattingEnabled = true;
            this.comboBox_SportsPackby.Items.AddRange(new object[] {
            "Single",
            "Pair",
            "Bundle"});
            this.comboBox_SportsPackby.Location = new System.Drawing.Point(66, 57);
            this.comboBox_SportsPackby.Name = "comboBox_SportsPackby";
            this.comboBox_SportsPackby.Size = new System.Drawing.Size(173, 25);
            this.comboBox_SportsPackby.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Pack By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Status:";
            // 
            // comboBox_SportsStatus
            // 
            this.comboBox_SportsStatus.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_SportsStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SportsStatus.FormattingEnabled = true;
            this.comboBox_SportsStatus.Items.AddRange(new object[] {
            "Brand New",
            "1 year old after release",
            "2 year old after release",
            "3 years or more"});
            this.comboBox_SportsStatus.Location = new System.Drawing.Point(66, 96);
            this.comboBox_SportsStatus.Name = "comboBox_SportsStatus";
            this.comboBox_SportsStatus.Size = new System.Drawing.Size(173, 25);
            this.comboBox_SportsStatus.TabIndex = 41;
            // 
            // textBox_SportsColor
            // 
            this.textBox_SportsColor.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_SportsColor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SportsColor.Location = new System.Drawing.Point(66, 133);
            this.textBox_SportsColor.Name = "textBox_SportsColor";
            this.textBox_SportsColor.Size = new System.Drawing.Size(173, 24);
            this.textBox_SportsColor.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Color:";
            // 
            // UserControl_Sports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_SportsColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_SportsStatus);
            this.Controls.Add(this.comboBox_SportsPackby);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_SportsItem);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Sports";
            this.Size = new System.Drawing.Size(260, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_SportsItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox_SportsPackby;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox_SportsStatus;
        public System.Windows.Forms.TextBox textBox_SportsColor;
        private System.Windows.Forms.Label label4;
    }
}
