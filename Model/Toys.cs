using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class Toys : Product
    {
        private string toys_Item;
        private string toys_Color;
        private string toys_Forwho;
        private string toys_Status;

        public string toy_Item
        {
            set { toys_Item = value; }
            get { return toys_Item; }
        }

        public string toy_Color
        {
            set { toys_Color = value; }
            get { return toys_Color; }
        }

        public string toy_Forwho
        {
            set { toys_Forwho = value; }
            get { return toys_Forwho; }
        }

        public string toy_Status
        {
            set { toys_Status = value; }
            get { return toys_Status; }
        }

        //public Toys(string name)
        //{
        //    StockCode = Convert.ToString(new Random().Next(100000, 999999));
        //    BrandName = "Lego";
        //    Unit = "7541 pieces";
        //    UnitPrice = 2500;
        //    Quantity = 500;
        //    Category = "Toys";
        //    DateAdded = DateTime.Today.ToString("MM-dd-yyyy");
        //    DateUpdated = "N.A.";
        //    toy_Item = "Lego Star Wars";
        //    toy_Color = "White";
        //    toy_Forwho = "7 years older";
        //    toy_Status = "Month/s Older";
        //}
    }
}
