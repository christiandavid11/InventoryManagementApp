using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class Kitchenwares : Product
    {
        private string kitchenwares_Quality;
        private string kitchenwares_Type;
        private string kitchenwares_Pack;
        private string kitchenwares_Color;

        public string kitchen_Quality
        {
            set { kitchenwares_Quality = value; }
            get { return kitchenwares_Quality; }
        }

        public string kitchen_Type
        {
            set { kitchenwares_Type = value; }
            get { return kitchenwares_Type; }
        }

        public string kitchen_Pack
        {
            set { kitchenwares_Pack = value; }
            get { return kitchenwares_Pack; }
        }

        public string kitchen_Color
        {
            set { kitchenwares_Color = value; }
            get { return kitchenwares_Color; }
        }

        //public Kitchenwares(string name)
        //{
        //    StockCode = Convert.ToString(new Random().Next(100000, 999999));
        //    BrandName = "Gorilla Grip";
        //    Unit = "8 inches";
        //    UnitPrice = 1000;
        //    Quantity = 200;
        //    Category = "Kitchenwares";
        //    DateAdded = DateTime.Today.ToString("MM-dd-yyyy");
        //    DateUpdated = "N.A.";
        //    kitchen_Quality = "Metal";
        //    kitchen_Type = "Knife";
        //    kitchen_Pack = "Bundle";
        //    kitchen_Color = "Single Deal";
        //}
    }
}
