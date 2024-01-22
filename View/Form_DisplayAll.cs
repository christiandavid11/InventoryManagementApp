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
    public partial class Form_DisplayAll : Form
    {
        AllMethodFunction allMethod = new AllMethodFunction();

        public Form_DisplayAll()
        {
            InitializeComponent();
        }

        private void Form_DisplayAll_Load(object sender, EventArgs e)
        {
            allMethod.RemoveAllProduct();
            dataGridView_DisplayAll.DataSource = allMethod.allTable;
        }
    }
}
