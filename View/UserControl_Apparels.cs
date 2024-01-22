using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BARAQUIL_OOP_FinalProject.Controller;
using BARAQUIL_OOP_FinalProject.Model;

namespace BARAQUIL_OOP_FinalProject.View
{
    public partial class UserControl_Apparels : UserControl
    {
        Apparels apparels = new Apparels();

        public UserControl_Apparels()
        {
            InitializeComponent();
        }
    }
}
