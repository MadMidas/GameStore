using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DeleonD_FinalProject_ACS
{
    class ProgOps
    {
        //connection string
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database= TheSpire_DD_2353SU21;User Id=ddeleonsu212353;password=1632908";
        //build a connection to Movie store db
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //est objects for VideoGames table
        private static SqlCommand _sqlVideoGamesCommand;
        private static SqlDataAdapter _daVideoGames = new SqlDataAdapter();
        private static DataTable _dtVideoGamesTable = new DataTable();
        //create variables
        public static int custID;
        public static int orderID;
        public static int ordersID;
        public static void OpenDatabase()
        {
            //open the connection to Spire database
            _cntDatabase.Open();
        }
        public static void CloseDatabase()
        {
            //close connection
            _cntDatabase.Close();
            //dispose of database
            _cntDatabase.Dispose();
        }
        public static void DatabaseCommandVideoGames(DataGridView dgvGames)
        {
            //set commandd object to null
            _sqlVideoGamesCommand = null;
            //reset data adapter and data table to new
            _daVideoGames = new SqlDataAdapter();
            _dtVideoGamesTable = new DataTable();

            try
            {
                string query = "SELECT * FROM VideoGames;";
                //est command object
                _sqlVideoGamesCommand = new SqlCommand(query,_cntDatabase);
                //est data adapter
                _daVideoGames.SelectCommand = _sqlVideoGamesCommand;
                //fill data table
                _daVideoGames.Fill(_dtVideoGamesTable);
                //bind dgvGames to data table
                dgvGames.DataSource = _dtVideoGamesTable;
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in filling VideoGames Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose
            _sqlVideoGamesCommand.Dispose();
            _daVideoGames.Dispose();
            _dtVideoGamesTable.Dispose();
        }
        public static void GetIDs()
        {
            //gets the customer max id
            string query = "SELECT MAX(CustomerID)From Customers;";
            //est sql command
            SqlCommand _custIDCommand;
            //sql command
            _custIDCommand = new SqlCommand(query, _cntDatabase);
            //returns value
            custID = Convert.ToInt32(_custIDCommand.ExecuteScalar());
            custID += 1;
            //disposes command
            _custIDCommand.Dispose();

            //gets the order max id
            string query2 = "SELECT MAX(OrderID)From Orders;";
            //est sql command
            SqlCommand _orderIDCommand;
            //sql command
            _orderIDCommand = new SqlCommand(query2, _cntDatabase);
            //returns value
            orderID = Convert.ToInt32(_orderIDCommand.ExecuteScalar());
            orderID += 1;
            //disposes command
            _orderIDCommand.Dispose();

            //gets the max orderdetails id
            string query3 = "SELECT MAX(OrdersID)From OrderDetails;";
            //est sql command
            SqlCommand _orderDetailsIDCommand;
            //sql command
            _orderDetailsIDCommand = new SqlCommand(query3, _cntDatabase);
            //returns value
            ordersID = Convert.ToInt32(_orderDetailsIDCommand.ExecuteScalar());
            ordersID += 1;
            //disposes command
            _orderDetailsIDCommand.Dispose();
        }
        public static void InsertIntoOrderDetails(double sub, double tax, double total)
        {
            try
            {
                //inserts the variables into the database for orderdetails
                string query = "INSERT INTO OrderDetails(CustomerID, OrdersID, SubTotal, TaxAmount, Total_Line_Cost)";
                query += " VALUES(" + custID + ", " + ordersID + ", " + sub + ", " + tax + ", " + total + ");";
                //create update command
                SqlCommand _sqlInsertOrderDetailsCommand = new SqlCommand(query, _cntDatabase);
                //update command
                _sqlInsertOrderDetailsCommand.ExecuteNonQuery();
                _sqlInsertOrderDetailsCommand.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error inserting into OrderDetails Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void InsertIntoOrders(string upc, int quantity)
        {
            try
            {
                //inserts the variables into the database for orders
                string query = "INSERT INTO Orders(OrderID, Video_Game_UPC, CustomerID, Order_Quantity)";
                query += " VALUES(" + orderID + ", '" + upc + "', " + custID + ", " + quantity + ");";
                //create update command
                SqlCommand _sqlInsertOrdersCommand = new SqlCommand(query, _cntDatabase);
                //update command
                _sqlInsertOrdersCommand.ExecuteNonQuery();
                _sqlInsertOrdersCommand.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error inserting into Orders Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void InsertIntoCustomers(string name, string address, string email)
        {
            try
            {
                //inserts the variables into the database for customers
                string query1 = "INSERT INTO Customers(CustomerID, Cust_Name, Address, Email)";
                query1 += " VALUES(" + custID + ", '" + name + "', '" + address + "', '" + email + "');";
                //create update command
                SqlCommand _sqlInsertCustomersCommand = new SqlCommand(query1, _cntDatabase);
                //update command
                _sqlInsertCustomersCommand.ExecuteNonQuery();
                _sqlInsertCustomersCommand.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error inserting into Customers Table", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void UpdateQuantity(string gameTitle, int gameQuantity)
        {
            try
            {
                string query = "Update VideoGames Set Video_QuantityOnHand=" + gameQuantity + " Where Video_Title='" + gameTitle + "'" + ";";
                //create update command
                _sqlVideoGamesCommand = new SqlCommand(query, _cntDatabase);
                //update command
                _sqlVideoGamesCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //show message on error
                MessageBox.Show(ex.Message, "Error in Updating Quantity", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose
            _sqlVideoGamesCommand.Dispose();
            _daVideoGames.Dispose();
        }
    }


}

