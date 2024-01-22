using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class Apparels : Product
    {
        private string apparel_Size;
        private string apparel_Color;
        private string apparel_ForWho;
        private string apparel_Gender;

        public string app_Size
        {
            set { apparel_Size = value; }
            get { return apparel_Size; }
        }

        public string app_Color
        {
            set { apparel_Color = value; }
            get { return apparel_Color; }
        }

        public string app_ForWho
        {
            set { apparel_ForWho = value; }
            get { return apparel_ForWho; }
        }

        public string app_Gender
        {
            set { apparel_Gender = value; }
            get { return apparel_Gender; }
        }

        //public Apparels(string name)
        //{
        //    StockCode = Convert.ToString(new Random().Next(100000, 999999));
        //    BrandName = "Lee Cooper";
        //    Unit = "Shirt";
        //    UnitPrice = 2000;
        //    Quantity = 500;
        //    Category = "Apparels";
        //    DateAdded = DateTime.Today.ToString("MM-dd-yyyy");
        //    DateUpdated = "N.A.";
        //    app_Size = "Medium";
        //    app_Color = "Gray";
        //    app_ForWho = "Adult";
        //    app_Gender = "MALE";
        //}
    }
}
