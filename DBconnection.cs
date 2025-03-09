using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Management_Application
{
    internal class DBconnection

    {
        DateTime dob = new DateTime();
        string connection = "Server=(localdb)\\mssqllocaldb; Database=C:\\USERS\\LOVEE\\DOCUMENTS\\STUDENTS.MDF; Integrated Security=True;";
        SqlConnection conn = new SqlConnection();
        public SqlConnection connect()
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                return conn;
               // conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
               return null;
            }

        }
        public bool insert_Product(int pro_id, string pro_name, string desc, string sku, int cost, int sell, int quant)
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                string querryIP = "INSERT into Product values( " + pro_id + " ,'" + pro_name + "','" + desc + "','" + sku + "'," + cost + "," + sell + "," + quant + ")";
                SqlCommand cmd = new SqlCommand(querryIP, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
        }
        public bool insert_Sales(int sales_id, int pro_id, DateTime dob, int qua_sold, int rev)
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                string querryIS = "INSERT into Sales values( " + sales_id + " ," + pro_id + ",'" + dob + "'," + qua_sold + "," + rev + ")";
                SqlCommand cmd = new SqlCommand(querryIS, conn);
                cmd.ExecuteNonQuery();
               // conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
        }
        public bool insert_Customer(int cust_id, string name, string email, string phone)
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                string querryIC = "INSERT into Customers values( " + cust_id + " ,'" + name + "','" + email + "','" + phone + "')";
                SqlCommand cmd = new SqlCommand(querryIC, conn);
                cmd.ExecuteNonQuery();
               // conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
        }
        public bool insert_SalesTrans(int trans_id, int pro_id, int cust_id)
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                string querryIT = "INSERT into SalesTransaction values( " + trans_id + " ," + pro_id + "," + cust_id + ")";
                SqlCommand cmd = new SqlCommand(querryIT, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
        }
        public bool insert_User(int user_id, string u_name, string pass, string role)
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                string querryIU = "INSERT into Users values( " + user_id + " ,'" + u_name + "','" + pass + "','" + role + "')";
                SqlCommand cmd = new SqlCommand(querryIU, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
        }
        public DataTable select_Product()
        {
            try
            {

                conn.ConnectionString = connection;
                conn.Open();
                string querrySP = "SELECT * FROM Product;";
                SqlDataAdapter adapter = new SqlDataAdapter(querrySP, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               // conn.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;" + ex.Message);
                return null;
            }
        }
        public DataTable select_Sales()
        {
            try
            {

                conn.ConnectionString = connection;
                conn.Open();
                string querrySS = "SELECT * FROM Sales;";
                SqlDataAdapter adapter = new SqlDataAdapter(querrySS, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //conn.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;" + ex.Message);
                return null;
            }
        }
        public DataTable select_Customers()
        {
            try
            {

                conn.ConnectionString = connection;
                conn.Open();
                string querrySC = "SELECT * FROM Customers;";
                SqlDataAdapter adapter = new SqlDataAdapter(querrySC, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               // conn.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;" + ex.Message);
                return null;
            }
        }
        public DataTable select_SalesTrans()
        {
            try
            {

                conn.ConnectionString = connection;
                conn.Open();
                string querryST = "SELECT * FROM SalesTransaction;";
                SqlDataAdapter adapter = new SqlDataAdapter(querryST, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               // conn.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;" + ex.Message);
                return null;
            }
        }
        public DataTable select_User()
        {
            try
            {

                conn.ConnectionString = connection;
                conn.Open();
                string querrySU = "SELECT * FROM Users;";
                SqlDataAdapter adapter = new SqlDataAdapter(querrySU, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               // conn.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error ;" + ex.Message);
                return null;
            }
        }
        public bool delete_Product(int pro_id)
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                string querryDP = " DELETE FROM Product WHERE ProductID = " + pro_id + ";";
                SqlCommand cmd = new SqlCommand(querryDP, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }

        }
        public bool delete_Sales(int sale_id)
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                string querryDS = " DELETE FROM Sales WHERE SaleID = " + sale_id + ";";
                SqlCommand cmd = new SqlCommand(querryDS, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
          

        }
        public bool delete_Customer(int cust_id)
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                string querryDC = " DELETE FROM Customers WHERE CustomerID = " + cust_id + ";";
                SqlCommand cmd = new SqlCommand(querryDC, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }

        }
        public bool delete_SalesTrans(int trans_id)
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                string querryDT = " DELETE FROM SalesTransaction WHERE TransactionID = " + trans_id + ";";
                SqlCommand cmd = new SqlCommand(querryDT, conn);
                cmd.ExecuteNonQuery();
               // conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }

        }
        public bool delete_User(int user_id)
        {
            try
            {
                conn.ConnectionString = connection;
                conn.Open();
                string querryDU = " DELETE FROM Users WHERE UserID = " + user_id + ";";
                SqlCommand cmd = new SqlCommand(querryDU, conn);
                cmd.ExecuteNonQuery();
               // conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }

        }
        public bool update_Product(int pro_id, string pro_name, string desc, string sku, int cost, int sell, int quant)
        {
            try
            {
                conn.Close();

                conn.ConnectionString = connection;
                conn.Open();
                string querryUP = "UPDATE Product SET ProductID =" + pro_id + ",ProductName ='" + pro_name + "', Description ='" + desc + "', SKU ='" + sku + "', CostPrice=" + cost + ", SellingPrice=" + sell + ", QuantityOnHand=" + quant + " WHERE ProductID=" + pro_id + ";";
                SqlCommand cmd = new SqlCommand(querryUP, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
        }
        public bool update_Sales(int sales_id, int pro_id, DateTime dob, int qua_sold, int rev)
        {
            try
            {
                conn.Close();

                conn.ConnectionString = connection;
                conn.Open();
                string querryUS = "UPDATE Sales SET SaleID = " + sales_id + " ,ProductID =" + pro_id + ", SaleDate =" + dob + ", QuantitySold =" + qua_sold + ",TotalRevenue =" + rev + ";";
                SqlCommand cmd = new SqlCommand(querryUS, conn);
                cmd.ExecuteNonQuery();
               // conn.Close();
                return true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
        }
        public bool update_Customer(int cust_id, string name, string email, string phone)
        {
            try
            {
                conn.Close();
                conn.ConnectionString = connection;
                conn.Open();
                string querryUC = "UPDATE Customers SET CustomerID =" + cust_id + " ,Cust_Name ='" + name + "',Cust_Email ='" + email + "', Cust_Phone='" + phone + "';";
                SqlCommand cmd = new SqlCommand(querryUC, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
        }
        public bool update_SalesTrans(int trans_id, int pro_id, int cust_id)
        {
            try
            {
                conn.Close();
                conn.ConnectionString = connection;
                conn.Open();
                string querryUT = "UPDATE SalesTransaction SET TransactionID= " + trans_id + " ,ProductID =" + pro_id + ",CustomerID =" + cust_id + ";";
                SqlCommand cmd = new SqlCommand(querryUT, conn);
                cmd.ExecuteNonQuery();
                //conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
        }
        public bool update_User(int user_id, string u_name, string pass, string role)
        {
            try
            {
                conn.Close();
                conn.ConnectionString = connection;
                conn.Open();
                string querryUU = "UPDATE Users SET UserID= " + user_id + " ,Username='" + u_name + "',Password ='" + pass + "',Role ='" + role + "')";
                SqlCommand cmd = new SqlCommand(querryUU, conn);
                cmd.ExecuteNonQuery();
               // conn.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return false;
            }
        }
        public DataTable GetTables(string query)
        {
            conn.Close();
            conn.ConnectionString = connection;
            conn.Open();
            DataTable table = new DataTable();
            SqlDataAdapter sqlData = new SqlDataAdapter(query,conn);
            sqlData.Fill(table);
           // conn.Close();
            return table;
            
        }
        public DataTable GetProductsAndSales()
        {


            try
            {
                conn.Close();
                conn.ConnectionString = connection;
                conn.Open();
                string query1 = "SELECT P.*, S.QuantitySold, S.SaleDate FROM Product P JOIN Sales S ON P.ProductID = S.ProductID";
                SqlDataAdapter adapter = new SqlDataAdapter(query1, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                //conn.Close();
                return dt;
                

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error :" + ex.Message);
                return null;
            }
        }

        public DataTable GetSortedProducts()
        {
            DataTable dt = new DataTable();

            try
            {
                conn.Close();
                conn.ConnectionString = connection;
                conn.Open();
                string query2 = "SELECT * FROM Product ORDER BY ProductName ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(query2, conn);
                DataTable tab = new DataTable();
                adapter.Fill(tab);
                //conn.Close();
                return tab;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return null;

            }
        }

        public DataTable GetCustomerProductInfo()
        {


            try
            {
                conn.Close();
                conn.ConnectionString = connection;
                conn.Open();
                string query3 = "SELECT C.Cust_Name, P.ProductName FROM Customers C JOIN SalesTransaction ST ON C.CustomerID = ST.CustomerID JOIN Product P ON ST.ProductID = P.ProductID";
                SqlDataAdapter adapter = new SqlDataAdapter(query3, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
               // conn.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return null;

            }
        }
        public int GetCustomerCount()
        {
            int count=0;

            try
            {
                conn.Close();
                conn.ConnectionString = connection;
                conn.Open();
                string query5 = "SELECT COUNT(*) FROM Customers";
                SqlCommand cmd = new SqlCommand(query5, conn);
                count=cmd.ExecuteNonQuery();
                return count;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return 0;
            }
        }

        public int GetTotalRevenue()
        {
            int totalRevenue;

            try
            {
                conn.Close();
                conn.ConnectionString = connection;
                conn.Open();
                string query6 = "SELECT SUM(CostPrice) FROM Product";
                SqlDataAdapter cmd = new SqlDataAdapter(query6, conn);
                DataTable dt=new DataTable();
                cmd.Fill(dt);
                totalRevenue = Convert.ToInt32( dt.Rows[0][0]);
                conn.Close();
                return totalRevenue;
               


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return 0;
            }
        }
        public DataTable Between()
        {
            try
            {
                conn.Close();
                conn.ConnectionString = connection;
                conn.Open();
                string query7 = "SELECT ProductName,Description From PRODUCT WHERE CostPrice BETWEEN 50 AND 250";
                SqlDataAdapter adapter = new SqlDataAdapter(query7, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                conn.Close();
                return dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
                return null;

            }
        }
    }
}
      
      






      
