namespace CisWindowsFormsApp
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));

            // panels
            this.pnlActionBar   = new System.Windows.Forms.Panel();
            this.pnlContent     = new System.Windows.Forms.Panel();
            this.pnlLeft        = new System.Windows.Forms.Panel();
            this.pnlLeftSpacer  = new System.Windows.Forms.Panel();
            this.pnlRight       = new System.Windows.Forms.Panel();
            this.pnlSearch      = new System.Windows.Forms.Panel();
            this.pnlNote        = new System.Windows.Forms.Panel();
            this.pnlHiddenField = new System.Windows.Forms.Panel();

            // search bar controls
            this.txtSearch  = new System.Windows.Forms.TextBox();
            this.btnSearch  = new System.Windows.Forms.Button();

            // action bar buttons
            this.btnClear  = new System.Windows.Forms.Button();
            this.btnAdd    = new System.Windows.Forms.Button();
            this.btnSave   = new System.Windows.Forms.Button();
            this.btnDel    = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();

            // form fields
            this.txtManualCode  = new System.Windows.Forms.TextBox();
            this.txtAutoCode    = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtPrice       = new System.Windows.Forms.TextBox();
            this.dtpDecreeDate  = new System.Windows.Forms.DateTimePicker();
            this.txtDiscount    = new System.Windows.Forms.TextBox();
            this.txtRestock     = new System.Windows.Forms.TextBox();
            this.cbUom          = new System.Windows.Forms.ComboBox();
            this.cbMedCat       = new System.Windows.Forms.ComboBox();
            this.cbUsageType    = new System.Windows.Forms.ComboBox();
            this.cbPrincipal    = new System.Windows.Forms.ComboBox();

            // note panel
            this.lblNoteDetail = new System.Windows.Forms.Label();

            // grid
            this.dgvProduct = new System.Windows.Forms.DataGridView();

            // hidden fields
            this.txtProductId  = new System.Windows.Forms.TextBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();

            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlNote.SuspendLayout();
            this.pnlHiddenField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();

            // ── pnlActionBar ──────────────────────────
            this.pnlActionBar.BackColor = System.Drawing.Color.FromArgb(228, 230, 233);
            this.pnlActionBar.Controls.Add(this.btnReload);
            this.pnlActionBar.Controls.Add(this.btnDel);
            this.pnlActionBar.Controls.Add(this.btnSave);
            this.pnlActionBar.Controls.Add(this.btnAdd);
            this.pnlActionBar.Controls.Add(this.btnClear);
            this.pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionBar.Name = "pnlActionBar";
            this.pnlActionBar.Size = new System.Drawing.Size(1360, 52);
            this.pnlActionBar.TabIndex = 0;

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(11, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 34);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(141, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(261, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDel.BackColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(381, 9);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 34);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);

            this.btnReload.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(501, 9);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(109, 34);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);

            // ── pnlContent ────────────────────────────
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlContent.Controls.Add(this.pnlRight);
            this.pnlContent.Controls.Add(this.pnlLeftSpacer);
            this.pnlContent.Controls.Add(this.pnlLeft);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(8);
            this.pnlContent.TabIndex = 1;

            // ── pnlLeft (form fields, white card) ─────
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLeft.Size = new System.Drawing.Size(388, 600);
            this.pnlLeft.TabIndex = 0;

            // ── pnlLeftSpacer ─────────────────────────
            this.pnlLeftSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSpacer.Name = "pnlLeftSpacer";
            this.pnlLeftSpacer.Size = new System.Drawing.Size(8, 600);
            this.pnlLeftSpacer.TabIndex = 1;

            // ── pnlRight (Fill) ───────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.dgvProduct);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(4);
            this.pnlRight.TabIndex = 2;

            // ── pnlSearch (Top, 42px, above grid) ─────
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(960, 42);
            this.pnlSearch.TabIndex = 0;

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(4, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 23);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(312, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // ── Form fields inside pnlLeft ────────────

            // --- Row 1: Kode Produk ---
            var lblKodeProduk = new System.Windows.Forms.Label();
            lblKodeProduk.AutoSize = true;
            lblKodeProduk.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblKodeProduk.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblKodeProduk.Location = new System.Drawing.Point(8, 8);
            lblKodeProduk.Text = "Kode Produk";
            this.pnlLeft.Controls.Add(lblKodeProduk);

            this.txtManualCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtManualCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtManualCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtManualCode.Location = new System.Drawing.Point(8, 24);
            this.txtManualCode.MaxLength = 2;
            this.txtManualCode.Name = "txtManualCode";
            this.txtManualCode.Size = new System.Drawing.Size(55, 23);
            this.txtManualCode.TabIndex = 1;
            this.pnlLeft.Controls.Add(this.txtManualCode);

            this.txtAutoCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutoCode.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.txtAutoCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAutoCode.Location = new System.Drawing.Point(70, 24);
            this.txtAutoCode.Name = "txtAutoCode";
            this.txtAutoCode.ReadOnly = true;
            this.txtAutoCode.Size = new System.Drawing.Size(100, 23);
            this.txtAutoCode.TabIndex = 99;
            this.pnlLeft.Controls.Add(this.txtAutoCode);

            // --- Row 2: Nama Produk ---
            var lblNamaProduk = new System.Windows.Forms.Label();
            lblNamaProduk.AutoSize = true;
            lblNamaProduk.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblNamaProduk.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblNamaProduk.Location = new System.Drawing.Point(8, 56);
            lblNamaProduk.Text = "Nama Produk";
            this.pnlLeft.Controls.Add(lblNamaProduk);

            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtProductName.Location = new System.Drawing.Point(8, 72);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(364, 23);
            this.txtProductName.TabIndex = 2;
            this.pnlLeft.Controls.Add(this.txtProductName);

            // --- Row 3: Harga / Tgl. SK Harga ---
            var lblHarga = new System.Windows.Forms.Label();
            lblHarga.AutoSize = true;
            lblHarga.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblHarga.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblHarga.Location = new System.Drawing.Point(8, 104);
            lblHarga.Text = "Harga (HNA)";
            this.pnlLeft.Controls.Add(lblHarga);

            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(8, 120);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 23);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            this.pnlLeft.Controls.Add(this.txtPrice);

            var lblSkHarga = new System.Windows.Forms.Label();
            lblSkHarga.AutoSize = true;
            lblSkHarga.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblSkHarga.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblSkHarga.Location = new System.Drawing.Point(156, 104);
            lblSkHarga.Text = "Tgl. SK Harga";
            this.pnlLeft.Controls.Add(lblSkHarga);

            this.dtpDecreeDate.CalendarForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.dtpDecreeDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDecreeDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDecreeDate.Location = new System.Drawing.Point(156, 120);
            this.dtpDecreeDate.Name = "dtpDecreeDate";
            this.dtpDecreeDate.Size = new System.Drawing.Size(140, 23);
            this.dtpDecreeDate.TabIndex = 4;
            this.pnlLeft.Controls.Add(this.dtpDecreeDate);

            // --- Row 4: Discount / Restock / Satuan ---
            var lblDiscount = new System.Windows.Forms.Label();
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblDiscount.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblDiscount.Location = new System.Drawing.Point(8, 152);
            lblDiscount.Text = "Discount (%)";
            this.pnlLeft.Controls.Add(lblDiscount);

            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscount.Location = new System.Drawing.Point(8, 168);
            this.txtDiscount.MaxLength = 3;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(70, 23);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            this.pnlLeft.Controls.Add(this.txtDiscount);

            var lblRestock = new System.Windows.Forms.Label();
            lblRestock.AutoSize = true;
            lblRestock.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblRestock.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblRestock.Location = new System.Drawing.Point(86, 152);
            lblRestock.Text = "Restock";
            this.pnlLeft.Controls.Add(lblRestock);

            this.txtRestock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRestock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRestock.Location = new System.Drawing.Point(86, 168);
            this.txtRestock.Name = "txtRestock";
            this.txtRestock.Size = new System.Drawing.Size(70, 23);
            this.txtRestock.TabIndex = 6;
            this.txtRestock.Text = "0";
            this.txtRestock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRestock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRestock_KeyPress);
            this.pnlLeft.Controls.Add(this.txtRestock);

            var lblSatuan = new System.Windows.Forms.Label();
            lblSatuan.AutoSize = true;
            lblSatuan.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblSatuan.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblSatuan.Location = new System.Drawing.Point(164, 152);
            lblSatuan.Text = "Satuan";
            this.pnlLeft.Controls.Add(lblSatuan);

            this.cbUom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbUom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUom.FormattingEnabled = true;
            this.cbUom.Location = new System.Drawing.Point(164, 168);
            this.cbUom.Name = "cbUom";
            this.cbUom.Size = new System.Drawing.Size(208, 23);
            this.cbUom.TabIndex = 7;
            this.pnlLeft.Controls.Add(this.cbUom);

            // --- Row 5: Kategori Obat ---
            var lblMedCat = new System.Windows.Forms.Label();
            lblMedCat.AutoSize = true;
            lblMedCat.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblMedCat.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblMedCat.Location = new System.Drawing.Point(8, 200);
            lblMedCat.Text = "Kategori Obat";
            this.pnlLeft.Controls.Add(lblMedCat);

            this.cbMedCat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbMedCat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbMedCat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbMedCat.FormattingEnabled = true;
            this.cbMedCat.Location = new System.Drawing.Point(8, 216);
            this.cbMedCat.Name = "cbMedCat";
            this.cbMedCat.Size = new System.Drawing.Size(364, 23);
            this.cbMedCat.TabIndex = 8;
            this.cbMedCat.SelectedIndexChanged += new System.EventHandler(this.cbMedCat_SelectedIndexChanged);
            this.pnlLeft.Controls.Add(this.cbMedCat);

            // --- Row 6: Jenis Pemakaian ---
            var lblUsageType = new System.Windows.Forms.Label();
            lblUsageType.AutoSize = true;
            lblUsageType.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblUsageType.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblUsageType.Location = new System.Drawing.Point(8, 248);
            lblUsageType.Text = "Jenis Pemakaian";
            this.pnlLeft.Controls.Add(lblUsageType);

            this.cbUsageType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbUsageType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbUsageType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbUsageType.FormattingEnabled = true;
            this.cbUsageType.Location = new System.Drawing.Point(8, 264);
            this.cbUsageType.Name = "cbUsageType";
            this.cbUsageType.Size = new System.Drawing.Size(364, 23);
            this.cbUsageType.TabIndex = 9;
            this.cbUsageType.SelectedIndexChanged += new System.EventHandler(this.cbUsageType_SelectedIndexChanged);
            this.pnlLeft.Controls.Add(this.cbUsageType);

            // --- Row 7: Principal ---
            var lblPrincipal = new System.Windows.Forms.Label();
            lblPrincipal.AutoSize = true;
            lblPrincipal.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblPrincipal.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblPrincipal.Location = new System.Drawing.Point(8, 296);
            lblPrincipal.Text = "Principal";
            this.pnlLeft.Controls.Add(lblPrincipal);

            this.cbPrincipal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPrincipal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPrincipal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbPrincipal.FormattingEnabled = true;
            this.cbPrincipal.Location = new System.Drawing.Point(8, 312);
            this.cbPrincipal.Name = "cbPrincipal";
            this.cbPrincipal.Size = new System.Drawing.Size(364, 23);
            this.cbPrincipal.TabIndex = 10;
            this.cbPrincipal.SelectedIndexChanged += new System.EventHandler(this.cbPrincipal_SelectedIndexChanged);
            this.pnlLeft.Controls.Add(this.cbPrincipal);

            // ── pnlNote (warning, hidden by default) ──
            var lblPerhatian = new System.Windows.Forms.Label();
            lblPerhatian.AutoSize = true;
            lblPerhatian.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblPerhatian.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            lblPerhatian.Location = new System.Drawing.Point(4, 4);
            lblPerhatian.Text = "PERHATIAN!";

            this.lblNoteDetail.AutoSize = true;
            this.lblNoteDetail.BackColor = System.Drawing.Color.Gold;
            this.lblNoteDetail.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNoteDetail.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.lblNoteDetail.Location = new System.Drawing.Point(4, 20);
            this.lblNoteDetail.Name = "lblNoteDetail";
            this.lblNoteDetail.Padding = new System.Windows.Forms.Padding(3);
            this.lblNoteDetail.Size = new System.Drawing.Size(76, 21);
            this.lblNoteDetail.Text = "Note Detail";

            this.pnlNote.Controls.Add(this.lblNoteDetail);
            this.pnlNote.Controls.Add(lblPerhatian);
            this.pnlNote.Location = new System.Drawing.Point(8, 348);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(364, 60);
            this.pnlNote.TabIndex = 20;
            this.pnlNote.Visible = false;
            this.pnlLeft.Controls.Add(this.pnlNote);

            // ── pnlHiddenField ────────────────────────
            this.pnlHiddenField.Controls.Add(this.txtProductId);
            this.pnlHiddenField.Controls.Add(this.txtModifiedAt);
            this.pnlHiddenField.Location = new System.Drawing.Point(0, 800);
            this.pnlHiddenField.Name = "pnlHiddenField";
            this.pnlHiddenField.Size = new System.Drawing.Size(400, 30);
            this.pnlHiddenField.TabIndex = 99;
            this.pnlHiddenField.Visible = false;

            this.txtProductId.Location = new System.Drawing.Point(0, 0);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(180, 23);
            this.txtProductId.TabIndex = 0;

            this.txtModifiedAt.Location = new System.Drawing.Point(190, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(180, 23);
            this.txtModifiedAt.TabIndex = 1;

            // ── dgvProduct ────────────────────────────
            var dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            var dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.DefaultCellStyle = dgvDefaultStyle;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.Click += new System.EventHandler(this.dgvProduct_Click);

            // ── FrmProduct ────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlHiddenField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProduct";
            this.Text = "Produk";
            this.Load += new System.EventHandler(this.FrmProduct_Load);

            this.pnlActionBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlNote.ResumeLayout(false);
            this.pnlNote.PerformLayout();
            this.pnlHiddenField.ResumeLayout(false);
            this.pnlHiddenField.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlActionBar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftSpacer;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.Panel pnlHiddenField;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtManualCode;
        private System.Windows.Forms.TextBox txtAutoCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DateTimePicker dtpDecreeDate;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtRestock;
        private System.Windows.Forms.ComboBox cbUom;
        private System.Windows.Forms.ComboBox cbMedCat;
        private System.Windows.Forms.ComboBox cbUsageType;
        private System.Windows.Forms.ComboBox cbPrincipal;
        private System.Windows.Forms.Label lblNoteDetail;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
