using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BARAQUIL_OOP_FinalProject.Controller;
using BARAQUIL_OOP_FinalProject.Model;

namespace BARAQUIL_OOP_FinalProject.View
{
    public partial class Form_RemoveProduct : Form
    {
        AllMethodFunction allMethod = new AllMethodFunction();

        public Form_RemoveProduct()
        {
            InitializeComponent();
        }

        private void comboBox_RemoveCategory_TextChanged(object sender, EventArgs e)
        {  
            allMethod.RemoveProduct(comboBox_RemoveCategory.SelectedItem.ToString());
            dataGridView_Remove.DataSource = allMethod.catTable;
        }

        private void dataGridView_Remove_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_RemoveStockcode.Text = Convert.ToString(dataGridView_Remove.CurrentCell);
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView_Remove.Rows[e.RowIndex];
                textBox_RemoveStockcode.Text = row.Cells[0].Value.ToString();
            }
        }

        private void button_RemoveDelete_Click(object sender, EventArgs e)
        {
            allMethod.RetrieveRemove(textBox_RemoveStockcode.Text);
            if (allMethod.indicator == true)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                allMethod.UpdateProduct(textBox_RemoveStockcode.Text,comboBox_RemoveCategory.SelectedItem.ToString());
                allMethod.UpdateAllProducts(textBox_RemoveStockcode.Text);
                allMethod.RemoveProduct(comboBox_RemoveCategory.SelectedItem.ToString());
                dataGridView_Remove.DataSource = allMethod.catTable;
            }
        }

        private void button_RemoveUpdate_Click(object sender, EventArgs e)
        {
            Form_UpdateProduct form_Update = new Form_UpdateProduct();
            form_Update.cat = comboBox_RemoveCategory.SelectedItem.ToString();
            form_Update.cod = textBox_RemoveStockcode.Text;
            form_Update.Show();
        }
    }
}
