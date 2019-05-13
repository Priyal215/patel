using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class ProductList
    {
        public List<Product> products;

        public ProductList()
        {
            products=new List<Product>();
        }

        public string LineString()
        {
            string result = "";
            foreach (var product in products)
            {

                result = product.LineString() + "\n";
            }
            return result;
        }
        public override string ToString()
        {
            string result = "";
            foreach (var product in products)
            {

                result = product.ToString() + "\n";
            }
            return result;
        }
    }
}
