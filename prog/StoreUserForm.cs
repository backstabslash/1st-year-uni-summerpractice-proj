using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using prog;
using System.IO;
using Curr;
using System.Xml;


namespace RegisterForm
{
    public partial class StoreUserForm : Form
    {
        
        public StoreUserForm()
        {
            InitializeComponent();
            cBProductType.Items.Add("Все категории");
            cBProductType.Items.AddRange(File.ReadAllLines("Categories.txt"));
            
        }

        private void tbQuantityOfProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar <= 8))
            {
                return;
            }
            e.Handled = true;
        }

        private void bExitMain_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Вы точно хотите выйти?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
                Application.Exit();
        }

        private void bBasket_Click(object sender, EventArgs e)
        {
            this.Hide();
            BasketForm basketForm = new BasketForm();
            basketForm.Show();
        }

      

        private void cBProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBUserAllproducts.Items.Clear();
            if (cBProductType.Text == "Все категории")
            {
                Store store = new Store();
                foreach (string str in File.ReadAllLines("Categories.txt")){
                    string ShowCategories = str + ".xml";
                    List<Product> products = store.ReadCategoryXMl(ShowCategories);
                    foreach (Product product in products)
                    {
                        lBUserAllproducts.Items.Add(product.Name + " — цена: " + product.PriceUSD * Currency.ConvertToUAHPrivat() + "; количество на складе :" + product.Quantity);
                    }
                }
            }
            else
            {
                Store store1 = new Store();
                string ShowCategories = cBProductType.Text + ".xml";
                List<Product> products = store1.ReadCategoryXMl(ShowCategories);
                foreach (Product product in products)
                {
                    lBUserAllproducts.Items.Add(product.Name + " — цена: " + product.PriceUSD * Currency.ConvertToUAHPrivat() + "; количество на складе :" + product.Quantity);
                }
            }
        }

        private void bBuyProduct_Click(object sender, EventArgs e)
        {
            if (lBUserAllproducts.SelectedIndex >= 0 && Convert.ToInt32(tBBuyProduct.Text) > 0 && cBProductType.Text != "Все категории")
            {
                Store store1 = new Store();
                string ShowCategories = cBProductType.Text + ".xml";
                List<Product> products = store1.ReadCategoryXMl(ShowCategories);
                int QuantityBuy = Convert.ToInt32(tBBuyProduct.Text);
                Product product = new Product();
                product = products[lBUserAllproducts.SelectedIndex];
                string old_log = product.Name + " количество до: " + product.Quantity + " прибыль до: " +
                    Convert.ToString(profit);
                decimal PriceForItems = store1.CountPrice(product, QuantityBuy);
                if (product.Quantity > QuantityBuy)
                {
                    XmlDocument xDoc1 = new XmlDocument();
                    xDoc1.Load("Basket.xml");
                    XmlElement xRoot1 = xDoc1.DocumentElement;
                    XmlElement eventElem = xDoc1.CreateElement("basket");
                    XmlElement event_nameElem = xDoc1.CreateElement("product");
                    XmlElement dateElem = xDoc1.CreateElement("quantity");
                    XmlElement userElem = xDoc1.CreateElement("productType");
                    

                    XmlText event_nameText = xDoc1.CreateTextNode(product.Name);
                    
                    XmlText pre_conditionText = xDoc1.CreateTextNode(Convert.ToString(QuantityBuy));
                    XmlText conditionText = xDoc1.CreateTextNode(product.Type);

                    event_nameElem.AppendChild(event_nameText);
                    dateElem.AppendChild(pre_conditionText);
                    userElem.AppendChild(conditionText);
                    
                    eventElem.AppendChild(event_nameElem);
                    eventElem.AppendChild(dateElem);
                    eventElem.AppendChild(userElem);
                  
                    xRoot1.AppendChild(eventElem);
                    xDoc1.Save("Basket.xml");
                    store1.BuyProduct(product, QuantityBuy);
                    lbPriceQuantity.Text = Convert.ToString(PriceForItems);
                    BasketForm basketForm = new BasketForm();
                    product.ProductType = File.ReadAllLines("Basket.txt");
                    string[] temp = product.ProductType;
                    Array.Resize(ref temp, temp.Length + 1);
                    temp[temp.Length - 1] = product.Name + "  " + QuantityBuy + "  " + Convert.ToString(PriceForItems);
                    File.WriteAllLines("Basket.txt", temp);
                    decimal _temp = profit + QuantityBuy * product.PriceUSD;
                    string new_log = product.Name + " количество после: " + Convert.ToString(product.Quantity - QuantityBuy) + " прибыль после: " +
                        Convert.ToString(_temp);
                    
                }
                else
                    lbPriceQuantity.Text = "Неправильное количество";
            }
            else if (Convert.ToInt32(tBBuyProduct.Text) <= 0)
                lbPriceQuantity.Text = "Выберите количество";
            else if (cBProductType.Text == "Все категории")
                lbPriceQuantity.Text = "Выберите категорию";
            else
                lbPriceQuantity.Text = "Выберите продукт";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Вы точно хотите выйти?",
               "Сообщение",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                this.Show();
        }

        private void bLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }

    }
}
