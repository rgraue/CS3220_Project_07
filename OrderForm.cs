/*
 * Author:          Ryan Graue
 * Class:           CSC 3220
 * Title:           Project 07
 * Date:            March 15, 2021
 * Desc:            Ordering form for an ice cream shop. Can enter specific details for items/orders.
 */

using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_07
{
    public partial class OrderForm : Form
    {
        private SqlConnection conn = new SqlConnection(
            "data source = (local);DataBase=Project07; Integrated Security = SSPI"      // database = Project07
            ); 

        public OrderForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Loads the data in the orderFrom window
        /// </summary>
        /// <param name="sender">button object which triggers the event</param>
        /// <param name="e">arguments included with the event</param>
        public void OrderForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                updateDatGrid();
            } catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            
            conn.Close();
        }
        /// <summary>
        /// Button for submitting the price entry to the sql server
        /// </summary>
        /// <param name="sender">button object which triggers the event</param>
        /// <param name="e">arguments included with the event</param>
        private void buttonPriceOverride_Click(object sender, EventArgs e)
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            string time = DateTime.Now.ToString("HH:mm");
            int id = getUniqueId();
            decimal price = 0.00M;
            try {
                price = Convert.ToDecimal(textBoxPriceOverride.Text);
                conn.Open();
                string values = id + ",'" + date + "'" + "," + "'" + time + "'" + "," + price;
                SqlCommand add = new SqlCommand("Insert Into [Orders] (Id, Date, Time, Price) values (" + values + ")", conn);
                add.ExecuteNonQuery();
            } catch (FormatException)
            {
                Console.WriteLine("Wrong input format");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            updateDatGrid();
            conn.Close();
        }

        /// <summary>
        /// Recursivley searches the sql server until a unique id is found for a new entry
        /// </summary>
        /// <returns>an int for the primary key. returns -1 if an error occurs in sql search.</returns>
        private int getUniqueId()
        {
            try
            {
                conn.Open();
                Random rand = new Random();
                int temp = rand.Next(100001);
                SqlCommand search = new SqlCommand("Select Id From Orders Where Id =" + temp, conn);        // sql query for id num
                SqlDataReader reader = search.ExecuteReader();
                if (reader.HasRows)
                {
                    return getUniqueId();
                }
                else
                {
                    conn.Close();
                    return temp;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            return -1;
        }

        /// <summary>
        /// updates the data grid
        /// </summary>
        private void updateDatGrid ()
        {
            // selects all entries from the sql server
            string sqlRetrieveAll = "Select * From Orders";
            SqlCommand command = new SqlCommand(sqlRetrieveAll, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataSet DF = new DataSet();
            adapter.Fill(DF);

            // enters the information into an DataTable object for the data grid.
            DataTable gridTable = DF.Tables[0];

            dataGridViewOrders.DataSource = gridTable;
            dataGridViewOrders.Refresh();
        }
    }
}
