using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.Lib;
using System.Data.SqlClient;
using Guna.UI2.WinForms;
using System.Drawing.Text;
using System.Data.Common;
using System.IO;
using System.Net;
using Guna.UI.WinForms;
using System.Collections;
using System.Threading;
using System.IO.Ports;
using System.Media;// sound library

namespace POS
{
   

    public partial class main_cashier : Form

    {

        SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.notification_sound);


        private SerialPort arduinoPort;


        SqlConnection connection;
        SqlDataAdapter adapter;
        SqlCommand command;
        SqlDataReader reader;


        public main_cashier()//deafult constructor
        {
            InitializeComponent();
            lbl_timeshow.Text = DateTime.Now.ToString();
            connection = new SqlConnection("Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True");
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_timeshow.Text = DateTime.Now.ToString("T");
            lbl_ddmmyyyy.Text = DateTime.Now.ToString("MMM dd yyyy");
            lbl_dateshow.Text = DateTime.Now.ToString("dddd");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            panel_itemname.Hide();
            automaticBillID();
            datetime_piker1.Value = DateTime.Now;//get current date and time to the date time picker
            txt_itemcode.Hide();

            panel_payment.Hide();
            btn_itemdelete.Enabled = false;
            btn_ADD.Enabled = false;
            btn_paynow.Enabled = false;
            txt_invoice.ReadOnly = true;
            txt_itemprice.ReadOnly = true;
            txt_itemtotal.ReadOnly = true;

            flowLayoutPanel_appertize.Visible = false;
            flowLayoutPanel_dessert.Visible = false;
            flowLayoutPanel_beverages.Visible = false;
            panel_payment_done.Visible = false;
            btn_PrintReport.Enabled = false;
            btn_paymentp_back.Enabled = false;


            /*try
            {
                // initilize Ardunio part 

               arduinoPort = new SerialPort("COM16", 9600);
                arduinoPort.Open();
                arduinoPort.DataReceived += ArduinoPort_DataReceived;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open serial port: " + ex.Message);
                Application.Exit();
            }

            arduinoPort.DtrEnable = true;
            Thread.Sleep(100);
            arduinoPort.DtrEnable = false;*/



        }

        private void ArduinoPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /*string receivedData = arduinoPort.ReadLine();
            UpdateLCD(receivedData);*/
        }
        private void UpdateLCD(string text)
        {
            /*if (InvokeRequired)
            {
                Invoke(new Action<string>(UpdateLCD), text);
            }
            else
            {
                // Update the LCD display
                // Assuming you have a TextBox control named lcdTextBox
                lbl_totalamount.Text = text;
            }*/
        }




        public void automaticBillID()//auto increment billID function
        {


            try
            {

                // auto increment the client ID
                command = new SqlCommand("select Max(Order_Bill_no) from orders ", connection);
                connection.Open();
                var maxid = command.ExecuteScalar() as string;
                if (maxid == null)
                {
                    txt_invoice.Text = "Bill00001";
                }
                else
                {

                    int num = int.Parse(maxid.Substring(4, 5));
                    num++;
                    txt_invoice.Text = string.Format("Bill{0:00000}", num);
                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Found" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("try again" + ex.Message);
            }



            

        }

        private void LayoutPanel_Pizza_Paint(object sender, PaintEventArgs e)
        {
            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowphelper = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(LayoutPanel_Pizza, gunaVScrollBar1, true);

        }

        private void btn_pizzacatagarey_Click(object sender, EventArgs e)
        {
            btn_ADD.Enabled = true;
            com_item_names.SelectedItem = null;
            panel_itemname.Show();

            Get_item_Details("P");

        }



        private void btn_beverage_cat_Click(object sender, EventArgs e)
        {
            btn_ADD.Enabled = true;
            panel_itemname.Show();

            Get_item_Details("B");
        }

        private void btn_dessert_cat_Click(object sender, EventArgs e)
        {
            btn_ADD.Enabled = true;
            panel_itemname.Show();

            Get_item_Details("D");
        }

        private void btn_appetizer_cat_Click(object sender, EventArgs e)
        {
            btn_ADD.Enabled = true;
            panel_itemname.Show();

            Get_item_Details("A");
        }



        private void backto_catogery_Click(object sender, EventArgs e)
        {
            btn_ADD.Enabled = false;
            panel_itemname.Visible = false;
            com_item_names.SelectedIndex = -1;
            txt_itemprice.Text="0";
            
            quantity_value.Value = 1;//set guna numeric box value to 1


            com_item_names.Items.Clear();//clear the combobox index items

        }







        private void Get_item_Details(string letter) //adding product id ID to combobox
        {


            try
            {

                command = new SqlCommand("select Product_name from Product_table where Product_Id like '" + letter + "%'", connection);



                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string itemname = reader.GetString(0);
                    com_item_names.Items.Add(itemname);

                }
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error Found" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("try again" + ex.Message);
            }


        }




        private void Get_customer_Details() //adding clientID to combobox
        {


            try
            {

                connection.Open();
                command = new SqlCommand("select * from Customers where Customer_tel='" + txt_contactno.Text + "'", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txt_cutomername.Text = reader["Customer_name"].ToString();

                    txt_address.Text = reader["Customer_address"].ToString();
                }
                connection.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error Found" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show("try again" + ex.Message);
            }



        }


        private void retrive_price()//retrive data from database
        {



            connection.Open();
            command = new SqlCommand("select Product_price,Product_Id from Product_table where Product_name ='" + com_item_names.Text + "'", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                txt_itemprice.Text = reader["Product_price"].ToString();
                txt_itemcode.Text = reader["Product_Id"].ToString();

            }
            connection.Close();
        }

        private void com_item_names_SelectedIndexChanged(object sender, EventArgs e)
        {

            retrive_price();
            txt_itemtotal.Text = Convert.ToString(txt_itemprice.Text);

        }

        private void panel_itemname_Paint(object sender, PaintEventArgs e)
        {

        }




        private void quantity_value_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                double price = Convert.ToDouble(txt_itemprice.Text);
                double quantity = Convert.ToDouble(quantity_value.Value);

                txt_itemtotal.Text = Convert.ToString(price * quantity);
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please try again " + ex.Message);
            }
        }




        private void Add_item_method()
        {


            try
            {
                connection.Open();
                command = new SqlCommand("insert into Order_item(Order_Bill_no,Product_Id ,Quantity,price ) values  ('" + txt_invoice.Text + "','" + txt_itemcode.Text + "','" + quantity_value.Value + "','" + txt_itemtotal.Text + "')", connection);
                int value = command.ExecuteNonQuery();  // excute the sql command if the excution is succsesfull it will return 1,if its unsuccsessfull return 0
                connection.Close();
                if (value == 1)
                {
                    connection.Open();
                    adapter = new SqlDataAdapter("select  Number,Product_name,Quantity,price from Order_item inner join Product_table on Order_item.Product_Id=Product_table.Product_Id where Order_Bill_no='" + txt_invoice.Text + "'", connection);
                    DataTable table1 = new DataTable();
                    adapter.Fill(table1);
                    datagridview_items.DataSource = table1;
                    connection.Close();

                }
                else
                {
                    MessageBox.Show(Owner, "registaion UNsuccessfully", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                calculate_bill_total();



                panel_itemname.Visible = false;
                com_item_names.SelectedIndex = -1;
                txt_itemprice.Text = "0";

                quantity_value.Value = 1;//set guna numeric box value to 1

                com_item_names.Items.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("ERROR", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("found errors in SQl connection " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again " + ex.Message);
            }












            
        }
        private void Add_inoviceID_meothod()
        {

            command = new SqlCommand("insert into orders(Order_Bill_no ) values  ('" + txt_invoice.Text + "')", connection);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

        }
        private void calculate_bill_total()
        {
            connection.Open();
            command = new SqlCommand("SELECT SUM(price) AS TotalPrice FROM Order_item where Order_Bill_no='" + txt_invoice.Text + "'", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                lbl_totalamount.Text = reader["TotalPrice"].ToString();
                txt_billtotal.Text = reader["TotalPrice"].ToString();


            }
            connection.Close();


        }







        private void btn_ADD_Click(object sender, EventArgs e)
        {
            if (com_item_names.SelectedIndex==-1)
            {
                MessageBox.Show("Please Select Item Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(quantity_value.Value==0)
            {
                MessageBox.Show("Please Select Qunatity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (com_ordertype.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Order Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_invoice.Text.Length == 0)
            {
                MessageBox.Show("Involice No Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_contactno.Text.Length != 12)
            {
                MessageBox.Show("Please enter Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contactno.Text.Any(Char.IsLetter))
            {
                MessageBox.Show("Please Valid Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_cutomername.Text.Length == 0)
            {
                MessageBox.Show("Please enter Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_cutomername.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Please Name Cannot Have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {

                    btn_itemdelete.Enabled = true;
                    command = new SqlCommand("SELECT COUNT(*) FROM orders WHERE Order_Bill_no = '" + txt_invoice.Text + "'", connection);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();


                    if (count > 0)
                    {
                        Add_item_method();
                    }
                    else
                    {
                        Add_inoviceID_meothod();
                        Add_item_method();
                    }
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("ERROR" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please try again " + ex.Message);
                }


                btn_ADD.Enabled = false;



            }



        }



        private void txt_contactno_TextChanged(object sender, EventArgs e)
        {
            Get_customer_Details();

        }


        private void Add_customerinfo_meothod()
        {
            try
            {

                command = new SqlCommand("insert into Customers values  ('" + txt_contactno.Text + "','" + txt_cutomername.Text + "','" + txt_address.Text + "')", connection);
                connection.Open();
                int value = command.ExecuteNonQuery();
                connection.Close();

                if (value == 1)
                {
                    MessageBox.Show("New customer Registerd succussfully", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERROR" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please try again " + ex.Message);
            }

           

        }
        private void Add_orderinfo_meothod()
        {

            command = new SqlCommand("Update orders set  Order_date= '" + datetime_piker1.Value + "', Order_type = '" + com_ordertype.Text + "', Payment_method=  '" + com_payement_type.SelectedItem + "', Order_total= '" + lbl_totalamount.Text + "', Customer_tel= '" + txt_contactno.Text + "' where Order_Bill_no = '" + txt_invoice.Text + "'", connection);
            connection.Open();
            int value = command.ExecuteNonQuery();
            connection.Close();

            if (value == 1)
            {
                
                MessageBox.Show("Order saved succussfully", "infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_paynow.Enabled = true;
            }
            else
            {
                MessageBox.Show("Try again Order cannot be Saved", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }





        private void btn_Save_Click(object sender, EventArgs e)
        {
            
            if(com_ordertype.SelectedIndex==-1)
            {
                MessageBox.Show("Please Select Order Type","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            else if (txt_invoice.Text.Length==0)
            {
                MessageBox.Show("Involice No Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_contactno.Text.Length !=12)
            {
                MessageBox.Show("Please enter Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_contactno.Text.Any(Char.IsLetter))
            {
                MessageBox.Show("Please Valid Contact Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txt_cutomername.Text.Length == 0)
            {
                MessageBox.Show("Please enter Customer Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txt_cutomername.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Please Name Cannot Have numbers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            else if (txt_address.Text.Length == 0)
            {
                MessageBox.Show("Please enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(com_payement_type.SelectedIndex== -1)
            {
                MessageBox.Show("Please select Payment type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






            else
            {
                try
                {
                    command = new SqlCommand("SELECT COUNT(*) FROM Customers WHERE Customer_tel = '" + txt_contactno.Text + "'", connection);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();


                    if (count > 0)
                    {
                        Add_orderinfo_meothod();
                    }
                    else
                    {
                        Add_customerinfo_meothod();
                        Add_orderinfo_meothod();
                    }
                    connection.Close();

                   


                }


                catch (SqlException ex)
                {
                    MessageBox.Show("sql exception showing" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please try Again" + ex.Message);
                }

            }
           

        }

           
            








        

        private void btn_paynow_Click(object sender, EventArgs e)
        {
            

            /*com_item_names.SelectedIndex = -1;
            txt_itemprice.Text = "0";

            quantity_value.Value = 1;

            com_item_names.Items.Clear();
            com_ordertype.SelectedIndex = -1;
           
            txt_address.Clear();
            com_payement_type.SelectedIndex = -1;
            datagridview_items.DataSource = null;
            datetime_piker1.Value = DateTime.Now;//get current date and time to the date time picker

            panel_payment.Show();
            btn_paynow.Enabled=false;
            btn_itemdelete.Enabled=false;



            string text = ("TotalBil=Rs")+lbl_totalamount.Text;

            arduinoPort.WriteLine(text);

            soundPlayer.Play();
            this.Alert("New Order Updated.\nPlease Check.");
            */

        }
        public void Alert(string msg)
        {
            MessageForm frm = new MessageForm();
            frm.showAlert(msg);
        }








        private void btn_itemdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (datagridview_items.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = datagridview_items.SelectedRows[0];
                    int selectedRowIndex = selectedRow.Index;
                    int recordId = Convert.ToInt32(selectedRow.Cells["Number"].Value); // Replace with the actual column name that contains the identifier


                    connection.Open();
                    string deleteQuery = "DELETE FROM Order_item WHERE Number = @Id"; // Replace YourTableName with the actual table name and Id with the actual column name of the identifier
                    command = new SqlCommand("DELETE FROM Order_item WHERE Number = @Id", connection);

                    command.Parameters.AddWithValue("@Id", recordId);
                    command.ExecuteNonQuery();
                    connection.Close();



                    datagridview_items.Rows.RemoveAt(selectedRowIndex);
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
            catch(SqlException ex)
            {
                MessageBox.Show("sql exception error" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again" + ex.Message);
            }


            calculate_bill_total();
        }

        private void btn_mainexit_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }

        }

        private void btn_payementOK_Click(object sender, EventArgs e)
        {
            


            if (string.IsNullOrEmpty(txt_amount.Text))
            {
                MessageBox.Show("Please enter Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                double amount = Convert.ToDouble(txt_amount.Text);
                double total = Convert.ToDouble(txt_billtotal.Text);


                if (amount < total)
                {
                    MessageBox.Show("Please enter Amount greater than The Total", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txt_amount.Text.Any(Char.IsLetter))
                {
                    MessageBox.Show("Please Enter Numbers Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    try
                    {
                        panel_payment_done.Visible = true;

                        command = new SqlCommand("Update orders set  Paid = '" + txt_amount.Text + "', Balance = '" + txt_balance.Text + "',Cashier='" + txt_loginuser.Text + "' where Order_Bill_no = '" + txt_invoice.Text + "'", connection);
                        connection.Open();
                        int value = command.ExecuteNonQuery();
                        connection.Close();


                        btn_rs1000.Enabled = false;
                        btn_rs2000.Enabled = false;
                        btn_rs5000.Enabled = false;
                        btn_PrintReport.Enabled = true;
                        btn_paymentp_back.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error in the data update Part: " + ex.Message);
                    }


                    // sms query part

                    /*
                     string result;
                     string apiKey = "bc1CBffVoiIxUnkQUPyP";
                     string user_id = "25368";
                     string numbers = txt_contactno.Text;
                     string sender_id = "NotifyDEMO";
                     string total1=txt_billtotal.Text;
                     string name =txt_cutomername.Text;
                     string invoice=txt_invoice.Text;


                     try
                     {
                         string message = $" Invoice No {invoice}\r\n\r\nDear {name} Thank you for choosing Pizza Master! Your order will be ready within 20 minutes.\r\nWe hope you enjoyed your meal!.\r\nYour total bill amount is RS {total1}/=\r\n\r\nIf you have any questions or feedback, please don't hesitate to contact us.\r\n\r\nBest regards,\r\nPizza Master";

                         string url = $"https://app.notify.lk/api/v1/send?user_id={user_id}&api_key={apiKey}&sender_id={sender_id}&to={numbers}&message={message}";

                         HttpWebRequest objRequest = (HttpWebRequest)WebRequest.Create(url);
                         objRequest.Method = "POST";

                         try
                         {
                             HttpWebResponse objResponse = (HttpWebResponse)objRequest.GetResponse();
                             using (StreamReader sr = new StreamReader(objResponse.GetResponseStream()))
                             {
                                 result = sr.ReadToEnd();
                                 sr.Close();
                             }
                            MessageBox.Show("SMS Sent Successfully!");
                         }
                         catch (Exception ex)
                         {
                             MessageBox.Show("Error sending OTP: " + ex.Message);
                         }
                     }
                     catch (Exception ex)
                     {
                         MessageBox.Show("Error retrieving name from the database: " + ex.Message);
                     }
                    */


                }





                string txt1 = ("...THANK YOU.....");

                //arduinoPort.WriteLine(txt1);








            }




        }







        private void btn_close_paymentpanel_Click(object sender, EventArgs e)
        {
            //panel_payment.Hide();
            //txt_amount.Text = "0";
            //txt_balance.Text = "0";
        }

        

        private void btn_rs5000_Click(object sender, EventArgs e)
        {
            txt_amount.Text = "5000";
        }

        private void btn_rs2000_Click(object sender, EventArgs e)
        {
            txt_amount.Text = "2000";
        }

        private void btn_rs1000_Click(object sender, EventArgs e)
        {
            txt_amount.Text = "10000";
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            try
            {

                int total = Convert.ToInt32(txt_billtotal.Text);
                int amount = Convert.ToInt32(txt_amount.Text);
                txt_balance.Text = Convert.ToString(amount - total);
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter Amount", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("something error Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_rs2000_DoubleClick(object sender, EventArgs e)
        {
            txt_amount.Text = "4000";
        }

        private void btn_rs5000_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_amount.Text = "10000";
        }

        private void btn_rs1000_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_amount.Text = "20000";
        }

        private void main_cashier_FormClosing(object sender, FormClosingEventArgs e)
        {

            /*try
            {
                arduinoPort.WriteLine("..CashierClose..");
                Thread.Sleep(100);  // Wait for the command to be processed
                arduinoPort.Close();
            }
            catch(InvalidOperationException ex)
            {
                MessageBox.Show("Error Found" + ex.Message);
            }*/


            /*arduinoPort.WriteLine("..CashierClose..");
            Thread.Sleep(100);  // Wait for the command to be processed
            arduinoPort.Close();*/

        }

        

        private void btn_paymentp_back_Click(object sender, EventArgs e)
        {
            automaticBillID();

            txt_amount.Text = "0";
            txt_billtotal.Text = "0";

            txt_cutomername.Clear();
            txt_contactno.Text = "+94";

            lbl_totalamount.Text = "0.00";
            txt_balance.Text = "0";



            btn_rs1000.Enabled = true;
            btn_rs2000.Enabled = true;
            btn_rs5000.Enabled = true;
            btn_PrintReport.Enabled = false;
            btn_paymentp_back.Enabled = false;
            datagridview_items.Rows.Clear();


            arduinoPort.DtrEnable = true;
            Thread.Sleep(100);
            arduinoPort.DtrEnable = false;

            panel_payment.Visible = false;
            panel_payment_done.Visible = false;
        }

        private void panel_payment_Paint(object sender, PaintEventArgs e)
        {
           
            txt_billtotal.ReadOnly = true;
            txt_balance.ReadOnly = true;
            btn_payementOK.Enabled = true;
            
        }

        private void txt_contactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if Backspace key is pressed
            char[] disallowedChars = { '@', '#', '$', '%', '&', '*', '=', '/', '\\', '|', ':', ';', ',', '.', '?', '!', '\'', '"', '`', '~', '>', '<', ']', '[', '{', '}', '^', '(', ')', '-', '_',  };

            if (disallowedChars.Contains(e.KeyChar))
            {
                e.Handled = true; // Prevent the character from being entered.
                MessageBox.Show("Please enter numbers only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void btn_logout1_Click(object sender, EventArgs e)
        {
            LoginPage loginfrom=new LoginPage();
            loginfrom.Show();
            this.Close();
        }


        public void login_user_CASHIER(string username)
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

        private void btn_logout2_Click(object sender, EventArgs e)
        {
            LoginPage loginfrom=new LoginPage();
            loginfrom.Show();
            this.Close();
        }

        private void btn_appertizse_menu_Click(object sender, EventArgs e)
        {
            
            flowLayoutPanel_appertize.Visible = true;
            flowLayoutPanel_dessert.Visible = false;
            flowLayoutPanel_beverages.Visible = false;
            LayoutPanel_Pizza.Visible = false;
        }

        private void btn_pizzamenue_Click(object sender, EventArgs e)
        {
            LayoutPanel_Pizza.Visible = true;
            flowLayoutPanel_appertize.Visible = false;
            flowLayoutPanel_dessert.Visible = false;
            flowLayoutPanel_beverages.Visible = false;
        }

        private void btn_desserts_menu_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_dessert.Visible = true;
            flowLayoutPanel_beverages.Visible = false;
            LayoutPanel_Pizza.Visible = false;
            flowLayoutPanel_appertize.Visible = false;
        }

        private void btn_beverage_menu_Click(object sender, EventArgs e)
        {
            flowLayoutPanel_beverages.Visible = true;
            LayoutPanel_Pizza.Visible = false;
            flowLayoutPanel_appertize.Visible = false;
            flowLayoutPanel_dessert.Visible = false;
        }

        private void txt_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the pressed key is the minus sign (-)
            if (e.KeyChar == '-')
            {
                // Handle the event and suppress the key press
                e.Handled = true;
            }
        }


        private void btn_PrintReport_Click(object sender, EventArgs e)
        {
            new Reports.Print_Bill(txt_invoice.Text).Show();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            orders_history FORM =   new orders_history();
            FORM.Show();
            
        }

        private void btn_kicthenview2_Click(object sender, EventArgs e)
        {
            main_cashier obj= new main_cashier();
            obj.Hide();
            
            Kichen kichenfrom1 = new Kichen();

            kichenfrom1.Show();
            kichenfrom1.showorderin_kitchen(txt_invoice.Text);
            
        }
    }
    





}

    


   


