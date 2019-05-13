using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesShop
{
    class ProductDB
    {
        private OleDbConnection connection;

        public ProductDB()
        {
            this.connection = null;
        }

        private String GetConnectionString()
        {
            return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\..\ClothesShop.mdb";
        }

        public OleDbConnection GetConnection()
        {
            string connectionString = GetConnectionString();
            if (connection == null)
            {
                connection = new OleDbConnection(connectionString);
            }

            if (connection != null && connection.State == ConnectionState.Closed)
            {
                Console.WriteLine("State is" + connection.State);
            }
            return connection;
        }

        public Product GetProduct(int Id)
        {
            Product p = null;
            var conn = GetConnection();
            string sql = string.Format("SELECT Product.* FROM Product where Id={0};", Id);
            OleDbCommand command = new OleDbCommand(sql, connection);
            try
            {
                conn.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        p = new Product(reader["Brand"].ToString(), Convert.ToInt16(reader["Id"]),
                            reader["Type"].ToString(), reader["Description"].ToString(), reader["Color"].ToString(),
                            Convert.ToDouble(reader["Price"]), Convert.ToDouble(reader["Cost"]), 1, 1);

                        Console.WriteLine(p.ToString());
                    }
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return p;
        }


        public List<Product> GetLSShirts(int id)
        {
            List<Product> list = new List<Product>();
            var conn = GetConnection();
            string sql = String.Format("SELECT LSShirt.* FROM LSShirt where ProductId = {0};", id);
            OleDbCommand command = new OleDbCommand(sql, connection);
            try
            {
                conn.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product p = new LSShirt(Convert.ToDouble(reader["Neck"]), Convert.ToInt16(reader["Sleeve"]));
                        p.Quantity = Convert.ToInt16(reader["Quantity"]);
                        p.Dbquantity = Convert.ToInt16(reader["Quantity"]);
                        Console.WriteLine(p.ToString());
                        list.Add(p);
                    }
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }

        public List<Product> GetSSShirts(int id)
        {
            List<Product> list = new List<Product>();
            var conn = GetConnection();
            string sql = String.Format("SELECT SSShirt.* FROM SSShirt where ProductId = {0};", id);
            OleDbCommand command = new OleDbCommand(sql, connection);
            try
            {
                conn.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product p = new SSShirt(Convert.ToDouble(reader["Neck"]));
                        p.Quantity = Convert.ToInt16(reader["Quantity"]);
                        p.Dbquantity = Convert.ToInt16(reader["Quantity"]);
                        Console.WriteLine(p.ToString());
                        list.Add(p);
                    }
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }


        public List<Product> GetTeeshirts(int id)
        {
            List<Product> list = new List<Product>();
            var conn = GetConnection();
            string sql = String.Format("SELECT TeeShirt.* FROM TeeShirt where ProductId = {0};", id);
            OleDbCommand command = new OleDbCommand(sql, connection);
            try
            {
                conn.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product p = new TeeShirt(reader["TeeSize"].ToString());
                        p.Quantity = Convert.ToInt16(reader["Quantity"]);
                        p.Dbquantity = Convert.ToInt16(reader["Quantity"]);
                        Console.WriteLine(p.ToString());
                        list.Add(p);
                    }
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }

        public List<Product> GetPants(int id)
        {
            List<Product> list = new List<Product>();
            var conn = GetConnection();
            string sql = String.Format("SELECT Pants.* FROM Pants where ProductId = {0};", id);
            OleDbCommand command = new OleDbCommand(sql, connection);
            try
            {
                conn.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product p = new Pants(Convert.ToInt16(reader["Inseam"]), Convert.ToInt16(reader["Waist"]));
                        p.Quantity = Convert.ToInt16(reader["Quantity"]);
                        p.Dbquantity = Convert.ToInt16(reader["Quantity"]);
                        Console.WriteLine(p.ToString());
                        list.Add(p);
                    }
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }


        public List<Product> GetShorts(int id)
        {
            List<Product> list = new List<Product>();
            var conn = GetConnection();
            string sql = String.Format("SELECT Shorts.* FROM Shorts where ProductId = {0};", id);
            OleDbCommand command = new OleDbCommand(sql, connection);
            try
            {
                conn.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product p = new Shorts(Convert.ToInt16(reader["Waist"]));
                        p.Quantity = Convert.ToInt16(reader["Quantity"]);
                        p.Dbquantity = Convert.ToInt16(reader["Quantity"]);
                        Console.WriteLine(p.ToString());
                        list.Add(p);
                    }
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }

        public int GetMaxInvoiceID()
        {
            int id = 0;

            var conn = GetConnection();
            string sql = "SELECT Max(Invoices.InvoiceID) AS InvoiceID FROM Invoices;";

            OleDbCommand command = new OleDbCommand(sql, connection);
            try
            {
                conn.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt16(reader["InvoiceID"]);
                    }
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return id;
        }

        public int GetMaxLineItemID()
        {
            int id = 0;

            var conn = GetConnection();
            string sql = "SELECT Max(LineItems.LineItemID) AS ID FROM LineItems;";

            OleDbCommand command = new OleDbCommand(sql, connection);
            try
            {
                conn.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt16(reader["ID"]);
                    }
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return id;
        }


        public bool InsertLineItem(Invoice invoice)
        {
            int id = GetMaxLineItemID() + 1;
            var list = invoice.List.products;

            foreach (var product in list)
            {
                var conn = GetConnection();
//                string sql =
//                    string.Format(",invoice.InvoiceNumber,product.Id,product.LineString(),product.Price,product.Quantity);

                OleDbCommand command =
                    new OleDbCommand(
                        "Insert into LineItems([LineItemID],[InvoiceID],[ProductID],[ProductLine],[ProductPrice],[ProductQuantity]) Values(@Id,@One,@Two,@Three,@Four,@Five);",
                        connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@One", invoice.InvoiceNumber);
                command.Parameters.AddWithValue("@Two", product.Id);
                command.Parameters.AddWithValue("@Three", product.LineString());
                command.Parameters.AddWithValue("@Four", product.Price);
                command.Parameters.AddWithValue("@Five", product.Quantity);
                try
                {
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();
                    id++;
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }

            return true;
        }


        public bool InsertInvoice(Invoice invoice)
        {
            var list = invoice.List.products;

            var conn = GetConnection();

            OleDbCommand command =
                new OleDbCommand(
                    "Insert into Invoices([InvoiceID],[InvoiceDate],[InvoiceSubTotal],[InvoiceTax],[InvoiceTotal]) Values(@One,@Two,@Three,@Four,@Five);",
                    connection);
            command.Parameters.AddWithValue("@One", invoice.InvoiceNumber);
            string dt = invoice.Time.ToString();
            command.Parameters.AddWithValue("@Two", OleDbType.DBTimeStamp).Value = DateTime.Parse(dt);
            command.Parameters.AddWithValue("@Three", invoice.SubTotal());
            command.Parameters.AddWithValue("@Four", invoice.SalesTax());
            command.Parameters.AddWithValue("@Five", invoice.Total());
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }


        public bool UpdateSSShirtQty(int qty, double neck, int pid)
        {
            var conn = GetConnection();

            string sql = string.Format("Update SSShirt Set Quantity={0} Where neck={1} and ProductId={2};", qty, neck,
                pid);
            OleDbCommand command =
                new OleDbCommand(
                    sql,
                    connection);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("UpdateSSShirtQty");

                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public bool UpdatePantsQty(int qty, int inseam, int waist, int pid)
        {
            var conn = GetConnection();

            string sql = string.Format(
                "Update Pants Set Quantity={0} Where inseam={1} and waist={2} and ProductId={3};", qty, inseam, waist,
                pid);
            OleDbCommand command =
                new OleDbCommand(
                    sql,
                    connection);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("UpdatePantsQty");
                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }


        public bool UpdateLSSQty(int qty, double neck, int sleeve, int pid)
        {
            var conn = GetConnection();

            string sql =
                string.Format("Update LSShirt Set Quantity={0} Where neck={1} and sleeve={2} and ProductId={3};", qty,
                    neck, sleeve, pid);
            OleDbCommand command =
                new OleDbCommand(
                    sql,
                    connection);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("UpdateLSSQty");

                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public bool UpdateShortsQty(int qty, int waist, int pid)
        {
            var conn = GetConnection();

            string sql = string.Format("Update Shorts Set Quantity={0} Where Waist={1} and ProductId={2};", qty, waist,
                pid);
            OleDbCommand command =
                new OleDbCommand(
                    sql,
                    connection);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("UpdateShortsQty");

                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public bool UpdateTeeShirtQty(int qty, string size, int pid)
        {
            var conn = GetConnection();

            string sql = string.Format("Update TeeShirt Set Quantity={0} Where TeeSize='{1}' and ProductId={2};", qty,
                size, pid);
            OleDbCommand command =
                new OleDbCommand(
                    sql,
                    connection);
            try
            {
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine("UpdateTeeShirtQty");

                Console.WriteLine(ex.Message);
                return false;
            }

            return true;
        }

        public List<Product> GetProductsByType(string type)
        {
            Console.WriteLine("Type is " + type);
            List<Product> all = new List<Product>();
            List<Product> list = new List<Product>();

            var conn = GetConnection();
            string sql = string.Format("SELECT Product.* FROM Product Where Type='{0}';", type);
            OleDbCommand command = new OleDbCommand(sql, connection);
            try
            {
                conn.Open();
                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Product p = new Product(reader["Brand"].ToString(), Convert.ToInt16(reader["Id"]),
                            reader["Type"].ToString(), reader["Description"].ToString(), reader["Color"].ToString(),
                            Convert.ToDouble(reader["Price"]), Convert.ToDouble(reader["Cost"]), 1, 1);
                        all.Add(p);
                        Console.WriteLine(p.ToString());
                    }
                }
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            foreach (var product in all)
            {
                List<Product> innerProduct = new List<Product>();
                if (type.Equals("LSShirt"))
                {
                    innerProduct = GetLSShirts(product.Id);
                }
                else if (type.Equals("Pants"))
                {
                    innerProduct = GetPants(product.Id);
                }
                else if (type.Equals("TeeShirt"))
                {
                    innerProduct = GetTeeshirts(product.Id);
                }
                else if (type.Equals("SSShirt"))
                {
                    innerProduct = GetSSShirts(product.Id);
                }
                if (type.Equals("Shorts"))
                {
                    innerProduct = GetShorts(product.Id);
                }
                foreach (var innerShirt in innerProduct)
                {
                    innerShirt.Copy(product);
                    list.Add(innerShirt);
                }
            }
            return list;
        }
    }
}