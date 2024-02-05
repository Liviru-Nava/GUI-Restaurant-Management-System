namespace POS
{
    partial class OrderItemReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderItemReportViewer));
            this.reportPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_generateOI = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna_backButton = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.crystalReportViewerOrderItem = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.reportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // reportPanel
            // 
            this.reportPanel.BackColor = System.Drawing.Color.Gray;
            this.reportPanel.Controls.Add(this.crystalReportViewerOrderItem);
            this.reportPanel.Location = new System.Drawing.Point(0, 174);
            this.reportPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportPanel.MaximumSize = new System.Drawing.Size(1891, 1050);
            this.reportPanel.Name = "reportPanel";
            this.reportPanel.Size = new System.Drawing.Size(1373, 1050);
            this.reportPanel.TabIndex = 62;
            // 
            // btn_generateOI
            // 
            this.btn_generateOI.BorderRadius = 15;
            this.btn_generateOI.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_generateOI.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_generateOI.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_generateOI.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_generateOI.FillColor = System.Drawing.Color.Gold;
            this.btn_generateOI.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_generateOI.ForeColor = System.Drawing.Color.Black;
            this.btn_generateOI.Location = new System.Drawing.Point(1063, 22);
            this.btn_generateOI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_generateOI.Name = "btn_generateOI";
            this.btn_generateOI.Size = new System.Drawing.Size(180, 46);
            this.btn_generateOI.TabIndex = 61;
            this.btn_generateOI.Text = "Generate Now";
            this.btn_generateOI.Click += new System.EventHandler(this.btn_generateOI_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(264, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Bill Number:";
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
            this.guna_backButton.Location = new System.Drawing.Point(0, 0);
            this.guna_backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna_backButton.Name = "guna_backButton";
            this.guna_backButton.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.guna_backButton.Size = new System.Drawing.Size(111, 81);
            this.guna_backButton.TabIndex = 65;
            this.guna_backButton.Click += new System.EventHandler(this.guna_backButton_Click);
            // 
            // dgv_search
            // 
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Location = new System.Drawing.Point(443, 58);
            this.dgv_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.RowHeadersWidth = 51;
            this.dgv_search.RowTemplate.Height = 24;
            this.dgv_search.Size = new System.Drawing.Size(471, 2);
            this.dgv_search.TabIndex = 64;
            this.dgv_search.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_search_CellClick);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(459, 22);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(433, 30);
            this.txt_search.TabIndex = 63;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // crystalReportViewerOrderItem
            // 
            this.crystalReportViewerOrderItem.ActiveViewIndex = -1;
            this.crystalReportViewerOrderItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerOrderItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerOrderItem.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerOrderItem.Name = "crystalReportViewerOrderItem";
            this.crystalReportViewerOrderItem.Size = new System.Drawing.Size(1373, 1050);
            this.crystalReportViewerOrderItem.TabIndex = 0;
            this.crystalReportViewerOrderItem.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // OrderItemReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1372, 881);
            this.Controls.Add(this.reportPanel);
            this.Controls.Add(this.btn_generateOI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna_backButton);
            this.Controls.Add(this.dgv_search);
            this.Controls.Add(this.txt_search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "OrderItemReportViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderItemReportViewer";
            this.Load += new System.EventHandler(this.OrderItemReportViewer_Load);
            this.reportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel reportPanel;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI2.WinForms.Guna2Button btn_generateOI;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ImageButton guna_backButton;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.TextBox txt_search;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerOrderItem;
    }
}