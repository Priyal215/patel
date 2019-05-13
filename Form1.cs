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
    public partial class Form1 : Form
    {
        private static int width;
        private static int height;
        private static int partWidth;
        private static int partHeight;
        private static ProductDB db = null;
        private static ProductList list = null;
        private static Invoice invoice = null;
        
        public Form1()
        {
            InitializeComponent();
            InitialSizes();
        }

        private void InitialSizes()
        {
            db = new ProductDB();
            list = new ProductList();
            invoice = new Invoice(list);

            height = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Height;
            width = System.Windows.Forms.SystemInformation.PrimaryMonitorSize.Width;
            partHeight = height / 20;
            partWidth = width / 20;

            Point[] points=new Point[9];
            int boxHeight = partHeight * 5;
            int boxWidth = partWidth * 3;

            points[0] = new Point(partWidth, partHeight * 3);
            points[1] = new Point(partWidth + boxWidth + partWidth / 2, partHeight * 3);
            points[2] = new Point(partWidth + boxWidth * 2 + partWidth, partHeight * 3);
            points[3] = new Point(partWidth, partHeight * 4 + boxHeight);
            points[4] = new Point(partWidth + boxWidth + partWidth / 2, partHeight * 4 + boxHeight);
            points[5] = new Point(partWidth, partHeight * 11 + boxHeight);
            points[6] = new Point(partWidth + boxWidth + partWidth / 2, partHeight * 11 + boxHeight);
            points[7] = new Point(partWidth + boxWidth * 2 + partWidth, partHeight * 11 + boxHeight);
            points[8] = new Point(partWidth * 11, partHeight);


            pictureBoxLsShirt.Location = points[0];
            pictureBoxLsShirt.Height = boxHeight;
            pictureBoxLsShirt.Width = boxWidth;

            pictureBoxSSShirt.Location = points[1];
            pictureBoxSSShirt.Height = boxHeight;
            pictureBoxSSShirt.Width = boxWidth;

            pictureBoxTeeShirt.Location = points[2];
            pictureBoxTeeShirt.Height = boxHeight;
            pictureBoxTeeShirt.Width = boxWidth;

            pictureBoxPants.Location = points[3];
            pictureBoxPants.Height = boxHeight;
            pictureBoxPants.Width = boxWidth;


            pictureBoxShorts.Location = points[4];
            pictureBoxShorts.Height = boxHeight;
            pictureBoxShorts.Width = boxWidth;


            buttonExit.Location = points[5];
            buttonExit.Width = boxWidth;


            buttonCancel.Location = points[6];
            buttonCancel.Width = boxWidth;

            buttonOrder.Location = points[7];
            buttonOrder.Width = boxWidth;


            detailsBox.Location = points[8];
            detailsBox.Width = partWidth * 8;
            detailsBox.Height = height - (partHeight * 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void detailsBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void pictureBoxLsShirt_Click(object sender, EventArgs e)
        {
            frmProductPlace frmP = new frmProductPlace("LSShirt");
            frmP.ShowDialog();
            if (frmP.DialogResult == DialogResult.OK)
            {
                Product p = (Product) frmP.Tag;
                list.products.Add(p);
                udpateInvoice();
            }
        }

        private void pictureBoxLsShirt_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 9))
            {
                e.Graphics.DrawString("LSShirt", myFont, Brushes.Black,
                    new Point(pictureBoxLsShirt.Height / 2 - 20, pictureBoxLsShirt.Width / 2));
            }
        }

        private void titleShop_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 30))
            {
                e.Graphics.DrawString("The Clothes Shop", myFont, Brushes.GreenYellow,
                    new Point(partHeight, partWidth));
            }
        }


        private void labelLsShirt_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxSSShirt_Click(object sender, EventArgs e)
        {
            frmProductPlace frmP = new frmProductPlace("SSShirt");
            frmP.ShowDialog();
            if (frmP.DialogResult == DialogResult.OK)
            {
                Product p = (Product) frmP.Tag;
                list.products.Add(p);
                udpateInvoice();
            }
        }

        private void pictureBoxSSShirt_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 9))
            {
                e.Graphics.DrawString("SSShirt", myFont, Brushes.Black,
                    new Point(pictureBoxSSShirt.Height / 2 - 20, pictureBoxSSShirt.Width / 2));
            }
        }

        private void pictureBoxTeeShirt_Click(object sender, EventArgs e)
        {
            frmProductPlace frmP = new frmProductPlace("TeeShirt");
            frmP.ShowDialog();
            if (frmP.DialogResult == DialogResult.OK)
            {
                Product p = (Product) frmP.Tag;
                list.products.Add(p);
                udpateInvoice();
            }
        }

        private void pictureBoxTeeShirt_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 9))
            {
                e.Graphics.DrawString("TeeShirt", myFont, Brushes.Black,
                    new Point(pictureBoxTeeShirt.Height / 2 - 20, pictureBoxTeeShirt.Width / 2));
            }
        }

        private void pictureBoxPants_Click(object sender, EventArgs e)
        {
            frmProductPlace frmP = new frmProductPlace("Pants");
            frmP.ShowDialog();
            if (frmP.DialogResult == DialogResult.OK)
            {
                Product p = (Product) frmP.Tag;
                list.products.Add(p);
                udpateInvoice();
            }
        }

        private void pictureBoxPants_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 9))
            {
                e.Graphics.DrawString("Pants", myFont, Brushes.Black,
                    new Point(pictureBoxPants.Height / 2 - 15, pictureBoxPants.Width / 2));
            }
        }

        private void pictureBoxShorts_Click(object sender, EventArgs e)
        {
            frmProductPlace frmP = new frmProductPlace("Shorts");
            frmP.ShowDialog();
            if (frmP.DialogResult == DialogResult.OK)
            {
                Product p = (Product) frmP.Tag;
                list.products.Add(p);
                udpateInvoice();
            }
        }

        private void pictureBoxShorts_Paint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Arial", 9))
            {
                e.Graphics.DrawString("Shorts", myFont, Brushes.Black,
                    new Point(pictureBoxShorts.Height / 2 - 15, pictureBoxShorts.Width / 2));
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void udpateInvoice()
        {
            invoice.List = list;
            detailsBox.Text = invoice.ToString();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (list.products.Count > 0)
            {
                bool flag = db.InsertLineItem(invoice);
                bool flag1 = db.InsertInvoice(invoice);

                foreach (var p in list.products)
                {
                    if (p.Type == "TeeShirt")
                    {
                        TeeShirt t = (TeeShirt) p;
                        int newQuantity = t.Dbquantity - t.Quantity;
                        db.UpdateTeeShirtQty(newQuantity, t.Size, t.Id);
                    }
                    if (p.Type == "Pants")
                    {
                        Pants t = (Pants) p;
                        int newQuantity = t.Dbquantity - t.Quantity;
                        db.UpdatePantsQty(newQuantity, t.Inseam, t.Waist, t.Id);
                    }
                    if (p.Type == "LSShirts")
                    {
                        LSShirt t = (LSShirt)p;
                        int newQuantity = t.Dbquantity - t.Quantity;
                        db.UpdateLSSQty(newQuantity, t.Neck, t.Sleeve, t.Id);
                    }
                    if (p.Type == "Shorts")
                    {
                        Shorts t = (Shorts)p;
                        int newQuantity = t.Dbquantity - t.Quantity;
                        db.UpdateShortsQty(newQuantity, t.Waist, t.Id);
                    }
                    if (p.Type == "SSShirt")
                    {
                        SSShirt t = (SSShirt)p;
                        int newQuantity = t.Dbquantity - t.Quantity;
                        db.UpdateSSShirtQty(newQuantity, t.Neck, t.Id);
                    }
                }

                if (flag && flag1)
                {
                    detailsBox.Text = "Thanks for your order.";
                    list.products.Clear();
                }
                else
                {
                    MessageBox.Show("Error in saving to file!");
                }
                invoice = new Invoice(list);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            list.products.Clear();
            udpateInvoice();
        }
    }
}