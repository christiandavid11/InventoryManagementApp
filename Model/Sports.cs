using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class Sports : Product
    {
        private string sports_Item;
        private string sports_Packby;
        private string sports_Status;
        private string sports_Color;

        public string spo_What
        {
            set { sports_Item = value; }
            get { return sports_Item; }
        }

        public string spo_Packby
        {
            set { sports_Packby = value; }
            get { return sports_Packby; }
        }

        public string spo_Status
        {
            set { sports_Status = value; }
            get { return sports_Status; }
        }

        public string spo_Color
        {
            set { sports_Color = value; }
            get { return sports_Color; }
        }

        //public Sports(string name)
        //{
        //    StockCode = Convert.ToString(new Random().Next(100000, 999999));
        //    BrandName = "Spalding";
        //    Unit = "20 ounce";
        //    UnitPrice = 2000;
        //    Quantity = 500;
        //    Category = "Sports";
        //    DateAdded = DateTime.Today.ToString("MM-dd-yyyy");
        //    DateUpdated = "N.A.";
        //    spo_What = "Ball";
        //    spo_Packby = "Single";
        //    spo_Status = "Brand New";
        //    spo_Color = "Brown";
        //}
    }
}
