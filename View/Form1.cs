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
using BARAQUIL_OOP_FinalProject.View;

namespace BARAQUIL_OOP_FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_AddProduct_Click(object sender, EventArgs e)
        {
            Form_AddProduct form_AddProduct = new Form_AddProduct();
            form_AddProduct.Show();
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            Form_RemoveProduct form_RemoveProduct = new Form_RemoveProduct();
            form_RemoveProduct.Show();
        }

        private void button_DisplayAll_Click(object sender, EventArgs e)
        {
            Form_DisplayAll form_DisplayAll = new Form_DisplayAll();
            form_DisplayAll.Show();
        }

        private void button_DisplayCategory_Click(object sender, EventArgs e)
        {
            Form_DisplayCategory form_DisplayCat = new Form_DisplayCategory();
            form_DisplayCat.Show();
        }
    }
}
