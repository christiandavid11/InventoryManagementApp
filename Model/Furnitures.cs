using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class Furnitures : Product
    {
        private string furnitures_Manufacturer;
        private string furnitures_Color;
        private string furnitures_Quality;
        private string furnitures_Deal;

        public string fur_Manu
        {
            set { furnitures_Manufacturer = value; }
            get { return furnitures_Manufacturer; }
        }

        public string fur_Color
        {
            set { furnitures_Color = value; }
            get { return furnitures_Color; }
        }

        public string fur_Quality
        {
            set { furnitures_Quality = value; }
            get { return furnitures_Quality; }
        }
        
        public string fur_Deal
        {
            set { furnitures_Deal = value; }
            get { return furnitures_Deal; }
        }

        //public Furnitures(string name)
        //{
        //    StockCode = Convert.ToString(new Random().Next(100000, 999999));
        //    BrandName = "Vermont Woods Studio";
        //    Unit = "Sofa";
        //    UnitPrice = 50000;
        //    Quantity = 200;
        //    Category = "Furnitures";
        //    DateAdded = DateTime.Today.ToString("MM-dd-yyyy");
        //    DateUpdated = "N.A.";
        //    fur_Manu = "Vermont Woods Studio";
        //    fur_Color = "Brown";
        //    fur_Quality = "Wood";
        //    fur_Deal = "Single Deal";
        //}
    }
}
