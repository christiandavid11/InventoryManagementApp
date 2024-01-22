using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class Cosmetics : Product
    {
        private string cosmetics_Deal;
        private string cosmetics_Status;
        private string cosmetics_ForWho;
        private string cosmetics_Type;

        public string cos_Deal
        {
            set { cosmetics_Deal = value; }
            get { return cosmetics_Deal; }
        }

        public string cos_Status
        {
            set { cosmetics_Status = value; }
            get { return cosmetics_Status; }
        }

        public string cos_ForWho
        {
            set { cosmetics_ForWho = value; }
            get { return cosmetics_ForWho; }
        }

        public string cos_Type
        {
            set { cosmetics_Type = value; }
            get { return cosmetics_Type; }
        }

        //public Cosmetics(string name)
        //{
        //    StockCode = Convert.ToString(new Random().Next(100000, 999999));
        //    BrandName = "My New York";
        //    Unit = "75 ml";
        //    UnitPrice = 10000;
        //    Quantity = 100;
        //    Category = "Cosmetics";
        //    DateAdded = DateTime.Today.ToString("MM-dd-yyyy");
        //    DateUpdated = "N.A.";
        //    cos_Type = "Perfume";
        //    cos_Status = "Brand New";
        //    cos_ForWho = "MEN";
        //    cos_Deal = "Single Deal";
        //}
    }
}
