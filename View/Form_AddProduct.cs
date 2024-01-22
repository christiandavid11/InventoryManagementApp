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
    public partial class Form_AddProduct : Form
    {
        Apparels apparels = new Apparels();
        Appliances appliances = new Appliances();
        Cosmetics cosmetics = new Cosmetics();
        Furnitures furnitures = new Furnitures();
        Gadgets gadgets = new Gadgets();
        Groceries groceries = new Groceries();
        Kitchenwares kitchenwares = new Kitchenwares();
        SchoolSupplies schoolSupplies = new SchoolSupplies();
        Sports sports = new Sports();
        Toys toys = new Toys();

        AllMethodFunction allMethod = new AllMethodFunction();
        
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

        public Form_AddProduct()
        {
            InitializeComponent();
        }
        
        private void Form_AddProduct_Load(object sender, EventArgs e)
        {
            textBox_AddDateAdded.Text = DateTime.Today.ToString("MM-dd-yyyy");
            apparels.DateAdded = textBox_AddDateAdded.Text;
            textBox_AddStockcode.Text = Convert.ToString(allMethod.code.Next(100000, 999999));
            textBox_AddDateUpdated.Text = "N.A.";
        }

        private void button_AddProceed_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if ((control as TextBox).Text == "")
                    {
                        allMethod.indicator = true;
                    }
                }
            }

            if (allMethod.indicator == true)
            {
                MessageBox.Show("Input All Data First");
            }
            else
            {
                if (comboBox_AddCategory.SelectedItem.ToString() == "Apparels")
                {
                    if (_Apparels.radioButton_Baby.Checked)
                    {
                        allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Apparels.comboBox_ApparelSize.SelectedItem.ToString(), _Apparels.textBox_ApparelColor.Text, _Apparels.radioButton_Baby.Text, _Apparels.comboBox_ApparelGender.SelectedItem.ToString());
                    }
                    else if (_Apparels.radioButton_Kids.Checked)
                    {
                        allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Apparels.comboBox_ApparelSize.SelectedItem.ToString(), _Apparels.textBox_ApparelColor.Text, _Apparels.radioButton_Kids.Text, _Apparels.comboBox_ApparelGender.SelectedItem.ToString());
                    }
                    else if (_Apparels.radioButton_Adult.Checked)
                    {
                        allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Apparels.comboBox_ApparelSize.SelectedItem.ToString(), _Apparels.textBox_ApparelColor.Text, _Apparels.radioButton_Adult.Text, _Apparels.comboBox_ApparelGender.SelectedItem.ToString());
                    }
                }

                else if (comboBox_AddCategory.SelectedItem.ToString() == "Appliances")
                {
                    if (_Appliances.radioButton_ApplianceDeal.Checked)
                    {
                        allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Appliances.textBox_ApplianceColor.Text, _Appliances.textBox_AppliancesType.Text, _Appliances.comboBox_ApplianceStatus.SelectedItem.ToString(), _Appliances.radioButton_ApplianceDeal.Text);
                    }
                    else if (_Appliances.radioButton_ApplianceSDeal.Checked)
                    {
                        allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Appliances.textBox_ApplianceColor.Text, _Appliances.textBox_AppliancesType.Text, _Appliances.comboBox_ApplianceStatus.SelectedItem.ToString(), _Appliances.radioButton_ApplianceSDeal.Text);
                    }
                }

                else if (comboBox_AddCategory.SelectedItem.ToString() == "Cosmetics")
                {
                    if (_Cosmetics.radioButton_CosmeticsPDeal.Checked)
                    {
                        allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Cosmetics.textBox_CosmeticsType.Text, _Cosmetics.comboBox_CosmeticsStatus.SelectedItem.ToString(), _Cosmetics.comboBox_CosmeticslGender.SelectedItem.ToString(), _Cosmetics.radioButton_CosmeticsPDeal.Text);
                    }
                    else if (_Cosmetics.radioButton_CosmeticsSDeal.Checked)
                    {
                        allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Cosmetics.textBox_CosmeticsType.Text, _Cosmetics.comboBox_CosmeticsStatus.SelectedItem.ToString(), _Cosmetics.comboBox_CosmeticslGender.SelectedItem.ToString(), _Cosmetics.radioButton_CosmeticsSDeal.Text);
                    }
                }

                else if (comboBox_AddCategory.SelectedItem.ToString() == "Furnitures")
                {
                    if (_Furnitures.radioButton_FurnituresPDeal.Checked)
                    {
                        allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Furnitures.textBox_FurnituresManu.Text, _Furnitures.textBox_FurnituresColor.Text, _Furnitures.textBox_FurnituresQuality.Text, _Furnitures.radioButton_FurnituresPDeal.Text);
                    }
                    else if (_Furnitures.radioButton_FurnituresSDeal.Checked)
                    {
                        allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Furnitures.textBox_FurnituresManu.Text, _Furnitures.textBox_FurnituresColor.Text, _Furnitures.textBox_FurnituresQuality.Text, _Furnitures.radioButton_FurnituresSDeal.Text);
                    }
                }

                else if (comboBox_AddCategory.SelectedItem.ToString() == "Gadgets")
                {
                    allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Gadgets.textBox_GadgetsManu.Text, _Gadgets.comboBox_GadgetsStatus.SelectedItem.ToString(), _Gadgets.textBox_GadgetsColor.Text, _Gadgets.textBox_GadgetsType.Text);
                }

                else if (comboBox_AddCategory.SelectedItem.ToString() == "Groceries")
                {
                    allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Groceries.textBox_GroceriesName.Text, _Groceries.comboBox_GroceriesType.SelectedItem.ToString(), _Groceries.comboBox_GroceriesStatus.SelectedItem.ToString(), _Groceries.comboBox_GroceriesKind.SelectedItem.ToString());
                }

                else if (comboBox_AddCategory.SelectedItem.ToString() == "Kitchenwares")
                {
                    allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Kitchen.comboBox_KitchenQuality.SelectedItem.ToString(), _Kitchen.textBox_KitchenType.Text, _Kitchen.comboBox_KitchenPackby.SelectedItem.ToString(), _Kitchen.textBox_KitchenColor.Text);
                }

                else if (comboBox_AddCategory.SelectedItem.ToString() == "School Supplies")
                {
                    allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _School.textBox_SchoolColor.Text, _School.textBox_SchoolName.Text, _School.comboBox_SchoolPackby.SelectedItem.ToString(), _School.comboBox_SchoolForwho.SelectedItem.ToString());
                }

                else if (comboBox_AddCategory.SelectedItem.ToString() == "Sports")
                {
                    allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Sports.textBox_SportsItem.Text, _Sports.comboBox_SportsPackby.SelectedItem.ToString(), _Sports.comboBox_SportsStatus.SelectedItem.ToString(), _Sports.textBox_SportsColor.Text);
                }

                else if (comboBox_AddCategory.SelectedItem.ToString() == "Toys")
                {
                    allMethod.AddProduct(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text, _Toys.textBox_ToysItem.Text, _Toys.textBox_ToysColor.Text, _Toys.comboBox_ToysForwho.SelectedItem.ToString(), _Toys.comboBox_ToysStatus.SelectedItem.ToString());
                }
                allMethod.AddAllProducts(textBox_AddStockcode.Text, textBox_AddBrandName.Text, textBox_AddUnit.Text, textBox_AddUnitPrice.Text, textBox_AddQuantity.Text, comboBox_AddCategory.SelectedItem.ToString(), textBox_AddDateAdded.Text, textBox_AddDateUpdated.Text);
                MessageBox.Show("Saved!");
                this.Close();
            }
        }

        private void comboBox_AddCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_AddCategory.SelectedItem.ToString() == "Apparels")
            {
                panel_AddContainer.Controls.Add(_Apparels);
                _Apparels.Dock = DockStyle.Fill;
                _Apparels.BringToFront();
            }

            else if (comboBox_AddCategory.SelectedItem.ToString() == "Appliances")
            {
                panel_AddContainer.Controls.Add(_Appliances);
                _Appliances.Dock = DockStyle.Fill;
                _Appliances.BringToFront();
            }

            else if (comboBox_AddCategory.SelectedItem.ToString() == "Cosmetics")
            {
                panel_AddContainer.Controls.Add(_Cosmetics);
                _Cosmetics.Dock = DockStyle.Fill;
                _Cosmetics.BringToFront();
            }

            else if (comboBox_AddCategory.SelectedItem.ToString() == "Furnitures")
            {
                panel_AddContainer.Controls.Add(_Furnitures);
                _Furnitures.Dock = DockStyle.Fill;
                _Furnitures.BringToFront();
            }

            else if (comboBox_AddCategory.SelectedItem.ToString() == "Gadgets")
            {
                panel_AddContainer.Controls.Add(_Gadgets);
                _Gadgets.Dock = DockStyle.Fill;
                _Gadgets.BringToFront();
            }

            else if (comboBox_AddCategory.SelectedItem.ToString() == "Groceries")
            {
                panel_AddContainer.Controls.Add(_Groceries);
                _Groceries.Dock = DockStyle.Fill;
                _Groceries.BringToFront();
            }

            else if (comboBox_AddCategory.SelectedItem.ToString() == "Kitchenwares")
            {
                panel_AddContainer.Controls.Add(_Kitchen);
                _Kitchen.Dock = DockStyle.Fill;
                _Kitchen.BringToFront();
            }

            else if (comboBox_AddCategory.SelectedItem.ToString() == "School Supplies")
            {
                panel_AddContainer.Controls.Add(_School);
                _School.Dock = DockStyle.Fill;
                _School.BringToFront();
            }

            else if (comboBox_AddCategory.SelectedItem.ToString() == "Sports")
            {
                panel_AddContainer.Controls.Add(_Sports);
                _Sports.Dock = DockStyle.Fill;
                _Sports.BringToFront();
            }

            else if (comboBox_AddCategory.SelectedItem.ToString() == "Toys")
            {
                panel_AddContainer.Controls.Add(_Toys);
                _Toys.Dock = DockStyle.Fill;
                _Toys.BringToFront();
            }
        }
    }
}
