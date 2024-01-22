using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class Appliances : Product
    {
        private string appliance_Color;
        private string appliance_Type;
        private string appliance_Status;
        private string appliance_Deal;

        public string apl_Color
        {
            set { appliance_Color = value; }
            get { return appliance_Color; }
        }

        public string apl_Type
        {
            set { appliance_Type = value; }
            get { return appliance_Type; }
        }

        public string apl_Status
        {
            set { appliance_Status = value; }
            get { return appliance_Status; }
        }

        public string apl_Deal
        {
            set { appliance_Deal = value; }
            get { return appliance_Deal; }
        }

        //public Appliances(string name)
        //{
        //    StockCode = Convert.ToString(new Random().Next(100000, 999999));
        //    BrandName = "Samsung";
        //    Unit = "Refrigerator";
        //    UnitPrice = 100000;
        //    Quantity = 200;
        //    Category = "Appliances";
        //    DateAdded = DateTime.Today.ToString("MM-dd-yyyy");
        //    DateUpdated = "N.A.";
        //    apl_Color = "Blue";
        //    apl_Type = "Smart Refrigerator";
        //    apl_Status = "Brand New";
        //    apl_Deal = "Single Deal";
        //}
    }
}