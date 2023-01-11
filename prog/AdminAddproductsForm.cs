using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using RegisterForm;
using Curr;
using System.IO;


namespace prog
{
    public partial class AdminAddproductsForm : Form
    {
        public AdminAddproductsForm()
        {
            InitializeComponent();
            cBProductType.Items.AddRange(File.ReadAllLines("Categories.txt"));
            cBChooseShowCategories.Items.Add("Все категории");
            cBChooseShowCategories.Items.AddRange(File.ReadAllLines("Categories.txt"));
        }

        private void bBackToAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            StoreAdminForm storeAdminForm = new StoreAdminForm();
            storeAdminForm.Show();
        }

        private void bExitMain_Click(object sender, EventArgs e)
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

        private void bAddProduct_Click(object sender, EventArgs e)
        {
            if (cBProductType.SelectedIndex >= 0 && tBNewProductName.TextLength > 0 && tBPriceUsd.TextLength > 0)
            {
                DialogResult result = MessageBox.Show(
                "Вы точно хотите добавить эту продукцию? ",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    Store store = new Store();
                    Product product = new Product(tBNewProductName.Text, Convert.ToDecimal(tBPriceUsd.Text), Currency.ConvertToUAHNBU(Convert.ToDecimal(tBPriceUsd.Text)), 0, cBProductType.Text);
                    string infoprod = product.Name +" цена товара : " + Convert.ToString(product.PriceUSD);
                    Log.AddToLog("Добавление нового товара", " ", infoprod);
                    store.AddProduct(product);
                }
            } else
                lbNewprod.Text = "Неправильно введены данные для добавления";
        }





        private void cBChooseShowCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBAllproducts.Items.Clear();
            if (cBChooseShowCategories.Text == "Все категории")
            {
                Store store = new Store();
                foreach (string str in File.ReadAllLines("Categories.txt"))
                {
                    string ShowCategories = str + ".xml";
                    List<Product> products = store.ReadCategoryXMl(ShowCategories);
                    foreach (Product product in products)
                    {
                        lBAllproducts.Items.Add(product.Name + " — цена в USD: " + product.PriceUSD  + "; цена в UAH: " + product.PriceUAH +   "; количество на складе: " + product.Quantity);
                    }
                }
            }
            else
            {
                Store store1 = new Store();
                string ShowCategories = cBChooseShowCategories.Text + ".xml";
                List<Product> products = store1.ReadCategoryXMl(ShowCategories);
                foreach (Product product in products)
                {
                    lBAllproducts.Items.Add(product.Name + " — цена в USD: " + product.PriceUSD + "; цена в UAH: " + product.PriceUAH + "; количество на складе: " + product.Quantity);
                }
            }
        }
    

        private void bAddQuantity_Click(object sender, EventArgs e)
        {
            if(cBChooseShowCategories.SelectedIndex > 0 && tBAddQuantity.TextLength >0 && lBAllproducts.SelectedIndex >= 0 
                && cBChooseShowCategories.Text != "Все категории")
            {
                int AddQuantity = Convert.ToInt32(tBAddQuantity.Text);
                string ShowCategories = cBChooseShowCategories.Text + ".xml";
                Store store = new Store();
                List<Product> products = store.ReadCategoryXMl(ShowCategories);
                string old_log = products[lBAllproducts.SelectedIndex].Name + " количество до: " + products[lBAllproducts.SelectedIndex].Quantity + " прибыль до: " +
                   Convert.ToString(profit);
                store.ChangeProductQuantity(products[lBAllproducts.SelectedIndex], AddQuantity);
                decimal _temp = profit + AddQuantity * products[lBAllproducts.SelectedIndex].PriceUSD;
                string new_log = products[lBAllproducts.SelectedIndex].Name + " количество после: " + Convert.ToString(products[lBAllproducts.SelectedIndex].Quantity + AddQuantity) + " прибыль после: " +
                        Convert.ToString(_temp);
                Log.AddToLog("Закупка товара", old_log, new_log);
                this.Close();
                AdminAddproductsForm adminAddproductsForm = new AdminAddproductsForm();
                adminAddproductsForm.Show();
            }
            else if (cBChooseShowCategories.Text == "Все категории")
                lbNewprod.Text = "Выберите категорию";
            else
                lbNewprod.Text = "Выберите товар в списке";
            

        }

        

        private void tBAddQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
                return;
            e.Handled = true;
        }

        
    }
}
