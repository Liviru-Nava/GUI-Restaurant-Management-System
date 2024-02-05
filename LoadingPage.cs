using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Web.UI.WebControls;


namespace POS
{
    public partial class LoadingPage : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int RightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );




        public LoadingPage()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            ProgressBar.Value = 0;
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {

        }

        public void LoadingFormClose()
        {
           // this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProgressBar.Value += 1;
            lblPresentage.Text = ProgressBar.Value.ToString() + "%";

            if (ProgressBar.Value == 100)
            {
                timer1.Enabled = false;
               
                LoginPage log = new LoginPage();
                log.Show();
                this.Hide();
            }
        }
    }
}
