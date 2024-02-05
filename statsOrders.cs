using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class statsOrders : Form
    {
        public statsOrders()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        private void btn_totalOrders_Click(object sender, EventArgs e)
        {
            OrdersChart.Visible = true;
            OrdersChart1.Visible = true;
            string query = "SELECT Order_Type, COUNT(Order_Bill_no) AS order_count FROM orders WHERE CONVERT(DATE, Order_date) = CONVERT(DATE, GETDATE()) GROUP BY Order_Type";

            command = new SqlCommand(query, connection);

            connection.Open();
            reader = command.ExecuteReader();

            OrdersChart.Series["Order_type"].Points.Clear();
            OrdersChart1.Series["Order_type"].Points.Clear();

            while (reader.Read())
            {
                string orderType = (string)reader["order_type"];
                int count = (int)reader["order_count"];

                OrdersChart.Series["Order_type"].Points.AddXY(orderType, count);
                OrdersChart1.Series["Order_type"].Points.AddXY(orderType, count);
            }
            reader.Close();
            connection.Close();
        }

        private void statsOrders_Load(object sender, EventArgs e)
        {
            OrdersChart.Visible = false;
            OrdersChart1.Visible = false;

            string query = "SELECT COUNT(Order_Bill_no) AS total_orders FROM orders WHERE CONVERT(DATE, Order_date) = CONVERT(DATE, GETDATE())";

            command = new SqlCommand(query, connection);
            connection.Open();

            int totalOrders = (int)command.ExecuteScalar();
            lbl_orders.Text = "Total order for today is " + totalOrders.ToString();

            connection.Close();
        }
    }
}
