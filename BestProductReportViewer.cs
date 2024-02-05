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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace POS
{
    public partial class BestProductReportViewer : Form
    {
        public BestProductReportViewer()
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

        private void btn_BestProduct_Click(object sender, EventArgs e)
        {
            string query = "SELECT TOP 5 p.Product_Id, p.Product_name, p.Product_price, SUM(oi.Quantity) as TotalSold " +
               "FROM Product_table p " +
               "INNER JOIN Order_item oi ON p.Product_Id = oi.Product_Id " +
               "GROUP BY p.Product_Id, p.Product_name, p.Product_price " +
               "ORDER BY TotalSold DESC;";


            connection.Open();
            DataTable dataTable = new DataTable();

            command = new SqlCommand(query, connection);
            adapter1 = new SqlDataAdapter(command);
            adapter1.Fill(dataTable);

            CrystalReportBestProduct crystal1 = new CrystalReportBestProduct();
            crystal1.Database.Tables["Order_item"].SetDataSource(dataTable);
            crystal1.Database.Tables["Product_table"].SetDataSource(dataTable);

            this.crystalReportViewerBestProduct.ReportSource = crystal1;
            connection.Close();
        }

        private void BestProductReportViewer_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
