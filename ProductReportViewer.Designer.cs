namespace POS
{
    partial class ProductReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductReportViewer));
            this.reportPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_generateProduct = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.guna_backButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.crystalReportViewerProduct1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.reportPanel.Controls.Add(this.crystalReportViewerProduct1);
            this.reportPanel.Location = new System.Drawing.Point(0, 144);
            this.reportPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(1356, 1050);
            this.reportPanel.TabIndex = 61;
            // 
            // btn_generateProduct
            // 
            this.btn_generateProduct.BorderRadius = 15;
            this.btn_generateProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_generateProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_generateProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_generateProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_generateProduct.FillColor = System.Drawing.Color.Gold;
            this.btn_generateProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_generateProduct.ForeColor = System.Drawing.Color.Black;
            this.btn_generateProduct.Location = new System.Drawing.Point(1071, 12);
            this.btn_generateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_generateProduct.Name = "btn_generateProduct";
            this.btn_generateProduct.Size = new System.Drawing.Size(180, 46);
            this.btn_generateProduct.TabIndex = 60;
            this.btn_generateProduct.Text = "Generate Now";
            this.btn_generateProduct.Click += new System.EventHandler(this.btn_generateProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(267, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 29);
            this.label1.TabIndex = 59;
            this.label1.Text = "Product Code: ";
            // 
            // dgv_search
            // 
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Location = new System.Drawing.Point(451, 55);
            this.dgv_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.RowHeadersWidth = 51;
            this.dgv_search.RowTemplate.Height = 24;
            this.dgv_search.Size = new System.Drawing.Size(471, 2);
            this.dgv_search.TabIndex = 63;
            this.dgv_search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(467, 18);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(433, 30);
            this.txt_search.TabIndex = 62;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
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
            this.guna_backButton.Location = new System.Drawing.Point(0, 1);
            this.guna_backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna_backButton.Name = "guna_backButton";
            this.guna_backButton.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna_backButton.Size = new System.Drawing.Size(111, 81);
            this.guna_backButton.TabIndex = 64;
            this.guna_backButton.Click += new System.EventHandler(this.guna_backButton_Click);
            // 
            // crystalReportViewerProduct1
            // 
            this.crystalReportViewerProduct1.ActiveViewIndex = -1;
            this.crystalReportViewerProduct1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerProduct1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerProduct1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerProduct1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerProduct1.Name = "crystalReportViewerProduct1";
            this.crystalReportViewerProduct1.Size = new System.Drawing.Size(1356, 1050);
            this.crystalReportViewerProduct1.TabIndex = 0;
            this.crystalReportViewerProduct1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // ProductReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1357, 881);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.btn_generateProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.guna_backButton);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ProductReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductReportViewer";
            this.Load += new System.EventHandler(this.ProductReportViewer_Load);
            this.Click += new System.EventHandler(this.ProductReportViewer_Click);
            this.reportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel reportPanel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerProduct;
        private Guna.UI2.WinForms.Guna2Button btn_generateProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.TextBox txt_search;
        private Guna.UI2.WinForms.Guna2ImageButton guna_backButton;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerProduct1;
    }
}