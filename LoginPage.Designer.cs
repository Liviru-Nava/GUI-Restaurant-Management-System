namespace POS
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.lblUsernameError = new System.Windows.Forms.Label();
            this.lblEmployeeError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxEmployeeType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.whiteline = new MetroFramework.Controls.MetroPanel();
            this.lblPasswordError = new System.Windows.Forms.Label();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.btn_loginExit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.Logopanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // lblUsernameError
            // 
            this.lblUsernameError.AutoSize = true;
            this.lblUsernameError.BackColor = System.Drawing.Color.Transparent;
            this.lblUsernameError.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblUsernameError.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameError.ForeColor = System.Drawing.Color.Red;
            this.lblUsernameError.Location = new System.Drawing.Point(561, 390);
            this.lblUsernameError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsernameError.Name = "lblUsernameError";
            this.lblUsernameError.Size = new System.Drawing.Size(0, 27);
            this.lblUsernameError.TabIndex = 25;
            // 
            // lblEmployeeError
            // 
            this.lblEmployeeError.AutoSize = true;
            this.lblEmployeeError.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeError.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblEmployeeError.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeError.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeError.Location = new System.Drawing.Point(561, 232);
            this.lblEmployeeError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeError.Name = "lblEmployeeError";
            this.lblEmployeeError.Size = new System.Drawing.Size(0, 27);
            this.lblEmployeeError.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(691, 40);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 62);
            this.label4.TabIndex = 23;
            this.label4.Text = "Welcome";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderRadius = 25;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnLogin.Location = new System.Drawing.Point(701, 598);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(212, 65);
            this.btnLogin.TabIndex = 22;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(542, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 36);
            this.label3.TabIndex = 21;
            this.label3.Text = "Employee Type";
            // 
            // cmbxEmployeeType
            // 
            this.cmbxEmployeeType.BackColor = System.Drawing.Color.Transparent;
            this.cmbxEmployeeType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.cmbxEmployeeType.BorderRadius = 15;
            this.cmbxEmployeeType.BorderThickness = 2;
            this.cmbxEmployeeType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxEmployeeType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbxEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxEmployeeType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cmbxEmployeeType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxEmployeeType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbxEmployeeType.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F);
            this.cmbxEmployeeType.ForeColor = System.Drawing.Color.White;
            this.cmbxEmployeeType.ItemHeight = 30;
            this.cmbxEmployeeType.Items.AddRange(new object[] {
            "Manager",
            "Cashier",
            "Delivery Staff",
            "Kitchen Staff"});
            this.cmbxEmployeeType.Location = new System.Drawing.Point(549, 188);
            this.cmbxEmployeeType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbxEmployeeType.Name = "cmbxEmployeeType";
            this.cmbxEmployeeType.Size = new System.Drawing.Size(510, 36);
            this.cmbxEmployeeType.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(542, 451);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(542, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(549, 341);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(510, 42);
            this.txtUsername.TabIndex = 16;
            // 
            // txtPassword
            // 
            this.txtPassword.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(43)))));
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Symbol", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(549, 490);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(510, 42);
            this.txtPassword.TabIndex = 17;
            // 
            // whiteline
            // 
            this.whiteline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.whiteline.BackColor = System.Drawing.Color.White;
            this.whiteline.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.whiteline.ForeColor = System.Drawing.Color.Black;
            this.whiteline.HorizontalScrollbarBarColor = true;
            this.whiteline.HorizontalScrollbarHighlightOnWheel = false;
            this.whiteline.HorizontalScrollbarSize = 10;
            this.whiteline.Location = new System.Drawing.Point(501, 40);
            this.whiteline.Margin = new System.Windows.Forms.Padding(2);
            this.whiteline.Name = "whiteline";
            this.whiteline.Size = new System.Drawing.Size(6, 620);
            this.whiteline.TabIndex = 15;
            this.whiteline.UseCustomBackColor = true;
            this.whiteline.VerticalScrollbarBarColor = true;
            this.whiteline.VerticalScrollbarHighlightOnWheel = false;
            this.whiteline.VerticalScrollbarSize = 0;
            // 
            // lblPasswordError
            // 
            this.lblPasswordError.AutoSize = true;
            this.lblPasswordError.BackColor = System.Drawing.Color.Transparent;
            this.lblPasswordError.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblPasswordError.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordError.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordError.Location = new System.Drawing.Point(561, 539);
            this.lblPasswordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPasswordError.Name = "lblPasswordError";
            this.lblPasswordError.Size = new System.Drawing.Size(0, 27);
            this.lblPasswordError.TabIndex = 24;
            // 
            // btn_loginExit
            // 
            this.btn_loginExit.Animated = true;
            this.btn_loginExit.AnimationHoverSpeed = 0.07F;
            this.btn_loginExit.AnimationSpeed = 0.03F;
            this.btn_loginExit.BackColor = System.Drawing.Color.Transparent;
            this.btn_loginExit.BaseColor = System.Drawing.Color.Transparent;
            this.btn_loginExit.BorderColor = System.Drawing.Color.Black;
            this.btn_loginExit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btn_loginExit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btn_loginExit.CheckedForeColor = System.Drawing.Color.White;
            this.btn_loginExit.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btn_loginExit.CheckedImage")));
            this.btn_loginExit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btn_loginExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_loginExit.FocusedColor = System.Drawing.Color.Empty;
            this.btn_loginExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginExit.ForeColor = System.Drawing.Color.White;
            this.btn_loginExit.Image = global::POS.Properties.Resources.switch__1_2;
            this.btn_loginExit.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_loginExit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_loginExit.Location = new System.Drawing.Point(1029, -8);
            this.btn_loginExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_loginExit.Name = "btn_loginExit";
            this.btn_loginExit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btn_loginExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_loginExit.OnHoverForeColor = System.Drawing.Color.Black;
            this.btn_loginExit.OnHoverImage = global::POS.Properties.Resources.switch__2_1;
            this.btn_loginExit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btn_loginExit.OnPressedColor = System.Drawing.Color.White;
            this.btn_loginExit.Radius = 8;
            this.btn_loginExit.Size = new System.Drawing.Size(82, 76);
            this.btn_loginExit.TabIndex = 93;
            this.btn_loginExit.Click += new System.EventHandler(this.btn_loginExit_Click_1);
            // 
            // Logopanel
            // 
            this.Logopanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logopanel.BackgroundImage")));
            this.Logopanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logopanel.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Logopanel.Location = new System.Drawing.Point(-9, -25);
            this.Logopanel.Margin = new System.Windows.Forms.Padding(2);
            this.Logopanel.Name = "Logopanel";
            this.Logopanel.Size = new System.Drawing.Size(514, 729);
            this.Logopanel.TabIndex = 14;
            // 
            // LoginPage
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.btn_loginExit);
            this.Controls.Add(this.lblPasswordError);
            this.Controls.Add(this.lblUsernameError);
            this.Controls.Add(this.lblEmployeeError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxEmployeeType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.whiteline);
            this.Controls.Add(this.Logopanel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblUsernameError;
        private System.Windows.Forms.Label lblEmployeeError;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbxEmployeeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private MetroFramework.Controls.MetroPanel whiteline;
        private Guna.UI2.WinForms.Guna2Panel Logopanel;
        private System.Windows.Forms.Label lblPasswordError;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI.WinForms.GunaAdvenceButton btn_loginExit;
    }
}