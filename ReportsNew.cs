using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class ReportsNew : Form
    {
        public ReportsNew()
        {
            InitializeComponent();
        }

        private void guna_backButton_Click(object sender, EventArgs e)
        {
            ManagerMain main = new ManagerMain();
            this.Close();
            main.Show();
        }

        private void btn_generateOrderItem_Click(object sender, EventArgs e)
        {
            OrderItemReportViewer orderitemReport = new OrderItemReportViewer();
            orderitemReport.Show();
            this.Hide();
        }

        private void btn_generateProduct_Click(object sender, EventArgs e)
        {
            ProductReportViewer productReport = new ProductReportViewer();
            productReport.Show();
            this.Hide();
        }

        private void btn_generateSales_Click(object sender, EventArgs e)
        {
            SalesReportViewer salesReport = new SalesReportViewer();
            salesReport.Show();
            this.Hide();
        }

        private void btn_generateTopSell_Click(object sender, EventArgs e)
        {
            BestProductReportViewer bestProduct = new BestProductReportViewer();
            bestProduct.Show();
            this.Hide();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
