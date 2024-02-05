namespace POS
{
    partial class EmployeeDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetails));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbl_ManagerName = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.Center_panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna_backButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.btn_delete = new Guna.UI2.WinForms.Guna2Button();
            this.btn_view = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.Center_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2CirclePictureBox2);
            this.guna2Panel1.Controls.Add(this.lbl_ManagerName);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.Black;
            this.guna2Panel1.ForeColor = System.Drawing.Color.Snow;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1412, 60);
            this.guna2Panel1.TabIndex = 41;
            // 
            // lbl_ManagerName
            // 
            this.lbl_ManagerName.AutoSize = true;
            this.lbl_ManagerName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ManagerName.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ManagerName.Location = new System.Drawing.Point(587, 7);
            this.lbl_ManagerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ManagerName.Name = "lbl_ManagerName";
            this.lbl_ManagerName.Size = new System.Drawing.Size(226, 37);
            this.lbl_ManagerName.TabIndex = 2;
            this.lbl_ManagerName.Text = "Employee Details";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.guna_backButton);
            this.guna2GradientPanel1.Controls.Add(this.btn_update);
            this.guna2GradientPanel1.Controls.Add(this.btn_delete);
            this.guna2GradientPanel1.Controls.Add(this.btn_view);
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Yellow;
            this.guna2GradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(22)))), ((int)(((byte)(2)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(1261, 60);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(151, 656);
            this.guna2GradientPanel1.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(589, 153);
            this.label2.TabIndex = 5;
            this.label2.Text = "You can View, Update and Delete\r\nEmployee Information...\r\nWhat would you like to " +
    "do now?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Center_panel
            // 
            this.Center_panel.Controls.Add(this.label2);
            this.Center_panel.FillColor = System.Drawing.Color.Black;
            this.Center_panel.FillColor2 = System.Drawing.Color.DarkRed;
            this.Center_panel.Location = new System.Drawing.Point(0, 60);
            this.Center_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Center_panel.Name = "Center_panel";
            this.Center_panel.Size = new System.Drawing.Size(1412, 763);
            this.Center_panel.TabIndex = 43;
            // 
            // guna_backButton
            // 
            this.guna_backButton.BackColor = System.Drawing.Color.Transparent;
            this.guna_backButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna_backButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna_backButton.HoverState.ImageSize = new System.Drawing.Size(53, 53);
            this.guna_backButton.Image = ((System.Drawing.Image)(resources.GetObject("guna_backButton.Image")));
            this.guna_backButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna_backButton.ImageRotate = 0F;
            this.guna_backButton.ImageSize = new System.Drawing.Size(50, 50);
            this.guna_backButton.Location = new System.Drawing.Point(4, 5);
            this.guna_backButton.Margin = new System.Windows.Forms.Padding(2);
            this.guna_backButton.Name = "guna_backButton";
            this.guna_backButton.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna_backButton.Size = new System.Drawing.Size(69, 61);
            this.guna_backButton.TabIndex = 46;
            this.guna_backButton.Click += new System.EventHandler(this.guna_backButton_Click);
            // 
            // btn_update
            // 
            this.btn_update.Animated = true;
            this.btn_update.AnimatedGIF = true;
            this.btn_update.BackColor = System.Drawing.Color.Transparent;
            this.btn_update.BorderRadius = 20;
            this.btn_update.CustomizableEdges.BottomRight = false;
            this.btn_update.CustomizableEdges.TopRight = false;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.Gold;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.Image = ((System.Drawing.Image)(resources.GetObject("btn_update.Image")));
            this.btn_update.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_update.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_update.Location = new System.Drawing.Point(0, 286);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(150, 119);
            this.btn_update.TabIndex = 41;
            this.btn_update.Text = "Update";
            this.btn_update.TextOffset = new System.Drawing.Point(15, 0);
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Animated = true;
            this.btn_delete.AnimatedGIF = true;
            this.btn_delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_delete.BorderRadius = 20;
            this.btn_delete.CustomizableEdges.BottomRight = false;
            this.btn_delete.CustomizableEdges.TopRight = false;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.Gold;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Black;
            this.btn_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete.Image")));
            this.btn_delete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_delete.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_delete.Location = new System.Drawing.Point(0, 461);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(150, 119);
            this.btn_delete.TabIndex = 41;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextOffset = new System.Drawing.Point(15, 0);
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_view
            // 
            this.btn_view.Animated = true;
            this.btn_view.AnimatedGIF = true;
            this.btn_view.BackColor = System.Drawing.Color.Transparent;
            this.btn_view.BorderRadius = 20;
            this.btn_view.CustomizableEdges.BottomRight = false;
            this.btn_view.CustomizableEdges.TopRight = false;
            this.btn_view.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_view.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_view.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_view.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_view.FillColor = System.Drawing.Color.Gold;
            this.btn_view.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.ForeColor = System.Drawing.Color.Black;
            this.btn_view.Image = ((System.Drawing.Image)(resources.GetObject("btn_view.Image")));
            this.btn_view.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_view.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_view.Location = new System.Drawing.Point(0, 115);
            this.btn_view.Margin = new System.Windows.Forms.Padding(2);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(150, 119);
            this.btn_view.TabIndex = 39;
            this.btn_view.Text = "View";
            this.btn_view.TextOffset = new System.Drawing.Point(15, 0);
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = global::POS.Properties.Resources._mj1;
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(11, 5);
            this.guna2CirclePictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(49, 50);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 4;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 716);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.Center_panel);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeDetails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeDetails_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.Center_panel.ResumeLayout(false);
            this.Center_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label lbl_ManagerName;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna_backButton;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private Guna.UI2.WinForms.Guna2Button btn_delete;
        private Guna.UI2.WinForms.Guna2Button btn_view;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel Center_panel;
    }
}