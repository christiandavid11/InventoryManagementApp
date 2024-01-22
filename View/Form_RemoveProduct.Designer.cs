namespace BARAQUIL_OOP_FinalProject.View
{
    partial class Form_RemoveProduct
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
            this.comboBox_RemoveCategory = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_Remove = new System.Windows.Forms.DataGridView();
            this.button_RemoveDelete = new System.Windows.Forms.Button();
            this.textBox_RemoveStockcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_RemoveUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Remove)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_RemoveCategory
            // 
            this.comboBox_RemoveCategory.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_RemoveCategory.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_RemoveCategory.FormattingEnabled = true;
            this.comboBox_RemoveCategory.Items.AddRange(new object[] {
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
            this.comboBox_RemoveCategory.Location = new System.Drawing.Point(100, 12);
            this.comboBox_RemoveCategory.Name = "comboBox_RemoveCategory";
            this.comboBox_RemoveCategory.Size = new System.Drawing.Size(165, 25);
            this.comboBox_RemoveCategory.TabIndex = 53;
            this.comboBox_RemoveCategory.TextChanged += new System.EventHandler(this.comboBox_RemoveCategory_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 19);
            this.label8.TabIndex = 52;
            this.label8.Text = "Category:";
            // 
            // dataGridView_Remove
            // 
            this.dataGridView_Remove.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Remove.Location = new System.Drawing.Point(12, 50);
            this.dataGridView_Remove.Name = "dataGridView_Remove";
            this.dataGridView_Remove.ReadOnly = true;
            this.dataGridView_Remove.Size = new System.Drawing.Size(895, 208);
            this.dataGridView_Remove.TabIndex = 54;
            this.dataGridView_Remove.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Remove_CellClick);
            // 
            // button_RemoveDelete
            // 
            this.button_RemoveDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_RemoveDelete.FlatAppearance.BorderSize = 0;
            this.button_RemoveDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveDelete.Location = new System.Drawing.Point(611, 264);
            this.button_RemoveDelete.Name = "button_RemoveDelete";
            this.button_RemoveDelete.Size = new System.Drawing.Size(81, 33);
            this.button_RemoveDelete.TabIndex = 55;
            this.button_RemoveDelete.Text = "Delete";
            this.button_RemoveDelete.UseVisualStyleBackColor = false;
            this.button_RemoveDelete.Click += new System.EventHandler(this.button_RemoveDelete_Click);
            // 
            // textBox_RemoveStockcode
            // 
            this.textBox_RemoveStockcode.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RemoveStockcode.Location = new System.Drawing.Point(611, 15);
            this.textBox_RemoveStockcode.Name = "textBox_RemoveStockcode";
            this.textBox_RemoveStockcode.ReadOnly = true;
            this.textBox_RemoveStockcode.Size = new System.Drawing.Size(165, 24);
            this.textBox_RemoveStockcode.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 56;
            this.label1.Text = "Stockcode:";
            // 
            // button_RemoveUpdate
            // 
            this.button_RemoveUpdate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_RemoveUpdate.FlatAppearance.BorderSize = 0;
            this.button_RemoveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_RemoveUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RemoveUpdate.Location = new System.Drawing.Point(256, 264);
            this.button_RemoveUpdate.Name = "button_RemoveUpdate";
            this.button_RemoveUpdate.Size = new System.Drawing.Size(81, 33);
            this.button_RemoveUpdate.TabIndex = 58;
            this.button_RemoveUpdate.Text = "Update";
            this.button_RemoveUpdate.UseVisualStyleBackColor = false;
            this.button_RemoveUpdate.Click += new System.EventHandler(this.button_RemoveUpdate_Click);
            // 
            // Form_RemoveProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 303);
            this.Controls.Add(this.button_RemoveUpdate);
            this.Controls.Add(this.textBox_RemoveStockcode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_RemoveDelete);
            this.Controls.Add(this.dataGridView_Remove);
            this.Controls.Add(this.comboBox_RemoveCategory);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_RemoveProduct";
            this.Text = "SSIMS (Remove Product)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Remove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_RemoveCategory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_Remove;
        private System.Windows.Forms.Button button_RemoveDelete;
        private System.Windows.Forms.TextBox textBox_RemoveStockcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_RemoveUpdate;
    }
}