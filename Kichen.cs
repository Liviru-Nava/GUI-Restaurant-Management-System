using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Kichen : Form
    {
        private SerialPort arduinoPort;



        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader reader;


        public Kichen()
        {
            InitializeComponent();

            connection = new SqlConnection("Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True");

            /*arduinoPort = new SerialPort("COM13", 9600); // Replace "COMX" with the correct port name
            arduinoPort.DataReceived += ArduinoPort_DataReceived;

            try
            {
                arduinoPort.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening serial port: " + ex.Message);
            }*/
        }

        
            


        private void ArduinoPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            
               /* string receivedData = arduinoPort.ReadLine();


                string[] values = receivedData.Split('\t');

                if (values.Length >= 2)
                {
                    string humidity = values[0];
                    string temperature = values[1];

                    // Update the labels on the UI thread
                    Invoke(new Action(() =>
                    {
                        lbl_humi.Text = $" {humidity} ";
                        lbl_temp.Text = $"{temperature}";
                    }));
                }*/
            
           
            
            
        }






        private void Kichen_Load(object sender, EventArgs e)
        {
            timer1.Start();
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_timeshow.Text = DateTime.Now.ToString("T");
            lbl_ddmmyyyy.Text = DateTime.Now.ToString("MMM dd yyyy");
            lbl_dateshow.Text = DateTime.Now.ToString("dddd");
        }

       
       

        private void btn_mainexit_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }

            
        }

        private void Kichen_FormClosing(object sender, FormClosingEventArgs e)
        {
           /* if (arduinoPort.IsOpen)
               arduinoPort.Close();*/
        }


        public void showorderin_kitchen(String bil_no)
        {
            try
            {
                connection.Open();

                command = new SqlCommand("select orders.Order_Bill_no,Product_name,Quantity, CONVERT(varchar, Order_date, 108) as Time  FROM ((Order_item inner join Product_table on Order_item.Product_Id=Product_table.Product_Id ) inner join orders on Order_item.Order_Bill_no=orders.Order_Bill_no) where orders.Order_Bill_no='" + bil_no + "'", connection);

                
                
                    // Get the order details
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    datagridview_kitchen.DataSource = dt;
                
               

          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading order details: " + ex.Message);
            }
            connection.Close();
        }

        private void btn_orderok_Click(object sender, EventArgs e)
        {

            DataGridViewRow selectedRow = datagridview_kitchen.SelectedRows[0]; //selected row 
            int selectedRowIndex = selectedRow.Index;
            datagridview_kitchen.Rows.RemoveAt(selectedRowIndex);//remove the selected row
        }

        private void btn_backtocashier_Click(object sender, EventArgs e)
        {
            this.Close();
            main_cashier main_Cashierfrom = new main_cashier();
            main_Cashierfrom.Show();
        }

        private void btn_logout2_Click(object sender, EventArgs e)
        {
            LoginPage loginform = new LoginPage();
            loginform.Show();
            this.Close();
        }

        public void login_user(string username)
        {

            connection.Open();
            command = new SqlCommand("select First_Name,User_Image  from EmployeeReg where Username='"+ username + "'", connection);
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

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }





}

