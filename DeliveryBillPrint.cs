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
using System.Drawing.Printing;

namespace POS
{
    public partial class DeliveryBillPrint : Form
    {
        private string date, time;
        public string dnumber, cname, ctelephone, caddress;

        

        public Image qrcodeimage = null;


        public DeliveryBillPrint()
        {
            InitializeComponent();
            date = DateTime.Now.ToString("MM/dd/yyyy");
            time = DateTime.Now.ToString("T");
        }


        private void print(Panel pn1)
        {
            PrinterSettings ps = new PrinterSettings();
            printPanel = pn1;
            Getprintarea(pn1);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void pictureBoxPrint_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint, "Print");
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            print(this.printPanel);
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private Bitmap memoryimg;

        private void Getprintarea(Panel pn1)
        {
            memoryimg = new Bitmap(pn1.Width, pn1.Height);
            pn1.DrawToBitmap(memoryimg, new Rectangle(0, 0, pn1.Width, pn1.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.printPanel.Width / 2), this.printPanel.Location.Y);
        }


        private void DeliveryBillPrint_Load(object sender, EventArgs e)
        {
            lbldateTime.Text = date + "     " + time;
            lblDiliveryNo.Text = dnumber;
            lblCustomerName.Text = cname;
            lblCustomerTelphone.Text = ctelephone;
            lblCustomerAddress.Text = caddress;
            QRCodeShow.Image = qrcodeimage;
        }
    }
}
