namespace CisWindowsFormsApp
{
    partial class FrmMasterDataDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterDataDashboard));

            this.btnProducts       = new System.Windows.Forms.Button();
            this.btnCustomers      = new System.Windows.Forms.Button();
            this.btnUsers          = new System.Windows.Forms.Button();
            this.btnPrincipals     = new System.Windows.Forms.Button();
            this.btnSalesAreas     = new System.Windows.Forms.Button();
            this.btnSalesmen       = new System.Windows.Forms.Button();
            this.btnBatches        = new System.Windows.Forms.Button();
            this.btnRepresentative = new System.Windows.Forms.Button();
            this.btnOutletTypes    = new System.Windows.Forms.Button();
            this.btnMedCats        = new System.Windows.Forms.Button();
            this.btnUsageTypes     = new System.Windows.Forms.Button();
            this.btnRoles          = new System.Windows.Forms.Button();
            this.btnUOM            = new System.Windows.Forms.Button();
            this.btnLocations      = new System.Windows.Forms.Button();
            this.btnTermOfPayment  = new System.Windows.Forms.Button();
            this.pnlMenu                 = new System.Windows.Forms.Panel();
            this.gbMenu                  = new System.Windows.Forms.Panel();
            this.pnlChildHeader          = new System.Windows.Forms.Panel();
            this.pnlHeaderSeparator      = new System.Windows.Forms.Panel();
            this.pnlMasterDataChildren   = new System.Windows.Forms.Panel();
            this.lblMasterDataChildHeader = new System.Windows.Forms.Label();
            this.toolTipButton = new System.Windows.Forms.ToolTip(this.components);

            System.Windows.Forms.TableLayoutPanel tlpTiles  = new System.Windows.Forms.TableLayoutPanel();
            System.Windows.Forms.FlowLayoutPanel  flpLegend = new System.Windows.Forms.FlowLayoutPanel();

            System.Windows.Forms.Panel pnlTileProd  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileCust  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileUsers = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTilePrinc = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileSA    = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileSales = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileBatch = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileRep   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileOT    = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileMC    = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileUT    = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileRoles = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileUOM   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileLoc   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlTileTOP   = new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel pnlAccProd  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccCust  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccUsers = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccPrinc = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccSA    = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccSales = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccBatch = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccRep   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccOT    = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccMC    = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccUT    = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccRoles = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccUOM   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccLoc   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlAccTOP   = new System.Windows.Forms.Panel();

            System.Windows.Forms.Panel pnlLegGreen  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlLegBlue   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlLegAmber  = new System.Windows.Forms.Panel();
            System.Windows.Forms.Label lblLegGreen  = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblLegBlue   = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblLegAmber  = new System.Windows.Forms.Label();

            this.pnlMenu.SuspendLayout();
            this.gbMenu.SuspendLayout();
            this.pnlChildHeader.SuspendLayout();
            tlpTiles.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Color navyBg   = System.Drawing.Color.FromArgb(26, 37, 53);
            System.Drawing.Color catGreen = System.Drawing.Color.FromArgb(107, 143, 94);
            System.Drawing.Color catBlue  = System.Drawing.Color.FromArgb(55, 138, 221);
            System.Drawing.Color catAmber = System.Drawing.Color.FromArgb(186, 117, 23);
            System.Drawing.Font  tileFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font  legFont  = new System.Drawing.Font("Segoe UI", 8F);
            System.Drawing.Color legText  = System.Drawing.Color.FromArgb(96, 96, 96);
            System.Windows.Forms.Padding  tileMargin = new System.Windows.Forms.Padding(0, 0, 8, 8);

            // btnProducts
            this.btnProducts.BackColor = navyBg;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = tileFont;
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.Text = "Produk";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);

            // btnCustomers
            this.btnCustomers.BackColor = navyBg;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.Font = tileFont;
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCustomers.Text = "Pelanggan";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);

            // btnUsers
            this.btnUsers.BackColor = navyBg;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = tileFont;
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsers.Text = "Users";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);

            // btnPrincipals
            this.btnPrincipals.BackColor = navyBg;
            this.btnPrincipals.FlatAppearance.BorderSize = 0;
            this.btnPrincipals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipals.Font = tileFont;
            this.btnPrincipals.ForeColor = System.Drawing.Color.White;
            this.btnPrincipals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrincipals.Text = "Principal";
            this.btnPrincipals.UseVisualStyleBackColor = false;
            this.btnPrincipals.Click += new System.EventHandler(this.btnPrincipals_Click);

            // btnSalesAreas
            this.btnSalesAreas.BackColor = navyBg;
            this.btnSalesAreas.FlatAppearance.BorderSize = 0;
            this.btnSalesAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesAreas.Font = tileFont;
            this.btnSalesAreas.ForeColor = System.Drawing.Color.White;
            this.btnSalesAreas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalesAreas.Text = "Sales Area";
            this.btnSalesAreas.UseVisualStyleBackColor = false;
            this.btnSalesAreas.Click += new System.EventHandler(this.btnSalesAreas_Click);

            // btnSalesmen
            this.btnSalesmen.BackColor = navyBg;
            this.btnSalesmen.FlatAppearance.BorderSize = 0;
            this.btnSalesmen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesmen.Font = tileFont;
            this.btnSalesmen.ForeColor = System.Drawing.Color.White;
            this.btnSalesmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalesmen.Text = "Salesmen";
            this.btnSalesmen.UseVisualStyleBackColor = false;
            this.btnSalesmen.Click += new System.EventHandler(this.btnSalesmen_Click);

            // btnBatches
            this.btnBatches.BackColor = navyBg;
            this.btnBatches.FlatAppearance.BorderSize = 0;
            this.btnBatches.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatches.Font = tileFont;
            this.btnBatches.ForeColor = System.Drawing.Color.White;
            this.btnBatches.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBatches.Text = "Batch";
            this.btnBatches.UseVisualStyleBackColor = false;
            this.btnBatches.Click += new System.EventHandler(this.btnBatches_Click);

            // btnRepresentative
            this.btnRepresentative.BackColor = navyBg;
            this.btnRepresentative.FlatAppearance.BorderSize = 0;
            this.btnRepresentative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepresentative.Font = tileFont;
            this.btnRepresentative.ForeColor = System.Drawing.Color.White;
            this.btnRepresentative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRepresentative.Text = "Perwakilan";
            this.btnRepresentative.UseVisualStyleBackColor = false;
            this.btnRepresentative.Click += new System.EventHandler(this.btnRepresentative_Click);

            // btnOutletTypes
            this.btnOutletTypes.BackColor = navyBg;
            this.btnOutletTypes.FlatAppearance.BorderSize = 0;
            this.btnOutletTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutletTypes.Font = tileFont;
            this.btnOutletTypes.ForeColor = System.Drawing.Color.White;
            this.btnOutletTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOutletTypes.Text = "Jenis Outlet";
            this.btnOutletTypes.UseVisualStyleBackColor = false;
            this.btnOutletTypes.Click += new System.EventHandler(this.btnOutletTypes_Click);

            // btnMedCats
            this.btnMedCats.BackColor = navyBg;
            this.btnMedCats.FlatAppearance.BorderSize = 0;
            this.btnMedCats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedCats.Font = tileFont;
            this.btnMedCats.ForeColor = System.Drawing.Color.White;
            this.btnMedCats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMedCats.Text = "Kategori Obat";
            this.btnMedCats.UseVisualStyleBackColor = false;
            this.btnMedCats.Click += new System.EventHandler(this.btnMedCats_Click);

            // btnUsageTypes
            this.btnUsageTypes.BackColor = navyBg;
            this.btnUsageTypes.FlatAppearance.BorderSize = 0;
            this.btnUsageTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsageTypes.Font = tileFont;
            this.btnUsageTypes.ForeColor = System.Drawing.Color.White;
            this.btnUsageTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsageTypes.Text = "Jenis Pakai";
            this.btnUsageTypes.UseVisualStyleBackColor = false;
            this.btnUsageTypes.Click += new System.EventHandler(this.btnUsageTypes_Click);

            // btnRoles
            this.btnRoles.BackColor = navyBg;
            this.btnRoles.FlatAppearance.BorderSize = 0;
            this.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoles.Font = tileFont;
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRoles.Text = "Roles";
            this.btnRoles.UseVisualStyleBackColor = false;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);

            // btnUOM
            this.btnUOM.BackColor = navyBg;
            this.btnUOM.FlatAppearance.BorderSize = 0;
            this.btnUOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUOM.Font = tileFont;
            this.btnUOM.ForeColor = System.Drawing.Color.White;
            this.btnUOM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUOM.Text = "Satuan Unit";
            this.btnUOM.UseVisualStyleBackColor = false;
            this.btnUOM.Click += new System.EventHandler(this.btnUOM_Click);

            // btnLocations
            this.btnLocations.BackColor = navyBg;
            this.btnLocations.FlatAppearance.BorderSize = 0;
            this.btnLocations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocations.Font = tileFont;
            this.btnLocations.ForeColor = System.Drawing.Color.White;
            this.btnLocations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLocations.Text = "Lokasi";
            this.btnLocations.UseVisualStyleBackColor = false;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);

            // btnTermOfPayment
            this.btnTermOfPayment.BackColor = navyBg;
            this.btnTermOfPayment.FlatAppearance.BorderSize = 0;
            this.btnTermOfPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTermOfPayment.Font = tileFont;
            this.btnTermOfPayment.ForeColor = System.Drawing.Color.White;
            this.btnTermOfPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTermOfPayment.Text = "T O P";
            this.btnTermOfPayment.UseVisualStyleBackColor = false;
            this.btnTermOfPayment.Click += new System.EventHandler(this.btnTermOfPayment_Click);

            this.toolTipButton.SetToolTip(this.btnUOM,           "Unit of Measurement");
            this.toolTipButton.SetToolTip(this.btnTermOfPayment, "Term of Payment");
            this.toolTipButton.SetToolTip(this.btnRepresentative,"Perwakilan");

            // accent panels
            pnlAccProd.BackColor  = catGreen; pnlAccProd.Dock  = System.Windows.Forms.DockStyle.Left; pnlAccProd.Width  = 4;
            pnlAccCust.BackColor  = catGreen; pnlAccCust.Dock  = System.Windows.Forms.DockStyle.Left; pnlAccCust.Width  = 4;
            pnlAccUsers.BackColor = catBlue;  pnlAccUsers.Dock = System.Windows.Forms.DockStyle.Left; pnlAccUsers.Width = 4;
            pnlAccPrinc.BackColor = catBlue;  pnlAccPrinc.Dock = System.Windows.Forms.DockStyle.Left; pnlAccPrinc.Width = 4;
            pnlAccSA.BackColor    = catBlue;  pnlAccSA.Dock    = System.Windows.Forms.DockStyle.Left; pnlAccSA.Width    = 4;
            pnlAccSales.BackColor = catBlue;  pnlAccSales.Dock = System.Windows.Forms.DockStyle.Left; pnlAccSales.Width = 4;
            pnlAccBatch.BackColor = catAmber; pnlAccBatch.Dock = System.Windows.Forms.DockStyle.Left; pnlAccBatch.Width = 4;
            pnlAccRep.BackColor   = catBlue;  pnlAccRep.Dock   = System.Windows.Forms.DockStyle.Left; pnlAccRep.Width   = 4;
            pnlAccOT.BackColor    = catAmber; pnlAccOT.Dock    = System.Windows.Forms.DockStyle.Left; pnlAccOT.Width    = 4;
            pnlAccMC.BackColor    = catAmber; pnlAccMC.Dock    = System.Windows.Forms.DockStyle.Left; pnlAccMC.Width    = 4;
            pnlAccUT.BackColor    = catAmber; pnlAccUT.Dock    = System.Windows.Forms.DockStyle.Left; pnlAccUT.Width    = 4;
            pnlAccRoles.BackColor = catBlue;  pnlAccRoles.Dock = System.Windows.Forms.DockStyle.Left; pnlAccRoles.Width = 4;
            pnlAccUOM.BackColor   = catAmber; pnlAccUOM.Dock   = System.Windows.Forms.DockStyle.Left; pnlAccUOM.Width   = 4;
            pnlAccLoc.BackColor   = catAmber; pnlAccLoc.Dock   = System.Windows.Forms.DockStyle.Left; pnlAccLoc.Width   = 4;
            pnlAccTOP.BackColor   = catAmber; pnlAccTOP.Dock   = System.Windows.Forms.DockStyle.Left; pnlAccTOP.Width   = 4;

            // tile wrapper panels
            pnlTileProd.BackColor  = navyBg; pnlTileProd.Dock  = System.Windows.Forms.DockStyle.Fill; pnlTileProd.Margin  = tileMargin;
            pnlTileCust.BackColor  = navyBg; pnlTileCust.Dock  = System.Windows.Forms.DockStyle.Fill; pnlTileCust.Margin  = tileMargin;
            pnlTileUsers.BackColor = navyBg; pnlTileUsers.Dock = System.Windows.Forms.DockStyle.Fill; pnlTileUsers.Margin = tileMargin;
            pnlTilePrinc.BackColor = navyBg; pnlTilePrinc.Dock = System.Windows.Forms.DockStyle.Fill; pnlTilePrinc.Margin = tileMargin;
            pnlTileSA.BackColor    = navyBg; pnlTileSA.Dock    = System.Windows.Forms.DockStyle.Fill; pnlTileSA.Margin    = tileMargin;
            pnlTileSales.BackColor = navyBg; pnlTileSales.Dock = System.Windows.Forms.DockStyle.Fill; pnlTileSales.Margin = tileMargin;
            pnlTileBatch.BackColor = navyBg; pnlTileBatch.Dock = System.Windows.Forms.DockStyle.Fill; pnlTileBatch.Margin = tileMargin;
            pnlTileRep.BackColor   = navyBg; pnlTileRep.Dock   = System.Windows.Forms.DockStyle.Fill; pnlTileRep.Margin   = tileMargin;
            pnlTileOT.BackColor    = navyBg; pnlTileOT.Dock    = System.Windows.Forms.DockStyle.Fill; pnlTileOT.Margin    = tileMargin;
            pnlTileMC.BackColor    = navyBg; pnlTileMC.Dock    = System.Windows.Forms.DockStyle.Fill; pnlTileMC.Margin    = tileMargin;
            pnlTileUT.BackColor    = navyBg; pnlTileUT.Dock    = System.Windows.Forms.DockStyle.Fill; pnlTileUT.Margin    = tileMargin;
            pnlTileRoles.BackColor = navyBg; pnlTileRoles.Dock = System.Windows.Forms.DockStyle.Fill; pnlTileRoles.Margin = tileMargin;
            pnlTileUOM.BackColor   = navyBg; pnlTileUOM.Dock   = System.Windows.Forms.DockStyle.Fill; pnlTileUOM.Margin   = tileMargin;
            pnlTileLoc.BackColor   = navyBg; pnlTileLoc.Dock   = System.Windows.Forms.DockStyle.Fill; pnlTileLoc.Margin   = tileMargin;
            pnlTileTOP.BackColor   = navyBg; pnlTileTOP.Dock   = System.Windows.Forms.DockStyle.Fill; pnlTileTOP.Margin   = tileMargin;

            // tile contents: Fill button added first, then Left accent panel
            pnlTileProd.Controls.Add(this.btnProducts);       pnlTileProd.Controls.Add(pnlAccProd);
            pnlTileCust.Controls.Add(this.btnCustomers);      pnlTileCust.Controls.Add(pnlAccCust);
            pnlTileUsers.Controls.Add(this.btnUsers);         pnlTileUsers.Controls.Add(pnlAccUsers);
            pnlTilePrinc.Controls.Add(this.btnPrincipals);    pnlTilePrinc.Controls.Add(pnlAccPrinc);
            pnlTileSA.Controls.Add(this.btnSalesAreas);       pnlTileSA.Controls.Add(pnlAccSA);
            pnlTileSales.Controls.Add(this.btnSalesmen);      pnlTileSales.Controls.Add(pnlAccSales);
            pnlTileBatch.Controls.Add(this.btnBatches);       pnlTileBatch.Controls.Add(pnlAccBatch);
            pnlTileRep.Controls.Add(this.btnRepresentative);  pnlTileRep.Controls.Add(pnlAccRep);
            pnlTileOT.Controls.Add(this.btnOutletTypes);      pnlTileOT.Controls.Add(pnlAccOT);
            pnlTileMC.Controls.Add(this.btnMedCats);          pnlTileMC.Controls.Add(pnlAccMC);
            pnlTileUT.Controls.Add(this.btnUsageTypes);       pnlTileUT.Controls.Add(pnlAccUT);
            pnlTileRoles.Controls.Add(this.btnRoles);         pnlTileRoles.Controls.Add(pnlAccRoles);
            pnlTileUOM.Controls.Add(this.btnUOM);             pnlTileUOM.Controls.Add(pnlAccUOM);
            pnlTileLoc.Controls.Add(this.btnLocations);       pnlTileLoc.Controls.Add(pnlAccLoc);
            pnlTileTOP.Controls.Add(this.btnTermOfPayment);   pnlTileTOP.Controls.Add(pnlAccTOP);

            // tlpTiles
            tlpTiles.ColumnCount = 5;
            tlpTiles.RowCount    = 3;
            tlpTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            tlpTiles.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.None;
            tlpTiles.Padding = new System.Windows.Forms.Padding(0);
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpTiles.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            tlpTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tlpTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tlpTiles.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            tlpTiles.Controls.Add(pnlTileProd,  0, 0);
            tlpTiles.Controls.Add(pnlTileCust,  1, 0);
            tlpTiles.Controls.Add(pnlTileUsers, 2, 0);
            tlpTiles.Controls.Add(pnlTilePrinc, 3, 0);
            tlpTiles.Controls.Add(pnlTileSA,    4, 0);
            tlpTiles.Controls.Add(pnlTileSales, 0, 1);
            tlpTiles.Controls.Add(pnlTileBatch, 1, 1);
            tlpTiles.Controls.Add(pnlTileRep,   2, 1);
            tlpTiles.Controls.Add(pnlTileOT,    3, 1);
            tlpTiles.Controls.Add(pnlTileMC,    4, 1);
            tlpTiles.Controls.Add(pnlTileUT,    0, 2);
            tlpTiles.Controls.Add(pnlTileRoles, 1, 2);
            tlpTiles.Controls.Add(pnlTileUOM,   2, 2);
            tlpTiles.Controls.Add(pnlTileLoc,   3, 2);
            tlpTiles.Controls.Add(pnlTileTOP,   4, 2);
            tlpTiles.Name = "tlpTiles";

            // legend dots
            pnlLegGreen.BackColor = catGreen;
            pnlLegGreen.Size = new System.Drawing.Size(10, 10);
            pnlLegGreen.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);

            pnlLegBlue.BackColor = catBlue;
            pnlLegBlue.Size = new System.Drawing.Size(10, 10);
            pnlLegBlue.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);

            pnlLegAmber.BackColor = catAmber;
            pnlLegAmber.Size = new System.Drawing.Size(10, 10);
            pnlLegAmber.Margin = new System.Windows.Forms.Padding(0, 4, 4, 0);

            // legend labels
            lblLegGreen.Text = "Produk & pelanggan";
            lblLegGreen.Font = legFont;
            lblLegGreen.ForeColor = legText;
            lblLegGreen.AutoSize = true;
            lblLegGreen.Margin = new System.Windows.Forms.Padding(0, 2, 16, 0);

            lblLegBlue.Text = "Organisasi";
            lblLegBlue.Font = legFont;
            lblLegBlue.ForeColor = legText;
            lblLegBlue.AutoSize = true;
            lblLegBlue.Margin = new System.Windows.Forms.Padding(0, 2, 16, 0);

            lblLegAmber.Text = "Referensi";
            lblLegAmber.Font = legFont;
            lblLegAmber.ForeColor = legText;
            lblLegAmber.AutoSize = true;
            lblLegAmber.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);

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

            // gbMenu
            this.gbMenu.BackColor = System.Drawing.Color.White;
            this.gbMenu.Controls.Add(tlpTiles);
            this.gbMenu.Controls.Add(flpLegend);
            this.gbMenu.Location = new System.Drawing.Point(150, 80);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(740, 270);
            this.gbMenu.TabIndex = 0;

            // pnlMenu
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlMenu.Controls.Add(this.gbMenu);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 42);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1104, 516);
            this.pnlMenu.TabIndex = 1;

            // pnlChildHeader
            this.pnlChildHeader.BackColor = System.Drawing.Color.White;
            this.pnlChildHeader.Controls.Add(this.lblMasterDataChildHeader);
            this.pnlChildHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlChildHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlChildHeader.Name = "pnlChildHeader";
            this.pnlChildHeader.Size = new System.Drawing.Size(1104, 40);
            this.pnlChildHeader.TabIndex = 2;

            // lblMasterDataChildHeader
            this.lblMasterDataChildHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMasterDataChildHeader.AutoSize = true;
            this.lblMasterDataChildHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMasterDataChildHeader.ForeColor = System.Drawing.Color.FromArgb(26, 37, 53);
            this.lblMasterDataChildHeader.Location = new System.Drawing.Point(12, 12);
            this.lblMasterDataChildHeader.Name = "lblMasterDataChildHeader";
            this.lblMasterDataChildHeader.TabIndex = 0;
            this.lblMasterDataChildHeader.Text = "MENU";

            // pnlHeaderSeparator
            this.pnlHeaderSeparator.BackColor = System.Drawing.Color.FromArgb(228, 230, 233);
            this.pnlHeaderSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSeparator.Location = new System.Drawing.Point(0, 40);
            this.pnlHeaderSeparator.Name = "pnlHeaderSeparator";
            this.pnlHeaderSeparator.Size = new System.Drawing.Size(1104, 2);
            this.pnlHeaderSeparator.TabIndex = 3;

            // pnlMasterDataChildren
            this.pnlMasterDataChildren.AutoScroll = true;
            this.pnlMasterDataChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMasterDataChildren.Location = new System.Drawing.Point(0, 42);
            this.pnlMasterDataChildren.Name = "pnlMasterDataChildren";
            this.pnlMasterDataChildren.Size = new System.Drawing.Size(1104, 516);
            this.pnlMasterDataChildren.TabIndex = 4;

            // FrmMasterDataDashboard
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 558);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlMasterDataChildren);
            this.Controls.Add(this.pnlHeaderSeparator);
            this.Controls.Add(this.pnlChildHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMasterDataDashboard";
            this.Text = "MASTER DATA";
            this.Load += new System.EventHandler(this.FrmMasterDataDashboard_Load);
            tlpTiles.ResumeLayout(false);
            this.gbMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlChildHeader.ResumeLayout(false);
            this.pnlChildHeader.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnPrincipals;
        private System.Windows.Forms.Button btnSalesAreas;
        private System.Windows.Forms.Button btnSalesmen;
        private System.Windows.Forms.Button btnBatches;
        private System.Windows.Forms.Button btnRepresentative;
        private System.Windows.Forms.Button btnOutletTypes;
        private System.Windows.Forms.Button btnMedCats;
        private System.Windows.Forms.Button btnUsageTypes;
        private System.Windows.Forms.Button btnRoles;
        private System.Windows.Forms.Button btnUOM;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnTermOfPayment;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel gbMenu;
        private System.Windows.Forms.Panel pnlChildHeader;
        private System.Windows.Forms.Panel pnlHeaderSeparator;
        private System.Windows.Forms.Panel pnlMasterDataChildren;
        private System.Windows.Forms.Label lblMasterDataChildHeader;
        private System.Windows.Forms.ToolTip toolTipButton;
    }
}
