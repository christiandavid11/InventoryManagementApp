namespace BARAQUIL_OOP_FinalProject.View
{
    partial class Form_DisplayAll
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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView_DisplayAll = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DisplayAll)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 21);
            this.label8.TabIndex = 53;
            this.label8.Text = "DISPLAY ALL PRODUCTS";
            // 
            // dataGridView_DisplayAll
            // 
            this.dataGridView_DisplayAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DisplayAll.Location = new System.Drawing.Point(12, 46);
            this.dataGridView_DisplayAll.Name = "dataGridView_DisplayAll";
            this.dataGridView_DisplayAll.ReadOnly = true;
            this.dataGridView_DisplayAll.Size = new System.Drawing.Size(844, 280);
            this.dataGridView_DisplayAll.TabIndex = 54;
            // 
            // Form_DisplayAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 338);
            this.Controls.Add(this.dataGridView_DisplayAll);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_DisplayAll";
            this.Text = "SSIMS (Display All Products)";
            this.Load += new System.EventHandler(this.Form_DisplayAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DisplayAll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView_DisplayAll;
    }
}