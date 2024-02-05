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
    public partial class statsRevenue : Form
    {
        public statsRevenue()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;

        private void btn_totalOrders_Click(object sender, EventArgs e)
        {
            RevenueChart.Visible = true;
            RevenueChart1.Visible = true;

            string query = "SELECT Payment_method, SUM(Order_total) AS total_revenue FROM orders WHERE CONVERT(DATE, Order_date) = CONVERT(DATE, GETDATE()) GROUP BY Payment_method";

            command = new SqlCommand(query, connection);

            connection.Open();
            reader = command.ExecuteReader();

            RevenueChart.Series["Payment_method"].Points.Clear();
            RevenueChart1.Series["Payment_method"].Points.Clear();

            while (reader.Read())
            {
                string paymentMethod = (string)reader["Payment_method"];
                double sum = (double)reader["total_revenue"];

                RevenueChart.Series["Payment_method"].Points.AddXY(paymentMethod, sum);
                RevenueChart1.Series["Payment_method"].Points.AddXY(paymentMethod, sum);
            }
            reader.Close();
            connection.Close();
        }

        private void statsRevenue_Load(object sender, EventArgs e)
        {
            RevenueChart.Visible = false;
            RevenueChart1.Visible = false;

            string query = "SELECT SUM(Order_total) AS total_revenue FROM orders WHERE CONVERT(DATE, order_date) = CONVERT(DATE, GETDATE());";

            command = new SqlCommand(query, connection);
            connection.Open();

            object result = command.ExecuteScalar();
            if (result != null && result != DBNull.Value)
            {
                if (double.TryParse(result.ToString(), out double totalRevenue))
                {
                    lbl_orders.Text = "Total revenue for today is " + totalRevenue.ToString();
                }
                else
                {
                    // Handle the case where conversion to double failed
                    lbl_orders.Text = "Error: Unable to convert the total revenue to double.";
                }
            }
            else
            {
                // Handle the case where the result is null or DBNull
                lbl_orders.Text = "No revenue data available for today.";
            }

            connection.Close();
        }
    }
}
