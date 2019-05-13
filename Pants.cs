using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class Pants : Product
    {
        private int inseam;
        private int waist;

        public int Inseam
        {
            get { return inseam; }
            set { inseam = value; }
        }

        public int Waist
        {
            get { return waist; }
            set { waist = value; }
        }

        public Pants(string brand, int id, string type, string description, string color, double price, double cost,
            int quantity, int dbquantity, int inseam, int waist)
            : base(brand, id, type, description, color, price, cost, quantity, dbquantity)
        {
            this.inseam = inseam;
            this.waist = waist;
        }

        public Pants(Product toCopy) : base(toCopy)
        {
            this.Copy(toCopy);
        }

        public Pants() : base()
        {
            inseam = 0;
            waist = 0;
        }

        public Pants(int inseam, int waist) : base()
        {
            this.inseam = inseam;
            this.waist = waist;
        }

        public override string ToString()
        {
            return string.Format("Inseam: {0} Waist:{1}", Inseam, Waist);
        }


        public override string LineString()
        {
            return string.Format("{0} {1} {2}", base.ToString(), ToString(), "\n");
        }

        public void Copy(Pants toCopy)
        {
            base.Copy(toCopy);
            this.inseam = toCopy.inseam;
            this.waist = toCopy.waist;
        }


        public Product Clone()
        {
            return this;
        }
    }
}