namespace BARAQUIL_OOP_FinalProject.View
{
    partial class Form_DisplayCategory
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
            this.dataGridView_DisplayCat = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_DisplayCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DisplayCat)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_DisplayCat
            // 
            this.dataGridView_DisplayCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DisplayCat.Location = new System.Drawing.Point(12, 78);
            this.dataGridView_DisplayCat.Name = "dataGridView_DisplayCat";
            this.dataGridView_DisplayCat.ReadOnly = true;
            this.dataGridView_DisplayCat.Size = new System.Drawing.Size(895, 221);
            this.dataGridView_DisplayCat.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(294, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(318, 21);
            this.label8.TabIndex = 54;
            this.label8.Text = "DISPLAY  ALL PRODUCTS BY CATEGORY";
            // 
            // comboBox_DisplayCategory
            // 
            this.comboBox_DisplayCategory.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_DisplayCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_DisplayCategory.FormattingEnabled = true;
            this.comboBox_DisplayCategory.Items.AddRange(new object[] {
            "Apparels",
            "Appliances",
            "Cosmetics",
            "Furnitures",
            "Gadgets",
            "Groceries",
            "Kitchenwares",
            "School Supplies",
            "Sports",
            "Toys"});
            this.comboBox_DisplayCategory.Location = new System.Drawing.Point(390, 47);
            this.comboBox_DisplayCategory.Name = "comboBox_DisplayCategory";
            this.comboBox_DisplayCategory.Size = new System.Drawing.Size(165, 25);
            this.comboBox_DisplayCategory.TabIndex = 56;
            this.comboBox_DisplayCategory.TextChanged += new System.EventHandler(this.comboBox_DisplayCategory_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 55;
            this.label1.Text = "Category:";
            // 
            // Form_DisplayCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 311);
            this.Controls.Add(this.comboBox_DisplayCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView_DisplayCat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_DisplayCategory";
            this.Text = "SSIMS (Display By Category)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DisplayCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DisplayCat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_DisplayCategory;
        private System.Windows.Forms.Label label1;
    }
}