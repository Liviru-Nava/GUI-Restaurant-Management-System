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
    public partial class orders_history : Form
    {


        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader reader;
        public orders_history()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True");

        }

        private void orders_history_Load(object sender, EventArgs e)
        {
            DateTimePicker_today.Value= DateTime.Now;
           
                connection.Open();
                adapter = new SqlDataAdapter("select * from orders where CONVERT(DATE, Order_date)='"+ DateTimePicker_today.Value + "'order by Order_Bill_no desc", connection);
                DataTable table1 = new DataTable();
                adapter.Fill(table1);
                datagridview_Today_ord.DataSource = table1;
                connection.Close();

            
           
        }

        private void btn_ord_delete_Click(object sender, EventArgs e)
        {


            connection.Open();
            adapter = new SqlDataAdapter("select * from orders where CONVERT(DATE, Order_date)='" + DateTimePicker_today.Value + "'order by Order_Bill_no desc", connection);
            DataTable table1 = new DataTable();
            adapter.Fill(table1);
            datagridview_Today_ord.DataSource = table1;
            connection.Close();



            /*try
            {
                if (datagridview_Today_ord.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = datagridview_Today_ord.SelectedRows[0];
                    int selectedRowIndex = selectedRow.Index;
                    int recordId = Convert.ToInt32(selectedRow.Cells["Number"].Value); // Replace with the actual column name that contains the identifier


                    connection.Open();
                    
                    command = new SqlCommand("DELETE FROM Order_item WHERE Number = @Id", connection);

                    command.Parameters.AddWithValue("@Id", recordId);
                    command.ExecuteNonQuery();
                    connection.Close();



                    datagridview_Today_ord.Rows.RemoveAt(selectedRowIndex);
                }
                else
                {
                    MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Need to Select Row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("sql exception error" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again" + ex.Message);
            }*/
        }

        private void btn_back_cashi_Click(object sender, EventArgs e)
        {
            

            this.Close();


        }
    }
}
