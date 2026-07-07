namespace CisWindowsFormsApp
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));

            // panels
            this.pnlActionBar   = new System.Windows.Forms.Panel();
            this.pnlContent     = new System.Windows.Forms.Panel();
            this.pnlLeft        = new System.Windows.Forms.Panel();
            this.pnlLeftSpacer  = new System.Windows.Forms.Panel();
            this.pnlRight       = new System.Windows.Forms.Panel();
            this.pnlSearch      = new System.Windows.Forms.Panel();
            this.pnlNote        = new System.Windows.Forms.Panel();
            this.pnlHiddenFields = new System.Windows.Forms.Panel();

            // action bar buttons
            this.btnClear  = new System.Windows.Forms.Button();
            this.btnAdd    = new System.Windows.Forms.Button();
            this.btnSave   = new System.Windows.Forms.Button();
            this.btnDel    = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();

            // search
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            // form fields
            this.cbSalesArea        = new System.Windows.Forms.ComboBox();
            this.txtCustomerCode    = new System.Windows.Forms.TextBox();
            this.txtCustomerName    = new System.Windows.Forms.TextBox();
            this.txtAddress         = new System.Windows.Forms.TextBox();
            this.cbProvince         = new System.Windows.Forms.ComboBox();
            this.cbDistrict         = new System.Windows.Forms.ComboBox();
            this.txtPostCode        = new System.Windows.Forms.TextBox();
            this.txtPhone           = new System.Windows.Forms.TextBox();
            this.txtEmail           = new System.Windows.Forms.TextBox();
            this.txtNpwp            = new System.Windows.Forms.TextBox();
            this.txtPharmacistName  = new System.Windows.Forms.TextBox();
            this.txtSipaNo          = new System.Windows.Forms.TextBox();
            this.dtpSipaExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtSiaNo           = new System.Windows.Forms.TextBox();
            this.cbOutletType       = new System.Windows.Forms.ComboBox();

            // note
            this.lblNoteDetail = new System.Windows.Forms.Label();

            // grid
            this.dgvCustomer = new System.Windows.Forms.DataGridView();

            // hidden
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();

            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlNote.SuspendLayout();
            this.pnlHiddenFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
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

            // ── pnlLeft (scrollable form, white card) ─
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLeft.Size = new System.Drawing.Size(430, 600);
            this.pnlLeft.TabIndex = 0;

            // ── pnlLeftSpacer ─────────────────────────
            this.pnlLeftSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSpacer.Name = "pnlLeftSpacer";
            this.pnlLeftSpacer.Size = new System.Drawing.Size(8, 600);
            this.pnlLeftSpacer.TabIndex = 1;

            // ── pnlRight (Fill) ───────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.dgvCustomer);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(4);
            this.pnlRight.TabIndex = 2;

            // ── pnlSearch (Top, 42px) ─────────────────
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(900, 42);
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

            // --- Row 1: Sales Area ---
            var lblSalesArea = new System.Windows.Forms.Label();
            lblSalesArea.AutoSize = true;
            lblSalesArea.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblSalesArea.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblSalesArea.Location = new System.Drawing.Point(8, 8);
            lblSalesArea.Text = "Sales Area";
            this.pnlLeft.Controls.Add(lblSalesArea);

            this.cbSalesArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSalesArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSalesArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSalesArea.FormattingEnabled = true;
            this.cbSalesArea.Location = new System.Drawing.Point(8, 24);
            this.cbSalesArea.Name = "cbSalesArea";
            this.cbSalesArea.Size = new System.Drawing.Size(300, 23);
            this.cbSalesArea.TabIndex = 1;
            this.cbSalesArea.SelectedIndexChanged += new System.EventHandler(this.cbSalesArea_SelectedIndexChanged);
            this.pnlLeft.Controls.Add(this.cbSalesArea);

            // --- Row 2: Kode Pelanggan ---
            var lblKodePelanggan = new System.Windows.Forms.Label();
            lblKodePelanggan.AutoSize = true;
            lblKodePelanggan.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblKodePelanggan.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblKodePelanggan.Location = new System.Drawing.Point(8, 56);
            lblKodePelanggan.Text = "Kode Pelanggan";
            this.pnlLeft.Controls.Add(lblKodePelanggan);

            this.txtCustomerCode.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.txtCustomerCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerCode.Location = new System.Drawing.Point(8, 72);
            this.txtCustomerCode.Name = "txtCustomerCode";
            this.txtCustomerCode.ReadOnly = true;
            this.txtCustomerCode.Size = new System.Drawing.Size(170, 23);
            this.txtCustomerCode.TabIndex = 99;
            this.pnlLeft.Controls.Add(this.txtCustomerCode);

            // --- Row 3: Nama Pelanggan ---
            var lblNamaPelanggan = new System.Windows.Forms.Label();
            lblNamaPelanggan.AutoSize = true;
            lblNamaPelanggan.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblNamaPelanggan.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblNamaPelanggan.Location = new System.Drawing.Point(8, 104);
            lblNamaPelanggan.Text = "Nama Pelanggan";
            this.pnlLeft.Controls.Add(lblNamaPelanggan);

            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerName.Location = new System.Drawing.Point(8, 120);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(400, 23);
            this.txtCustomerName.TabIndex = 2;
            this.pnlLeft.Controls.Add(this.txtCustomerName);

            // --- Row 4: Alamat ---
            var lblAlamat = new System.Windows.Forms.Label();
            lblAlamat.AutoSize = true;
            lblAlamat.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblAlamat.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblAlamat.Location = new System.Drawing.Point(8, 152);
            lblAlamat.Text = "Alamat";
            this.pnlLeft.Controls.Add(lblAlamat);

            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(8, 168);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(400, 52);
            this.txtAddress.TabIndex = 3;
            this.pnlLeft.Controls.Add(this.txtAddress);

            // --- Row 5: Provinsi / Kab.Kota ---
            var lblProvinsi = new System.Windows.Forms.Label();
            lblProvinsi.AutoSize = true;
            lblProvinsi.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblProvinsi.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblProvinsi.Location = new System.Drawing.Point(8, 228);
            lblProvinsi.Text = "Provinsi";
            this.pnlLeft.Controls.Add(lblProvinsi);

            this.cbProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProvince.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(8, 244);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(192, 23);
            this.cbProvince.TabIndex = 4;
            this.cbProvince.SelectedIndexChanged += new System.EventHandler(this.cbProvince_SelectedIndexChanged);
            this.pnlLeft.Controls.Add(this.cbProvince);

            var lblKabKota = new System.Windows.Forms.Label();
            lblKabKota.AutoSize = true;
            lblKabKota.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblKabKota.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblKabKota.Location = new System.Drawing.Point(208, 228);
            lblKabKota.Text = "Kab. / Kota";
            this.pnlLeft.Controls.Add(lblKabKota);

            this.cbDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDistrict.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Location = new System.Drawing.Point(208, 244);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(200, 23);
            this.cbDistrict.TabIndex = 5;
            this.cbDistrict.SelectedIndexChanged += new System.EventHandler(this.cbDistrict_SelectedIndexChanged);
            this.pnlLeft.Controls.Add(this.cbDistrict);

            // --- Row 6: Kode Pos / Telepon ---
            var lblKodePos = new System.Windows.Forms.Label();
            lblKodePos.AutoSize = true;
            lblKodePos.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblKodePos.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblKodePos.Location = new System.Drawing.Point(8, 276);
            lblKodePos.Text = "Kode Pos";
            this.pnlLeft.Controls.Add(lblKodePos);

            this.txtPostCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPostCode.Location = new System.Drawing.Point(8, 292);
            this.txtPostCode.MaxLength = 5;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(100, 23);
            this.txtPostCode.TabIndex = 6;
            this.txtPostCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostCode_KeyPress);
            this.pnlLeft.Controls.Add(this.txtPostCode);

            var lblTelepon = new System.Windows.Forms.Label();
            lblTelepon.AutoSize = true;
            lblTelepon.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblTelepon.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblTelepon.Location = new System.Drawing.Point(116, 276);
            lblTelepon.Text = "Telepon";
            this.pnlLeft.Controls.Add(lblTelepon);

            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(116, 292);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 23);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.pnlLeft.Controls.Add(this.txtPhone);

            // --- Row 7: Email ---
            var lblEmail = new System.Windows.Forms.Label();
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblEmail.Location = new System.Drawing.Point(8, 324);
            lblEmail.Text = "Email";
            this.pnlLeft.Controls.Add(lblEmail);

            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(8, 340);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(400, 23);
            this.txtEmail.TabIndex = 8;
            this.pnlLeft.Controls.Add(this.txtEmail);

            // --- Row 8: NPWP ---
            var lblNpwp = new System.Windows.Forms.Label();
            lblNpwp.AutoSize = true;
            lblNpwp.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblNpwp.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblNpwp.Location = new System.Drawing.Point(8, 372);
            lblNpwp.Text = "NPWP";
            this.pnlLeft.Controls.Add(lblNpwp);

            this.txtNpwp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNpwp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNpwp.Location = new System.Drawing.Point(8, 388);
            this.txtNpwp.Name = "txtNpwp";
            this.txtNpwp.Size = new System.Drawing.Size(300, 23);
            this.txtNpwp.TabIndex = 9;
            this.pnlLeft.Controls.Add(this.txtNpwp);

            // --- Row 9: Nama Apoteker ---
            var lblApoteker = new System.Windows.Forms.Label();
            lblApoteker.AutoSize = true;
            lblApoteker.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblApoteker.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblApoteker.Location = new System.Drawing.Point(8, 420);
            lblApoteker.Text = "Nama Apoteker";
            this.pnlLeft.Controls.Add(lblApoteker);

            this.txtPharmacistName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPharmacistName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPharmacistName.Location = new System.Drawing.Point(8, 436);
            this.txtPharmacistName.Name = "txtPharmacistName";
            this.txtPharmacistName.Size = new System.Drawing.Size(300, 23);
            this.txtPharmacistName.TabIndex = 10;
            this.pnlLeft.Controls.Add(this.txtPharmacistName);

            // --- Row 10: No. SIPA / Tgl. Expired SIPA ---
            var lblSipaNo = new System.Windows.Forms.Label();
            lblSipaNo.AutoSize = true;
            lblSipaNo.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblSipaNo.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblSipaNo.Location = new System.Drawing.Point(8, 468);
            lblSipaNo.Text = "No. SIPA";
            this.pnlLeft.Controls.Add(lblSipaNo);

            this.txtSipaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSipaNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSipaNo.Location = new System.Drawing.Point(8, 484);
            this.txtSipaNo.Name = "txtSipaNo";
            this.txtSipaNo.Size = new System.Drawing.Size(192, 23);
            this.txtSipaNo.TabIndex = 11;
            this.pnlLeft.Controls.Add(this.txtSipaNo);

            var lblSipaExp = new System.Windows.Forms.Label();
            lblSipaExp.AutoSize = true;
            lblSipaExp.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblSipaExp.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblSipaExp.Location = new System.Drawing.Point(208, 468);
            lblSipaExp.Text = "Tgl. Expired SIPA";
            this.pnlLeft.Controls.Add(lblSipaExp);

            this.dtpSipaExpiredDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSipaExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSipaExpiredDate.Location = new System.Drawing.Point(208, 484);
            this.dtpSipaExpiredDate.Name = "dtpSipaExpiredDate";
            this.dtpSipaExpiredDate.Size = new System.Drawing.Size(160, 23);
            this.dtpSipaExpiredDate.TabIndex = 12;
            this.pnlLeft.Controls.Add(this.dtpSipaExpiredDate);

            // --- Row 11: No. SIA ---
            var lblSiaNo = new System.Windows.Forms.Label();
            lblSiaNo.AutoSize = true;
            lblSiaNo.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblSiaNo.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblSiaNo.Location = new System.Drawing.Point(8, 516);
            lblSiaNo.Text = "No. SIA";
            this.pnlLeft.Controls.Add(lblSiaNo);

            this.txtSiaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSiaNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSiaNo.Location = new System.Drawing.Point(8, 532);
            this.txtSiaNo.Name = "txtSiaNo";
            this.txtSiaNo.Size = new System.Drawing.Size(300, 23);
            this.txtSiaNo.TabIndex = 13;
            this.pnlLeft.Controls.Add(this.txtSiaNo);

            // --- Row 12: Jenis Outlet ---
            var lblOutletType = new System.Windows.Forms.Label();
            lblOutletType.AutoSize = true;
            lblOutletType.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblOutletType.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblOutletType.Location = new System.Drawing.Point(8, 564);
            lblOutletType.Text = "Jenis Outlet";
            this.pnlLeft.Controls.Add(lblOutletType);

            this.cbOutletType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbOutletType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbOutletType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbOutletType.FormattingEnabled = true;
            this.cbOutletType.Location = new System.Drawing.Point(8, 580);
            this.cbOutletType.Name = "cbOutletType";
            this.cbOutletType.Size = new System.Drawing.Size(300, 23);
            this.cbOutletType.TabIndex = 14;
            this.pnlLeft.Controls.Add(this.cbOutletType);

            // ── pnlNote ───────────────────────────────
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
            this.pnlNote.Location = new System.Drawing.Point(8, 616);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(400, 60);
            this.pnlNote.TabIndex = 30;
            this.pnlNote.Visible = false;
            this.pnlLeft.Controls.Add(this.pnlNote);

            // ── pnlHiddenFields ───────────────────────
            this.pnlHiddenFields.Controls.Add(this.txtCustomerId);
            this.pnlHiddenFields.Controls.Add(this.txtModifiedAt);
            this.pnlHiddenFields.Location = new System.Drawing.Point(0, 900);
            this.pnlHiddenFields.Name = "pnlHiddenFields";
            this.pnlHiddenFields.Size = new System.Drawing.Size(400, 30);
            this.pnlHiddenFields.TabIndex = 99;
            this.pnlHiddenFields.Visible = false;

            this.txtCustomerId.Location = new System.Drawing.Point(0, 0);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(180, 23);
            this.txtCustomerId.TabIndex = 0;

            this.txtModifiedAt.Location = new System.Drawing.Point(190, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(180, 23);
            this.txtModifiedAt.TabIndex = 1;

            // ── dgvCustomer ───────────────────────────
            var dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            var dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.DefaultCellStyle = dgvDefaultStyle;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.Click += new System.EventHandler(this.dgvCustomer_Click);

            // ── FrmCustomer ───────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlHiddenFields);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCustomer";
            this.Text = "Pelanggan";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);

            this.pnlActionBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlNote.ResumeLayout(false);
            this.pnlNote.PerformLayout();
            this.pnlHiddenFields.ResumeLayout(false);
            this.pnlHiddenFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
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
        private System.Windows.Forms.Panel pnlHiddenFields;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSalesArea;
        private System.Windows.Forms.TextBox txtCustomerCode;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNpwp;
        private System.Windows.Forms.TextBox txtPharmacistName;
        private System.Windows.Forms.TextBox txtSipaNo;
        private System.Windows.Forms.DateTimePicker dtpSipaExpiredDate;
        private System.Windows.Forms.TextBox txtSiaNo;
        private System.Windows.Forms.ComboBox cbOutletType;
        private System.Windows.Forms.Label lblNoteDetail;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
