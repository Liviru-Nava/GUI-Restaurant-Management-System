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
    public partial class OrderItemReportViewer : Form
    {
        public OrderItemReportViewer()
        {
            InitializeComponent();
        }

        //initialize sql connections
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

        private void btn_generateOI_Click(object sender, EventArgs e)
        {
            string BillNumber = txt_search.Text;
            string query = "SELECT Order_Bill_no, Product_ID, Quantity, price FROM Order_item WHERE Order_Bill_no = '" + BillNumber + "'";

            connection.Open();
            DataTable dataTable = new DataTable();

            command = new SqlCommand(query, connection);
            adapter1 = new SqlDataAdapter(command);
            adapter1.Fill(dataTable);

            CrystalReportOrderItem1 crystal1 = new CrystalReportOrderItem1();
            crystal1.Database.Tables["Order_item"].SetDataSource(dataTable);

            this.crystalReportViewerOrderItem.ReportSource = crystal1;

            connection.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.Length >= 4)
            {
                connection.Open();
                string query = "SELECT DISTINCT Order_Bill_no from Order_item where Order_Bill_no like @bill;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@bill", txt_search.Text + "%");
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    //dgv_Searchresult.Height = 0;
                    dgv_search.DataSource = dataTable;
                    dgv_search.Height = dgv_search.Rows.Count * 10;
                }
                else
                {
                    dgv_search.Height = 0;
                }
                //dgv_Searchresult.DataSource = dataTable;
                command.Dispose();
                adapter.Dispose();
                connection.Close();
            }
            else if (txt_search.Text.Length <= 0)
            {
                dgv_search.Height = 0;
            }
        }

        private void dgv_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value from the clicked cell
                object Value = dgv_search.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Display the value in the TextBox (assuming txt_search is the TextBox control)
                txt_search.Text = Value.ToString();

                if (!string.IsNullOrEmpty(txt_search.Text))
                {
                    dgv_search.Height = 0;
                }
            }
        }

        private void OrderItemReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
