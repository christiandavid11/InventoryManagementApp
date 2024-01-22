using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BARAQUIL_OOP_FinalProject.Controller;
using BARAQUIL_OOP_FinalProject.View;
using System.Data.OleDb;

namespace BARAQUIL_OOP_FinalProject.Model
{
    class AllChoices
    {
        public bool indicator = false;
        public string[] tempData = new string[12];
        public string[] tempAllData = new string[8];
        public string temp;             //string for getting the table RemoveProduct()
        public string tempRadio;        //RetrieveProduct()
        public string category;
        public OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cdbaraquil\Desktop\projectDB.accdb");
        public OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\cdbaraquil\Desktop\projectDB.accdb");
        public OleDbDataAdapter allAdapt;
        public OleDbDataAdapter catAdapt;
        public DataTable catTable;
        public DataTable allTable;
        public DataSet allData;
        public DataSet catData;
        //public string tempCode;
        public Random code = new Random();
        //public OleDbCommand cmd = con.CreateCommand();
    }
}
