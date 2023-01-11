using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Text;

namespace Curr
{

    public class Currency
    {
        private string currency_codel;
        private decimal amountSale;
        private decimal amountPurchase;

        public static void GetXml(string link, string curencyXml)
        {
            WebRequest request = WebRequest.Create(link + DateTime.Now.ToString("dd.MM.yyyy"));
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string line = "";
                    using (StreamWriter sw = new StreamWriter(curencyXml, false, System.Text.Encoding.Default))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            sw.WriteLine(line);
                        }
                    }
                }
            }
        }

        public static decimal USDNBUXml()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("CurrNBU.xml");
            XmlElement xRoot = xdoc.DocumentElement;
            string a = "";
            string b = "";
            foreach (XmlNode xnode in xRoot)
            {
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    if (childnode.Name == "CurrencyCodeL")
                    {
                        a = childnode.InnerText;
                    }
                    if (childnode.Name == "Amount" && a == "USD")
                    {
                        b = childnode.InnerText;
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
                        return Convert.ToDecimal(c);
                    }
                }
            }
            return 0;
        }

        public static decimal ReadPrivatXml()
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("CurrencyPrivat.xml");
            XmlElement xRoot = xdoc.DocumentElement;
            Currency currency = new Currency();
            foreach (XmlNode xnode in xRoot)
            {
                bool temp = false;
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("currency");
                    if (attr != null)
                    {
                        if (attr.InnerText == "USD")
                            temp = true;
                    }

                }
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("saleRate");
                    if (attr != null && temp)
                    {
                        string b = attr.InnerText;
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
                        return Convert.ToDecimal(c);
                    }
                }
            }
            return 1;
        }
        public static decimal ConvertToUAHNBU(decimal priceUSD)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            GetXml("https://bank.gov.ua/NBU_Exchange/exchange?date=", "CurrNBU.xml");
            return Convert.ToDecimal(USDNBUXml()) * priceUSD;
        }
        public static decimal ConvertToUAHPrivat()
        {
            decimal multiply = Convert.ToDecimal(File.ReadAllText("Multiply.txt"));
            return Convert.ToDecimal(ReadPrivatXml()) * multiply;
        }
    }
}