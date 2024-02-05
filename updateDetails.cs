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
using MetroFramework;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.IO;

namespace POS
{
    public partial class updateDetails : Form
    {

        string connstring = "Data Source=DESKTOP-DPD4LNN;Initial Catalog=RestaurantManagementSystem;Integrated Security=True";
        SqlConnection connection;
        SqlCommand command;

        public updateDetails()
        {
            InitializeComponent();
        }

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
                    dgv_searchresult.DataSource = dataTable;
                    dgv_searchresult.Height = dgv_searchresult.Rows.Count * 30;
                }
                else
                {
                    dgv_searchresult.Height = 0;
                }

                command.Dispose();
                adapter.Dispose();
                connection.Close();
            }
            else if (txt_search.Text.Length <= 0)
            {
                dgv_searchresult.Height = 0;
            }
        }

        private void dgv_searchresult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            string value = dgv_searchresult.Rows[row].Cells[column].Value.ToString();

            SqlConnection connection = new SqlConnection(connstring);
            connection.Open();

            string query = "SELECT Employee_ID, First_Name, Last_Name, Gender, Email, Telephone, Address, Date_of_Birth, Username, User_Image" +
                " FROM EmployeeReg WHERE Employee_ID = @Employee_ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Employee_ID", value);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string column1 = reader["Employee_ID"].ToString();
                string column2 = reader["First_Name"].ToString();
                string column3 = reader["Last_Name"].ToString();
                string column4 = reader["Gender"].ToString();
                string column5 = reader["Email"].ToString();
                string column6 = reader["Telephone"].ToString();
                string column7 = reader["Address"].ToString();
                string column8 = reader["Date_of_Birth"].ToString();
                string column9 = reader["Username"].ToString();

                txt_fname.Enabled = true;
                txt_lname.Enabled = true;
                txt_email.Enabled = true;
                txt_tp.Enabled = true;
                txt_address.Enabled = true;
                txt_DOB.Enabled = true;
                txt_age.Enabled = true;
                txt_username.Enabled = true;
                btn_genderMale.Enabled = true;
                btn_genderFemale.Enabled = true;
                btn_genderOther.Enabled = true;
                txt_password.Enabled = true;

                txt_empID.Text = column1;
                txt_fname.Text = column2;
                txt_lname.Text = column3;
                txt_email.Text = column5;
                txt_tp.Text = column6;
                txt_address.Text = column7;
                txt_DOB.Value = Convert.ToDateTime(column8);
                txt_username.Text = column9;

                if (column4 == "Male")
                {
                    btn_genderMale.Checked = true;
                }
                else if (column4 == "Female")
                {
                    btn_genderFemale.Checked = true;
                }
                else if (column4 == "Other")
                {
                    btn_genderOther.Checked = true;
                }

                

                byte[] arr = null;
                arr = (byte[])reader["User_Image"];

                // Replace it with [0][3] according to your posted query
                System.Drawing.Bitmap bitmap = null;
                ImageConverter converter = new ImageConverter();
                System.Drawing.Image img = (System.Drawing.Image)converter.ConvertFrom(arr);
                bitmap = (System.Drawing.Bitmap)img;
                emp_picturebox.Image = bitmap;

            }
            reader.Close();

            dgv_searchresult.Height = 0;
            txt_search.Clear();

            connection.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                //MANAGER                               //CASHIER                         //DELIVERY STAFF                         //KITCHEN STAFF
                if (cmb_Position.SelectedIndex == 0 || cmb_Position.SelectedIndex == 1 || cmb_Position.SelectedIndex == 2 || cmb_Position.SelectedIndex == 3)
                {
                    //first name validations
                    if (string.IsNullOrEmpty(txt_fname.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter your first name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_fname.Focus();
                    }
                    else if (txt_fname.Text.Any(char.IsDigit))
                    {
                        MetroMessageBox.Show(this, "Your first name cannot have numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_fname.Focus();
                    }
                    else if (txt_fname.Text.Length <= 1)
                    {
                        MetroMessageBox.Show(this, "Please enter your first name correctly!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_fname.Focus();
                    }
                    else if (!Regex.IsMatch(txt_fname.Text, @"^[A-Z][a-zA-Z]*$"))
                    {
                        MetroMessageBox.Show(this, "Your first name should start with Capital letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_fname.Focus();
                    }

                    //last name validations
                    else if (string.IsNullOrEmpty(txt_lname.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter your last name", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_lname.Focus();
                    }
                    else if (txt_lname.Text.Any(char.IsDigit))
                    {
                        MetroMessageBox.Show(this, "Your last name cannot have numbers!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_lname.Focus();
                    }
                    else if (txt_lname.Text.Length <= 1)
                    {
                        MetroMessageBox.Show(this, "Please enter your last name correctly!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_fname.Focus();
                    }
                    else if (!Regex.IsMatch(txt_fname.Text, @"^[A-Z][a-zA-Z]*$"))
                    {
                        MetroMessageBox.Show(this, "Your last name should start with Capital letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_lname.Focus();
                    }

                    //gender validations
                    else if ((!btn_genderMale.Checked) && (!btn_genderFemale.Checked) && (!btn_genderOther.Checked))
                    {
                        MetroMessageBox.Show(this, "Please select a gender category!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //email validations
                    else if (!Regex.IsMatch(txt_email.Text, @"^(?![0-9]+$)(?:[a-zA-Z][\w.-]*@[a-zA-Z]+\.[a-zA-Z]+|[0-9][a-zA-Z0-9]*@[a-zA-Z]+\.[a-zA-Z]+)$"))
                    {
                        MetroMessageBox.Show(this, "Please enter a valid Email! \n Example: abc123@gmail.com", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_email.Focus();
                    }
                    else if (Regex.IsMatch(txt_email.Text, @"^[0-9]+@.*"))
                    {
                        MetroMessageBox.Show(this, "Please enter a valid Email! \n Example: abc123@gmail.com", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_email.Focus();
                    }
                    else if (Regex.IsMatch(txt_email.Text, @"^[^@]+@[0-9]+$"))
                    {
                        MetroMessageBox.Show(this, "Please enter a valid Email! \n Example: abc123@gmail.com", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_email.Focus();
                    }

                    //telephone verification
                    else if (!Regex.IsMatch(txt_tp.Text, @"^[0-9]{10}$"))
                    {
                        MetroMessageBox.Show(this, "Please enter a valid Telephone number! \n Your number should only have 10 digits!\n " +
                            "Your number should not have any characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_tp.Focus();
                    }

                    //address validation
                    else if (string.IsNullOrEmpty(txt_address.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter your address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_address.Focus();
                    }
                    else if (txt_address.Text.Length <= 1)
                    {
                        MetroMessageBox.Show(this, "Please enter your address correctly!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_address.Focus();
                    }
                    else if (!Regex.IsMatch(txt_address.Text, @"^[a-zA-Z0-9\s]+$"))
                    {
                        MetroMessageBox.Show(this, "This address is invalid, please enter your address correctly!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_address.Focus();
                    }
                    //date of birth validation
                    else if ((DateTime.Now.Year - txt_DOB.Value.Year) < 20 || (DateTime.Now.Year - txt_DOB.Value.Year) < 0 || (DateTime.Now.Year - txt_DOB.Value.Year) > 65)
                    {
                        MetroMessageBox.Show(this, "This age does not meet with our recruitment standards! \n Please enter a valid age!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_DOB.Focus();
                    }

                    //username validation
                    else if (string.IsNullOrEmpty(txt_username.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter a username!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Focus();
                    }
                    else if (txt_username.Text.Length <= 1)
                    {
                        MetroMessageBox.Show(this, "Please enter a valid username!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Focus();
                    }
                    else if (txt_username.Text.Any(char.IsDigit))
                    {
                        MetroMessageBox.Show(this, "Your username cannot have numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_username.Focus();
                    }
                    //password validation
                    else if (string.IsNullOrEmpty(txt_password.Text))
                    {
                        MetroMessageBox.Show(this, "Please enter a password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_password.Focus();
                    }
                    else if (!Regex.IsMatch(txt_password.Text, @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
                    {
                        MetroMessageBox.Show(this, "Password is not strong enough! \n Password does not meet requirements!\n" +
                            "Password needs at least one Uppercase letter\n " +
                            "Password needs at least one Lowercase letter\n " +
                            "Password needs to have at least one digit and at least one special character!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_password.Focus();
                    }
                    else
                    {
                        connection = new SqlConnection(connstring);
                        connection.Open();
                        string radio_value = string.Empty;

                        if (btn_genderMale.Checked)
                        {
                            radio_value = "Male";
                        }
                        else if (btn_genderFemale.Checked)
                        {
                            radio_value = "Female";
                        }
                        else if (btn_genderOther.Checked)
                        {
                            radio_value = "Other";
                        }

                        string employee_ID = txt_empID.Text;
                        Image image = emp_picturebox.Image;
                        if (image != null)
                        {

                            byte[] imageData = ImageToByteArray(image);

                            command = new SqlCommand("Update EmployeeReg set Position = '" + cmb_Position.SelectedItem + "', " +
                                "First_Name = '" + txt_fname.Text + "', Last_Name = '" + txt_lname.Text + "', Gender = @Gender, Email = '" + txt_email.Text + "', " +
                                "Telephone = '" + txt_tp.Text + "', Address = '" + txt_address.Text + "', Date_of_Birth = '" + txt_DOB.Value + "', Age = '" + txt_age.Text + "', " +
                                "Username = '" + txt_username.Text + "', Password = '" + txt_password.Text + "', User_Image = @User_Image WHERE Employee_ID = '" + txt_empID.Text + "'", connection);
                            command.Parameters.AddWithValue("@Gender", radio_value);
                            command.Parameters.AddWithValue("@User_Image", imageData);

                            int i = command.ExecuteNonQuery();
                            if (i == 1)
                            {
                                string fromMail = "pizzamaster647@gmail.com";
                                string fromPassword = "ommmdqwlnsjjmqvu";


                                MailMessage message = new MailMessage();
                                message.From = new MailAddress(fromMail);
                                message.Subject = "Updated Employee Details" + txt_fname.Text + "!";
                                message.To.Add(new MailAddress(txt_email.Text.Trim()));
                                message.Body = "<html><body> <h1>Hello " + txt_fname.Text + "</h1>" +
                                    "<p>After a few decisions made we have decided to update your login credentials</p>" + "<p></p>" +
                                    "<p>Please use these credentials you have been given below when you have to login for your future tasks</p>" +
                                    "<p><b>Username:</b> " + txt_username.Text + " </p>" +
                                    "<p><b>Password:</b> " + txt_password.Text + "</p></body></html>";
                                message.IsBodyHtml = true;

                                var smtpClient = new SmtpClient("smtp.gmail.com")
                                {
                                    Port = 587,
                                    Credentials = new NetworkCredential(fromMail, fromPassword),
                                    EnableSsl = true,
                                };

                                smtpClient.Send(message);


                                MetroMessageBox.Show(this, "Your data has been updated!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Please upload an image!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            emp_picturebox.Focus();
                        }

                        connection.Close();

                        txt_fname.Clear();
                        txt_age.Clear();
                        txt_address.Clear();
                        txt_email.Clear();
                        txt_lname.Clear();
                        txt_password.Clear();
                        txt_tp.Clear();
                        txt_username.Clear();
                        emp_picturebox.Image = null;
                    }
                }
            }
            catch (FormatException)
            {
                MetroMessageBox.Show(this, "Please enter correct values!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openfile = new OpenFileDialog();
                openfile.Filter = "JPEG Files (*.jpg, *.jpeg)|*.jpg;*.jpeg|PNG Files (*.png)|*.png";
                if (openfile.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openfile.FileName;

                    // Check if the selected file has a valid extension
                    if (selectedFilePath.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                        selectedFilePath.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                        selectedFilePath.EndsWith(".png", StringComparison.OrdinalIgnoreCase))
                    {
                        // Load the image into PictureBox
                        try
                        {
                            Image image = Image.FromFile(selectedFilePath);
                            emp_picturebox.Image = image;
                        }
                        catch (Exception ex)
                        {
                            // Handle any errors that may occur while loading the image
                            MessageBox.Show("An error occurred while loading the image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Display an error message for invalid file types
                        MessageBox.Show("Please select a JPEG or PNG image file.", "Invalid File Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (ArgumentException)
            {
                MetroMessageBox.Show(this, "Please select the correct file format!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotSupportedException)
            {
                MetroMessageBox.Show(this, "There is an error in uploading this image!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MetroMessageBox.Show(this, "An error has occured, Please try again!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_DOB_ValueChanged(object sender, EventArgs e)
        {
            txt_age.Text = (DateTime.Now.Year - txt_DOB.Value.Year).ToString();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_fname.Clear();
            txt_age.Clear();
            txt_address.Clear();
            txt_email.Clear();
            txt_lname.Clear();
            txt_password.Clear();
            txt_tp.Clear();
            txt_username.Clear();
        }

        private bool IsSpecialCharacter(char c)
        {
            // Define the list of special characters you want to restrict
            char[] specialCharacters = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', ',', '.', '?', '"', '\'', ':', '{', '}', '|', '<', '>', '+', '-', '_', '[', ']', '/', ';' };

            return specialCharacters.Contains(c);
        }

        private void txt_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
                MetroMessageBox.Show(this, "Special characters are not allowed in the address.");
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            MemoryStream stream = new MemoryStream();
            image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg); // Change format if required
            return stream.ToArray();
        }

        private void updateDetails_Click(object sender, EventArgs e)
        {
            dgv_searchresult.Height = 0;
            txt_search.Clear();
        }

        private void txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
                MetroMessageBox.Show(this, "Special characters are not allowed in the First name.");
            }
        }

        private void txt_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsSpecialCharacter(e.KeyChar))
            {
                e.Handled = true; // Suppress the key press
                MetroMessageBox.Show(this, "Special characters are not allowed in the Last name.");
            }
        }

        private void updateDetails_Load(object sender, EventArgs e)
        {
            txt_fname.Enabled = false;
            txt_lname.Enabled = false;
            txt_email.Enabled = false;
            txt_tp.Enabled = false;
            txt_address.Enabled = false;
            txt_DOB.Enabled = false;
            txt_age.Enabled = false;
            txt_username.Enabled = false;
            btn_genderMale.Enabled = false;
            btn_genderFemale.Enabled = false;
            btn_genderOther.Enabled = false;
            txt_password.Enabled = false;
        }
    }
}
