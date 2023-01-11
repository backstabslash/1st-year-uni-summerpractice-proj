using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using Curr;

namespace prog
{
    [Serializable]
    class Store
    {
        public static decimal multiply;
        private decimal profit;
        public decimal capital;


        public void AddCategory(string newCategory)
        {
            Product product = new Product();
            product.ProductType = File.ReadAllLines("Categories.txt");
            string[] temp = product.ProductType;
            Array.Resize(ref temp, temp.Length + 1);
            temp[temp.Length - 1] = newCategory;
            File.WriteAllLines("Categories.txt", temp);
            string productXml = newCategory + ".xml";
            XDocument xDoc = new XDocument();
            //   XmlElement xRoot1 = xDoc1.DocumentElement;
            XElement products = new XElement("products");
            xDoc.Add(products);
            xDoc.Save(productXml);
        }
        public void DeleteCategory(string oldCategory)
        {
            Product product = new Product();
            product.ProductType = File.ReadAllLines("Categories.txt");
            var list = new List<string>(product.ProductType);
            list.Remove(oldCategory);
            product.ProductType = list.ToArray();
            File.WriteAllLines("Categories.txt", product.ProductType);
        }
        public void AddProduct(Product product)
        {
            string productXml = product.Type + ".xml";
            XmlDocument xDoc1 = new XmlDocument();
            xDoc1.Load(productXml);
            XmlElement xRoot1 = xDoc1.DocumentElement;
            XmlElement productElem = xDoc1.CreateElement("product");
            XmlElement nameElem = xDoc1.CreateElement("name");
            XmlElement priceUSDElem = xDoc1.CreateElement("priceUSD");
            XmlElement priceUAHElem = xDoc1.CreateElement("priceUAH");
            XmlElement quantityElem = xDoc1.CreateElement("quantity");
            XmlElement typeElem = xDoc1.CreateElement("type");
            XmlText nameText = xDoc1.CreateTextNode(product.Name);
            XmlText priceUSDText = xDoc1.CreateTextNode(Convert.ToString(product.PriceUSD));
            XmlText priceUAHText = xDoc1.CreateTextNode(Convert.ToString(product.PriceUAH));
            XmlText quantityText = xDoc1.CreateTextNode(Convert.ToString(0));
            XmlText typeText = xDoc1.CreateTextNode(product.Type);
            nameElem.AppendChild(nameText);
            priceUSDElem.AppendChild(priceUSDText);
            priceUAHElem.AppendChild(priceUAHText);
            quantityElem.AppendChild(quantityText);
            typeElem.AppendChild(typeText);
            productElem.AppendChild(nameElem);
            productElem.AppendChild(priceUSDElem);
            productElem.AppendChild(priceUAHElem);
            productElem.AppendChild(quantityElem);
            productElem.AppendChild(typeElem);
            xRoot1.AppendChild(productElem);
            xDoc1.Save(productXml);
            /* XmlDocument xDoc2 = new XmlDocument();
             xDoc2.Load("Store.xml");
             XmlElement xRoot2 = xDoc2.DocumentElement;
             XPathNavigator navigator = xDoc2.CreateNavigator();
             string allProductsPrice = "";
             foreach (XmlNode xnode in xRoot2)
             {
                 foreach (XmlNode childnode in xnode.ChildNodes)
                 {
                     if (childnode.Name == "allProductsPrice")
                     {
                         decimal a = Convert.ToDecimal(childnode.InnerText);
                         a += product.Price * product.Quantity;
                         allProductsPrice = Convert.ToString(a);
                     }
                 }
             }
             foreach (XPathNavigator nav in navigator.Select("Store.xml"))
             {
                 if (nav.Value == "allProductsPrice")
                 {
                     nav.SetValue(allProductsPrice);
                 }
             }*/

        }
        public void AddQuantity(Product product, int quantity)
        {
            string productXml = product.Type + ".xml";

            XmlDocument xDoc1 = new XmlDocument();
            xDoc1.Load(productXml);
            XmlElement xRoot = xDoc1.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "quantity")
                    {
                        int a = Convert.ToInt32(childnode.InnerText);
                        a += quantity;
                        childnode.InnerText = Convert.ToString(a);
                    }
                }
            }
        }

        public void ChangeProductQuantity1(string product, int quantity, string type)
        {
            string productXml = type + ".xml";
            XmlDocument xDoc1 = new XmlDocument();
            xDoc1.Load(productXml);
            string productQuantity = "";
            XmlElement xRoot = xDoc1.DocumentElement;
            string name = " ";
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                    {
                        name = childnode.InnerText;
                    }
                    if (childnode.Name == "quantity" && name == product)
                    {
                        int a = Convert.ToInt32(childnode.InnerText);
                        a += quantity;
                        productQuantity = Convert.ToString(a);
                        childnode.InnerXml = productQuantity;
                    }
                }
            }
            xDoc1.Save(productXml);

        }
        public void ChangeProductQuantity(Product product, int quantity)
        {
            string productXml = product.Type + ".xml";
            XmlDocument xDoc1 = new XmlDocument();
            xDoc1.Load(productXml);
            string productQuantity = "";
            XmlElement xRoot = xDoc1.DocumentElement;
            string name = " ";
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                    {
                        name = childnode.InnerText;
                    }
                    if (childnode.Name == "quantity" && name == product.Name)
                    {
                        string oldValue = childnode.InnerText;
                        int a = Convert.ToInt32(childnode.InnerText);
                        a += quantity;
                        productQuantity = Convert.ToString(a);
                        childnode.InnerXml = productQuantity;
                    }

                    if (childnode.Name == "priceUSD" && name == product.Name)
                    {
                        string spending = File.ReadAllText("Spending.txt");
                        decimal spendings = Convert.ToDecimal(spending) + (quantity * Convert.ToDecimal(childnode.InnerText));
                        File.WriteAllText("Spending.txt", Convert.ToString(spendings));
                    }
                }
            }
            xDoc1.Save(productXml);
        }
        public decimal CountPrice(Product product, int quantity)
        {
            string productXml = product.Type + ".xml";
            XmlDocument xDoc1 = new XmlDocument();
            xDoc1.Load(productXml);
            string productQuantity = "";
            XmlElement xRoot = xDoc1.DocumentElement;
            string name = " ";
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                    {
                        name = childnode.InnerText;
                    }
                    if (childnode.Name == "quantity" && name == product.Name)
                    {
                        string oldValue = childnode.InnerText;
                        int a = Convert.ToInt32(childnode.InnerText);
                        a -= quantity;
                        productQuantity = Convert.ToString(a);
                        childnode.InnerXml = productQuantity;
                    }
                    if (childnode.Name == "priceUSD" && name == product.Name)
                    {
                        xDoc1.Save(productXml);
                        return Convert.ToDecimal(childnode.InnerText) * quantity * Currency.ConvertToUAHPrivat();
                    }
                }
            }
            xDoc1.Save(productXml);
            return 0;
        }
        public void BuyProduct(Product product, int quantity)
        {
            string productXml = product.Type + ".xml";
            XmlDocument xDoc1 = new XmlDocument();
            xDoc1.Load(productXml);
            string productQuantity = "";
            XmlElement xRoot = xDoc1.DocumentElement;
            string name = " ";

            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                    {
                        name = childnode.InnerText;
                    }
                    if (childnode.Name == "quantity" && name == product.Name)
                    {
                        string oldValue = childnode.InnerText;
                        int a = Convert.ToInt32(childnode.InnerText);
                        a -= quantity;
                        productQuantity = Convert.ToString(a);
                        childnode.InnerText = productQuantity;
                    }
                    if (childnode.Name == "priceUSD" && name == product.Name)
                    {
                        string profit = File.ReadAllText("Profit.txt");
                        decimal profitd = Convert.ToDecimal(profit) + quantity * Convert.ToDecimal(childnode.InnerText);
                        File.WriteAllText("Profit.txt", Convert.ToString(profitd));
                    }
                }
            }
            xDoc1.Save(productXml);
        }

        public List<Product> ReadCategoryXMl(string categoryXml)
        {
            List<Product> products = new List<Product>();
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(categoryXml);
            XmlElement xRoot = xdoc.DocumentElement;
            foreach (XmlNode xnode in xRoot)
            {
                Product product = new Product();
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "name")
                    {
                        product.Name = childnode.InnerText;
                    }
                    if (childnode.Name == "priceUSD")
                    {
                        string b = childnode.InnerText;
                        string c = "";
                        for (int i = 0; i < b.Length; i++)
                        {
                            if (b[i] == '.')
                            {
                                c += ',';
                            }
                            else
                                c += b[i];
                        }

                        product.PriceUSD = Convert.ToDecimal(c);
                    }
                    if (childnode.Name == "priceUAH")
                    {
                        string b = childnode.InnerText;
                        string c = "";
                        for (int i = 0; i < b.Length; i++)
                        {
                            if (b[i] == '.')
                            {
                                c += ',';
                            }
                            else
                                c += b[i];
                        }
                        product.PriceUAH = Convert.ToDecimal(c);
                    }
                    if (childnode.Name == "quantity")
                    {
                        product.Quantity = Convert.ToInt32(childnode.InnerText);
                    }
                    if (childnode.Name == "type")
                    {
                        product.Type = childnode.InnerText;
                    }

                }
                products.Add(product);
            }
            return products;
        }

    }


}
