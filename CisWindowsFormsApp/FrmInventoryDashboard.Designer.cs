namespace CisWindowsFormsApp
{
    partial class FrmInventoryDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventoryDashboard));

            this.pnlChildHeader          = new System.Windows.Forms.Panel();
            this.lblInventoryChildHeader  = new System.Windows.Forms.Label();
            this.pnlHeaderSeparator      = new System.Windows.Forms.Panel();
            this.pnlInventoryChildren    = new System.Windows.Forms.Panel();
            this.pnlMenu                 = new System.Windows.Forms.Panel();
            this.gbMenu                  = new System.Windows.Forms.Panel();
            this.btnStockAdjustment      = new System.Windows.Forms.Button();
            this.btnStockTransfer        = new System.Windows.Forms.Button();
            this.btnStockOpname          = new System.Windows.Forms.Button();

            System.Windows.Forms.TableLayoutPanel tlpTiles  = new System.Windows.Forms.TableLayoutPanel();
            System.Windows.Forms.FlowLayoutPanel  flpLegend = new System.Windows.Forms.FlowLayoutPanel();

            System.Windows.Forms.Panel pnlTileAdj      = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileTransfer = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileOpname   = new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel pnlAccAdj      = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccTransfer = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccOpname   = new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel pnlLegAmber = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlLegBlue  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlLegGreen = new System.Windows.Forms.Panel();
            System.Windows.Forms.Label lblLegAmber = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblLegBlue  = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblLegGreen = new System.Windows.Forms.Label();

            this.pnlChildHeader.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.gbMenu.SuspendLayout();
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

            // btnStockAdjustment
            this.btnStockAdjustment.BackColor = navyBg;
            this.btnStockAdjustment.FlatAppearance.BorderSize = 0;
            this.btnStockAdjustment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockAdjustment.Font = tileFont;
            this.btnStockAdjustment.ForeColor = System.Drawing.Color.White;
            this.btnStockAdjustment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStockAdjustment.Name = "btnStockAdjustment";
            this.btnStockAdjustment.Text = "Adj. Stok";
            this.btnStockAdjustment.UseVisualStyleBackColor = false;
            this.btnStockAdjustment.Click += new System.EventHandler(this.btnStockAdjustment_Click);

            // btnStockTransfer
            this.btnStockTransfer.BackColor = navyBg;
            this.btnStockTransfer.FlatAppearance.BorderSize = 0;
            this.btnStockTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockTransfer.Font = tileFont;
            this.btnStockTransfer.ForeColor = System.Drawing.Color.White;
            this.btnStockTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStockTransfer.Name = "btnStockTransfer";
            this.btnStockTransfer.Text = "Transfer Stok";
            this.btnStockTransfer.UseVisualStyleBackColor = false;
            this.btnStockTransfer.Click += new System.EventHandler(this.btnStockTransfer_Click);

            // btnStockOpname
            this.btnStockOpname.BackColor = navyBg;
            this.btnStockOpname.FlatAppearance.BorderSize = 0;
            this.btnStockOpname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockOpname.Font = tileFont;
            this.btnStockOpname.ForeColor = System.Drawing.Color.White;
            this.btnStockOpname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStockOpname.Name = "btnStockOpname";
            this.btnStockOpname.Text = "Stock Opname";
            this.btnStockOpname.UseVisualStyleBackColor = false;
            this.btnStockOpname.Click += new System.EventHandler(this.btnStockOpname_Click);

            // accent panels
            pnlAccAdj.BackColor      = catAmber; pnlAccAdj.Dock      = System.Windows.Forms.DockStyle.Left; pnlAccAdj.Width      = 4;
            pnlAccTransfer.BackColor = catBlue;  pnlAccTransfer.Dock = System.Windows.Forms.DockStyle.Left; pnlAccTransfer.Width = 4;
            pnlAccOpname.BackColor   = catGreen; pnlAccOpname.Dock   = System.Windows.Forms.DockStyle.Left; pnlAccOpname.Width   = 4;

            // tile wrapper panels
            pnlTileAdj.BackColor      = navyBg; pnlTileAdj.Dock      = System.Windows.Forms.DockStyle.Fill; pnlTileAdj.Margin      = tileMargin;
            pnlTileTransfer.BackColor = navyBg; pnlTileTransfer.Dock = System.Windows.Forms.DockStyle.Fill; pnlTileTransfer.Margin = tileMargin;
            pnlTileOpname.BackColor   = navyBg; pnlTileOpname.Dock   = System.Windows.Forms.DockStyle.Fill; pnlTileOpname.Margin   = tileMargin;

            pnlTileAdj.Controls.Add(this.btnStockAdjustment); pnlTileAdj.Controls.Add(pnlAccAdj);
            pnlTileTransfer.Controls.Add(this.btnStockTransfer); pnlTileTransfer.Controls.Add(pnlAccTransfer);
            pnlTileOpname.Controls.Add(this.btnStockOpname); pnlTileOpname.Controls.Add(pnlAccOpname);

            // tlpTiles — 3 cols x 1 row
            tlpTiles.ColumnCount = 3;
            tlpTiles.RowCount    = 1;
            tlpTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpTiles.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            tlpTiles.Padding = new System.Windows.Forms.Padding(0);
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            tlpTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tlpTiles.Controls.Add(pnlTileAdj,      0, 0);
            tlpTiles.Controls.Add(pnlTileTransfer, 1, 0);
            tlpTiles.Controls.Add(pnlTileOpname,   2, 0);
            tlpTiles.Name = "tlpTiles";

            // legend dots
            pnlLegAmber.BackColor = catAmber; pnlLegAmber.Size = new System.Drawing.Size(10, 10); pnlLegAmber.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);
            pnlLegBlue.BackColor  = catBlue;  pnlLegBlue.Size  = new System.Drawing.Size(10, 10); pnlLegBlue.Margin  = new System.Windows.Forms.Padding(0, 4, 4, 0);
            pnlLegGreen.BackColor = catGreen; pnlLegGreen.Size = new System.Drawing.Size(10, 10); pnlLegGreen.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);

            lblLegAmber.Text = "Penyesuaian"; lblLegAmber.Font = legFont; lblLegAmber.ForeColor = legText; lblLegAmber.AutoSize = true; lblLegAmber.Margin = new System.Windows.Forms.Padding(0, 2, 16, 0);
            lblLegBlue.Text  = "Mutasi";      lblLegBlue.Font  = legFont; lblLegBlue.ForeColor  = legText; lblLegBlue.AutoSize  = true; lblLegBlue.Margin  = new System.Windows.Forms.Padding(0, 2, 16, 0);
            lblLegGreen.Text = "Opname";      lblLegGreen.Font = legFont; lblLegGreen.ForeColor = legText; lblLegGreen.AutoSize = true; lblLegGreen.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);

            // flpLegend
            flpLegend.Dock = System.Windows.Forms.DockStyle.Top;
            flpLegend.Height = 24;
            flpLegend.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            flpLegend.WrapContents = false;
            flpLegend.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            flpLegend.Controls.Add(pnlLegAmber);
            flpLegend.Controls.Add(lblLegAmber);
            flpLegend.Controls.Add(pnlLegBlue);
            flpLegend.Controls.Add(lblLegBlue);
            flpLegend.Controls.Add(pnlLegGreen);
            flpLegend.Controls.Add(lblLegGreen);
            flpLegend.Name = "flpLegend";

            // gbMenu (Panel, centered in CenterControls)
            this.gbMenu.BackColor = System.Drawing.Color.White;
            this.gbMenu.Controls.Add(tlpTiles);
            this.gbMenu.Controls.Add(flpLegend);
            this.gbMenu.Location = new System.Drawing.Point(239, 60);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(560, 120);
            this.gbMenu.TabIndex = 0;

            // pnlMenu
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlMenu.Controls.Add(this.gbMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 51);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1104, 558);
            this.pnlMenu.TabIndex = 3;

            // pnlChildHeader
            this.pnlChildHeader.BackColor = System.Drawing.Color.White;
            this.pnlChildHeader.Controls.Add(this.lblInventoryChildHeader);
            this.pnlChildHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlChildHeader.Name = "pnlChildHeader";
            this.pnlChildHeader.Size = new System.Drawing.Size(1104, 40);
            this.pnlChildHeader.TabIndex = 0;

            // lblInventoryChildHeader
            this.lblInventoryChildHeader.AutoSize = true;
            this.lblInventoryChildHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblInventoryChildHeader.ForeColor = System.Drawing.Color.FromArgb(26, 37, 53);
            this.lblInventoryChildHeader.Location = new System.Drawing.Point(12, 12);
            this.lblInventoryChildHeader.Name = "lblInventoryChildHeader";
            this.lblInventoryChildHeader.TabIndex = 0;
            this.lblInventoryChildHeader.Text = "MENU";

            // pnlHeaderSeparator
            this.pnlHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(228, 230, 233);
            this.pnlHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSeparator.Location = new System.Drawing.Point(0, 40);
            this.pnlHeaderSeparator.Name = "pnlHeaderSeparator";
            this.pnlHeaderSeparator.Size = new System.Drawing.Size(1104, 2);
            this.pnlHeaderSeparator.TabIndex = 1;

            // pnlInventoryChildren
            this.pnlInventoryChildren.AutoScroll = true;
            this.pnlInventoryChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInventoryChildren.Location = new System.Drawing.Point(0, 42);
            this.pnlInventoryChildren.Name = "pnlInventoryChildren";
            this.pnlInventoryChildren.Size = new System.Drawing.Size(1104, 558);
            this.pnlInventoryChildren.TabIndex = 2;

            // FrmInventoryDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 600);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlInventoryChildren);
            this.Controls.Add(this.pnlHeaderSeparator);
            this.Controls.Add(this.pnlChildHeader);
            this.Name = "FrmInventoryDashboard";
            this.Text = "INVENTORY";
            this.Load += new System.EventHandler(this.FrmInventoryDashboard_Load);
            this.Resize += new System.EventHandler(this.FrmInventoryDashboard_Resize);
            tlpTiles.ResumeLayout(false);
            this.gbMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlChildHeader.ResumeLayout(false);
            this.pnlChildHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlChildHeader;
        private System.Windows.Forms.Label lblInventoryChildHeader;
        private System.Windows.Forms.Panel pnlHeaderSeparator;
        private System.Windows.Forms.Panel pnlInventoryChildren;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel gbMenu;
        private System.Windows.Forms.Button btnStockAdjustment;
        private System.Windows.Forms.Button btnStockTransfer;
        private System.Windows.Forms.Button btnStockOpname;
    }
}
