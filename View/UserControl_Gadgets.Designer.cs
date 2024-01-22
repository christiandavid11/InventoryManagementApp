namespace BARAQUIL_OOP_FinalProject.View
{
    partial class UserControl_Gadgets
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
            this.textBox_GadgetsManu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_GadgetsColor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_GadgetsType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_GadgetsStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_GadgetsManu
            // 
            this.textBox_GadgetsManu.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_GadgetsManu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GadgetsManu.Location = new System.Drawing.Point(87, 23);
            this.textBox_GadgetsManu.Name = "textBox_GadgetsManu";
            this.textBox_GadgetsManu.Size = new System.Drawing.Size(170, 24);
            this.textBox_GadgetsManu.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Manufacturer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Status:";
            // 
            // textBox_GadgetsColor
            // 
            this.textBox_GadgetsColor.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_GadgetsColor.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GadgetsColor.Location = new System.Drawing.Point(87, 96);
            this.textBox_GadgetsColor.Name = "textBox_GadgetsColor";
            this.textBox_GadgetsColor.Size = new System.Drawing.Size(146, 24);
            this.textBox_GadgetsColor.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Color:";
            // 
            // textBox_GadgetsType
            // 
            this.textBox_GadgetsType.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_GadgetsType.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GadgetsType.Location = new System.Drawing.Point(87, 131);
            this.textBox_GadgetsType.Name = "textBox_GadgetsType";
            this.textBox_GadgetsType.Size = new System.Drawing.Size(146, 24);
            this.textBox_GadgetsType.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Type:";
            // 
            // comboBox_GadgetsStatus
            // 
            this.comboBox_GadgetsStatus.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_GadgetsStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_GadgetsStatus.FormattingEnabled = true;
            this.comboBox_GadgetsStatus.Items.AddRange(new object[] {
            "Brand New",
            "1 year old after release",
            "2 year old after release",
            "3 years or more"});
            this.comboBox_GadgetsStatus.Location = new System.Drawing.Point(84, 60);
            this.comboBox_GadgetsStatus.Name = "comboBox_GadgetsStatus";
            this.comboBox_GadgetsStatus.Size = new System.Drawing.Size(173, 25);
            this.comboBox_GadgetsStatus.TabIndex = 26;
            // 
            // UserControl_Gadgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_GadgetsStatus);
            this.Controls.Add(this.textBox_GadgetsType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_GadgetsColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_GadgetsManu);
            this.Controls.Add(this.label3);
            this.Name = "UserControl_Gadgets";
            this.Size = new System.Drawing.Size(260, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_GadgetsManu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBox_GadgetsColor;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_GadgetsType;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comboBox_GadgetsStatus;
    }
}
