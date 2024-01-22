using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class Groceries : Product
    {
        private string groceries_Type;
        private string groceries_Name;
        private string groceries_Status;
        private string groceries_Kind;

        public string gro_Type
        {
            set { groceries_Type = value; }
            get { return groceries_Type; }
        }

        public string gro_Name
        {
            set { groceries_Name = value; }
            get { return groceries_Name; }
        }

        public string gro_Status
        {
            set { groceries_Status = value; }
            get { return groceries_Status; }
        }

        public string gro_Kind
        {
            set { groceries_Kind = value; }
            get { return groceries_Kind; }
        }

        //public Groceries(string name)
        //{
        //    StockCode = Convert.ToString(new Random().Next(100000, 999999));
        //    BrandName = "Nestle";
        //    Unit = "170 grams";
        //    UnitPrice = 120;
        //    Quantity = 500;
        //    Category = "Groceries";
        //    DateAdded = DateTime.Today.ToString("MM-dd-yyyy");
        //    DateUpdated = "N.A.";
        //    gro_Name = "Koko Kruch";
        //    gro_Type = "Ready To Eat";
        //    gro_Status = "White";
        //    gro_Kind = "Cereal";
        //}
    }
}
