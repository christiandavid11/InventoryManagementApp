using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BARAQUIL_OOP_FinalProject.Controller;
using BARAQUIL_OOP_FinalProject.Model;

namespace BARAQUIL_OOP_FinalProject.View
{
    public partial class Form_UpdateProduct : Form
    {
        AllMethodFunction allMethod = new AllMethodFunction();
        public string cat;
        public string cod;
        UserControl_Apparels _Apparels = new UserControl_Apparels();
        UserControl_Appliances _Appliances = new UserControl_Appliances();
        UserControl_Cosmetics _Cosmetics = new UserControl_Cosmetics();
        UserControl_Furnitures _Furnitures = new UserControl_Furnitures();
        UserControl_Gadgets _Gadgets = new UserControl_Gadgets();
        UserControl_Groceries _Groceries = new UserControl_Groceries();
        UserControl_Kitchenwares _Kitchen = new UserControl_Kitchenwares();
        UserControl_SchoolSupplies _School = new UserControl_SchoolSupplies();
        UserControl_Sports _Sports = new UserControl_Sports();
        UserControl_Toys _Toys = new UserControl_Toys();

        public Form_UpdateProduct()
        {
            InitializeComponent();
            textBox_UpdateStockCode.Text = cod;
            comboBox_UpdateCategory.Text = cat;
        } 
        
        private void Form_UpdateProduct_Load(object sender, EventArgs e)
        {
            textBox_UpdateStockCode.Text = cod;
            comboBox_UpdateCategory.Text = cat;
            if (comboBox_UpdateCategory.SelectedItem.ToString() == "Apparels")
            {
                panel_UpdateContainer.Controls.Add(_Apparels);
                _Apparels.Dock = DockStyle.Fill;
                _Apparels.BringToFront();
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Appliances")
            {
                panel_UpdateContainer.Controls.Add(_Appliances);
                _Appliances.Dock = DockStyle.Fill;
                _Appliances.BringToFront();
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Cosmetics")
            {
                panel_UpdateContainer.Controls.Add(_Cosmetics);
                _Cosmetics.Dock = DockStyle.Fill;
                _Cosmetics.BringToFront();
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Furnitures")
            {
                panel_UpdateContainer.Controls.Add(_Furnitures);
                _Furnitures.Dock = DockStyle.Fill;
                _Furnitures.BringToFront();
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Gadgets")
            {
                panel_UpdateContainer.Controls.Add(_Gadgets);
                _Gadgets.Dock = DockStyle.Fill;
                _Gadgets.BringToFront();
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Groceries")
            {
                panel_UpdateContainer.Controls.Add(_Groceries);
                _Groceries.Dock = DockStyle.Fill;
                _Groceries.BringToFront();
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Kitchenwares")
            {
                panel_UpdateContainer.Controls.Add(_Kitchen);
                _Kitchen.Dock = DockStyle.Fill;
                _Kitchen.BringToFront();
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "School Supplies")
            {
                panel_UpdateContainer.Controls.Add(_School);
                _School.Dock = DockStyle.Fill;
                _School.BringToFront();
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Sports")
            {
                panel_UpdateContainer.Controls.Add(_Sports);
                _Sports.Dock = DockStyle.Fill;
                _Sports.BringToFront();
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Toys")
            {
                panel_UpdateContainer.Controls.Add(_Toys);
                _Toys.Dock = DockStyle.Fill;
                _Toys.BringToFront();
            }
            allMethod.category = comboBox_UpdateCategory.SelectedItem.ToString();
        }

        private void button_UpdateRetrieve_Click(object sender, EventArgs e)
        {
            comboBox_UpdateCategory.Enabled = false;
            allMethod.RetrieveProduct(textBox_UpdateStockCode.Text);
            if (allMethod.indicator == true)
            {
                MessageBox.Show("No Data Found");
            }
            else
            {
                textBox_UpdateUnit.ReadOnly = false;
                textBox_UpdateUnitPrice.ReadOnly = false;
                textBox_UpdateQuantity.ReadOnly = false;

                textBox_UpdateBrandName.Text = allMethod.catData.Tables[0].Rows[0]["BrandName"].ToString();
                textBox_UpdateUnit.Text = allMethod.catData.Tables[0].Rows[0]["Unit"].ToString();
                textBox_UpdateUnitPrice.Text = allMethod.catData.Tables[0].Rows[0]["UnitPrice"].ToString();
                textBox_UpdateQuantity.Text = allMethod.catData.Tables[0].Rows[0]["Quantity"].ToString();
                textBox_UpdateDateAdded.Text = allMethod.catData.Tables[0].Rows[0]["DateAdded"].ToString();
                textBox_UpdateDateUpdated.Text = allMethod.catData.Tables[0].Rows[0]["DateUpdated"].ToString();

                if (comboBox_UpdateCategory.SelectedItem.ToString() == "Apparels")
                {
                    _Apparels.comboBox_ApparelSize.Text = allMethod.catData.Tables[0].Rows[0]["Size"].ToString();
                    _Apparels.textBox_ApparelColor.Text = allMethod.catData.Tables[0].Rows[0]["Color"].ToString();
                    if (allMethod.tempRadio == _Apparels.radioButton_Baby.Text)
                    {
                        _Apparels.radioButton_Baby.Checked = true;
                    }
                    
                    else if (allMethod.tempRadio == _Apparels.radioButton_Kids.Text)
                    {
                        _Apparels.radioButton_Kids.Checked = true;
                    }

                    else if (allMethod.tempRadio == _Apparels.radioButton_Adult.Text)
                    {
                        _Apparels.radioButton_Adult.Checked = true;
                    }
                    _Apparels.comboBox_ApparelGender.Text = allMethod.catData.Tables[0].Rows[0]["Gender"].ToString();
                }

                else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Appliances")
                {
                    _Appliances.textBox_ApplianceColor.Text = allMethod.catData.Tables[0].Rows[0]["Color"].ToString();
                    _Appliances.textBox_AppliancesType.Text = allMethod.catData.Tables[0].Rows[0]["Type"].ToString();
                    _Appliances.comboBox_ApplianceStatus.Text = allMethod.catData.Tables[0].Rows[0]["Status"].ToString();
                    if (allMethod.tempRadio == _Appliances.radioButton_ApplianceDeal.Text)
                    {
                        _Appliances.radioButton_ApplianceDeal.Checked = true;
                    }

                    else if (allMethod.tempRadio == _Appliances.radioButton_ApplianceSDeal.Text)
                    {
                        _Appliances.radioButton_ApplianceSDeal.Checked = true;
                    }
                }

                else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Cosmetics")
                {
                    _Cosmetics.textBox_CosmeticsType.Text = allMethod.catData.Tables[0].Rows[0]["Type"].ToString();
                    _Cosmetics.comboBox_CosmeticsStatus.Text = allMethod.catData.Tables[0].Rows[0]["Status"].ToString();
                    _Cosmetics.comboBox_CosmeticslGender.Text = allMethod.catData.Tables[0].Rows[0]["Gender"].ToString();
                    if (allMethod.tempRadio == _Cosmetics.radioButton_CosmeticsPDeal.Text)
                    {
                        _Cosmetics.radioButton_CosmeticsPDeal.Checked = true;
                    }

                    else if (allMethod.tempRadio == _Cosmetics.radioButton_CosmeticsSDeal.Text)
                    {
                        _Cosmetics.radioButton_CosmeticsSDeal.Checked = true;
                    }
                }

                else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Furnitures")
                {
                    _Furnitures.textBox_FurnituresManu.Text = allMethod.catData.Tables[0].Rows[0]["Manufacturer"].ToString();
                    _Furnitures.textBox_FurnituresColor.Text = allMethod.catData.Tables[0].Rows[0]["Color"].ToString();
                    _Furnitures.textBox_FurnituresQuality.Text = allMethod.catData.Tables[0].Rows[0]["Quality"].ToString();
                    if (allMethod.tempRadio == _Cosmetics.radioButton_CosmeticsPDeal.Text)
                    {
                        _Furnitures.radioButton_FurnituresPDeal.Checked = true;
                    }

                    else if (allMethod.tempRadio == _Cosmetics.radioButton_CosmeticsSDeal.Text)
                    {
                        _Furnitures.radioButton_FurnituresSDeal.Checked = true;
                    }
                }

                else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Gadgets")
                {
                    _Gadgets.textBox_GadgetsManu.Text = allMethod.catData.Tables[0].Rows[0]["Manufacturer"].ToString();
                    _Gadgets.comboBox_GadgetsStatus.Text = allMethod.catData.Tables[0].Rows[0]["Status"].ToString();
                    _Gadgets.textBox_GadgetsColor.Text = allMethod.catData.Tables[0].Rows[0]["Color"].ToString();
                    _Gadgets.textBox_GadgetsType.Text = allMethod.catData.Tables[0].Rows[0]["Type"].ToString();
                }

                else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Groceries")
                {
                    _Groceries.textBox_GroceriesName.Text = allMethod.catData.Tables[0].Rows[0]["GroceryName"].ToString();
                    _Groceries.comboBox_GroceriesType.Text = allMethod.catData.Tables[0].Rows[0]["Type"].ToString();
                    _Groceries.comboBox_GroceriesStatus.Text = allMethod.catData.Tables[0].Rows[0]["Status"].ToString();
                    _Groceries.comboBox_GroceriesKind.Text = allMethod.catData.Tables[0].Rows[0]["Kind"].ToString();
                }

                else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Kitchenwares")
                {
                    _Kitchen.comboBox_KitchenQuality.Text = allMethod.catData.Tables[0].Rows[0]["Quality"].ToString();
                    _Kitchen.textBox_KitchenType.Text = allMethod.catData.Tables[0].Rows[0]["Type"].ToString();
                    _Kitchen.comboBox_KitchenPackby.Text = allMethod.catData.Tables[0].Rows[0]["PackedBy"].ToString();
                    _Kitchen.textBox_KitchenColor.Text = allMethod.catData.Tables[0].Rows[0]["Color"].ToString();
                }

                else if (comboBox_UpdateCategory.SelectedItem.ToString() == "School Supplies")
                {
                    _School.textBox_SchoolColor.Text = allMethod.catData.Tables[0].Rows[0]["Color"].ToString();
                    _School.textBox_SchoolName.Text = allMethod.catData.Tables[0].Rows[0]["ItemName"].ToString();
                    _School.comboBox_SchoolPackby.Text = allMethod.catData.Tables[0].Rows[0]["PackedBy"].ToString();
                    _School.comboBox_SchoolForwho.Text = allMethod.catData.Tables[0].Rows[0]["For"].ToString();
                }

                else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Sports")
                {
                    _Sports.textBox_SportsItem.Text = allMethod.catData.Tables[0].Rows[0]["Item"].ToString();
                    _Sports.comboBox_SportsPackby.Text = allMethod.catData.Tables[0].Rows[0]["PackedBy"].ToString();
                    _Sports.comboBox_SportsStatus.Text = allMethod.catData.Tables[0].Rows[0]["Status"].ToString();
                    _Sports.textBox_SportsColor.Text = allMethod.catData.Tables[0].Rows[0]["Color"].ToString();
                }

                else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Toys")
                {
                    _Toys.textBox_ToysItem.Text = allMethod.catData.Tables[0].Rows[0]["Item"].ToString();
                    _Toys.textBox_ToysColor.Text = allMethod.catData.Tables[0].Rows[0]["Color"].ToString();
                    _Toys.comboBox_ToysForwho.Text = allMethod.catData.Tables[0].Rows[0]["GoodFor"].ToString();
                    _Toys.comboBox_ToysStatus.Text = allMethod.catData.Tables[0].Rows[0]["Status"].ToString();
                }
                button_UpdateUpdate.Enabled = true;
            }
        }

        private void button_UpdateUpdate_Click(object sender, EventArgs e)
        {
            allMethod.UpdateProduct(textBox_UpdateStockCode.Text, comboBox_UpdateCategory.SelectedItem.ToString());
            allMethod.UpdateAllProducts(textBox_UpdateStockCode.Text);
            textBox_UpdateDateUpdated.Text = DateTime.Today.ToString("MM-dd-yyyy");
            if (comboBox_UpdateCategory.SelectedItem.ToString() == "Apparels")
            {
                if (_Apparels.radioButton_Baby.Checked)
                {
                    allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Apparels.comboBox_ApparelSize.SelectedItem.ToString(), _Apparels.textBox_ApparelColor.Text, _Apparels.radioButton_Baby.Text, _Apparels.comboBox_ApparelGender.SelectedItem.ToString());
                }
                else if (_Apparels.radioButton_Kids.Checked)
                {
                    allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Apparels.comboBox_ApparelSize.SelectedItem.ToString(), _Apparels.textBox_ApparelColor.Text, _Apparels.radioButton_Kids.Text, _Apparels.comboBox_ApparelGender.SelectedItem.ToString());
                }
                else if (_Apparels.radioButton_Adult.Checked)
                {
                    allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Apparels.comboBox_ApparelSize.SelectedItem.ToString(), _Apparels.textBox_ApparelColor.Text, _Apparels.radioButton_Adult.Text, _Apparels.comboBox_ApparelGender.SelectedItem.ToString());
                }
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Appliances")
            {
                if (_Appliances.radioButton_ApplianceDeal.Checked)
                {
                    allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Appliances.textBox_ApplianceColor.Text, _Appliances.textBox_AppliancesType.Text, _Appliances.comboBox_ApplianceStatus.SelectedItem.ToString(), _Appliances.radioButton_ApplianceDeal.Text);
                }
                else if (_Appliances.radioButton_ApplianceSDeal.Checked)
                {
                    allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Appliances.textBox_ApplianceColor.Text, _Appliances.textBox_AppliancesType.Text, _Appliances.comboBox_ApplianceStatus.SelectedItem.ToString(), _Appliances.radioButton_ApplianceSDeal.Text);
                }
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Cosmetics")
            {
                if (_Cosmetics.radioButton_CosmeticsPDeal.Checked)
                {
                    allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Cosmetics.textBox_CosmeticsType.Text, _Cosmetics.comboBox_CosmeticsStatus.SelectedItem.ToString(), _Cosmetics.comboBox_CosmeticslGender.SelectedItem.ToString(), _Cosmetics.radioButton_CosmeticsPDeal.Text);
                }
                else if (_Cosmetics.radioButton_CosmeticsSDeal.Checked)
                {
                    allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Cosmetics.textBox_CosmeticsType.Text, _Cosmetics.comboBox_CosmeticsStatus.SelectedItem.ToString(), _Cosmetics.comboBox_CosmeticslGender.SelectedItem.ToString(), _Cosmetics.radioButton_CosmeticsSDeal.Text);
                }
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Furnitures")
            {
                if (_Furnitures.radioButton_FurnituresPDeal.Checked)
                {
                    allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Furnitures.textBox_FurnituresManu.Text, _Furnitures.textBox_FurnituresColor.Text, _Furnitures.textBox_FurnituresQuality.Text, _Furnitures.radioButton_FurnituresPDeal.Text);
                }
                else if (_Furnitures.radioButton_FurnituresSDeal.Checked)
                {
                    allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Furnitures.textBox_FurnituresManu.Text, _Furnitures.textBox_FurnituresColor.Text, _Furnitures.textBox_FurnituresQuality.Text, _Furnitures.radioButton_FurnituresSDeal.Text);
                }
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Gadgets")
            {
                allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Gadgets.textBox_GadgetsManu.Text, _Gadgets.comboBox_GadgetsStatus.SelectedItem.ToString(), _Gadgets.textBox_GadgetsColor.Text, _Gadgets.textBox_GadgetsType.Text);
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Groceries")
            {
                allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Groceries.textBox_GroceriesName.Text, _Groceries.comboBox_GroceriesType.SelectedItem.ToString(), _Groceries.comboBox_GroceriesStatus.SelectedItem.ToString(), _Groceries.comboBox_GroceriesKind.SelectedItem.ToString());
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Kitchenwares")
            {
                allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Kitchen.comboBox_KitchenQuality.SelectedItem.ToString(), _Kitchen.textBox_KitchenType.Text, _Kitchen.comboBox_KitchenPackby.SelectedItem.ToString(), _Kitchen.textBox_KitchenColor.Text);
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "School Supplies")
            {
                allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _School.textBox_SchoolColor.Text, _School.textBox_SchoolName.Text, _School.comboBox_SchoolPackby.SelectedItem.ToString(), _School.comboBox_SchoolForwho.SelectedItem.ToString());
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Sports")
            {
                allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Sports.textBox_SportsItem.Text, _Sports.comboBox_SportsPackby.SelectedItem.ToString(), _Sports.comboBox_SportsStatus.SelectedItem.ToString(), _Sports.textBox_SportsColor.Text);
            }

            else if (comboBox_UpdateCategory.SelectedItem.ToString() == "Toys")
            {
                allMethod.AddProduct(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text, _Toys.textBox_ToysItem.Text, _Toys.textBox_ToysColor.Text, _Toys.comboBox_ToysForwho.SelectedItem.ToString(), _Toys.comboBox_ToysStatus.SelectedItem.ToString());
            }
            allMethod.AddAllProducts(textBox_UpdateStockCode.Text, textBox_UpdateBrandName.Text, textBox_UpdateUnit.Text, textBox_UpdateUnitPrice.Text, textBox_UpdateQuantity.Text, comboBox_UpdateCategory.SelectedItem.ToString(), textBox_UpdateDateAdded.Text, textBox_UpdateDateUpdated.Text);
            this.Close();
        }
    }
}
