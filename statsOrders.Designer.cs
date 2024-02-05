namespace POS
{
    partial class statsOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statsOrders));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lbl_orders = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_totalOrders = new Guna.UI2.WinForms.Guna2TileButton();
            this.OrdersChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.OrdersChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.BackColor = System.Drawing.Color.Red;
            this.lbl_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders.ForeColor = System.Drawing.Color.White;
            this.lbl_orders.Location = new System.Drawing.Point(108, 503);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(81, 29);
            this.lbl_orders.TabIndex = 10;
            this.lbl_orders.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(178, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "Today\'s Orders:";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(31, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(141, 126);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // btn_totalOrders
            // 
            this.btn_totalOrders.Animated = true;
            this.btn_totalOrders.BackColor = System.Drawing.Color.Transparent;
            this.btn_totalOrders.BorderRadius = 10;
            this.btn_totalOrders.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_totalOrders.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_totalOrders.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_totalOrders.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_totalOrders.FillColor = System.Drawing.Color.Red;
            this.btn_totalOrders.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_totalOrders.ForeColor = System.Drawing.Color.White;
            this.btn_totalOrders.Image = ((System.Drawing.Image)(resources.GetObject("btn_totalOrders.Image")));
            this.btn_totalOrders.ImageOffset = new System.Drawing.Point(90, -45);
            this.btn_totalOrders.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_totalOrders.Location = new System.Drawing.Point(93, 304);
            this.btn_totalOrders.Name = "btn_totalOrders";
            this.btn_totalOrders.Size = new System.Drawing.Size(414, 270);
            this.btn_totalOrders.TabIndex = 11;
            this.btn_totalOrders.Text = "Total Orders";
            this.btn_totalOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_totalOrders.TextOffset = new System.Drawing.Point(20, -110);
            this.btn_totalOrders.Click += new System.EventHandler(this.btn_totalOrders_Click);
            // 
            // OrdersChart
            // 
            this.OrdersChart.BackColor = System.Drawing.Color.Coral;
            chartArea1.Name = "ChartArea1";
            this.OrdersChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.OrdersChart.Legends.Add(legend1);
            this.OrdersChart.Location = new System.Drawing.Point(843, 41);
            this.OrdersChart.Name = "OrdersChart";
            this.OrdersChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Order_type";
            this.OrdersChart.Series.Add(series1);
            this.OrdersChart.Size = new System.Drawing.Size(598, 374);
            this.OrdersChart.TabIndex = 12;
            this.OrdersChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Orders Chart";
            this.OrdersChart.Titles.Add(title1);
            // 
            // OrdersChart1
            // 
            this.OrdersChart1.BackColor = System.Drawing.Color.Coral;
            chartArea2.Name = "ChartArea1";
            this.OrdersChart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.OrdersChart1.Legends.Add(legend2);
            this.OrdersChart1.Location = new System.Drawing.Point(843, 485);
            this.OrdersChart1.Name = "OrdersChart1";
            this.OrdersChart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Order_type";
            this.OrdersChart1.Series.Add(series2);
            this.OrdersChart1.Size = new System.Drawing.Size(598, 381);
            this.OrdersChart1.TabIndex = 13;
            this.OrdersChart1.Text = "chart2";
            title2.Name = "Orders ";
            title2.Text = "Orders ";
            this.OrdersChart1.Titles.Add(title2);
            // 
            // statsOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1628, 969);
            this.Controls.Add(this.OrdersChart1);
            this.Controls.Add(this.OrdersChart);
            this.Controls.Add(this.lbl_orders);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_totalOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statsOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "statsOrders";
            this.Load += new System.EventHandler(this.statsOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersChart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_orders;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TileButton btn_totalOrders;
        private System.Windows.Forms.DataVisualization.Charting.Chart OrdersChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart OrdersChart1;
    }
}