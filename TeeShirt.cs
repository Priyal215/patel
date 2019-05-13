using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class TeeShirt : Product
    {
        private string size;

        public string Size
        {
            get { return size; }
            set { size = value; }
        }


        public TeeShirt(string brand, int id, string type, string description, string color, double price, double cost,
            int quantity, int dbquantity, string size)
            : base(brand, id, type, description, color, price, cost, quantity, dbquantity)
        {
            this.size = size;
        }

        public TeeShirt(SSShirt toCopy) : base(toCopy)
        {
            this.Copy(toCopy);
        }

        public TeeShirt():base()
        {
            size = "Small";
        }
        public TeeShirt(string size) : base()
        {
            this.size = size;
        }

        public override string ToString()
        {
            return string.Format("Size: {0}", Size);
        }


        public override string LineString()
        {
            return string.Format("{0} {1} {2}", base.ToString(), ToString(), "\n");
        }

        public void Copy(TeeShirt toCopy)
        {
            base.Copy(toCopy);
            this.size = toCopy.size;
        }


        public Product Clone()
        {
            return this;
        }
    }
}