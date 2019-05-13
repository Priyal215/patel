using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop {
    class SSShirt : Product {
        private double neck;

        public double Neck {
            get { return neck; }
            set { neck = value; }
        }

        public SSShirt (string brand, int id, string type, string description, string color, double price, double cost,
            int quantity, int dbquantity, double neck) : base (brand, id, type, description, color, price, cost, quantity, dbquantity) {
            this.neck = neck;
        }

        public SSShirt (SSShirt toCopy) : base (toCopy) {
            this.Copy (toCopy);
        }

        public SSShirt () : base () {
            neck = 0;
        }
        public SSShirt (double neck) : base () {
            this.neck = neck;
        }
        public override string ToString () {
            return string.Format ("Neck: {0}", Neck);
        }

        public override string LineString () {
            return string.Format ("{0} {1} {2}", base.ToString (), ToString (), "\n");
        }

        public void Copy (SSShirt toCopy) {
            base.Copy (toCopy);
            this.neck = toCopy.neck;
        }

        public Product Clone () {
            return this;
        }
    }
}