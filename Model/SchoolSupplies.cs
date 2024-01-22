using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class SchoolSupplies : Product
    {
        private string schoolsupplies_Color;
        private string schoolsupplies_Name;
        private string schoolsupplies_PackBy;
        private string schoolsupplies_ForWho;

        public string school_Color
        {
            set { schoolsupplies_Color = value; }
            get { return schoolsupplies_Color; }
        }

        public string school_Name
        {
            set { schoolsupplies_Name = value; }
            get { return schoolsupplies_Name; }
        }

        public string school_Packby
        {
            set { schoolsupplies_PackBy = value; }
            get { return schoolsupplies_PackBy; }
        }

        public string school_Forwho
        {
            set { schoolsupplies_ForWho = value; }
            get { return schoolsupplies_ForWho; }
        }

        //public SchoolSupplies(string name)
        //{
        //    StockCode = Convert.ToString(new Random().Next(100000, 999999));
        //    BrandName = "Staedtler";
        //    Unit = "2.5 mm";
        //    UnitPrice = 20;
        //    Quantity = 500;
        //    Category = "School Supplies";
        //    DateAdded = DateTime.Today.ToString("MM-dd-yyyy");
        //    DateUpdated = "N.A.";
        //    school_Color = "Blue";
        //    school_Name = "Pencil";
        //    school_Packby = "Bundle";
        //    school_Forwho = "Everyone";
        //}
    }
}
