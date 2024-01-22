using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BARAQUIL_OOP_FinalProject.Model;
using BARAQUIL_OOP_FinalProject.View;
using System.Data.OleDb;

namespace BARAQUIL_OOP_FinalProject.Controller
{
    class AllMethodFunction : AllChoices
    {
        public void AddProduct(string allmethod_StockCode, string allmethod_BrandName, string allmethod_Unit, string allmethod_UnitPrice, string allmethod_Quantity, string allmethod_Category, string allmethod_DateAdded, string allmethod_DateUpdated, string allmethod_First, string allmethod_Second, string allmethod_Third, string allmethod_Fourth)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            tempData[0] = allmethod_StockCode;
            tempData[1] = allmethod_BrandName;
            tempData[2] = allmethod_Unit;
            tempData[3] = allmethod_UnitPrice;
            tempData[4] = allmethod_Quantity;
            tempData[5] = allmethod_Category;
            tempData[6] = allmethod_DateAdded;
            tempData[7] = allmethod_DateUpdated;
            tempData[8] = allmethod_First;
            tempData[9] = allmethod_Second;
            tempData[10] = allmethod_Third;
            tempData[11] = allmethod_Fourth;

            if (tempData[5] == "Apparels")
            {
                cmd.CommandText = "insert into Apparels ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated], [Size], [Color], [ForWho], [Gender]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "','" + tempData[8] + "','" + tempData[9] + "','" + tempData[10] + "','" + tempData[11] + "')";
            }

            else if (tempData[5] == "Appliances")
            {
                cmd.CommandText = "insert into Appliances ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated], [Color], [Type], [Status], [Deal]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "','" + tempData[8] + "','" + tempData[9] + "','" + tempData[10] + "','" + tempData[11] + "')";
            }

            else if (tempData[5] == "Cosmetics")
            {
                cmd.CommandText = "insert into Cosmetics ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated], [Type], [Status], [Gender], [Deal]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "','" + tempData[8] + "','" + tempData[9] + "','" + tempData[10] + "','" + tempData[11] + "')";
            }

            else if (tempData[5] == "Furnitures")
            {
                cmd.CommandText = "insert into Furnitures ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated], [Manufacturer], [Color], [Quality], [Deal]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "','" + tempData[8] + "','" + tempData[9] + "','" + tempData[10] + "','" + tempData[11] + "')";
            }

            else if (tempData[5] == "Gadgets")
            {
                cmd.CommandText = "insert into Gadgets ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated], [Manufacturer], [Status], [Color], [Type]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "','" + tempData[8] + "','" + tempData[9] + "','" + tempData[10] + "','" + tempData[11] + "')";
            }

            else if (tempData[5] == "Groceries")
            {
                cmd.CommandText = "insert into Groceries ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated], [GroceryName], [Type], [Status], [Kind]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "','" + tempData[8] + "','" + tempData[9] + "','" + tempData[10] + "','" + tempData[11] + "')";
            }

            else if (tempData[5] == "Kitchenwares")
            {
                cmd.CommandText = "insert into Kitchenwares ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated], [Quality], [Type], [PackedBy], [Color]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "','" + tempData[8] + "','" + tempData[9] + "','" + tempData[10] + "','" + tempData[11] + "')";
            }

            else if (tempData[5] == "School Supplies")
            {
                cmd.CommandText = "insert into SchoolSupplies ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated], [Color], [ItemName], [PackedBy], [For]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "','" + tempData[8] + "','" + tempData[9] + "','" + tempData[10] + "','" + tempData[11] + "')";
            }

            else if (tempData[5] == "Sports")
            {
                cmd.CommandText = "insert into Sports ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated], [Item], [PackedBy], [Status], [Color]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "','" + tempData[8] + "','" + tempData[9] + "','" + tempData[10] + "','" + tempData[11] + "')";
            }

            else if (tempData[5] == "Toys")
            {
                cmd.CommandText = "insert into Toys ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated], [Item], [Color], [GoodFor], [Status]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "','" + tempData[8] + "','" + tempData[9] + "','" + tempData[10] + "','" + tempData[11] + "')";
            }
            //cmd.CommandText = "insert into AllProducts ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
        }

        public void AddAllProducts(string scode, string bname, string aunit, string uprice, string aquantity, string acategory, string dadded, string dupdated)
        {
            con1.Open();
            OleDbCommand cmd1 = con1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            tempAllData[0] = scode;
            tempAllData[1] = bname;
            tempAllData[2] = aunit;
            tempAllData[3] = uprice;
            tempAllData[4] = aquantity;
            tempAllData[5] = acategory;
            tempAllData[6] = dadded;
            tempAllData[7] = dupdated;
            cmd1.CommandText = "insert into AllProducts ([Stockcode], [BrandName], [Unit], [UnitPrice], [Quantity], [Category], [DateAdded], [DateUpdated]) values('" + tempData[0] + "','" + tempData[1] + "','" + tempData[2] + "','" + tempData[3] + "','" + tempData[4] + "','" + tempData[5] + "','" + tempData[6] + "','" + tempData[7] + "')";
            cmd1.ExecuteNonQuery();
            con1.Close();
            con1.Dispose();
        }

        public void UpdateProduct(string scode, string category)
        {
            con.Open();
            if (category == "Apparels")
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Apparels where Stockcode = '" + scode + "' ";
                cmd.ExecuteNonQuery();
            }

            else if (category == "Appliances")
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Appliances where Stockcode = '" + scode + "' ";
                cmd.ExecuteNonQuery();
            }
            
            else if (category == "Cosmetics")
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Cosmetics where Stockcode = '" + scode + "' ";
                cmd.ExecuteNonQuery();
            }

            else if (category == "Furnitures")
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Furnitures where Stockcode = '" + scode + "' ";
                cmd.ExecuteNonQuery();
            }

            else if (category == "Gadgets")
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Gadgets where Stockcode = '" + scode + "' ";
                cmd.ExecuteNonQuery();
            }

            else if (category == "Groceries")
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Groceries where Stockcode = '" + scode + "' ";
                cmd.ExecuteNonQuery();
            }

            else if (category == "Kitchenwares")
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Kitchenwares where Stockcode = '" + scode + "' ";
                cmd.ExecuteNonQuery();
            }

            else if (category == "SchoolSupplies")
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from SchoolSupplies where Stockcode = '" + scode + "' ";
                cmd.ExecuteNonQuery();
            }

            else if (category == "Sports")
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Sports where Stockcode = '" + scode + "' ";
                cmd.ExecuteNonQuery();
            }

            else if (category == "Toys")
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Toys where Stockcode = '" + scode + "' ";
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        public void UpdateAllProducts(string scode)
        {
            con1.Open();
            OleDbCommand cmd1 = con1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "delete from AllProducts where Stockcode = '" + scode + "' ";
            cmd1.ExecuteNonQuery();
            con1.Close();
        }

        public string RetrieveProduct(string stockcode)
        {
            if (string.IsNullOrEmpty(stockcode))
            {
                indicator = true;
            }
            else
            {
                if (category == "Apparels")
                {
                    con.Open();
                    temp = "select * from Apparels where Stockcode='" + stockcode + "' ";
                    catAdapt = new OleDbDataAdapter(temp, con);
                    catData = new DataSet();
                    catAdapt.Fill(catData);
                    if (catData.Tables[0].Rows.Count >= 1)
                    {
                        indicator = false;
                        tempRadio = catData.Tables[0].Rows[0]["ForWho"].ToString();
                        //tempData[0] = catData.Tables[0].Rows[0]["Stockcode"].ToString();
                        //tempData[1] = catData.Tables[0].Rows[0]["BrandName"].ToString();
                        //tempData[2] = catData.Tables[0].Rows[0]["Unit"].ToString();
                        //tempData[3] = catData.Tables[0].Rows[0]["UnitPrice"].ToString();
                        //tempData[4] = catData.Tables[0].Rows[0]["Quantity"].ToString();
                        //tempData[5] = catData.Tables[0].Rows[0]["Category"].ToString();
                        //tempData[6] = catData.Tables[0].Rows[0]["DateAdded"].ToString();
                        //tempData[7] = catData.Tables[0].Rows[0]["DateUpdated"].ToString();
                        //tempData[8] = catData.Tables[0].Rows[0]["Size"].ToString();
                        //tempData[9] = catData.Tables[0].Rows[0]["Color"].ToString();
                        //tempData[10] = catData.Tables[0].Rows[0]["ForWho"].ToString();
                        //tempData[11] = catData.Tables[0].Rows[0]["Gender"].ToString();
                    }
                    else
                    {
                        indicator = true;
                    }
                    con.Close();
                }

                else if (category == "Appliances")
                {
                    con.Open();
                    temp = "select * from Appliances where Stockcode='" + stockcode + "' ";
                    catAdapt = new OleDbDataAdapter(temp, con);
                    catData = new DataSet();
                    catAdapt.Fill(catData);
                    if (catData.Tables[0].Rows.Count >= 1)
                    {
                        indicator = false;
                        tempRadio = catData.Tables[0].Rows[0]["Deal"].ToString();
                    }
                    else
                    {
                        indicator = true;
                    }
                    con.Close();
                }

                else if (category == "Cosmetics")
                {
                    con.Open();
                    temp = "select * from Cosmetics where Stockcode='" + stockcode + "' ";
                    catAdapt = new OleDbDataAdapter(temp, con);
                    catData = new DataSet();
                    catAdapt.Fill(catData);
                    if (catData.Tables[0].Rows.Count >= 1)
                    {
                        indicator = false;
                        tempRadio = catData.Tables[0].Rows[0]["Deal"].ToString();
                    }
                    else
                    {
                        indicator = true;
                    }
                    con.Close();
                }

                else if (category == "Furnitures")
                {
                    con.Open();
                    temp = "select * from Furniture where Stockcode='" + stockcode + "' ";
                    catAdapt = new OleDbDataAdapter(temp, con);
                    catData = new DataSet();
                    catAdapt.Fill(catData);
                    if (catData.Tables[0].Rows.Count >= 1)
                    {
                        indicator = false;
                        tempRadio = catData.Tables[0].Rows[0]["Deal"].ToString();
                    }
                    else
                    {
                        indicator = true;
                    }
                    con.Close();
                }

                else if (category == "Gadgets")
                {
                    con.Open();
                    temp = "select * from Gadgets where Stockcode='" + stockcode + "' ";
                    catAdapt = new OleDbDataAdapter(temp, con);
                    catData = new DataSet();
                    catAdapt.Fill(catData);
                    if (catData.Tables[0].Rows.Count >= 1)
                    {
                        indicator = false;
                    }
                    else
                    {
                        indicator = true;
                    }
                }

                else if (category == "Groceries")
                {
                    con.Open();
                    temp = "select * from Groceries where Stockcode='" + stockcode + "' ";
                    catAdapt = new OleDbDataAdapter(temp, con);
                    catData = new DataSet();
                    catAdapt.Fill(catData);
                    if (catData.Tables[0].Rows.Count >= 1)
                    {
                        indicator = false;
                    }
                    else
                    {
                        indicator = true;
                    }
                    con.Close();
                }

                else if (category == "Kitchenwares")
                {
                    con.Open();
                    temp = "select * from Kitchenwares where Stockcode='" + stockcode + "' ";
                    catAdapt = new OleDbDataAdapter(temp, con);
                    catData = new DataSet();
                    catAdapt.Fill(catData);
                    if (catData.Tables[0].Rows.Count >= 1)
                    {
                        indicator = false;
                    }
                    else
                    {
                        indicator = true;
                    }
                    con.Close();
                }

                else if (category == "School Supplies")
                {
                    con.Open();
                    temp = "select * from SchoolSupplies where Stockcode='" + stockcode + "' ";
                    catAdapt = new OleDbDataAdapter(temp, con);
                    catData = new DataSet();
                    catAdapt.Fill(catData);
                    if (catData.Tables[0].Rows.Count >= 1)
                    {
                        indicator = false;
                    }
                    else
                    {
                        indicator = true;
                    }
                    con.Close();
                }

                else if (category == "Sports")
                {
                    con.Open();
                    temp = "select * from Sports where Stockcode='" + stockcode + "' ";
                    catAdapt = new OleDbDataAdapter(temp, con);
                    catData = new DataSet();
                    catAdapt.Fill(catData);
                    if (catData.Tables[0].Rows.Count >= 1)
                    {
                        indicator = false;
                    }
                    else
                    {
                        indicator = true;
                    }
                    con.Close();
                }

                else if (category == "Toys")
                {
                    con.Open();
                    temp = "select * from Toys where Stockcode='" + stockcode + "' ";
                    catAdapt = new OleDbDataAdapter(temp, con);
                    catData = new DataSet();
                    catAdapt.Fill(catData);
                    if (catData.Tables[0].Rows.Count >= 1)
                    {
                        indicator = false;
                    }
                    else
                    {
                        indicator = true;
                    }
                    con.Close();
                }
            }
            return stockcode;
        }

        public void RemoveProduct(string cat)
        {
            con.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = con;

            if (cat == "Apparels")
            {
                temp = "select * from Apparels";
                cmd.CommandText = temp;
                catAdapt = new OleDbDataAdapter(cmd);
                catTable = new DataTable();
                catAdapt.Fill(catTable);
            }

            else if (cat == "Appliances")
            {
                temp = "select * from Appliances";
                cmd.CommandText = temp;
                catAdapt = new OleDbDataAdapter(cmd);
                catTable = new DataTable();
                catAdapt.Fill(catTable);
            }

            else if (cat == "Cosmetics")
            {
                temp = "select * from Cosmetics";
                cmd.CommandText = temp;
                catAdapt = new OleDbDataAdapter(cmd);
                catTable = new DataTable();
                catAdapt.Fill(catTable);
            }

            else if (cat == "Furnitures")
            {
                temp = "select * from Furnitures";
                cmd.CommandText = temp;
                catAdapt = new OleDbDataAdapter(cmd);
                catTable = new DataTable();
                catAdapt.Fill(catTable);
            }

            else if (cat == "Gadgets")
            {
                temp = "select * from Gadgets";
                cmd.CommandText = temp;
                catAdapt = new OleDbDataAdapter(cmd);
                catTable = new DataTable();
                catAdapt.Fill(catTable);
            }

            else if (cat == "Groceries")
            {
                temp = "select * from Groceries";
                cmd.CommandText = temp;
                catAdapt = new OleDbDataAdapter(cmd);
                catTable = new DataTable();
                catAdapt.Fill(catTable);
            }

            else if (cat == "Kitchenwares")
            {
                temp = "select * from Kitchenwares";
                cmd.CommandText = temp;
                catAdapt = new OleDbDataAdapter(cmd);
                catTable = new DataTable();
                catAdapt.Fill(catTable);
            }

            else if (cat == "School Supplies")
            {
                temp = "select * from SchoolSupplies";
                cmd.CommandText = temp;
                catAdapt = new OleDbDataAdapter(cmd);
                catTable = new DataTable();
                catAdapt.Fill(catTable);
            }

            else if (cat == "Sports")
            {
                temp = "select * from Sports";
                cmd.CommandText = temp;
                catAdapt = new OleDbDataAdapter(cmd);
                catTable = new DataTable();
                catAdapt.Fill(catTable);
            }

            else if (cat == "Toys")
            {
                temp = "select * from Toys";
                cmd.CommandText = temp;
                catAdapt = new OleDbDataAdapter(cmd);
                catTable = new DataTable();
                catAdapt.Fill(catTable);

            }
            con.Close();
        }

        public void RemoveAllProduct()
        {
            con1.Open();
            OleDbCommand cmd1 = new OleDbCommand();
            cmd1.Connection = con1;
            temp = "select * from AllProducts";
            cmd1.CommandText = temp;
            allAdapt = new OleDbDataAdapter(cmd1);
            allTable = new DataTable();
            allAdapt.Fill(allTable);
        }

        public void RetrieveRemove(string code)
        {
            if (string.IsNullOrEmpty(code))
            {
                indicator = true;
            }
            else
            {
                indicator = false;
            }
        }
    }
}
