using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class LSShirt:Product
    {
        private double neck;
        private int sleeve;

        public double Neck
        {
            get { return neck; }
            set { neck = value; }
        }

        public int Sleeve
        {
            get { return sleeve; }
            set { sleeve = value; }
        }


        public LSShirt(string brand, int id, string type, string description, string color, double price, double cost, int quantity, int dbquantity, double neck, int sleeve) : base(brand, id, type, description, color, price, cost, quantity, dbquantity)
        {
            this.neck = neck;
            this.sleeve = sleeve;
        }

        public LSShirt(LSShirt toCopy) : base(toCopy)
        {
            this.Copy(toCopy);
        }

        public LSShirt():base()
        {
            neck = 0;
            sleeve = 0;
        }

        public LSShirt(double neck,int sleeve):base()
        {
            this.neck = neck;
            this.sleeve=sleeve;
        }

        public override string ToString()
        {
            return string.Format("Neck: {0} Sleeve:{1}", Neck, Sleeve);

        }


        public override string LineString()
        {
            return string.Format("{0}{1}{2}", base.ToString(), ToString(), "\n");

        }
        public void Copy(LSShirt toCopy)
        {
            base.Copy(toCopy);
            this.neck = toCopy.neck;
            this.sleeve = toCopy.sleeve;
        }



        public Product Clone()
        {
            return this;
        }
    }
}
