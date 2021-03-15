using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_07
{
    public partial class OrderForm : Form
    {
       // private string stringConnect = "data source = (local);DataBase=Project07; Integrated Security = SSPI";      // DATABASE = Project07
        private SqlConnection conn = new SqlConnection("data source = (local);DataBase=Project07; Integrated Security = SSPI");

        public OrderForm()
        {
            InitializeComponent();
        }
        
        public void OrderForm_Load(object sender, EventArgs e)
        {
            //conn.ConnectionString = stringConnect;
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

        private void buttonPriceOverride_Click(object sender, EventArgs e)
        {
            //conn.ConnectionString = stringConnect;
            //conn.Open();

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

        private int getUniqueId()
        {
            //conn.ConnectionString = stringConnect;
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

        private void updateDatGrid ()
        {
            string sqlRetrieveAll = "Select * From Orders";
            SqlCommand command = new SqlCommand(sqlRetrieveAll, conn);

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;

            DataSet DF = new DataSet();
            adapter.Fill(DF);

            DataTable gridTable = DF.Tables[0];

            dataGridViewOrders.DataSource = gridTable;
            dataGridViewOrders.Refresh();
        }
    }
}
