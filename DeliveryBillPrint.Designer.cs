namespace POS
{
    partial class DeliveryBillPrint
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryBillPrint));
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbldateTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerTelphone = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblDiliveryNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label6 = new System.Windows.Forms.Label();
            this.printPanel = new System.Windows.Forms.Panel();
            this.QRCodeShow = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxPrint = new System.Windows.Forms.PictureBox();
            this.printPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lbldateTime
            // 
            this.lbldateTime.AutoSize = true;
            this.lbldateTime.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateTime.Location = new System.Drawing.Point(43, 249);
            this.lbldateTime.Name = "lbldateTime";
            this.lbldateTime.Size = new System.Drawing.Size(140, 26);
            this.lbldateTime.TabIndex = 8;
            this.lbldateTime.Text = "Date and time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(45, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(612, 26);
            this.label8.TabIndex = 6;
            this.label8.Text = "---------------------------------------------------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(487, 52);
            this.label4.TabIndex = 5;
            this.label4.Text = "DELIVERY RECEIPT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 26);
            this.label7.TabIndex = 4;
            this.label7.Text = "Customer Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer Telephone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Name";
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.Location = new System.Drawing.Point(251, 453);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCustomerAddress.Size = new System.Drawing.Size(404, 85);
            this.lblCustomerAddress.TabIndex = 4;
            this.lblCustomerAddress.Text = "Delivery Bill No";
            this.lblCustomerAddress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblCustomerTelphone
            // 
            this.lblCustomerTelphone.AutoSize = true;
            this.lblCustomerTelphone.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTelphone.Location = new System.Drawing.Point(420, 411);
            this.lblCustomerTelphone.Name = "lblCustomerTelphone";
            this.lblCustomerTelphone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomerTelphone.Size = new System.Drawing.Size(172, 28);
            this.lblCustomerTelphone.TabIndex = 4;
            this.lblCustomerTelphone.Text = "Delivery Bill No";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(420, 353);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCustomerName.Size = new System.Drawing.Size(172, 28);
            this.lblCustomerName.TabIndex = 4;
            this.lblCustomerName.Text = "Delivery Bill No";
            // 
            // lblDiliveryNo
            // 
            this.lblDiliveryNo.AutoSize = true;
            this.lblDiliveryNo.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiliveryNo.Location = new System.Drawing.Point(420, 294);
            this.lblDiliveryNo.Name = "lblDiliveryNo";
            this.lblDiliveryNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDiliveryNo.Size = new System.Drawing.Size(172, 28);
            this.lblDiliveryNo.TabIndex = 4;
            this.lblDiliveryNo.Text = "Delivery Bill No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Delivery Bill No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(612, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "---------------------------------------------------------------------------";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(43, 81);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(270, 130);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "No 23/7, Prince Street,\r\nWard Place,\r\nColombo 07 .\r\nTel:-0113104586\r\npizzamaster5" +
    "63@gmail.com";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(657, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.MaximumSize = new System.Drawing.Size(40, 753);
            this.panel3.MinimumSize = new System.Drawing.Size(40, 753);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 753);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.MaximumSize = new System.Drawing.Size(40, 753);
            this.panel2.MinimumSize = new System.Drawing.Size(40, 753);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 753);
            this.panel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(612, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "---------------------------------------------------------------------------";
            // 
            // printPanel
            // 
            this.printPanel.BackColor = System.Drawing.Color.White;
            this.printPanel.Controls.Add(this.lbldateTime);
            this.printPanel.Controls.Add(this.QRCodeShow);
            this.printPanel.Controls.Add(this.label8);
            this.printPanel.Controls.Add(this.label4);
            this.printPanel.Controls.Add(this.label7);
            this.printPanel.Controls.Add(this.label2);
            this.printPanel.Controls.Add(this.label3);
            this.printPanel.Controls.Add(this.lblCustomerAddress);
            this.printPanel.Controls.Add(this.lblCustomerTelphone);
            this.printPanel.Controls.Add(this.lblCustomerName);
            this.printPanel.Controls.Add(this.lblDiliveryNo);
            this.printPanel.Controls.Add(this.label1);
            this.printPanel.Controls.Add(this.label6);
            this.printPanel.Controls.Add(this.label5);
            this.printPanel.Controls.Add(this.lblAddress);
            this.printPanel.Controls.Add(this.panel1);
            this.printPanel.Controls.Add(this.panel3);
            this.printPanel.Controls.Add(this.panel2);
            this.printPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.printPanel.Location = new System.Drawing.Point(0, 43);
            this.printPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printPanel.Name = "printPanel";
            this.printPanel.Size = new System.Drawing.Size(697, 753);
            this.printPanel.TabIndex = 2;
            // 
            // QRCodeShow
            // 
            this.QRCodeShow.BackColor = System.Drawing.Color.Transparent;
            this.QRCodeShow.Location = new System.Drawing.Point(237, 530);
            this.QRCodeShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QRCodeShow.Name = "QRCodeShow";
            this.QRCodeShow.Size = new System.Drawing.Size(200, 199);
            this.QRCodeShow.TabIndex = 7;
            this.QRCodeShow.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackgroundImage = global::POS.Properties.Resources.Pizza_Master_Logo1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(494, 81);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.MaximumSize = new System.Drawing.Size(156, 156);
            this.panel1.MinimumSize = new System.Drawing.Size(156, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 156);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxPrint
            // 
            this.pictureBoxPrint.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxPrint.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPrint.Image")));
            this.pictureBoxPrint.Location = new System.Drawing.Point(652, 0);
            this.pictureBoxPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPrint.Name = "pictureBoxPrint";
            this.pictureBoxPrint.Size = new System.Drawing.Size(45, 43);
            this.pictureBoxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrint.TabIndex = 3;
            this.pictureBoxPrint.TabStop = false;
            this.pictureBoxPrint.Click += new System.EventHandler(this.pictureBoxPrint_Click);
            this.pictureBoxPrint.MouseHover += new System.EventHandler(this.pictureBoxPrint_MouseHover);
            // 
            // DeliveryBillPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 796);
            this.Controls.Add(this.pictureBoxPrint);
            this.Controls.Add(this.printPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(715, 843);
            this.MinimumSize = new System.Drawing.Size(715, 843);
            this.Name = "DeliveryBillPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryBillPrint";
            this.Load += new System.EventHandler(this.DeliveryBillPrint_Load);
            this.printPanel.ResumeLayout(false);
            this.printPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRCodeShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbldateTime;
        private System.Windows.Forms.PictureBox QRCodeShow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerTelphone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.PictureBox pictureBoxPrint;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblDiliveryNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel printPanel;
    }
}