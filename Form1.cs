/*
 * Author:          Ryan Graue
 * Date:            March 7th, 2021
 * Title:           Project 06
 * Desc:            App to record and store ice cream orders. recors are stored in local sql database (Project06).
 */

using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project_07
{
    public partial class Form1 : Form
    {
        private const decimal priceChoc = 1.50M;
        private const decimal priceVan = 1.00M;
        private const decimal priceStraw = 2.00M;
                                                        // Price constants
        private const decimal priceNuts = 1.00M;
        private const decimal priceCherry = 0.75M;
        private const decimal priceSprink = 0.50M;

        private decimal totalPrice = 0.00M;

        private string stringConnect = "data source = (local);DataBase=Project07; Integrated Security = SSPI";      // DATABASE = Project07
        private SqlConnection conn = new SqlConnection();
        

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adds the total price of the specific cone to the order
        /// </summary>
        /// <param name="sender">button object which triggers the event</param>
        /// <param name="e">arguments included with the event</param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            decimal orderPrice = 0.00M;
            if (radioButtonChoc.Checked == true)
            {
                orderPrice += priceChoc;

            }
            else if (radioButtonStraw.Checked == true)
            {
                orderPrice += priceStraw;

            }
            else if (radioButtonVan.Checked == true)
            {
                orderPrice += priceVan;
            }
            if (checkBoxCherry.Checked == true)
            {
                orderPrice += priceCherry;
            }
            if (checkBoxNuts.Checked == true)
            {
                orderPrice += priceNuts;
            }
            if (checkBoxSprinkles.Checked == true)
            {
                orderPrice += priceSprink;
            }

            listBoxOrders.Items.Add(orderPrice);
            totalPrice += orderPrice;
        }
        /// <summary>
        /// Clears the current order
        /// </summary>
        /// <param name="sender">button object which triggers the event</param>
        /// <param name="e">arguments included with the event</param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            totalPrice = 0.0M;
            listBoxOrders.Items.Clear();
        }

        /// <summary>
        /// Sums the total order. Sends ther order total to to the local sql database
        /// </summary>
        /// <param name="sender">button object which triggers the event</param>
        /// <param name="e">arguments included with the event</param>
        private void buttonTotal_Click(object sender, EventArgs e)
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            string time = DateTime.Now.ToString("HH:mm");
            int id = getUniqueId();
            string values = id + ",'" + date + "'" + "," +  "'"+ time + "'" + "," +  totalPrice;

            conn.ConnectionString = stringConnect;
            conn.Open();
            SqlCommand add = new SqlCommand("Insert Into [Orders] (Id, Date, Time, Price) values (" + values + ")", conn);
            add.ExecuteNonQuery();

            textBoxTotal.Text = "$" + totalPrice;

            listBoxTotTrans.Items.Add(totalPrice);
            conn.Close();
        }

        /// <summary>
        /// Adds up the total transactions for the day
        /// </summary>
        /// <param name="sender">button object which triggers the event</param>
        /// <param name="e">arguments included with the event</param>
        private void buttonTotalTrans_Click(object sender, EventArgs e)
        {

            Decimal dayTotal = 0.0M;
            foreach (Decimal d in listBoxTotTrans.Items)
            {
                dayTotal += d;
            }

            textBoxTransSummary.Text = "$" + dayTotal;
        }

        /// <summary>
        /// returns a unique primary key int for each entity in the database. Recursivley checks to find unique int
        /// </summary>
        /// <returns>unique int for primary key</returns>
        private int getUniqueId ()
        {
            conn.ConnectionString = stringConnect;
            conn.Open();
            Random rand = new Random();
            int temp = rand.Next(100001);
            SqlCommand search = new SqlCommand("Select Id From Orders Where Id =" + temp, conn);        // sql query for id num
            SqlDataReader reader = search.ExecuteReader();
            if (reader.HasRows)
            {
                return getUniqueId();     
            } else
            {
                conn.Close();
                return temp;
            }   
        }


        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.TopLevel = true;
            orderForm.Show();

        }
    }
}
