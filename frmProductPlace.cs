using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesShop
{
    public partial class frmProductPlace : Form
    {
        public static string type = string.Empty;
        private List<Product> products;
        private int selectedProduct;
        private int selectedQuantity;

        public frmProductPlace()
        {
            InitializeComponent();
            LoadData();
        }

        public frmProductPlace(string t)
        {
            type = t;
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            ProductDB db = new ProductDB();
            products = db.GetProductsByType(type);
            if (products.Count > 0)
            {
                for (int i = 0; i < products.Count; i++)
                {
                    combBoxProducts.Items.Insert(i, products[i].LineString());
                }
            }
            else
            {
                MessageBox.Show("No records found!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Product toReturn = products[selectedProduct];
            toReturn.Quantity = selectedQuantity;
            this.Tag = toReturn;
        }

        private void border_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, this.Width - 1, this.Height - 1));
        }

        private void combBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combBoxProducts.SelectedItem == null) return;
            selectedProduct = combBoxProducts.SelectedIndex;
            comboBoxQuantity.Items.Clear();
            int quantity = products[selectedProduct].Quantity;
            for (int i = 0; i < quantity; i++)
            {
                string v = Convert.ToString(i + 1);
                comboBoxQuantity.Items.Insert(i, v);
            }
        }

        private void comboBoxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxQuantity.SelectedItem == null) return;
            selectedQuantity = comboBoxQuantity.SelectedIndex + 1;
        }

        private void frmProductPlace_Load(object sender, EventArgs e)
        {
        }
    }
}