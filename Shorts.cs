using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class Shorts:Product
    {
        private int waist;


        public int Waist
        {
            get { return waist; }
            set { waist = value; }
        }

        public Shorts(string brand, int id, string type, string description, string color, double price, double cost, int quantity, int dbquantity,int waist) : base(brand, id, type, description, color, price, cost, quantity, dbquantity)
        {
            this.waist = waist;
        }

        public Shorts(Product toCopy) : base(toCopy)
        {
            this.Copy(toCopy);
        }

        public Shorts():base()
        {
            waist = 0;
        }
        public Shorts(int waist) : base()
        {
            this.waist = waist;
        }

        public override string ToString()
        {
            return string.Format("Waist:{0}", Waist);

        }


        public override string LineString()
        {
            return string.Format("{0} {1} {2}", base.ToString(), ToString(), "\n");

        }
        public void Copy(Shorts toCopy)
        {
            base.Copy(toCopy);
            this.waist = toCopy.waist;
        }
        
        public Product Clone()
        {
            return this;
        }
    }
}
