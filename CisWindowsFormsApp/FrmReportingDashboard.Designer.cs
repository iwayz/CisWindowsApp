namespace CisWindowsFormsApp
{
    partial class FrmReportingDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportingDashboard));

            this.btnExportPelanggan   = new System.Windows.Forms.Button();
            this.btnExportProduct     = new System.Windows.Forms.Button();
            this.btnExportExcel       = new System.Windows.Forms.Button();
            this.btnStockCard         = new System.Windows.Forms.Button();
            this.btnStockMovement     = new System.Windows.Forms.Button();
            this.pnlChildHeader       = new System.Windows.Forms.Panel();
            this.lblReportingChildHeader = new System.Windows.Forms.Label();
            this.pnlSeparator         = new System.Windows.Forms.Panel();
            this.pnlReportingChildren = new System.Windows.Forms.Panel();
            this.pnlMenuReporting     = new System.Windows.Forms.Panel();
            this.gbMenuReporting      = new System.Windows.Forms.Panel();

            System.Windows.Forms.TableLayoutPanel tlpTiles  = new System.Windows.Forms.TableLayoutPanel();
            System.Windows.Forms.FlowLayoutPanel  flpLegend = new System.Windows.Forms.FlowLayoutPanel();

            System.Windows.Forms.Panel pnlTileStockCard     = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileStockMovement = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileExportFaktur  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileExportProduk  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileExportPelanggan = new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel pnlAccStockCard     = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccStockMovement = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccExportFaktur  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccExportProduk  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccExportPelanggan = new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel pnlLegBlue  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlLegAmber = new System.Windows.Forms.Panel();
            System.Windows.Forms.Label lblLegBlue  = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblLegAmber = new System.Windows.Forms.Label();

            this.pnlChildHeader.SuspendLayout();
            this.pnlMenuReporting.SuspendLayout();
            this.gbMenuReporting.SuspendLayout();
            tlpTiles.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color navyBg   = System.Drawing.Color.FromArgb(26, 37, 53);
            System.Drawing.Color catBlue  = System.Drawing.Color.FromArgb(55, 138, 221);
            System.Drawing.Color catAmber = System.Drawing.Color.FromArgb(186, 117, 23);
            System.Drawing.Font  tileFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font  legFont  = new System.Drawing.Font("Segoe UI", 8F);
            System.Drawing.Color legText  = System.Drawing.Color.FromArgb(96, 96, 96);
            System.Windows.Forms.Padding tileMargin = new System.Windows.Forms.Padding(0, 0, 8, 8);

            // btnStockCard
            this.btnStockCard.BackColor = navyBg;
            this.btnStockCard.FlatAppearance.BorderSize = 0;
            this.btnStockCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockCard.Font = tileFont;
            this.btnStockCard.ForeColor = System.Drawing.Color.White;
            this.btnStockCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStockCard.Name = "btnStockCard";
            this.btnStockCard.Text = "Stock Card";
            this.btnStockCard.UseVisualStyleBackColor = false;
            this.btnStockCard.Click += new System.EventHandler(this.btnStockCard_Click);

            // btnStockMovement
            this.btnStockMovement.BackColor = navyBg;
            this.btnStockMovement.FlatAppearance.BorderSize = 0;
            this.btnStockMovement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockMovement.Font = tileFont;
            this.btnStockMovement.ForeColor = System.Drawing.Color.White;
            this.btnStockMovement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStockMovement.Name = "btnStockMovement";
            this.btnStockMovement.Text = "Stock Movement";
            this.btnStockMovement.UseVisualStyleBackColor = false;
            this.btnStockMovement.Click += new System.EventHandler(this.btnStockMovement_Click);

            // btnExportExcel
            this.btnExportExcel.BackColor = navyBg;
            this.btnExportExcel.FlatAppearance.BorderSize = 0;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = tileFont;
            this.btnExportExcel.ForeColor = System.Drawing.Color.White;
            this.btnExportExcel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Text = "Export Faktur";
            this.btnExportExcel.UseVisualStyleBackColor = false;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);

            // btnExportProduct
            this.btnExportProduct.BackColor = navyBg;
            this.btnExportProduct.FlatAppearance.BorderSize = 0;
            this.btnExportProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportProduct.Font = tileFont;
            this.btnExportProduct.ForeColor = System.Drawing.Color.White;
            this.btnExportProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportProduct.Name = "btnExportProduct";
            this.btnExportProduct.Text = "Export Produk";
            this.btnExportProduct.UseVisualStyleBackColor = false;
            this.btnExportProduct.Click += new System.EventHandler(this.btnExportProduct_Click);

            // btnExportPelanggan
            this.btnExportPelanggan.BackColor = navyBg;
            this.btnExportPelanggan.FlatAppearance.BorderSize = 0;
            this.btnExportPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportPelanggan.Font = tileFont;
            this.btnExportPelanggan.ForeColor = System.Drawing.Color.White;
            this.btnExportPelanggan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportPelanggan.Name = "btnExportPelanggan";
            this.btnExportPelanggan.Text = "Export Pelanggan";
            this.btnExportPelanggan.UseVisualStyleBackColor = false;
            this.btnExportPelanggan.Click += new System.EventHandler(this.btnExportPelanggan_Click);

            // accent panels
            pnlAccStockCard.BackColor      = catBlue;  pnlAccStockCard.Dock      = System.Windows.Forms.DockStyle.Left; pnlAccStockCard.Width      = 4;
            pnlAccStockMovement.BackColor  = catBlue;  pnlAccStockMovement.Dock  = System.Windows.Forms.DockStyle.Left; pnlAccStockMovement.Width  = 4;
            pnlAccExportFaktur.BackColor   = catAmber; pnlAccExportFaktur.Dock   = System.Windows.Forms.DockStyle.Left; pnlAccExportFaktur.Width   = 4;
            pnlAccExportProduk.BackColor   = catAmber; pnlAccExportProduk.Dock   = System.Windows.Forms.DockStyle.Left; pnlAccExportProduk.Width   = 4;
            pnlAccExportPelanggan.BackColor = catAmber; pnlAccExportPelanggan.Dock = System.Windows.Forms.DockStyle.Left; pnlAccExportPelanggan.Width = 4;

            // tile wrapper panels
            pnlTileStockCard.BackColor      = navyBg; pnlTileStockCard.Dock      = System.Windows.Forms.DockStyle.Fill; pnlTileStockCard.Margin      = tileMargin;
            pnlTileStockMovement.BackColor  = navyBg; pnlTileStockMovement.Dock  = System.Windows.Forms.DockStyle.Fill; pnlTileStockMovement.Margin  = tileMargin;
            pnlTileExportFaktur.BackColor   = navyBg; pnlTileExportFaktur.Dock   = System.Windows.Forms.DockStyle.Fill; pnlTileExportFaktur.Margin   = tileMargin;
            pnlTileExportProduk.BackColor   = navyBg; pnlTileExportProduk.Dock   = System.Windows.Forms.DockStyle.Fill; pnlTileExportProduk.Margin   = tileMargin;
            pnlTileExportPelanggan.BackColor = navyBg; pnlTileExportPelanggan.Dock = System.Windows.Forms.DockStyle.Fill; pnlTileExportPelanggan.Margin = tileMargin;

            pnlTileStockCard.Controls.Add(this.btnStockCard);           pnlTileStockCard.Controls.Add(pnlAccStockCard);
            pnlTileStockMovement.Controls.Add(this.btnStockMovement);   pnlTileStockMovement.Controls.Add(pnlAccStockMovement);
            pnlTileExportFaktur.Controls.Add(this.btnExportExcel);      pnlTileExportFaktur.Controls.Add(pnlAccExportFaktur);
            pnlTileExportProduk.Controls.Add(this.btnExportProduct);    pnlTileExportProduk.Controls.Add(pnlAccExportProduk);
            pnlTileExportPelanggan.Controls.Add(this.btnExportPelanggan); pnlTileExportPelanggan.Controls.Add(pnlAccExportPelanggan);

            // tlpTiles — 3 cols x 2 rows
            tlpTiles.ColumnCount = 3;
            tlpTiles.RowCount    = 2;
            tlpTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpTiles.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            tlpTiles.Padding = new System.Windows.Forms.Padding(0);
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            tlpTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpTiles.Controls.Add(pnlTileStockCard,      0, 0);
            tlpTiles.Controls.Add(pnlTileStockMovement,  1, 0);
            tlpTiles.Controls.Add(pnlTileExportFaktur,   0, 1);
            tlpTiles.Controls.Add(pnlTileExportProduk,   1, 1);
            tlpTiles.Controls.Add(pnlTileExportPelanggan, 2, 1);
            tlpTiles.Name = "tlpTiles";

            // legend dots
            pnlLegBlue.BackColor  = catBlue;  pnlLegBlue.Size  = new System.Drawing.Size(10, 10); pnlLegBlue.Margin  = new System.Windows.Forms.Padding(0, 4, 4, 0);
            pnlLegAmber.BackColor = catAmber; pnlLegAmber.Size = new System.Drawing.Size(10, 10); pnlLegAmber.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);

            lblLegBlue.Text  = "Laporan Stok"; lblLegBlue.Font  = legFont; lblLegBlue.ForeColor  = legText; lblLegBlue.AutoSize  = true; lblLegBlue.Margin  = new System.Windows.Forms.Padding(0, 2, 16, 0);
            lblLegAmber.Text = "Ekspor Data";  lblLegAmber.Font = legFont; lblLegAmber.ForeColor = legText; lblLegAmber.AutoSize = true; lblLegAmber.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);

            // flpLegend
            flpLegend.Dock = System.Windows.Forms.DockStyle.Top;
            flpLegend.Height = 24;
            flpLegend.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flpLegend.WrapContents = false;
            flpLegend.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            flpLegend.Controls.Add(pnlLegBlue);
            flpLegend.Controls.Add(lblLegBlue);
            flpLegend.Controls.Add(pnlLegAmber);
            flpLegend.Controls.Add(lblLegAmber);
            flpLegend.Name = "flpLegend";

            // gbMenuReporting (Panel, centered in CenterControls)
            this.gbMenuReporting.BackColor = System.Drawing.Color.White;
            this.gbMenuReporting.Controls.Add(tlpTiles);
            this.gbMenuReporting.Controls.Add(flpLegend);
            this.gbMenuReporting.Location = new System.Drawing.Point(183, 92);
            this.gbMenuReporting.Name = "gbMenuReporting";
            this.gbMenuReporting.Size = new System.Drawing.Size(560, 200);
            this.gbMenuReporting.TabIndex = 0;

            // pnlMenuReporting
            this.pnlMenuReporting.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlMenuReporting.Controls.Add(this.gbMenuReporting);
            this.pnlMenuReporting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuReporting.Location = new System.Drawing.Point(0, 42);
            this.pnlMenuReporting.Name = "pnlMenuReporting";
            this.pnlMenuReporting.Size = new System.Drawing.Size(1002, 637);
            this.pnlMenuReporting.TabIndex = 3;

            // pnlChildHeader
            this.pnlChildHeader.BackColor = System.Drawing.Color.White;
            this.pnlChildHeader.Controls.Add(this.lblReportingChildHeader);
            this.pnlChildHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlChildHeader.Name = "pnlChildHeader";
            this.pnlChildHeader.Size = new System.Drawing.Size(1002, 40);
            this.pnlChildHeader.TabIndex = 1;

            // lblReportingChildHeader
            this.lblReportingChildHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReportingChildHeader.AutoSize = true;
            this.lblReportingChildHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblReportingChildHeader.ForeColor = System.Drawing.Color.FromArgb(26, 37, 53);
            this.lblReportingChildHeader.Location = new System.Drawing.Point(12, 12);
            this.lblReportingChildHeader.Name = "lblReportingChildHeader";
            this.lblReportingChildHeader.TabIndex = 0;
            this.lblReportingChildHeader.Text = "MENU";

            // pnlSeparator
            this.pnlSeparator.BackColor = System.Drawing.Color.FromArgb(228, 230, 233);
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 40);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(1002, 2);
            this.pnlSeparator.TabIndex = 2;

            // pnlReportingChildren
            this.pnlReportingChildren.AutoScroll = true;
            this.pnlReportingChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReportingChildren.Location = new System.Drawing.Point(0, 42);
            this.pnlReportingChildren.Name = "pnlReportingChildren";
            this.pnlReportingChildren.Size = new System.Drawing.Size(1002, 637);
            this.pnlReportingChildren.TabIndex = 4;

            // FrmReportingDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 679);
            this.Controls.Add(this.pnlMenuReporting);
            this.Controls.Add(this.pnlReportingChildren);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlChildHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReportingDashboard";
            this.Text = "REPORTING";
            this.Load += new System.EventHandler(this.FrmReportingDashboard_Load);
            this.Resize += new System.EventHandler(this.FrmReportingDashboard_Resize);
            tlpTiles.ResumeLayout(false);
            this.gbMenuReporting.ResumeLayout(false);
            this.pnlMenuReporting.ResumeLayout(false);
            this.pnlChildHeader.ResumeLayout(false);
            this.pnlChildHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlChildHeader;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Panel pnlReportingChildren;
        private System.Windows.Forms.Label lblReportingChildHeader;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Panel pnlMenuReporting;
        private System.Windows.Forms.Button btnExportPelanggan;
        private System.Windows.Forms.Button btnExportProduct;
        private System.Windows.Forms.Button btnStockCard;
        private System.Windows.Forms.Button btnStockMovement;
        private System.Windows.Forms.Panel gbMenuReporting;
    }
}
