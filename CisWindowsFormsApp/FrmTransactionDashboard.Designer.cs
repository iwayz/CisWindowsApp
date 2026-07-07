namespace CisWindowsFormsApp
{
    partial class FrmTransactionDashboard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTransactionDashboard));

            this.btnSales           = new System.Windows.Forms.Button();
            this.buttonPurchase     = new System.Windows.Forms.Button();
            this.btnSalesReturn     = new System.Windows.Forms.Button();
            this.btnPurchaseReturn  = new System.Windows.Forms.Button();
            this.pnlChildHeader          = new System.Windows.Forms.Panel();
            this.lblTransactionChildHeader = new System.Windows.Forms.Label();
            this.pnlTransactionChildren  = new System.Windows.Forms.Panel();
            this.pnlSeparator            = new System.Windows.Forms.Panel();
            this.pnlMenuTransaction      = new System.Windows.Forms.Panel();
            this.gbMenuTransaction       = new System.Windows.Forms.Panel();
            this.toolTipTransactionMenu  = new System.Windows.Forms.ToolTip(this.components);

            System.Windows.Forms.TableLayoutPanel tlpTiles  = new System.Windows.Forms.TableLayoutPanel();
            System.Windows.Forms.FlowLayoutPanel  flpLegend = new System.Windows.Forms.FlowLayoutPanel();

            System.Windows.Forms.Panel pnlTileSales   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTilePurch   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileSalesRt = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTilePurchRt = new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel pnlAccSales   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccPurch   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccSalesRt = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccPurchRt = new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel pnlLegGreen = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlLegBlue  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlLegAmber = new System.Windows.Forms.Panel();
            System.Windows.Forms.Label lblLegGreen = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblLegBlue  = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblLegAmber = new System.Windows.Forms.Label();

            this.pnlChildHeader.SuspendLayout();
            this.pnlMenuTransaction.SuspendLayout();
            this.gbMenuTransaction.SuspendLayout();
            tlpTiles.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color navyBg   = System.Drawing.Color.FromArgb(26, 37, 53);
            System.Drawing.Color catGreen = System.Drawing.Color.FromArgb(107, 143, 94);
            System.Drawing.Color catBlue  = System.Drawing.Color.FromArgb(55, 138, 221);
            System.Drawing.Color catAmber = System.Drawing.Color.FromArgb(186, 117, 23);
            System.Drawing.Font  tileFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font  legFont  = new System.Drawing.Font("Segoe UI", 8F);
            System.Drawing.Color legText  = System.Drawing.Color.FromArgb(96, 96, 96);
            System.Windows.Forms.Padding tileMargin = new System.Windows.Forms.Padding(0, 0, 8, 8);

            // btnSales
            this.btnSales.BackColor = navyBg;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Font = tileFont;
            this.btnSales.ForeColor = System.Drawing.Color.White;
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSales.Text = "Penjualan";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            this.toolTipTransactionMenu.SetToolTip(this.btnSales, "Transaksi Penjualan / Faktur");

            // buttonPurchase
            this.buttonPurchase.BackColor = navyBg;
            this.buttonPurchase.FlatAppearance.BorderSize = 0;
            this.buttonPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPurchase.Font = tileFont;
            this.buttonPurchase.ForeColor = System.Drawing.Color.White;
            this.buttonPurchase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPurchase.Text = "Pembelian";
            this.buttonPurchase.UseVisualStyleBackColor = false;
            this.buttonPurchase.Click += new System.EventHandler(this.buttonPurchase_Click);
            this.toolTipTransactionMenu.SetToolTip(this.buttonPurchase, "Transaksi Pembelian");

            // btnSalesReturn
            this.btnSalesReturn.BackColor = navyBg;
            this.btnSalesReturn.FlatAppearance.BorderSize = 0;
            this.btnSalesReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesReturn.Font = tileFont;
            this.btnSalesReturn.ForeColor = System.Drawing.Color.White;
            this.btnSalesReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalesReturn.Text = "Return Jual";
            this.btnSalesReturn.UseVisualStyleBackColor = false;
            this.btnSalesReturn.Click += new System.EventHandler(this.btnSalesReturn_Click);

            // btnPurchaseReturn
            this.btnPurchaseReturn.BackColor = navyBg;
            this.btnPurchaseReturn.FlatAppearance.BorderSize = 0;
            this.btnPurchaseReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseReturn.Font = tileFont;
            this.btnPurchaseReturn.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPurchaseReturn.Text = "Return Beli";
            this.btnPurchaseReturn.UseVisualStyleBackColor = false;
            this.btnPurchaseReturn.Click += new System.EventHandler(this.btnPurchaseReturn_Click);

            // accent panels
            pnlAccSales.BackColor   = catGreen; pnlAccSales.Dock   = System.Windows.Forms.DockStyle.Left; pnlAccSales.Width   = 4;
            pnlAccPurch.BackColor   = catBlue;  pnlAccPurch.Dock   = System.Windows.Forms.DockStyle.Left; pnlAccPurch.Width   = 4;
            pnlAccSalesRt.BackColor = catAmber; pnlAccSalesRt.Dock = System.Windows.Forms.DockStyle.Left; pnlAccSalesRt.Width = 4;
            pnlAccPurchRt.BackColor = catAmber; pnlAccPurchRt.Dock = System.Windows.Forms.DockStyle.Left; pnlAccPurchRt.Width = 4;

            // tile wrapper panels
            pnlTileSales.BackColor   = navyBg; pnlTileSales.Dock   = System.Windows.Forms.DockStyle.Fill; pnlTileSales.Margin   = tileMargin;
            pnlTilePurch.BackColor   = navyBg; pnlTilePurch.Dock   = System.Windows.Forms.DockStyle.Fill; pnlTilePurch.Margin   = tileMargin;
            pnlTileSalesRt.BackColor = navyBg; pnlTileSalesRt.Dock = System.Windows.Forms.DockStyle.Fill; pnlTileSalesRt.Margin = tileMargin;
            pnlTilePurchRt.BackColor = navyBg; pnlTilePurchRt.Dock = System.Windows.Forms.DockStyle.Fill; pnlTilePurchRt.Margin = tileMargin;

            pnlTileSales.Controls.Add(this.btnSales);          pnlTileSales.Controls.Add(pnlAccSales);
            pnlTilePurch.Controls.Add(this.buttonPurchase);    pnlTilePurch.Controls.Add(pnlAccPurch);
            pnlTileSalesRt.Controls.Add(this.btnSalesReturn);  pnlTileSalesRt.Controls.Add(pnlAccSalesRt);
            pnlTilePurchRt.Controls.Add(this.btnPurchaseReturn); pnlTilePurchRt.Controls.Add(pnlAccPurchRt);

            // tlpTiles — 2 cols x 2 rows
            tlpTiles.ColumnCount = 2;
            tlpTiles.RowCount    = 2;
            tlpTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpTiles.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            tlpTiles.Padding = new System.Windows.Forms.Padding(0);
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tlpTiles.Controls.Add(pnlTileSales,   0, 0);
            tlpTiles.Controls.Add(pnlTilePurch,   1, 0);
            tlpTiles.Controls.Add(pnlTileSalesRt, 0, 1);
            tlpTiles.Controls.Add(pnlTilePurchRt, 1, 1);
            tlpTiles.Name = "tlpTiles";

            // legend dots
            pnlLegGreen.BackColor = catGreen; pnlLegGreen.Size = new System.Drawing.Size(10, 10); pnlLegGreen.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            pnlLegBlue.BackColor  = catBlue;  pnlLegBlue.Size  = new System.Drawing.Size(10, 10); pnlLegBlue.Margin  = new System.Windows.Forms.Padding(0, 4, 4, 0);
            pnlLegAmber.BackColor = catAmber; pnlLegAmber.Size = new System.Drawing.Size(10, 10); pnlLegAmber.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);

            lblLegGreen.Text = "Penjualan"; lblLegGreen.Font = legFont; lblLegGreen.ForeColor = legText; lblLegGreen.AutoSize = true; lblLegGreen.Margin = new System.Windows.Forms.Padding(0, 2, 16, 0);
            lblLegBlue.Text  = "Pembelian"; lblLegBlue.Font  = legFont; lblLegBlue.ForeColor  = legText; lblLegBlue.AutoSize  = true; lblLegBlue.Margin  = new System.Windows.Forms.Padding(0, 2, 16, 0);
            lblLegAmber.Text = "Retur";     lblLegAmber.Font = legFont; lblLegAmber.ForeColor = legText; lblLegAmber.AutoSize = true; lblLegAmber.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);

            // flpLegend
            flpLegend.Dock = System.Windows.Forms.DockStyle.Top;
            flpLegend.Height = 24;
            flpLegend.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flpLegend.WrapContents = false;
            flpLegend.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            flpLegend.Controls.Add(pnlLegGreen);
            flpLegend.Controls.Add(lblLegGreen);
            flpLegend.Controls.Add(pnlLegBlue);
            flpLegend.Controls.Add(lblLegBlue);
            flpLegend.Controls.Add(pnlLegAmber);
            flpLegend.Controls.Add(lblLegAmber);
            flpLegend.Name = "flpLegend";

            // gbMenuTransaction (Panel, centered in Load)
            this.gbMenuTransaction.BackColor = System.Drawing.Color.White;
            this.gbMenuTransaction.Controls.Add(tlpTiles);
            this.gbMenuTransaction.Controls.Add(flpLegend);
            this.gbMenuTransaction.Location = new System.Drawing.Point(179, 49);
            this.gbMenuTransaction.Name = "gbMenuTransaction";
            this.gbMenuTransaction.Size = new System.Drawing.Size(380, 200);
            this.gbMenuTransaction.TabIndex = 0;

            // pnlMenuTransaction
            this.pnlMenuTransaction.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlMenuTransaction.Controls.Add(this.gbMenuTransaction);
            this.pnlMenuTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenuTransaction.Location = new System.Drawing.Point(0, 42);
            this.pnlMenuTransaction.Name = "pnlMenuTransaction";
            this.pnlMenuTransaction.Size = new System.Drawing.Size(1064, 516);
            this.pnlMenuTransaction.TabIndex = 3;

            // pnlChildHeader
            this.pnlChildHeader.BackColor = System.Drawing.Color.White;
            this.pnlChildHeader.Controls.Add(this.lblTransactionChildHeader);
            this.pnlChildHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlChildHeader.Name = "pnlChildHeader";
            this.pnlChildHeader.Size = new System.Drawing.Size(1064, 40);
            this.pnlChildHeader.TabIndex = 1;

            // lblTransactionChildHeader
            this.lblTransactionChildHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTransactionChildHeader.AutoSize = true;
            this.lblTransactionChildHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTransactionChildHeader.ForeColor = System.Drawing.Color.FromArgb(26, 37, 53);
            this.lblTransactionChildHeader.Location = new System.Drawing.Point(12, 12);
            this.lblTransactionChildHeader.Name = "lblTransactionChildHeader";
            this.lblTransactionChildHeader.TabIndex = 0;
            this.lblTransactionChildHeader.Text = "MENU";

            // pnlSeparator
            this.pnlSeparator.BackColor = System.Drawing.Color.FromArgb(228, 230, 233);
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 40);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(1064, 2);
            this.pnlSeparator.TabIndex = 2;

            // pnlTransactionChildren
            this.pnlTransactionChildren.AutoScroll = true;
            this.pnlTransactionChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransactionChildren.Location = new System.Drawing.Point(0, 42);
            this.pnlTransactionChildren.Name = "pnlTransactionChildren";
            this.pnlTransactionChildren.Size = new System.Drawing.Size(1064, 516);
            this.pnlTransactionChildren.TabIndex = 2;

            // FrmTransactionDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1064, 558);
            this.Controls.Add(this.pnlMenuTransaction);
            this.Controls.Add(this.pnlTransactionChildren);
            this.Controls.Add(this.pnlSeparator);
            this.Controls.Add(this.pnlChildHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTransactionDashboard";
            this.Text = "TRANSAKSI";
            this.Load += new System.EventHandler(this.FrmTransactionDashboard_Load);
            tlpTiles.ResumeLayout(false);
            this.gbMenuTransaction.ResumeLayout(false);
            this.pnlMenuTransaction.ResumeLayout(false);
            this.pnlChildHeader.ResumeLayout(false);
            this.pnlChildHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlChildHeader;
        private System.Windows.Forms.Panel pnlTransactionChildren;
        private System.Windows.Forms.Label lblTransactionChildHeader;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button buttonPurchase;
        private System.Windows.Forms.Button btnPurchaseReturn;
        private System.Windows.Forms.Button btnSalesReturn;
        private System.Windows.Forms.Panel pnlSeparator;
        private System.Windows.Forms.Panel pnlMenuTransaction;
        private System.Windows.Forms.Panel gbMenuTransaction;
        private System.Windows.Forms.ToolTip toolTipTransactionMenu;
    }
}
