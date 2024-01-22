namespace BARAQUIL_OOP_FinalProject.View
{
    partial class UserControl_Groceries
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
            this.textBox_GroceriesName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_GroceriesType = new System.Windows.Forms.ComboBox();
            this.Kind = new System.Windows.Forms.Label();
            this.comboBox_GroceriesStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_GroceriesKind = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_GroceriesName
            // 
            this.textBox_GroceriesName.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_GroceriesName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_GroceriesName.Location = new System.Drawing.Point(69, 22);
            this.textBox_GroceriesName.Name = "textBox_GroceriesName";
            this.textBox_GroceriesName.Size = new System.Drawing.Size(173, 24);
            this.textBox_GroceriesName.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name:";
            // 
            // comboBox_GroceriesType
            // 
            this.comboBox_GroceriesType.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_GroceriesType.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_GroceriesType.FormattingEnabled = true;
            this.comboBox_GroceriesType.Items.AddRange(new object[] {
            "Raw",
            "Ready To Eat",
            "Processed Food",
            "Frozen Food",
            "Beverage"});
            this.comboBox_GroceriesType.Location = new System.Drawing.Point(69, 59);
            this.comboBox_GroceriesType.Name = "comboBox_GroceriesType";
            this.comboBox_GroceriesType.Size = new System.Drawing.Size(173, 25);
            this.comboBox_GroceriesType.TabIndex = 28;
            // 
            // Kind
            // 
            this.Kind.AutoSize = true;
            this.Kind.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kind.Location = new System.Drawing.Point(23, 62);
            this.Kind.Name = "Kind";
            this.Kind.Size = new System.Drawing.Size(43, 16);
            this.Kind.TabIndex = 27;
            this.Kind.Text = "Type:";
            // 
            // comboBox_GroceriesStatus
            // 
            this.comboBox_GroceriesStatus.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_GroceriesStatus.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_GroceriesStatus.FormattingEnabled = true;
            this.comboBox_GroceriesStatus.Items.AddRange(new object[] {
            "Days",
            "Months",
            "Years"});
            this.comboBox_GroceriesStatus.Location = new System.Drawing.Point(69, 98);
            this.comboBox_GroceriesStatus.Name = "comboBox_GroceriesStatus";
            this.comboBox_GroceriesStatus.Size = new System.Drawing.Size(173, 25);
            this.comboBox_GroceriesStatus.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status:";
            // 
            // comboBox_GroceriesKind
            // 
            this.comboBox_GroceriesKind.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_GroceriesKind.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_GroceriesKind.FormattingEnabled = true;
            this.comboBox_GroceriesKind.Items.AddRange(new object[] {
            "Cereal",
            "Vegetable",
            "Meat",
            "Fruit",
            "Cookie",
            "Chips",
            "Sweets",
            "Canned Food"});
            this.comboBox_GroceriesKind.Location = new System.Drawing.Point(69, 132);
            this.comboBox_GroceriesKind.Name = "comboBox_GroceriesKind";
            this.comboBox_GroceriesKind.Size = new System.Drawing.Size(173, 25);
            this.comboBox_GroceriesKind.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Kind:";
            // 
            // UserControl_Groceries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_GroceriesKind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_GroceriesStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_GroceriesType);
            this.Controls.Add(this.Kind);
            this.Controls.Add(this.textBox_GroceriesName);
            this.Controls.Add(this.label3);
            this.Name = "UserControl_Groceries";
            this.Size = new System.Drawing.Size(260, 180);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox_GroceriesName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comboBox_GroceriesType;
        private System.Windows.Forms.Label Kind;
        public System.Windows.Forms.ComboBox comboBox_GroceriesStatus;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox_GroceriesKind;
        private System.Windows.Forms.Label label2;
    }
}
