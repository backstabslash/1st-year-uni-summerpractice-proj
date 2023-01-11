using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using RegisterForm;
using System.Xml;

namespace prog
{
    public partial class BasketForm : Form
    {
        public BasketForm()
        {
            InitializeComponent();
            lBProductsInBasket.Items.AddRange(File.ReadAllLines("Basket.txt"));
        }


        private void bBuyItems_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Спасибо за покупку",
                "Сообщение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            Application.Exit();
        }

        private void bBackToAdmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Очистить корзину и вернуться к покупкам?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                Store store = new Store();
                List<string> productX = new List<string>();
                List<string> typeX = new List<string>();
                List<int> quantityX = new List<int>(); ;
                XmlDocument xDoc1 = new XmlDocument();
                xDoc1.Load("Basket.xml");
                StoreUserForm storeUserForm = new StoreUserForm();
                storeUserForm.Show();
                XmlElement xRoot = xDoc1.DocumentElement;
                foreach (XmlNode xnode in xRoot)
                {
                    foreach (XmlNode childnode in xnode.ChildNodes)
                    {
                        if (childnode.Name == "product")
                        {
                            productX.Add(childnode.InnerText);
                        }
                        if (childnode.Name == "quantity")
                        {
                            quantityX.Add(Convert.ToInt32(childnode.InnerText));
                            childnode.InnerText = Convert.ToString(0);
                            xDoc1.Save("Basket.xml");
                        }
                        if (childnode.Name == "productType")
                        {
                            typeX.Add(childnode.InnerText);
                        }
                    }
                }
                for (int i = 0; i < productX.Count; i++)
                {
                    store.ChangeProductQuantity1(productX[i], quantityX[i], typeX[i]);
                }
                File.WriteAllText("Basket.txt", String.Empty);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Очистить корзину и выйти?",
                "Сообщение",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                File.WriteAllText("Basket.txt", String.Empty);
                Application.Exit();
            }
            else
                this.Show();
        }

        private void BasketForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
