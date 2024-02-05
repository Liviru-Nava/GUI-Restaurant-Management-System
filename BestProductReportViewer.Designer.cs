namespace POS
{
    partial class BestProductReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestProductReportViewer));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.crystalReportViewerBestProduct = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.guna_backButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_BestProduct = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.crystalReportViewerBestProduct);
            this.guna2Panel1.Location = new System.Drawing.Point(2, 76);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1256, 967);
            this.guna2Panel1.TabIndex = 61;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // crystalReportViewerBestProduct
            // 
            this.crystalReportViewerBestProduct.ActiveViewIndex = -1;
            this.crystalReportViewerBestProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerBestProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerBestProduct.Location = new System.Drawing.Point(3, 3);
            this.crystalReportViewerBestProduct.Name = "crystalReportViewerBestProduct";
            this.crystalReportViewerBestProduct.Size = new System.Drawing.Size(1250, 961);
            this.crystalReportViewerBestProduct.TabIndex = 0;
            this.crystalReportViewerBestProduct.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.guna_backButton.Location = new System.Drawing.Point(2, 1);
            this.guna_backButton.Name = "guna_backButton";
            this.guna_backButton.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna_backButton.Size = new System.Drawing.Size(111, 81);
            this.guna_backButton.TabIndex = 63;
            this.guna_backButton.Click += new System.EventHandler(this.guna_backButton_Click);
            // 
            // btn_BestProduct
            // 
            this.btn_BestProduct.BackColor = System.Drawing.Color.Transparent;
            this.btn_BestProduct.BorderRadius = 15;
            this.btn_BestProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_BestProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_BestProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_BestProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_BestProduct.FillColor = System.Drawing.Color.Gold;
            this.btn_BestProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_BestProduct.ForeColor = System.Drawing.Color.Black;
            this.btn_BestProduct.Location = new System.Drawing.Point(936, 12);
            this.btn_BestProduct.Name = "btn_BestProduct";
            this.btn_BestProduct.Size = new System.Drawing.Size(255, 58);
            this.btn_BestProduct.TabIndex = 62;
            this.btn_BestProduct.Text = "Generate Report ";
            this.btn_BestProduct.Click += new System.EventHandler(this.btn_BestProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(418, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(373, 46);
            this.label4.TabIndex = 60;
            this.label4.Text = "Best Sold Products ";
            // 
            // BestProductReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1256, 1055);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna_backButton);
            this.Controls.Add(this.btn_BestProduct);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.Name = "BestProductReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BestProductReportViewer";
            this.Load += new System.EventHandler(this.BestProductReportViewer_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerBestProduct;
        private Guna.UI2.WinForms.Guna2ImageButton guna_backButton;
        private Guna.UI2.WinForms.Guna2Button btn_BestProduct;
        private System.Windows.Forms.Label label4;
    }
}