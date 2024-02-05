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
    public partial class SalesReportViewer : Form
    {
        public SalesReportViewer()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter1;

        private void guna_backButton_Click(object sender, EventArgs e)
        {
            ReportsNew main = new ReportsNew();
            this.Close();
            main.Show();
        }

        private void btn_reportSalesRange_Click(object sender, EventArgs e)
        {
            string date1 = datepickerFrom.Value.Year + "-" + datepickerFrom.Value.Month + "-" + datepickerFrom.Value.Day;
            string date2 = datepickerTo.Value.Year + "-" + datepickerTo.Value.Month + "-" + datepickerTo.Value.Day;
            string query = "SELECT Order_Bill_no, Order_date, Order_type, Payment_method, Order_total " +
                "FROM orders " +
                "WHERE Order_date >= CONVERT(datetime, '" + date1 + "') and Order_date<= CONVERT(datetime, '" + date2 + "');";


            connection.Open();
            DataTable dataTable = new DataTable();

            command = new SqlCommand(query, connection);
            adapter1 = new SqlDataAdapter(command);
            adapter1.Fill(dataTable);

            CrystalReportSales1 crystal1 = new CrystalReportSales1();
            crystal1.Database.Tables["orders"].SetDataSource(dataTable);

            this.crystalReportViewerSales.ReportSource = crystal1;
            connection.Close();
        }

        private void btn_reportSalesDate_Click(object sender, EventArgs e)
        {
            string date1 = datepicker.Value.Year + "-" + datepicker.Value.Month + "-" + datepicker.Value.Day;
            string query = "SELECT Order_Bill_no, Order_date, Order_type, Payment_method, Order_total " +
                "FROM orders " +
                "WHERE CONVERT(DATE,Order_date) = '" + date1 + "'";


            connection.Open();
            DataTable dataTable = new DataTable();

            command = new SqlCommand(query, connection);
            adapter1 = new SqlDataAdapter(command);
            adapter1.Fill(dataTable);

            CrystalReportSales1 crystal1 = new CrystalReportSales1();
            crystal1.Database.Tables["orders"].SetDataSource(dataTable);

            this.crystalReportViewerSales.ReportSource = crystal1;
            connection.Close();
        }

        private void SalesReportViewer_Load(object sender, EventArgs e)
        {
            datepicker.Value = DateTime.Now;
            datepickerFrom.Value = DateTime.Now;
            datepickerTo.Value = DateTime.Now;
        }
    }
}
