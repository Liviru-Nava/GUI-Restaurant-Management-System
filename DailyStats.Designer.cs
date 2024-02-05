namespace POS
{
    partial class DailyStats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyStats));
            this.gunaPanel_Top = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2CirclePictureBox2 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lbl_stats = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna_backButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_revenue = new Guna.UI2.WinForms.Guna2Button();
            this.btn_orders = new Guna.UI2.WinForms.Guna2Button();
            this.Center_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.gunaPanel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel_Top
            // 
            this.gunaPanel_Top.Controls.Add(this.guna2CirclePictureBox2);
            this.gunaPanel_Top.Controls.Add(this.lbl_stats);
            this.gunaPanel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel_Top.FillColor = System.Drawing.Color.Black;
            this.gunaPanel_Top.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel_Top.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gunaPanel_Top.Name = "gunaPanel_Top";
            this.gunaPanel_Top.Size = new System.Drawing.Size(1404, 76);
            this.gunaPanel_Top.TabIndex = 40;
            this.gunaPanel_Top.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel_Top_Paint);
            // 
            // guna2CirclePictureBox2
            // 
            this.guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox2.Image")));
            this.guna2CirclePictureBox2.ImageRotate = 0F;
            this.guna2CirclePictureBox2.Location = new System.Drawing.Point(11, 2);
            this.guna2CirclePictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
            this.guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox2.Size = new System.Drawing.Size(84, 75);
            this.guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox2.TabIndex = 6;
            this.guna2CirclePictureBox2.TabStop = false;
            // 
            // lbl_stats
            // 
            this.lbl_stats.AutoSize = true;
            this.lbl_stats.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stats.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_stats.Location = new System.Drawing.Point(602, 17);
            this.lbl_stats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_stats.Name = "lbl_stats";
            this.lbl_stats.Size = new System.Drawing.Size(221, 37);
            this.lbl_stats.TabIndex = 1;
            this.lbl_stats.Text = "Today\'s statistics";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.Controls.Add(this.guna_backButton);
            this.guna2GradientPanel1.Controls.Add(this.btn_revenue);
            this.guna2GradientPanel1.Controls.Add(this.btn_orders);
            this.guna2GradientPanel1.CustomBorderColor = System.Drawing.Color.Yellow;
            this.guna2GradientPanel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Red;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.Black;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 76);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(220, 672);
            this.guna2GradientPanel1.TabIndex = 41;
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
            this.guna_backButton.Location = new System.Drawing.Point(2, 5);
            this.guna_backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna_backButton.Name = "guna_backButton";
            this.guna_backButton.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna_backButton.Size = new System.Drawing.Size(69, 61);
            this.guna_backButton.TabIndex = 45;
            this.guna_backButton.Click += new System.EventHandler(this.guna_backButton_Click);
            // 
            // btn_revenue
            // 
            this.btn_revenue.Animated = true;
            this.btn_revenue.AnimatedGIF = true;
            this.btn_revenue.BackColor = System.Drawing.Color.Transparent;
            this.btn_revenue.BorderRadius = 20;
            this.btn_revenue.CustomizableEdges.BottomRight = false;
            this.btn_revenue.CustomizableEdges.TopRight = false;
            this.btn_revenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_revenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_revenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_revenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_revenue.FillColor = System.Drawing.Color.Gold;
            this.btn_revenue.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btn_revenue.ForeColor = System.Drawing.Color.Black;
            this.btn_revenue.Image = ((System.Drawing.Image)(resources.GetObject("btn_revenue.Image")));
            this.btn_revenue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_revenue.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_revenue.Location = new System.Drawing.Point(-2, 439);
            this.btn_revenue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_revenue.Name = "btn_revenue";
            this.btn_revenue.Size = new System.Drawing.Size(222, 153);
            this.btn_revenue.TabIndex = 41;
            this.btn_revenue.Text = "Revenue";
            this.btn_revenue.TextOffset = new System.Drawing.Point(20, 0);
            this.btn_revenue.Click += new System.EventHandler(this.btn_revenue_Click);
            // 
            // btn_orders
            // 
            this.btn_orders.Animated = true;
            this.btn_orders.AnimatedGIF = true;
            this.btn_orders.BackColor = System.Drawing.Color.Transparent;
            this.btn_orders.BorderRadius = 20;
            this.btn_orders.CustomizableEdges.BottomRight = false;
            this.btn_orders.CustomizableEdges.TopRight = false;
            this.btn_orders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_orders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_orders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_orders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_orders.FillColor = System.Drawing.Color.Gold;
            this.btn_orders.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.btn_orders.ForeColor = System.Drawing.Color.Black;
            this.btn_orders.Image = ((System.Drawing.Image)(resources.GetObject("btn_orders.Image")));
            this.btn_orders.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_orders.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_orders.Location = new System.Drawing.Point(0, 180);
            this.btn_orders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_orders.Name = "btn_orders";
            this.btn_orders.Size = new System.Drawing.Size(220, 153);
            this.btn_orders.TabIndex = 39;
            this.btn_orders.Text = "Orders";
            this.btn_orders.TextOffset = new System.Drawing.Point(20, 0);
            this.btn_orders.Click += new System.EventHandler(this.btn_orders_Click);
            // 
            // Center_panel
            // 
            this.Center_panel.Location = new System.Drawing.Point(220, 76);
            this.Center_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Center_panel.Name = "Center_panel";
            this.Center_panel.Size = new System.Drawing.Size(1418, 853);
            this.Center_panel.TabIndex = 0;
            // 
            // DailyStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 748);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.gunaPanel_Top);
            this.Controls.Add(this.Center_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DailyStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DailyStats";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gunaPanel_Top.ResumeLayout(false);
            this.gunaPanel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox2)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gunaPanel_Top;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;
        private System.Windows.Forms.Label lbl_stats;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna_backButton;
        private Guna.UI2.WinForms.Guna2Button btn_revenue;
        private Guna.UI2.WinForms.Guna2Button btn_orders;
        private Guna.UI2.WinForms.Guna2Panel Center_panel;
    }
}