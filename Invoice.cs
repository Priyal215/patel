using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class Invoice
    {
        private DateTime time;
        public ProductList list;
        public int invoiceNumber = 0;

     
        public ProductList List
        {
            get { return list; }
            set { list = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public  int InvoiceNumber
        {
            get { return invoiceNumber; }
            set { invoiceNumber = value; }
        }

        public Invoice(ProductList list)
        {
            ProductDB db=new ProductDB();;
            time = DateTime.Now;
            this.list = list;
            invoiceNumber = db.GetMaxInvoiceID() + 1;

        }

        public double Total()
        {
            double totalSale = SubTotal();
            double totalTax = SalesTax();
            return totalSale + totalTax;
        }

        public double SalesTax()
        {
            double totalSale = SubTotal();
            return totalSale * (0.08);
        }

        public double SubTotal()
        {
            double total = 0;
            foreach (var product in list.products)
            {
                total = total + product.GetTotalPrice();
            }
            return total;
        }

        public override string ToString()
        {
            string invoiceText = "The Clothes Shop" + "\n";
            invoiceText = invoiceText + "Receipt No.: " + invoiceNumber.ToString() + "\n";
            invoiceText = invoiceText + "Date/time: " + time.ToString() + "\n" + "\n";

            foreach (var product in list.products)
            {
                invoiceText = invoiceText + product.LineString() + "\n";
            }

            invoiceText = invoiceText + "\n" + "\n";

            invoiceText = invoiceText + "Subtotal: $" + SubTotal().ToString() + "\n";
            invoiceText = invoiceText + "Sales Tax $: " + SalesTax().ToString() + "\n";
            invoiceText = invoiceText + "Total: $" + Total().ToString() + "\n";

            return invoiceText;
        }
    }
}