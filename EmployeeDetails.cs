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
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void guna_backButton_Click(object sender, EventArgs e)
        {
            ManagerMain main = new ManagerMain();
            this.Close();
            main.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            viewDetails view = new viewDetails();
            view.TopLevel = false;
            view.Dock = DockStyle.Fill;
            Center_panel.Controls.Add(view);
            view.BringToFront();
            view.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            updateDetails update = new updateDetails();
            update.TopLevel = false;
            update.Dock = DockStyle.Fill;
            Center_panel.Controls.Add(update);
            update.BringToFront();
            update.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            deleteDetails delete = new deleteDetails();
            delete.TopLevel = false;
            delete.Dock = DockStyle.Fill;
            Center_panel.Controls.Add(delete);
            delete.BringToFront();
            delete.Show();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
