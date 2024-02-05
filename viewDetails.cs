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
    public partial class viewDetails : Form
    {
        public viewDetails()
        {
            InitializeComponent();
        }

        string connstring = "Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True";

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text.Length >= 2)
            {
                SqlConnection connection = new SqlConnection(connstring);
                connection.Open();
                string query = "select Employee_ID, Position, First_Name from EmployeeReg where Employee_ID like @id or Position like @pos or First_Name like @fname";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", txt_search.Text + "%");
                command.Parameters.AddWithValue("@pos", txt_search.Text + "%");
                command.Parameters.AddWithValue("@fname", txt_search.Text + "%");
                DataTable dataTable = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    //dgv_Searchresult.Height = 0;
                    dgv_Searchresult.DataSource = dataTable;
                    dgv_Searchresult.Height = dgv_Searchresult.Rows.Count * 30;
                }
                else
                {
                    dgv_Searchresult.Height = 0;
                }
                //dgv_Searchresult.DataSource = dataTable;
                command.Dispose();
                adapter.Dispose();
                connection.Close();
            }
            else if (txt_search.Text.Length <= 0)
            {
                dgv_Searchresult.Height = 0;
            }
        }

        private void dgv_Searchresult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            string value = dgv_Searchresult.Rows[row].Cells[column].Value.ToString();

            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();

            string query = "SELECT Employee_ID, Position, First_Name, Last_Name, Gender, Email, Telephone, Address, Date_of_Birth, Age, Username, User_Image" +
                " FROM EmployeeReg WHERE Employee_ID = @Employee_ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Employee_ID", value);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string column1 = reader["Employee_ID"].ToString();
                string column2 = reader["Position"].ToString();
                string column3 = reader["First_Name"].ToString();
                string column4 = reader["Last_Name"].ToString();
                string column5 = reader["Gender"].ToString();
                string column6 = reader["Email"].ToString();
                string column7 = reader["Telephone"].ToString();
                string column8 = reader["Address"].ToString();
                DateTime dateOfBirth = (DateTime)reader["Date_of_Birth"];
                string formattedDateOfBirth = dateOfBirth.ToString("MM/dd/yyyy");
                //string column9 = reader["Date_of_Birth"].ToString();
                string column10 = reader["Age"].ToString();
                string column11 = reader["Username"].ToString();

                txt_empID.Text = column1;
                txt_position.Text = column2;
                txt_fname.Text = column3;
                txt_lname.Text = column4;
                txt_gender.Text = column5;
                txt_email.Text = column6;
                txt_tp.Text = column7;
                txt_address.Text = column8;
                txt_DOB.Text = formattedDateOfBirth;
                txt_age.Text = column10;
                txt_username.Text = column11;
                

                byte[] arr = null;
                arr = (byte[])reader["User_Image"];

                // Replace it with [0][3] according to your posted query
                System.Drawing.Bitmap bitmap = null;
                ImageConverter converter = new ImageConverter();
                System.Drawing.Image img = (System.Drawing.Image)converter.ConvertFrom(arr);
                bitmap = (System.Drawing.Bitmap)img;
                emp_pictureBox.Image = bitmap;

            }
            reader.Close();

            dgv_Searchresult.Height = 0;
            txt_search.Clear();

            connection.Close();
        }

        private void viewDetails_Click(object sender, EventArgs e)
        {
            dgv_Searchresult.Height = 0;
            txt_search.Clear();
        }

        private void viewDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
