using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class Gadgets : Product
    {
        private string gadgets_Manufacturer;
        private string gadgets_Status;
        private string gadgets_Type;
        private string gadgets_Color;

        public string gad_Manu
        {
            set { gadgets_Manufacturer = value; }
            get { return gadgets_Manufacturer; }
        }

        public string gad_Status
        {
            set { gadgets_Status = value; }
            get { return gadgets_Status; }
        }

        public string gad_Type
        {
            set { gadgets_Type = value; }
            get { return gadgets_Type; }
        }

        public string gad_Color
        {
            set { gadgets_Color = value; }
            get { return gadgets_Color; }
        }

        //public Gadgets(string name)
        //{
        //    StockCode = Convert.ToString(new Random().Next(100000, 999999));
        //    BrandName = "Apple";
        //    Unit = "iPhone 9999Pro Max";
        //    UnitPrice = 99999999999;
        //    Quantity = 5;
        //    Category = "Gadgets";
        //    DateAdded = DateTime.Today.ToString("MM-dd-yyyy");
        //    DateUpdated = "N.A.";
        //    gad_Manu = "Hon Hai Precision Industry Co., LTD";
        //    gad_Status = "Brand New";
        //    gad_Color = "White";
        //    gad_Type = "Smartphone";
        //}
    }
}
