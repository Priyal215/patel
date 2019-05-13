using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class Product
    {
        private string brand;
        int id;
        private string type;
        private string description;
        private string color;
        private double price;
        private double cost;
        private int quantity;
        private int dbquantity;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int Dbquantity
        {
            get { return dbquantity; }
            set { dbquantity = value; }
        }


        public Product(string brand, int id, string type, string description, string color, double price, double cost,
            int quantity, int dbquantity)
        {
            this.brand = brand;
            this.id = id;
            this.type = type;
            this.description = description;
            this.color = color;
            this.price = price;
            this.cost = cost;
            this.quantity = quantity;
            this.dbquantity = dbquantity;
        }

        public Product()
        {
            this.brand = "";
            this.id = 0;
            this.type = "";
            this.description = "";
            this.color = "";
            this.price = 0;
            this.cost = 0;
            this.quantity = 0;
            this.dbquantity = 0;
        }

        public Product(Product toCopy)
        {
            this.Copy(toCopy);
        }

        public void Copy(Product toCopy)
        {
            this.brand = toCopy.brand;
            this.id = toCopy.id;
            this.type = toCopy.type;
            this.description = toCopy.description;
            this.color = toCopy.color;
            this.price = toCopy.price;
            this.cost = toCopy.cost;
//            this.dbquantity = toCopy.dbquantity;
        }


        public override string ToString()
        {
            return String.Format("ID: {0} Qty: {1} @${2}ea {3} {4} {5}", Id, Quantity, Price, Brand, Description,
                Color);
        }

        public virtual string LineString()
        {
            return String.Format("ID: {0} Qty: {1} @${2}ea {3} {4} {5}", Id, Quantity, Price, Brand, Description,
                Color);
        }

        public double GetTotalPrice()
        {
            return Price * Quantity;
        }

        public Product Clone()
        {
            return this;
        }
    }
}