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
    public partial class Form_DisplayCategory : Form
    {
        AllMethodFunction allMethod = new AllMethodFunction();

        public Form_DisplayCategory()
        {
            InitializeComponent();
        }

        private void comboBox_DisplayCategory_TextChanged(object sender, EventArgs e)
        {
            allMethod.RemoveProduct(comboBox_DisplayCategory.SelectedItem.ToString());
            dataGridView_DisplayCat.DataSource = allMethod.catTable;
        }
    }
}
