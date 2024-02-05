namespace POS
{
    partial class deleteDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteDetails));
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_searchResult = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_empID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_position = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_DOB = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_gender = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tp = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_age = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_lname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_fname = new Guna.UI2.WinForms.Guna2TextBox();
            this.emp_pictureBox = new System.Windows.Forms.PictureBox();
            this.txt_searchbox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.DataPropertyName = "First_Name";
            this.Result.HeaderText = "Result";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.btn_delete.BorderRadius = 20;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.Black;
            this.btn_delete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.btn_delete.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(237)))), ((int)(((byte)(0)))));
            this.btn_delete.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Location = new System.Drawing.Point(1278, 74);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(210, 88);
            this.btn_delete.TabIndex = 226;
            this.btn_delete.Text = "Delete";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // dgv_searchResult
            // 
            this.dgv_searchResult.AllowUserToAddRows = false;
            this.dgv_searchResult.AllowUserToDeleteRows = false;
            this.dgv_searchResult.AllowUserToResizeColumns = false;
            this.dgv_searchResult.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_searchResult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_searchResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_searchResult.ColumnHeadersHeight = 4;
            this.dgv_searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_searchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Position,
            this.Result});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_searchResult.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_searchResult.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_searchResult.Location = new System.Drawing.Point(592, 124);
            this.dgv_searchResult.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_searchResult.Name = "dgv_searchResult";
            this.dgv_searchResult.RowHeadersVisible = false;
            this.dgv_searchResult.RowHeadersWidth = 51;
            this.dgv_searchResult.RowTemplate.Height = 24;
            this.dgv_searchResult.Size = new System.Drawing.Size(594, 1);
            this.dgv_searchResult.TabIndex = 225;
            this.dgv_searchResult.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_searchResult.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_searchResult.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_searchResult.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_searchResult.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_searchResult.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_searchResult.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_searchResult.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_searchResult.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_searchResult.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_searchResult.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_searchResult.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_searchResult.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_searchResult.ThemeStyle.ReadOnly = false;
            this.dgv_searchResult.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_searchResult.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_searchResult.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_searchResult.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_searchResult.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_searchResult.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_searchResult.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_searchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_searchResult_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Employee_ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            // 
            // txt_empID
            // 
            this.txt_empID.Animated = true;
            this.txt_empID.AutoRoundedCorners = true;
            this.txt_empID.BackColor = System.Drawing.Color.Transparent;
            this.txt_empID.BorderRadius = 16;
            this.txt_empID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_empID.DefaultText = "";
            this.txt_empID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_empID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_empID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_empID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_empID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_empID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_empID.ForeColor = System.Drawing.Color.Black;
            this.txt_empID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_empID.Location = new System.Drawing.Point(642, 456);
            this.txt_empID.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_empID.Name = "txt_empID";
            this.txt_empID.PasswordChar = '\0';
            this.txt_empID.PlaceholderText = "";
            this.txt_empID.ReadOnly = true;
            this.txt_empID.SelectedText = "";
            this.txt_empID.Size = new System.Drawing.Size(328, 35);
            this.txt_empID.TabIndex = 224;
            // 
            // txt_position
            // 
            this.txt_position.Animated = true;
            this.txt_position.AutoRoundedCorners = true;
            this.txt_position.BackColor = System.Drawing.Color.Transparent;
            this.txt_position.BorderRadius = 16;
            this.txt_position.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_position.DefaultText = "";
            this.txt_position.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_position.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_position.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_position.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_position.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_position.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_position.ForeColor = System.Drawing.Color.Black;
            this.txt_position.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_position.Location = new System.Drawing.Point(642, 402);
            this.txt_position.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_position.Name = "txt_position";
            this.txt_position.PasswordChar = '\0';
            this.txt_position.PlaceholderText = "";
            this.txt_position.ReadOnly = true;
            this.txt_position.SelectedText = "";
            this.txt_position.Size = new System.Drawing.Size(328, 35);
            this.txt_position.TabIndex = 223;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(228, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 37);
            this.label2.TabIndex = 222;
            this.label2.Text = "Search for an Employee";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label16.Location = new System.Drawing.Point(464, 401);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 37);
            this.label16.TabIndex = 220;
            this.label16.Text = "Position";
            // 
            // txt_DOB
            // 
            this.txt_DOB.Animated = true;
            this.txt_DOB.AutoRoundedCorners = true;
            this.txt_DOB.BackColor = System.Drawing.Color.Transparent;
            this.txt_DOB.BorderRadius = 15;
            this.txt_DOB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DOB.DefaultText = "";
            this.txt_DOB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DOB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DOB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DOB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DOB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DOB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DOB.ForeColor = System.Drawing.Color.Black;
            this.txt_DOB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DOB.Location = new System.Drawing.Point(1248, 514);
            this.txt_DOB.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_DOB.Name = "txt_DOB";
            this.txt_DOB.PasswordChar = '\0';
            this.txt_DOB.PlaceholderText = "";
            this.txt_DOB.ReadOnly = true;
            this.txt_DOB.SelectedText = "";
            this.txt_DOB.Size = new System.Drawing.Size(355, 32);
            this.txt_DOB.TabIndex = 219;
            // 
            // txt_gender
            // 
            this.txt_gender.Animated = true;
            this.txt_gender.AutoRoundedCorners = true;
            this.txt_gender.BackColor = System.Drawing.Color.Transparent;
            this.txt_gender.BorderRadius = 15;
            this.txt_gender.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_gender.DefaultText = "";
            this.txt_gender.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_gender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_gender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gender.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_gender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gender.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gender.ForeColor = System.Drawing.Color.Black;
            this.txt_gender.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_gender.Location = new System.Drawing.Point(642, 628);
            this.txt_gender.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.PasswordChar = '\0';
            this.txt_gender.PlaceholderText = "";
            this.txt_gender.ReadOnly = true;
            this.txt_gender.SelectedText = "";
            this.txt_gender.Size = new System.Drawing.Size(328, 32);
            this.txt_gender.TabIndex = 218;
            // 
            // txt_email
            // 
            this.txt_email.Animated = true;
            this.txt_email.AutoRoundedCorners = true;
            this.txt_email.BackColor = System.Drawing.Color.Transparent;
            this.txt_email.BorderRadius = 15;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Black;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(642, 682);
            this.txt_email.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.ReadOnly = true;
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(328, 32);
            this.txt_email.TabIndex = 216;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(405, 681);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 37);
            this.label5.TabIndex = 217;
            this.label5.Text = "Email Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(471, 626);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 215;
            this.label1.Text = "Gender";
            // 
            // txt_address
            // 
            this.txt_address.Animated = true;
            this.txt_address.AutoRoundedCorners = true;
            this.txt_address.BackColor = System.Drawing.Color.Transparent;
            this.txt_address.BorderRadius = 15;
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_address.ForeColor = System.Drawing.Color.Black;
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Location = new System.Drawing.Point(1248, 401);
            this.txt_address.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderText = "";
            this.txt_address.ReadOnly = true;
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(355, 32);
            this.txt_address.TabIndex = 207;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(1048, 454);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 37);
            this.label10.TabIndex = 214;
            this.label10.Text = "Telephone";
            // 
            // txt_tp
            // 
            this.txt_tp.Animated = true;
            this.txt_tp.AutoRoundedCorners = true;
            this.txt_tp.BackColor = System.Drawing.Color.Transparent;
            this.txt_tp.BorderRadius = 15;
            this.txt_tp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tp.DefaultText = "";
            this.txt_tp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tp.ForeColor = System.Drawing.Color.Black;
            this.txt_tp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tp.Location = new System.Drawing.Point(1248, 456);
            this.txt_tp.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_tp.Name = "txt_tp";
            this.txt_tp.PasswordChar = '\0';
            this.txt_tp.PlaceholderText = "";
            this.txt_tp.ReadOnly = true;
            this.txt_tp.SelectedText = "";
            this.txt_tp.Size = new System.Drawing.Size(355, 32);
            this.txt_tp.TabIndex = 206;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(1045, 628);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 37);
            this.label12.TabIndex = 213;
            this.label12.Text = "Username";
            // 
            // txt_age
            // 
            this.txt_age.Animated = true;
            this.txt_age.AutoRoundedCorners = true;
            this.txt_age.BackColor = System.Drawing.Color.Transparent;
            this.txt_age.BorderRadius = 15;
            this.txt_age.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_age.DefaultText = "";
            this.txt_age.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_age.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_age.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_age.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_age.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_age.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_age.ForeColor = System.Drawing.Color.Black;
            this.txt_age.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_age.Location = new System.Drawing.Point(1248, 571);
            this.txt_age.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_age.Name = "txt_age";
            this.txt_age.PasswordChar = '\0';
            this.txt_age.PlaceholderText = "";
            this.txt_age.ReadOnly = true;
            this.txt_age.SelectedText = "";
            this.txt_age.Size = new System.Drawing.Size(355, 32);
            this.txt_age.TabIndex = 208;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(1108, 569);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 37);
            this.label13.TabIndex = 212;
            this.label13.Text = "Age";
            // 
            // txt_username
            // 
            this.txt_username.Animated = true;
            this.txt_username.AutoRoundedCorners = true;
            this.txt_username.BackColor = System.Drawing.Color.Transparent;
            this.txt_username.BorderRadius = 15;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Black;
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Location = new System.Drawing.Point(1248, 628);
            this.txt_username.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "";
            this.txt_username.ReadOnly = true;
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(355, 32);
            this.txt_username.TabIndex = 209;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(1016, 512);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(173, 37);
            this.label14.TabIndex = 211;
            this.label14.Text = "Date of Birth";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(1066, 401);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 37);
            this.label15.TabIndex = 210;
            this.label15.Text = "Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(415, 456);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 37);
            this.label18.TabIndex = 205;
            this.label18.Text = "Employee ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(442, 572);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 37);
            this.label6.TabIndex = 204;
            this.label6.Text = "Last Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label17.Location = new System.Drawing.Point(438, 515);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(150, 37);
            this.label17.TabIndex = 203;
            this.label17.Text = "First Name";
            // 
            // txt_lname
            // 
            this.txt_lname.Animated = true;
            this.txt_lname.AutoRoundedCorners = true;
            this.txt_lname.BackColor = System.Drawing.Color.Transparent;
            this.txt_lname.BorderRadius = 15;
            this.txt_lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lname.DefaultText = "";
            this.txt_lname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_lname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_lname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lname.ForeColor = System.Drawing.Color.Black;
            this.txt_lname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lname.Location = new System.Drawing.Point(642, 571);
            this.txt_lname.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.PasswordChar = '\0';
            this.txt_lname.PlaceholderText = "";
            this.txt_lname.ReadOnly = true;
            this.txt_lname.SelectedText = "";
            this.txt_lname.Size = new System.Drawing.Size(328, 32);
            this.txt_lname.TabIndex = 202;
            // 
            // txt_fname
            // 
            this.txt_fname.Animated = true;
            this.txt_fname.AutoRoundedCorners = true;
            this.txt_fname.BackColor = System.Drawing.Color.Transparent;
            this.txt_fname.BorderRadius = 16;
            this.txt_fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_fname.DefaultText = "";
            this.txt_fname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_fname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_fname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_fname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fname.ForeColor = System.Drawing.Color.Black;
            this.txt_fname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_fname.Location = new System.Drawing.Point(642, 512);
            this.txt_fname.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.PasswordChar = '\0';
            this.txt_fname.PlaceholderText = "";
            this.txt_fname.ReadOnly = true;
            this.txt_fname.SelectedText = "";
            this.txt_fname.Size = new System.Drawing.Size(328, 35);
            this.txt_fname.TabIndex = 201;
            // 
            // emp_pictureBox
            // 
            this.emp_pictureBox.BackColor = System.Drawing.Color.White;
            this.emp_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("emp_pictureBox.Image")));
            this.emp_pictureBox.Location = new System.Drawing.Point(35, 332);
            this.emp_pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.emp_pictureBox.Name = "emp_pictureBox";
            this.emp_pictureBox.Size = new System.Drawing.Size(335, 379);
            this.emp_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.emp_pictureBox.TabIndex = 200;
            this.emp_pictureBox.TabStop = false;
            // 
            // txt_searchbox
            // 
            this.txt_searchbox.Animated = true;
            this.txt_searchbox.AutoRoundedCorners = true;
            this.txt_searchbox.BackColor = System.Drawing.Color.Transparent;
            this.txt_searchbox.BorderRadius = 15;
            this.txt_searchbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchbox.DefaultText = "";
            this.txt_searchbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_searchbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_searchbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_searchbox.ForeColor = System.Drawing.Color.Black;
            this.txt_searchbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchbox.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_searchbox.IconLeft")));
            this.txt_searchbox.Location = new System.Drawing.Point(592, 84);
            this.txt_searchbox.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.txt_searchbox.Name = "txt_searchbox";
            this.txt_searchbox.PasswordChar = '\0';
            this.txt_searchbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_searchbox.PlaceholderText = " Search for Employee";
            this.txt_searchbox.SelectedText = "";
            this.txt_searchbox.Size = new System.Drawing.Size(594, 32);
            this.txt_searchbox.TabIndex = 227;
            this.txt_searchbox.TextChanged += new System.EventHandler(this.txt_searchbox_TextChanged);
            // 
            // deleteDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1682, 831);
            this.Controls.Add(this.txt_searchbox);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.dgv_searchResult);
            this.Controls.Add(this.txt_empID);
            this.Controls.Add(this.txt_position);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_DOB);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_tp);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.emp_pictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "deleteDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "deleteDetails";
            this.Load += new System.EventHandler(this.deleteDetails_Load);
            this.Click += new System.EventHandler(this.deleteDetails_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emp_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_searchResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private Guna.UI2.WinForms.Guna2TextBox txt_empID;
        private Guna.UI2.WinForms.Guna2TextBox txt_position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txt_DOB;
        private Guna.UI2.WinForms.Guna2TextBox txt_gender;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_tp;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txt_age;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txt_lname;
        private Guna.UI2.WinForms.Guna2TextBox txt_fname;
        private System.Windows.Forms.PictureBox emp_pictureBox;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchbox;
    }
}