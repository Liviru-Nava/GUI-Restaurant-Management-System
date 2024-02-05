namespace POS
{
    partial class statsRevenue
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(statsRevenue));
            this.RevenueChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_orders = new System.Windows.Forms.Label();
            this.RevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_totalOrders = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RevenueChart1
            // 
            this.RevenueChart1.BackColor = System.Drawing.Color.Orange;
            chartArea1.Name = "ChartArea1";
            this.RevenueChart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.RevenueChart1.Legends.Add(legend1);
            this.RevenueChart1.Location = new System.Drawing.Point(818, 496);
            this.RevenueChart1.Name = "RevenueChart1";
            this.RevenueChart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Payment_method";
            this.RevenueChart1.Series.Add(series1);
            this.RevenueChart1.Size = new System.Drawing.Size(598, 374);
            this.RevenueChart1.TabIndex = 17;
            this.RevenueChart1.Text = "chart1";
            // 
            // lbl_orders
            // 
            this.lbl_orders.AutoSize = true;
            this.lbl_orders.BackColor = System.Drawing.Color.Gold;
            this.lbl_orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orders.ForeColor = System.Drawing.Color.Black;
            this.lbl_orders.Location = new System.Drawing.Point(88, 515);
            this.lbl_orders.Name = "lbl_orders";
            this.lbl_orders.Size = new System.Drawing.Size(64, 25);
            this.lbl_orders.TabIndex = 15;
            this.lbl_orders.Text = "label2";
            // 
            // RevenueChart
            // 
            this.RevenueChart.BackColor = System.Drawing.Color.Orange;
            this.RevenueChart.BorderlineColor = System.Drawing.Color.Black;
            this.RevenueChart.BorderlineWidth = 13;
            chartArea2.Name = "ChartArea1";
            this.RevenueChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.RevenueChart.Legends.Add(legend2);
            this.RevenueChart.Location = new System.Drawing.Point(818, 48);
            this.RevenueChart.Name = "RevenueChart";
            this.RevenueChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Payment_method";
            this.RevenueChart.Series.Add(series2);
            this.RevenueChart.Size = new System.Drawing.Size(598, 374);
            this.RevenueChart.TabIndex = 14;
            this.RevenueChart.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "Revenue chart";
            this.RevenueChart.Titles.Add(title1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(204, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 57);
            this.label3.TabIndex = 13;
            this.label3.Text = "Today\'s Revenue:";
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
            this.btn_totalOrders.FillColor = System.Drawing.Color.Orange;
            this.btn_totalOrders.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btn_totalOrders.ForeColor = System.Drawing.Color.White;
            this.btn_totalOrders.Image = ((System.Drawing.Image)(resources.GetObject("btn_totalOrders.Image")));
            this.btn_totalOrders.ImageOffset = new System.Drawing.Point(100, -45);
            this.btn_totalOrders.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_totalOrders.Location = new System.Drawing.Point(69, 300);
            this.btn_totalOrders.Name = "btn_totalOrders";
            this.btn_totalOrders.Size = new System.Drawing.Size(414, 270);
            this.btn_totalOrders.TabIndex = 16;
            this.btn_totalOrders.Text = "Total Revenue";
            this.btn_totalOrders.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_totalOrders.TextOffset = new System.Drawing.Point(20, -110);
            this.btn_totalOrders.Click += new System.EventHandler(this.btn_totalOrders_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(37, 22);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(141, 126);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 12;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // statsRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1628, 969);
            this.Controls.Add(this.RevenueChart1);
            this.Controls.Add(this.lbl_orders);
            this.Controls.Add(this.RevenueChart);
            this.Controls.Add(this.btn_totalOrders);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "statsRevenue";
            this.Text = "statsRevenue";
            this.Load += new System.EventHandler(this.statsRevenue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart RevenueChart1;
        private System.Windows.Forms.Label lbl_orders;
        private System.Windows.Forms.DataVisualization.Charting.Chart RevenueChart;
        private Guna.UI2.WinForms.Guna2TileButton btn_totalOrders;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}