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
    public partial class ProductReportViewer : Form
    {
        public ProductReportViewer()
        {
            InitializeComponent();
        }

        //Initialize the sql connections
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True");
        SqlCommand command;
        SqlDataReader reader;
        SqlDataAdapter adapter1;

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.Length >= 1)
            {
                connection.Open();
                string query = "SELECT Product_ID, Product_name, Product_price FROM Product_table WHERE Product_ID like @productID;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@productID", txt_search.Text + "%");
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    //dgv_Searchresult.Height = 0;
                    dgv_search.DataSource = dataTable;
                    dgv_search.Height = dgv_search.Rows.Count * 20;

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

        private void btn_generateProduct_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (!String.IsNullOrEmpty(txt_search.Text))
            {
                string ProductID = txt_search.Text;
                string query = "SELECT Product_ID, Product_name, Product_price FROM Product_table WHERE Product_ID = '" + ProductID + "'";


                DataTable dataTable = new DataTable();

                command = new SqlCommand(query, connection);
                adapter1 = new SqlDataAdapter(command);
                adapter1.Fill(dataTable);

                CrystalReportProduct1 crystal1 = new CrystalReportProduct1();
                crystal1.Database.Tables["Product_table"].SetDataSource(dataTable);

                this.crystalReportViewerProduct1.ReportSource = crystal1;
            }
            if (txt_search.Text.Length >= 2)
            {
                string query = "SELECT Product_ID, Product_name, Product_price FROM Product_table WHERE Product_ID like @productID;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@productID", txt_search.Text + "%");

                DataTable dataTable = new DataTable();
                adapter1 = new SqlDataAdapter(command);
                adapter1.Fill(dataTable);

                CrystalReportProduct1 crystal1 = new CrystalReportProduct1();
                crystal1.Database.Tables["Product_table"].SetDataSource(dataTable);

                this.crystalReportViewerProduct1.ReportSource = crystal1;
            }
            else
            {
                string query = "SELECT Product_ID, Product_name, Product_price FROM Product_table";

                DataTable dataTable = new DataTable();

                command = new SqlCommand(query, connection);
                adapter1 = new SqlDataAdapter(command);
                adapter1.Fill(dataTable);

                CrystalReportProduct1 crystal1 = new CrystalReportProduct1();
                crystal1.Database.Tables["Product_table"].SetDataSource(dataTable);

                this.crystalReportViewerProduct1.ReportSource = crystal1;
            }

            connection.Close();
        }

        private void ProductReportViewer_Click(object sender, EventArgs e)
        {
            dgv_search.Height = 0;
        }

        private void guna_backButton_Click(object sender, EventArgs e)
        {
            ReportsNew main = new ReportsNew();
            this.Close();
            main.Show();
        }

        private void ProductReportViewer_Load(object sender, EventArgs e)
        {

        }
    }
}
