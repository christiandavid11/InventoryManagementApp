namespace BARAQUIL_OOP_FinalProject.View
{
    partial class UserControl_Toys
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
            this.textBox_ToysItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ToysColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ToysForwho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_ToysStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_ToysItem
            // 
            this.textBox_ToysItem.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_ToysItem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ToysItem.Location = new System.Drawing.Point(68, 18);
            this.textBox_ToysItem.Name = "textBox_ToysItem";
            this.textBox_ToysItem.Size = new System.Drawing.Size(173, 24);
            this.textBox_ToysItem.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Item:";
            // 
            // textBox_ToysColor
            // 
            this.textBox_ToysColor.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_ToysColor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ToysColor.Location = new System.Drawing.Point(68, 57);
            this.textBox_ToysColor.Name = "textBox_ToysColor";
            this.textBox_ToysColor.Size = new System.Drawing.Size(173, 24);
            this.textBox_ToysColor.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Color:";
            // 
            // comboBox_ToysForwho
            // 
            this.comboBox_ToysForwho.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_ToysForwho.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ToysForwho.FormattingEnabled = true;
            this.comboBox_ToysForwho.Items.AddRange(new object[] {
            "0-2 years old",
            "2-7 years old",
            "7 years older"});
            this.comboBox_ToysForwho.Location = new System.Drawing.Point(68, 97);
            this.comboBox_ToysForwho.Name = "comboBox_ToysForwho";
            this.comboBox_ToysForwho.Size = new System.Drawing.Size(173, 25);
            this.comboBox_ToysForwho.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "For Who:";
            // 
            // comboBox_ToysStatus
            // 
            this.comboBox_ToysStatus.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_ToysStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ToysStatus.FormattingEnabled = true;
            this.comboBox_ToysStatus.Items.AddRange(new object[] {
            "Brand New",
            "Month/s Older",
            "Year/s Older"});
            this.comboBox_ToysStatus.Location = new System.Drawing.Point(68, 132);
            this.comboBox_ToysStatus.Name = "comboBox_ToysStatus";
            this.comboBox_ToysStatus.Size = new System.Drawing.Size(173, 25);
            this.comboBox_ToysStatus.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 43;
            this.label4.Text = "Status:";
            // 
            // UserControl_Toys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_ToysStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_ToysForwho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_ToysColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ToysItem);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Toys";
            this.Size = new System.Drawing.Size(260, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_ToysItem;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_ToysColor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox_ToysForwho;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox_ToysStatus;
        private System.Windows.Forms.Label label4;
    }
}
