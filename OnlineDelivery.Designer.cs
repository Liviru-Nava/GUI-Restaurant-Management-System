namespace POS
{
    partial class OnlineDelivery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineDelivery));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblToday = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbxBillNo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTelephoneError = new System.Windows.Forms.Label();
            this.txtSearchCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearchRoad2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSearchRoad1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.timepanel = new System.Windows.Forms.Panel();
            this.gunaGradient2Panel3 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.txt_loginuser = new Guna.UI.WinForms.GunaLabel();
            this.picture_user = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.AddressGroupBox = new System.Windows.Forms.GroupBox();
            this.lblEmailError = new System.Windows.Forms.Label();
            this.lblCustomernameError = new System.Windows.Forms.Label();
            this.lblDiliveryNo = new System.Windows.Forms.Label();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnMap = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelephone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menubarpanel = new System.Windows.Forms.Panel();
            this.btn_logoutdelivery = new Guna.UI.WinForms.GunaAdvenceButton();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.btn_deleiveryexit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.GenarateQRCode = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timepanel.SuspendLayout();
            this.gunaGradient2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).BeginInit();
            this.AddressGroupBox.SuspendLayout();
            this.menubarpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenarateQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.BackColor = System.Drawing.Color.Transparent;
            this.lblToday.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.ForeColor = System.Drawing.Color.White;
            this.lblToday.Location = new System.Drawing.Point(762, 22);
            this.lblToday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(97, 31);
            this.lblToday.TabIndex = 26;
            this.lblToday.Text = "TODAY";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(558, 22);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(158, 31);
            this.lblTime.TabIndex = 26;
            this.lblTime.Text = "00:00:00 PM";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(340, 22);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(172, 31);
            this.lblDate.TabIndex = 26;
            this.lblDate.Text = "MM DD YYYY";
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1233, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(12, 75);
            this.panel4.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(30, 266);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 36);
            this.label12.TabIndex = 18;
            this.label12.Text = "City";
            // 
            // cmbxBillNo
            // 
            this.cmbxBillNo.BackColor = System.Drawing.Color.Transparent;
            this.cmbxBillNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.cmbxBillNo.BorderRadius = 15;
            this.cmbxBillNo.BorderThickness = 2;
            this.cmbxBillNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxBillNo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbxBillNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxBillNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cmbxBillNo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxBillNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxBillNo.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F);
            this.cmbxBillNo.ForeColor = System.Drawing.Color.White;
            this.cmbxBillNo.ItemHeight = 30;
            this.cmbxBillNo.Location = new System.Drawing.Point(382, 125);
            this.cmbxBillNo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxBillNo.Name = "cmbxBillNo";
            this.cmbxBillNo.Size = new System.Drawing.Size(366, 36);
            this.cmbxBillNo.TabIndex = 53;
            this.cmbxBillNo.SelectedIndexChanged += new System.EventHandler(this.cmbxBillNo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 36);
            this.label5.TabIndex = 20;
            this.label5.Text = "Road no.1";
            // 
            // lblTelephoneError
            // 
            this.lblTelephoneError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTelephoneError.AutoSize = true;
            this.lblTelephoneError.BackColor = System.Drawing.Color.Transparent;
            this.lblTelephoneError.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblTelephoneError.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephoneError.ForeColor = System.Drawing.Color.Red;
            this.lblTelephoneError.Location = new System.Drawing.Point(378, 432);
            this.lblTelephoneError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelephoneError.Name = "lblTelephoneError";
            this.lblTelephoneError.Size = new System.Drawing.Size(0, 27);
            this.lblTelephoneError.TabIndex = 48;
            // 
            // txtSearchCity
            // 
            this.txtSearchCity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchCity.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchCity.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtSearchCity.BorderRadius = 15;
            this.txtSearchCity.BorderThickness = 2;
            this.txtSearchCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchCity.DefaultText = "";
            this.txtSearchCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchCity.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtSearchCity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCity.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCity.ForeColor = System.Drawing.Color.White;
            this.txtSearchCity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchCity.Location = new System.Drawing.Point(198, 268);
            this.txtSearchCity.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchCity.Name = "txtSearchCity";
            this.txtSearchCity.PasswordChar = '\0';
            this.txtSearchCity.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchCity.PlaceholderText = "";
            this.txtSearchCity.SelectedText = "";
            this.txtSearchCity.Size = new System.Drawing.Size(368, 42);
            this.txtSearchCity.TabIndex = 15;
            // 
            // txtSearchRoad2
            // 
            this.txtSearchRoad2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchRoad2.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchRoad2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtSearchRoad2.BorderRadius = 15;
            this.txtSearchRoad2.BorderThickness = 2;
            this.txtSearchRoad2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchRoad2.DefaultText = "";
            this.txtSearchRoad2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchRoad2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchRoad2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRoad2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRoad2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtSearchRoad2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchRoad2.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoad2.ForeColor = System.Drawing.Color.White;
            this.txtSearchRoad2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchRoad2.Location = new System.Drawing.Point(198, 168);
            this.txtSearchRoad2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchRoad2.Name = "txtSearchRoad2";
            this.txtSearchRoad2.PasswordChar = '\0';
            this.txtSearchRoad2.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchRoad2.PlaceholderText = "";
            this.txtSearchRoad2.SelectedText = "";
            this.txtSearchRoad2.Size = new System.Drawing.Size(368, 42);
            this.txtSearchRoad2.TabIndex = 16;
            // 
            // txtSearchRoad1
            // 
            this.txtSearchRoad1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchRoad1.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchRoad1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtSearchRoad1.BorderRadius = 15;
            this.txtSearchRoad1.BorderThickness = 2;
            this.txtSearchRoad1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchRoad1.DefaultText = "";
            this.txtSearchRoad1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchRoad1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchRoad1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRoad1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchRoad1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtSearchRoad1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchRoad1.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRoad1.ForeColor = System.Drawing.Color.White;
            this.txtSearchRoad1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchRoad1.Location = new System.Drawing.Point(198, 65);
            this.txtSearchRoad1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearchRoad1.Name = "txtSearchRoad1";
            this.txtSearchRoad1.PasswordChar = '\0';
            this.txtSearchRoad1.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearchRoad1.PlaceholderText = "";
            this.txtSearchRoad1.SelectedText = "";
            this.txtSearchRoad1.Size = new System.Drawing.Size(368, 42);
            this.txtSearchRoad1.TabIndex = 17;
            // 
            // lblAddressError
            // 
            this.lblAddressError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressError.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblAddressError.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(154, 810);
            this.lblAddressError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(0, 27);
            this.lblAddressError.TabIndex = 52;
            // 
            // timepanel
            // 
            this.timepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.timepanel.Controls.Add(this.gunaGradient2Panel3);
            this.timepanel.Controls.Add(this.lblToday);
            this.timepanel.Controls.Add(this.lblTime);
            this.timepanel.Controls.Add(this.lblDate);
            this.timepanel.Controls.Add(this.panel4);
            this.timepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timepanel.Location = new System.Drawing.Point(100, 10);
            this.timepanel.Margin = new System.Windows.Forms.Padding(2);
            this.timepanel.Name = "timepanel";
            this.timepanel.Size = new System.Drawing.Size(1245, 75);
            this.timepanel.TabIndex = 50;
            this.timepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.timepanel_Paint);
            // 
            // gunaGradient2Panel3
            // 
            this.gunaGradient2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel3.Controls.Add(this.txt_loginuser);
            this.gunaGradient2Panel3.Controls.Add(this.picture_user);
            this.gunaGradient2Panel3.GradientColor1 = System.Drawing.Color.Black;
            this.gunaGradient2Panel3.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.gunaGradient2Panel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel3.Location = new System.Drawing.Point(980, 6);
            this.gunaGradient2Panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaGradient2Panel3.Name = "gunaGradient2Panel3";
            this.gunaGradient2Panel3.Radius = 8;
            this.gunaGradient2Panel3.Size = new System.Drawing.Size(261, 65);
            this.gunaGradient2Panel3.TabIndex = 87;
            // 
            // txt_loginuser
            // 
            this.txt_loginuser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginuser.ForeColor = System.Drawing.Color.White;
            this.txt_loginuser.Location = new System.Drawing.Point(100, 19);
            this.txt_loginuser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_loginuser.Name = "txt_loginuser";
            this.txt_loginuser.Size = new System.Drawing.Size(134, 39);
            this.txt_loginuser.TabIndex = 22;
            this.txt_loginuser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // picture_user
            // 
            this.picture_user.BaseColor = System.Drawing.Color.White;
            this.picture_user.Location = new System.Drawing.Point(22, 1);
            this.picture_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picture_user.Name = "picture_user";
            this.picture_user.Size = new System.Drawing.Size(70, 61);
            this.picture_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_user.TabIndex = 8;
            this.picture_user.TabStop = false;
            this.picture_user.UseTransfarantBackground = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(100, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1245, 10);
            this.panel5.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(30, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(150, 36);
            this.label10.TabIndex = 19;
            this.label10.Text = "Road no.2";
            // 
            // AddressGroupBox
            // 
            this.AddressGroupBox.Controls.Add(this.label12);
            this.AddressGroupBox.Controls.Add(this.label10);
            this.AddressGroupBox.Controls.Add(this.label5);
            this.AddressGroupBox.Controls.Add(this.txtSearchCity);
            this.AddressGroupBox.Controls.Add(this.txtSearchRoad2);
            this.AddressGroupBox.Controls.Add(this.txtSearchRoad1);
            this.AddressGroupBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressGroupBox.ForeColor = System.Drawing.Color.White;
            this.AddressGroupBox.Location = new System.Drawing.Point(154, 468);
            this.AddressGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddressGroupBox.Name = "AddressGroupBox";
            this.AddressGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.AddressGroupBox.Size = new System.Drawing.Size(596, 340);
            this.AddressGroupBox.TabIndex = 51;
            this.AddressGroupBox.TabStop = false;
            this.AddressGroupBox.Text = "Address";
            // 
            // lblEmailError
            // 
            this.lblEmailError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmailError.AutoSize = true;
            this.lblEmailError.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailError.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblEmailError.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailError.ForeColor = System.Drawing.Color.Red;
            this.lblEmailError.Location = new System.Drawing.Point(378, 348);
            this.lblEmailError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailError.Name = "lblEmailError";
            this.lblEmailError.Size = new System.Drawing.Size(0, 27);
            this.lblEmailError.TabIndex = 47;
            // 
            // lblCustomernameError
            // 
            this.lblCustomernameError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomernameError.AutoSize = true;
            this.lblCustomernameError.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomernameError.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblCustomernameError.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomernameError.ForeColor = System.Drawing.Color.Red;
            this.lblCustomernameError.Location = new System.Drawing.Point(378, 264);
            this.lblCustomernameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomernameError.Name = "lblCustomernameError";
            this.lblCustomernameError.Size = new System.Drawing.Size(0, 27);
            this.lblCustomernameError.TabIndex = 46;
            // 
            // lblDiliveryNo
            // 
            this.lblDiliveryNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiliveryNo.AutoSize = true;
            this.lblDiliveryNo.BackColor = System.Drawing.Color.Transparent;
            this.lblDiliveryNo.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblDiliveryNo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiliveryNo.ForeColor = System.Drawing.Color.Red;
            this.lblDiliveryNo.Location = new System.Drawing.Point(378, 176);
            this.lblDiliveryNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiliveryNo.Name = "lblDiliveryNo";
            this.lblDiliveryNo.Size = new System.Drawing.Size(0, 27);
            this.lblDiliveryNo.TabIndex = 45;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 25;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.HoverState.BorderColor = System.Drawing.Color.White;
            this.btnClear.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(854, 449);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(441, 80);
            this.btnClear.TabIndex = 44;
            this.btnClear.Text = "Clear Detail";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMap
            // 
            this.btnMap.BackColor = System.Drawing.Color.Transparent;
            this.btnMap.BorderColor = System.Drawing.Color.Transparent;
            this.btnMap.BorderRadius = 25;
            this.btnMap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMap.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnMap.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnMap.ForeColor = System.Drawing.Color.White;
            this.btnMap.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btnMap.Location = new System.Drawing.Point(854, 562);
            this.btnMap.Margin = new System.Windows.Forms.Padding(2);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(441, 80);
            this.btnMap.TabIndex = 43;
            this.btnMap.Text = "Go to Google Map";
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 25;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.Green;
            this.btnAdd.Location = new System.Drawing.Point(854, 670);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(441, 80);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.Text = "Generate QR Code";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderRadius = 25;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnSubmit.Location = new System.Drawing.Point(854, 780);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(441, 80);
            this.btnSubmit.TabIndex = 42;
            this.btnSubmit.Text = "Print the Bill";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(848, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 36);
            this.label6.TabIndex = 39;
            this.label6.Text = "QR Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(148, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 36);
            this.label4.TabIndex = 38;
            this.label4.Text = "Delivery No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(148, 382);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 36);
            this.label2.TabIndex = 37;
            this.label2.Text = "Telephone ";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTelephone.BackColor = System.Drawing.Color.Transparent;
            this.txtTelephone.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtTelephone.BorderRadius = 15;
            this.txtTelephone.BorderThickness = 2;
            this.txtTelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelephone.DefaultText = "";
            this.txtTelephone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTelephone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTelephone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTelephone.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtTelephone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephone.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelephone.ForeColor = System.Drawing.Color.White;
            this.txtTelephone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTelephone.Location = new System.Drawing.Point(382, 384);
            this.txtTelephone.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.PasswordChar = '\0';
            this.txtTelephone.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtTelephone.PlaceholderText = "";
            this.txtTelephone.SelectedText = "";
            this.txtTelephone.Size = new System.Drawing.Size(368, 42);
            this.txtTelephone.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 298);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtEmail.BorderRadius = 15;
            this.txtEmail.BorderThickness = 2;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(382, 299);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(368, 42);
            this.txtEmail.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(148, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 36);
            this.label3.TabIndex = 33;
            this.label3.Text = "Customer Name";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.txtCustomerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtCustomerName.BorderRadius = 15;
            this.txtCustomerName.BorderThickness = 2;
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.White;
            this.txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.Location = new System.Drawing.Point(382, 215);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(368, 42);
            this.txtCustomerName.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 10);
            this.panel3.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 870);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 10);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 880);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 10);
            this.panel1.TabIndex = 3;
            // 
            // menubarpanel
            // 
            this.menubarpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.menubarpanel.Controls.Add(this.btn_logoutdelivery);
            this.menubarpanel.Controls.Add(this.pictureBoxGoBack);
            this.menubarpanel.Controls.Add(this.btn_deleiveryexit);
            this.menubarpanel.Controls.Add(this.panel3);
            this.menubarpanel.Controls.Add(this.panel2);
            this.menubarpanel.Controls.Add(this.panel1);
            this.menubarpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menubarpanel.Location = new System.Drawing.Point(0, 0);
            this.menubarpanel.Margin = new System.Windows.Forms.Padding(2);
            this.menubarpanel.Name = "menubarpanel";
            this.menubarpanel.Size = new System.Drawing.Size(100, 890);
            this.menubarpanel.TabIndex = 31;
            // 
            // btn_logoutdelivery
            // 
            this.btn_logoutdelivery.Animated = true;
            this.btn_logoutdelivery.AnimationHoverSpeed = 0.07F;
            this.btn_logoutdelivery.AnimationSpeed = 0.03F;
            this.btn_logoutdelivery.BackColor = System.Drawing.Color.Transparent;
            this.btn_logoutdelivery.BaseColor = System.Drawing.Color.Transparent;
            this.btn_logoutdelivery.BorderColor = System.Drawing.Color.Black;
            this.btn_logoutdelivery.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_logoutdelivery.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_logoutdelivery.CheckedForeColor = System.Drawing.Color.White;
            this.btn_logoutdelivery.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_logoutdelivery.CheckedImage")));
            this.btn_logoutdelivery.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_logoutdelivery.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_logoutdelivery.FocusedColor = System.Drawing.Color.Empty;
            this.btn_logoutdelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logoutdelivery.ForeColor = System.Drawing.Color.White;
            this.btn_logoutdelivery.Image = global::POS.Properties.Resources.logout1;
            this.btn_logoutdelivery.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_logoutdelivery.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_logoutdelivery.Location = new System.Drawing.Point(4, 701);
            this.btn_logoutdelivery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_logoutdelivery.Name = "btn_logoutdelivery";
            this.btn_logoutdelivery.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_logoutdelivery.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_logoutdelivery.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_logoutdelivery.OnHoverImage = global::POS.Properties.Resources.logout__1_;
            this.btn_logoutdelivery.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_logoutdelivery.OnPressedColor = System.Drawing.Color.White;
            this.btn_logoutdelivery.Radius = 8;
            this.btn_logoutdelivery.Size = new System.Drawing.Size(82, 76);
            this.btn_logoutdelivery.TabIndex = 95;
            this.btn_logoutdelivery.Click += new System.EventHandler(this.btn_logoutdelivery_Click);
            // 
            // pictureBoxGoBack
            // 
            this.pictureBoxGoBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxGoBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxGoBack.Image = global::POS.Properties.Resources._mj__;
            this.pictureBoxGoBack.Location = new System.Drawing.Point(0, 10);
            this.pictureBoxGoBack.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(100, 102);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGoBack.TabIndex = 25;
            this.pictureBoxGoBack.TabStop = false;
            // 
            // btn_deleiveryexit
            // 
            this.btn_deleiveryexit.Animated = true;
            this.btn_deleiveryexit.AnimationHoverSpeed = 0.07F;
            this.btn_deleiveryexit.AnimationSpeed = 0.03F;
            this.btn_deleiveryexit.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleiveryexit.BaseColor = System.Drawing.Color.Transparent;
            this.btn_deleiveryexit.BorderColor = System.Drawing.Color.Black;
            this.btn_deleiveryexit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_deleiveryexit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_deleiveryexit.CheckedForeColor = System.Drawing.Color.White;
            this.btn_deleiveryexit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_deleiveryexit.CheckedImage")));
            this.btn_deleiveryexit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_deleiveryexit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_deleiveryexit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_deleiveryexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleiveryexit.ForeColor = System.Drawing.Color.White;
            this.btn_deleiveryexit.Image = global::POS.Properties.Resources.switch__1_2;
            this.btn_deleiveryexit.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_deleiveryexit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_deleiveryexit.Location = new System.Drawing.Point(4, 790);
            this.btn_deleiveryexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_deleiveryexit.Name = "btn_deleiveryexit";
            this.btn_deleiveryexit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_deleiveryexit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_deleiveryexit.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_deleiveryexit.OnHoverImage = global::POS.Properties.Resources.switch__2_1;
            this.btn_deleiveryexit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_deleiveryexit.OnPressedColor = System.Drawing.Color.White;
            this.btn_deleiveryexit.Radius = 8;
            this.btn_deleiveryexit.Size = new System.Drawing.Size(82, 84);
            this.btn_deleiveryexit.TabIndex = 94;
            this.btn_deleiveryexit.Click += new System.EventHandler(this.btn_deleiveryexit_Click);
            // 
            // GenarateQRCode
            // 
            this.GenarateQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GenarateQRCode.ImageRotate = 0F;
            this.GenarateQRCode.Location = new System.Drawing.Point(938, 168);
            this.GenarateQRCode.Margin = new System.Windows.Forms.Padding(2);
            this.GenarateQRCode.Name = "GenarateQRCode";
            this.GenarateQRCode.Size = new System.Drawing.Size(270, 250);
            this.GenarateQRCode.TabIndex = 40;
            this.GenarateQRCode.TabStop = false;
            // 
            // OnlineDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1345, 890);
            this.Controls.Add(this.cmbxBillNo);
            this.Controls.Add(this.lblTelephoneError);
            this.Controls.Add(this.lblAddressError);
            this.Controls.Add(this.timepanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.AddressGroupBox);
            this.Controls.Add(this.lblEmailError);
            this.Controls.Add(this.lblCustomernameError);
            this.Controls.Add(this.lblDiliveryNo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.GenarateQRCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTelephone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.menubarpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OnlineDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OnlineDelivery";
            this.Load += new System.EventHandler(this.OnlineDelivery_Load);
            this.timepanel.ResumeLayout(false);
            this.timepanel.PerformLayout();
            this.gunaGradient2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picture_user)).EndInit();
            this.AddressGroupBox.ResumeLayout(false);
            this.AddressGroupBox.PerformLayout();
            this.menubarpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenarateQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox cmbxBillNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTelephoneError;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchCity;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchRoad2;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchRoad1;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Panel timepanel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox AddressGroupBox;
        private System.Windows.Forms.Label lblEmailError;
        private System.Windows.Forms.Label lblCustomernameError;
        private System.Windows.Forms.Label lblDiliveryNo;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnMap;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2PictureBox GenarateQRCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtTelephone;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel menubarpanel;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel3;
        private Guna.UI.WinForms.GunaLabel txt_loginuser;
        private Guna.UI.WinForms.GunaCirclePictureBox picture_user;
        private Guna.UI.WinForms.GunaAdvenceButton btn_deleiveryexit;
        private Guna.UI.WinForms.GunaAdvenceButton btn_logoutdelivery;
    }
}