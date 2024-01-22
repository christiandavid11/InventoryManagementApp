using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class Product
    {
        private string product_StockCode;
        private string product_BrandName;
        private string product_Unit;
        private double product_UnitPrice;
        private int product_Quantity;
        private string product_Category;
        private string product_DateAdded;
        private string product_DateUpdated;
        public string allData;

        public string StockCode
        {
            set { product_StockCode = value; }
            get { return product_StockCode; }
        }

        public string BrandName
        {
            set { product_BrandName = value; }
            get { return product_BrandName; }
        }

        public string Unit
        {
            set { product_Unit = value; }
            get { return product_Unit; }
        }

        public double UnitPrice
        {
            set { product_UnitPrice = value; }
            get { return product_UnitPrice; }
        }

        public int Quantity
        {
            set { product_Quantity = value; }
            get { return product_Quantity; }
        }

        public string Category
        {
            set { product_Category = value; }
            get { return product_Category; }
        }

        public string DateAdded
        {
            set { product_DateAdded = value; }
            get { return product_DateAdded; }
        }

        public string DateUpdated
        {
            set { product_DateUpdated = value; }
            get { return product_DateUpdated; }
        }
    }
}
