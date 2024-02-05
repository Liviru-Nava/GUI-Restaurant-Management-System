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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static MetroFramework.Drawing.MetroPaint.BorderColor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.InteropServices;

namespace POS
{
    public partial class LoginPage : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int RightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );



        public LoginPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter da;

        private void LoginPage_Load(object sender, EventArgs e)
        {
            con = new SqlConnection("Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True");

        }

        private void logincheker(string emptype)
        {
           
            
           
           

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username;
            string password;


            if (cmbxEmployeeType.SelectedIndex==-1)
            {
                lblUsernameError.Text = "";
                lblPasswordError.Text = "";
                lblEmployeeError.Text = "Employee Type cannot be empty.";
            }
            else if (txtUsername.Text.Length==0)
            {
                lblEmployeeError.Text = "";
                lblPasswordError.Text = string.Empty;
                lblUsernameError.Text = "Username cannot be empty";
            }
            else if (txtPassword.Text.Length==0)
            {

                lblEmployeeError.Text = "";

                lblUsernameError.Text = string.Empty;
                lblPasswordError.Text = "Password cannot be empty";
            }




            else 
            {

                if (cmbxEmployeeType.SelectedIndex == 0)//manager
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("select Username ,Password from EmployeeReg where Position='manager'", con);

                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            username = reader["Username"].ToString();
                            password = reader["Password"].ToString();

                            if (txtUsername.Text == username && txtPassword.Text == password) //if username password is corerct
                            {

                                ManagerMain form1= new ManagerMain();
                                form1.login_user(txtUsername.Text);
                                form1.Show();
                                MessageBox.Show("Login successful!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username And Password, Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                        con.Close();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
                else if (cmbxEmployeeType.SelectedIndex == 1)//Cashier
                {


                  
                       
                        

                    string username1 = txtUsername.Text;
                    string password1 = txtPassword.Text;
                    
                    cmd = new SqlCommand("SELECT * FROM EmployeeReg WHERE Username = @username AND Password = @password And Position='Cashier'", con);

                    cmd.Parameters.AddWithValue("@username", username1);
                    cmd.Parameters.AddWithValue("@password", password1);

                    try
                    {
                        con.Open();
                        reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            main_cashier cashierfrom = new main_cashier();
                            cashierfrom.Show();
                            cashierfrom.login_user_CASHIER(txtUsername.Text);
                            MessageBox.Show("Login successful!");
                            this.Close();
                        }
                        else
                        {
                            // Login failed
                            MessageBox.Show("Incorrect Username And Password, Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        MessageBox.Show(ex.Message);
                    }
                    con.Close() ;
                }









            
                else if (cmbxEmployeeType.SelectedIndex == 2)//Delivery
                {
                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("select Username ,Password from EmployeeReg where Position='Delivery Staff'", con);

                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            username = reader["Username"].ToString();
                            password = reader["Password"].ToString();

                            if (txtUsername.Text == username && txtPassword.Text == password) //if username password is corerct
                            {

                                OnlineDelivery deiliveyfrom = new OnlineDelivery();
                                deiliveyfrom.login_user(txtUsername.Text);
                                deiliveyfrom.Show();
                                MessageBox.Show("Login successful!");

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username And Password, Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                        con.Close();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }



                else if (cmbxEmployeeType.SelectedIndex == 3)//Kitchen
                {




                    try
                    {
                        con.Open();
                        cmd = new SqlCommand("select Username ,Password from EmployeeReg where Position='Kitchen Staff'", con);

                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            username = reader["Username"].ToString();
                            password = reader["Password"].ToString();

                            if (txtUsername.Text == username && txtPassword.Text == password) //if username password is corerct
                            {

                                Kichen kicthenform = new Kichen();
                                kicthenform.login_user(txtUsername.Text);

                                kicthenform.Show();
                                MessageBox.Show("Login successful!");

                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username And Password, Please Try Again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                        con.Close();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                }
            }


        }

      

        private void btn_loginExit_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
    }
}
