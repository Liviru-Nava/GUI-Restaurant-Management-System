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
    public partial class DailyStats : Form
    {
        public DailyStats()
        {
            InitializeComponent();
        }

        private void btn_orders_Click(object sender, EventArgs e)
        {
            statsOrders orders = new statsOrders();
            orders.FormBorderStyle = FormBorderStyle.None;
            orders.Dock = DockStyle.Fill;
            orders.TopLevel = false;
            Center_panel.Controls.Add(orders);
            orders.BringToFront();
            orders.Show();
        }

        private void btn_revenue_Click(object sender, EventArgs e)
        {
            statsRevenue revenue = new statsRevenue();
            revenue.TopLevel = false;
            revenue.Dock = DockStyle.Fill;
            Center_panel.Controls.Add(revenue);
            revenue.BringToFront();
            revenue.Show();
        }

        private void guna_backButton_Click(object sender, EventArgs e)
        {
            ManagerMain main = new ManagerMain();
            this.Close();
            main.Show();
        }

        private void gunaPanel_Top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
