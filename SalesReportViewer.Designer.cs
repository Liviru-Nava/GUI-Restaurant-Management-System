namespace POS
{
    partial class SalesReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesReportViewer));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.crystalReportViewerSales = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_reportSalesDate = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datepicker = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btn_reportSalesRange = new Guna.UI2.WinForms.Guna2Button();
            this.datepickerTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.datepickerFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna_backButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gray;
            this.guna2Panel1.Controls.Add(this.crystalReportViewerSales);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 287);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1541, 716);
            this.guna2Panel1.TabIndex = 70;
            // 
            // crystalReportViewerSales
            // 
            this.crystalReportViewerSales.ActiveViewIndex = -1;
            this.crystalReportViewerSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerSales.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerSales.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerSales.Name = "crystalReportViewerSales";
            this.crystalReportViewerSales.Size = new System.Drawing.Size(1541, 716);
            this.crystalReportViewerSales.TabIndex = 0;
            this.crystalReportViewerSales.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_reportSalesDate
            // 
            this.btn_reportSalesDate.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportSalesDate.BorderRadius = 15;
            this.btn_reportSalesDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reportSalesDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reportSalesDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reportSalesDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reportSalesDate.FillColor = System.Drawing.Color.Gold;
            this.btn_reportSalesDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reportSalesDate.ForeColor = System.Drawing.Color.Black;
            this.btn_reportSalesDate.Location = new System.Drawing.Point(1319, 119);
            this.btn_reportSalesDate.Name = "btn_reportSalesDate";
            this.btn_reportSalesDate.Size = new System.Drawing.Size(204, 45);
            this.btn_reportSalesDate.TabIndex = 69;
            this.btn_reportSalesDate.Text = "Generate Report from date";
            this.btn_reportSalesDate.Click += new System.EventHandler(this.btn_reportSalesDate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(218, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(236, 29);
            this.label5.TabIndex = 68;
            this.label5.Text = "Please select a date:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(304, 29);
            this.label4.TabIndex = 67;
            this.label4.Text = "Please select a date range:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 66;
            this.label3.Text = "From";
            // 
            // datepicker
            // 
            this.datepicker.BorderRadius = 10;
            this.datepicker.Checked = true;
            this.datepicker.FillColor = System.Drawing.Color.White;
            this.datepicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepicker.Location = new System.Drawing.Point(556, 115);
            this.datepicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepicker.Name = "datepicker";
            this.datepicker.Size = new System.Drawing.Size(276, 36);
            this.datepicker.TabIndex = 65;
            this.datepicker.Value = new System.DateTime(2023, 7, 22, 13, 39, 22, 644);
            // 
            // btn_reportSalesRange
            // 
            this.btn_reportSalesRange.BackColor = System.Drawing.Color.Transparent;
            this.btn_reportSalesRange.BorderRadius = 15;
            this.btn_reportSalesRange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reportSalesRange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reportSalesRange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reportSalesRange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reportSalesRange.FillColor = System.Drawing.Color.Gold;
            this.btn_reportSalesRange.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reportSalesRange.ForeColor = System.Drawing.Color.Black;
            this.btn_reportSalesRange.Location = new System.Drawing.Point(1319, 29);
            this.btn_reportSalesRange.Name = "btn_reportSalesRange";
            this.btn_reportSalesRange.Size = new System.Drawing.Size(204, 45);
            this.btn_reportSalesRange.TabIndex = 64;
            this.btn_reportSalesRange.Text = "Generate Report from range";
            this.btn_reportSalesRange.Click += new System.EventHandler(this.btn_reportSalesRange_Click);
            // 
            // datepickerTo
            // 
            this.datepickerTo.BorderRadius = 10;
            this.datepickerTo.Checked = true;
            this.datepickerTo.FillColor = System.Drawing.Color.White;
            this.datepickerTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datepickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepickerTo.Location = new System.Drawing.Point(955, 29);
            this.datepickerTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepickerTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepickerTo.Name = "datepickerTo";
            this.datepickerTo.Size = new System.Drawing.Size(276, 36);
            this.datepickerTo.TabIndex = 63;
            this.datepickerTo.Value = new System.DateTime(2023, 7, 22, 13, 39, 22, 644);
            // 
            // datepickerFrom
            // 
            this.datepickerFrom.BorderRadius = 10;
            this.datepickerFrom.Checked = true;
            this.datepickerFrom.FillColor = System.Drawing.Color.White;
            this.datepickerFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.datepickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datepickerFrom.Location = new System.Drawing.Point(556, 29);
            this.datepickerFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.datepickerFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.datepickerFrom.Name = "datepickerFrom";
            this.datepickerFrom.Size = new System.Drawing.Size(276, 36);
            this.datepickerFrom.TabIndex = 62;
            this.datepickerFrom.Value = new System.DateTime(2023, 7, 22, 13, 39, 22, 644);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(907, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 60;
            this.label1.Text = "From";
            // 
            // guna_backButton
            // 
            this.guna_backButton.BackColor = System.Drawing.Color.Red;
            this.guna_backButton.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna_backButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna_backButton.HoverState.ImageSize = new System.Drawing.Size(53, 53);
            this.guna_backButton.Image = ((System.Drawing.Image)(resources.GetObject("guna_backButton.Image")));
            this.guna_backButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna_backButton.ImageRotate = 0F;
            this.guna_backButton.ImageSize = new System.Drawing.Size(50, 50);
            this.guna_backButton.Location = new System.Drawing.Point(0, 2);
            this.guna_backButton.Name = "guna_backButton";
            this.guna_backButton.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna_backButton.Size = new System.Drawing.Size(111, 81);
            this.guna_backButton.TabIndex = 71;
            this.guna_backButton.Click += new System.EventHandler(this.guna_backButton_Click);
            // 
            // SalesReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1541, 1003);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_reportSalesDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datepicker);
            this.Controls.Add(this.btn_reportSalesRange);
            this.Controls.Add(this.datepickerTo);
            this.Controls.Add(this.datepickerFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna_backButton);
            this.Name = "SalesReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReportViewer";
            this.Load += new System.EventHandler(this.SalesReportViewer_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerSales;
        private Guna.UI2.WinForms.Guna2Button btn_reportSalesDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepicker;
        private Guna.UI2.WinForms.Guna2Button btn_reportSalesRange;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepickerTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker datepickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna_backButton;
    }
}