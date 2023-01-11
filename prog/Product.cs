using System;
using System.Collections.Generic;
using System.Text;
using Curr;

namespace prog
{
    class Product
    {
        private string name;
        private decimal priceUSD;
        private decimal priceUAH;
        private int quantity;
        private string type;
        private string[] productType;
        public Product()
        {
            name = "";
            priceUSD = 0;
            priceUAH = 0;
            quantity = 0;
            type = "";
        }
        public Product(string name, decimal priceUSD, decimal priceUAH, int quantity, string type)
        {
            this.name = name;
            this.priceUSD = priceUSD;
            this.priceUAH = priceUAH;
            this.quantity = quantity;
            this.type = type;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public decimal PriceUSD
        {
            get
            {
                return priceUSD;
            }
            set
            {
                priceUSD = value;
            }
        }
        public decimal PriceUAH
        {
            get
            {
                return priceUAH;
            }
            set
            {
                priceUAH = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        public string[] ProductType
        {
            get
            {
                return productType;
            }
            set
            {
                productType = value;
            }
        }
        public string ProductCategoryInfo()
        {
            return type;
        }

    }
}
