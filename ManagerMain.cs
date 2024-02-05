using Microsoft.ReportingServices.Diagnostics.Internal;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace POS
{
    public partial class ManagerMain : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader reader;

        public ManagerMain()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True");
        }

       

        private void ManagerMain_Load(object sender, EventArgs e)
        {
            //not needed
            timer1.Start();
        }

        private void btn_Employee_register_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeRegistration register = new EmployeeRegistration(); //create an object to access or open the  registration form
            register.ShowDialog();  //open the registration form but you cannot click anywhere else
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            this.Hide();
            DailyStats statistcs = new DailyStats();    //create an object to access the statistics form
            statistcs.ShowDialog(); //open the statistics form
        }

        private void btn_Employee_details_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeDetails details = new EmployeeDetails();    //create an object to access the Employee details form
            details.ShowDialog();   //Open the details form
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportsNew report = new ReportsNew();     //create an object to access the report form
            report.ShowDialog();    //open the report form
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you wish to logout from your workspace?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            {
                LoginPage loginPage = new LoginPage();
                loginPage.Show();
                this.Close();
            }
            else
            {

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lbl_timeshow.Text = DateTime.Now.ToString("T");
            lbl_ddmmyyyy.Text = DateTime.Now.ToString("MMM dd yyyy");
            lbl_dateshow.Text = DateTime.Now.ToString("dddd");
        }
         public void login_user(string username)
        {
            connection.Open();
            command = new SqlCommand("select First_Name,User_Image  from EmployeeReg where Username='" + username + "'", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                txt_loginuser.Text = reader["First_Name"].ToString();

                byte[] arr = null;
                arr = (byte[])reader["User_Image"];

                // Replace it with [0][3] according to your posted query
                System.Drawing.Bitmap bitmap = null;
                ImageConverter converter = new ImageConverter();
                System.Drawing.Image img = (System.Drawing.Image)converter.ConvertFrom(arr);
                bitmap = (System.Drawing.Bitmap)img;
                picture_user.Image = bitmap;



            }
            connection.Close();
        }


    




    }
}
