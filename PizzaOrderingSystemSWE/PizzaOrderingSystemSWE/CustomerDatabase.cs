using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace PizzaOrderingSystemSWE
{
    public class CustomerDatabase
    {
        #region Fields
        private bool isConnected;   //connection status to DB
        private string connString;
        private SqlConnection conn;
        #endregion



        #region Constructors
        public CustomerDatabase()
        {

            string path = @"C:\Users\Raul Rojas\OneDrive - Kennesaw State University\Fall 2017\SWE 1301 Intro to Software Engineering\SWE 3313 Team 7 Project\New folder\PizzaOrderingSystemSWE\PizzaOrderingSystemSWE\MomPopDb.mdf";
            connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + ";Integrated Security=True";

            if (connectToDB())
                this.isConnected = true;
            else
                this.isConnected = false;
        }
        #endregion



        #region Public Methods
        private bool connectToDB()
        {
            bool connection = false;
            conn = new SqlConnection(connString);
            conn.Open();
            connection = true;
            conn.Close();
            return connection;
        }

        public bool createNewProfile(Customer c)
        {
            bool isSuccessful = false;
            conn.Open();
            string query = "INSERT INTO customer (name, address, phone, cardNum, directions)" +
                " VALUES ('" + c.Name + "', '" +
                             c.Address + "', '" +
                             c.Phone + "', '" +
                             c.CardNum + "', '" +
                             c.Directions + "')";
            SqlCommand comm = new SqlCommand(query, conn);
            try
            {
                comm.ExecuteNonQuery();
                isSuccessful = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error:\nCustomer with the same number may already exist.\nError Message: " + e.Message);
                isSuccessful = false;
            }
            conn.Close();
            return isSuccessful;
        }

        public Customer retrieveProfile(string phoneNum)
        {
            Customer c;
            //retreive customer record from data base here
            //replace the following line with code that fills 
            //  customer object with retrieved data.
            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM customer WHERE phone = " + phoneNum, connString);
            DataTable profile = new DataTable();
            adapter.Fill(profile);
            try
            {
                DataRow dr = profile.Rows[0];
                
                if (((string)dr["name"]).Length > 1)
                {
                    c = new Customer((int)dr["Id"],(string)dr["name"], (string)dr["address"], phoneNum, (string)dr["cardNum"], (string)dr["directions"]);
                }
                else
                    c = new Customer();
            }
            catch (Exception)
            {
                MessageBox.Show("Error\nCustomer not found.");
                c = new Customer();
            }
            
            //MessageBox.Show(c.ToString());
            conn.Close();
            return c;
        }

        public DataTable getInventory()
        {
            DataTable inventory = new DataTable();

            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT productName, price, type FROM inventory", conn);
            adapter.Fill(inventory);
            conn.Close();

            return inventory;
        }

        public bool updateCustomer(Customer c)
        {
            Customer oldCInfo = retrieveProfile(c.Phone);
            string command = "UPDATE customer SET ";
            int changeCount = 0;
            if (c.Name != oldCInfo.Name)
            {
                changeCount++;
                command += "name = '" + c.Name + "', ";
            }
            if (c.Address != oldCInfo.Address)
            {
                changeCount++;
                command += "address = '" + c.Address + "', ";
            }
            if (c.CardNum != oldCInfo.CardNum)
            {
                changeCount++;
                command += "cardNum = '" + c.CardNum + "', ";
            }
            if (c.Directions != oldCInfo.Directions)
            {
                changeCount++;
                command += "directions = '" + c.Directions + "' ";
            }
            command += "WHERE phone = '" + c.Phone + "'";
            if (changeCount > 0)
            {
                SqlCommand sqlComm = new SqlCommand(command, conn);
                conn.Open();
                if (sqlComm.ExecuteNonQuery() > 0)
                {
                    conn.Close();
                    return true;
                }
                else
                {
                    conn.Close();
                    return false;
                }               
                
            }
            else
                return false;
        }

        //public float getPrice(string product)
        //{
        //    string query = "SELECT price FROM inventory WHERE product LIKE '%" + product + "%'";
        //    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
        //    DataTable data = new DataTable();
        //    conn.Open();
        //    adapter.Fill(data);
        //    conn.Close();
        //    DataRow dr = data.Rows[0];

        //}
        #endregion

    }
}
