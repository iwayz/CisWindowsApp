namespace CisWindowsFormsApp
{
    partial class FrmSalesman
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesman));

            // panels
            this.pnlActionBar    = new System.Windows.Forms.Panel();
            this.pnlContent      = new System.Windows.Forms.Panel();
            this.pnlLeft         = new System.Windows.Forms.Panel();
            this.pnlLeftSpacer   = new System.Windows.Forms.Panel();
            this.pnlRight        = new System.Windows.Forms.Panel();
            this.pnlSearch       = new System.Windows.Forms.Panel();
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
            this.txtSalesmanCode = new System.Windows.Forms.TextBox();
            this.txtFullName     = new System.Windows.Forms.TextBox();
            this.gbGender        = new System.Windows.Forms.GroupBox();
            this.rbFemale        = new System.Windows.Forms.RadioButton();
            this.rbMale          = new System.Windows.Forms.RadioButton();
            this.txtAddress      = new System.Windows.Forms.TextBox();
            this.cbProvince      = new System.Windows.Forms.ComboBox();
            this.cbDistrict      = new System.Windows.Forms.ComboBox();
            this.txtPostCode     = new System.Windows.Forms.TextBox();
            this.txtPhone        = new System.Windows.Forms.TextBox();
            this.txtEmail        = new System.Windows.Forms.TextBox();

            // grid
            this.dgvSalesman = new System.Windows.Forms.DataGridView();

            // hidden
            this.txtSalesmanId = new System.Windows.Forms.TextBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();

            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlHiddenFields.SuspendLayout();
            this.gbGender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesman)).BeginInit();
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

            // ── pnlLeft (white card) ──────────────────
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLeft.Size = new System.Drawing.Size(420, 600);
            this.pnlLeft.TabIndex = 0;

            // ── pnlLeftSpacer ─────────────────────────
            this.pnlLeftSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSpacer.Name = "pnlLeftSpacer";
            this.pnlLeftSpacer.Size = new System.Drawing.Size(8, 600);
            this.pnlLeftSpacer.TabIndex = 1;

            // ── pnlRight (Fill) ───────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.dgvSalesman);
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
            this.txtSearch.TabIndex = 20;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(312, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 28);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // ── Form fields inside pnlLeft ────────────

            // --- Row 1: Kode Salesman ---
            var lblSalesmanCode = new System.Windows.Forms.Label();
            lblSalesmanCode.AutoSize = true;
            lblSalesmanCode.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblSalesmanCode.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblSalesmanCode.Location = new System.Drawing.Point(8, 8);
            lblSalesmanCode.Text = "Kode Salesman";
            this.pnlLeft.Controls.Add(lblSalesmanCode);

            this.txtSalesmanCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesmanCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalesmanCode.Location = new System.Drawing.Point(8, 24);
            this.txtSalesmanCode.Name = "txtSalesmanCode";
            this.txtSalesmanCode.Size = new System.Drawing.Size(160, 23);
            this.txtSalesmanCode.TabIndex = 1;
            this.pnlLeft.Controls.Add(this.txtSalesmanCode);

            // --- Row 2: Nama Lengkap ---
            var lblFullName = new System.Windows.Forms.Label();
            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblFullName.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblFullName.Location = new System.Drawing.Point(8, 56);
            lblFullName.Text = "Nama Lengkap";
            this.pnlLeft.Controls.Add(lblFullName);

            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.Location = new System.Drawing.Point(8, 72);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(396, 23);
            this.txtFullName.TabIndex = 2;
            this.pnlLeft.Controls.Add(this.txtFullName);

            // --- Row 3: Gender (GroupBox) ---
            this.rbFemale.AutoSize = true;
            this.rbFemale.Checked = true;
            this.rbFemale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbFemale.Location = new System.Drawing.Point(8, 18);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(85, 19);
            this.rbFemale.TabIndex = 0;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Perempuan";
            this.rbFemale.UseVisualStyleBackColor = true;

            this.rbMale.AutoSize = true;
            this.rbMale.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rbMale.Location = new System.Drawing.Point(108, 18);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(65, 19);
            this.rbMale.TabIndex = 1;
            this.rbMale.Text = "Laki-laki";
            this.rbMale.UseVisualStyleBackColor = true;

            this.gbGender.Controls.Add(this.rbFemale);
            this.gbGender.Controls.Add(this.rbMale);
            this.gbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbGender.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gbGender.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            this.gbGender.Location = new System.Drawing.Point(8, 104);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(220, 44);
            this.gbGender.TabIndex = 3;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            this.pnlLeft.Controls.Add(this.gbGender);

            // --- Row 4: Alamat ---
            var lblAddress = new System.Windows.Forms.Label();
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblAddress.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblAddress.Location = new System.Drawing.Point(8, 156);
            lblAddress.Text = "Alamat";
            this.pnlLeft.Controls.Add(lblAddress);

            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(8, 172);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(396, 52);
            this.txtAddress.TabIndex = 4;
            this.pnlLeft.Controls.Add(this.txtAddress);

            // --- Row 5: Provinsi / Kab. Kota ---
            var lblProvinsi = new System.Windows.Forms.Label();
            lblProvinsi.AutoSize = true;
            lblProvinsi.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblProvinsi.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblProvinsi.Location = new System.Drawing.Point(8, 232);
            lblProvinsi.Text = "Provinsi";
            this.pnlLeft.Controls.Add(lblProvinsi);

            this.cbProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProvince.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(8, 248);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(192, 23);
            this.cbProvince.TabIndex = 5;
            this.cbProvince.SelectedIndexChanged += new System.EventHandler(this.cbProvince_SelectedIndexChanged);
            this.pnlLeft.Controls.Add(this.cbProvince);

            var lblKabKota = new System.Windows.Forms.Label();
            lblKabKota.AutoSize = true;
            lblKabKota.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblKabKota.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblKabKota.Location = new System.Drawing.Point(208, 232);
            lblKabKota.Text = "Kab. / Kota";
            this.pnlLeft.Controls.Add(lblKabKota);

            this.cbDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDistrict.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Location = new System.Drawing.Point(208, 248);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(196, 23);
            this.cbDistrict.TabIndex = 6;
            this.cbDistrict.SelectedIndexChanged += new System.EventHandler(this.cbDistrict_SelectedIndexChanged);
            this.pnlLeft.Controls.Add(this.cbDistrict);

            // --- Row 6: Kode Pos / Telepon ---
            var lblKodePos = new System.Windows.Forms.Label();
            lblKodePos.AutoSize = true;
            lblKodePos.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblKodePos.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblKodePos.Location = new System.Drawing.Point(8, 280);
            lblKodePos.Text = "Kode Pos";
            this.pnlLeft.Controls.Add(lblKodePos);

            this.txtPostCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPostCode.Location = new System.Drawing.Point(8, 296);
            this.txtPostCode.MaxLength = 5;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(100, 23);
            this.txtPostCode.TabIndex = 7;
            this.txtPostCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPostCode_KeyPress);
            this.pnlLeft.Controls.Add(this.txtPostCode);

            var lblTelepon = new System.Windows.Forms.Label();
            lblTelepon.AutoSize = true;
            lblTelepon.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblTelepon.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblTelepon.Location = new System.Drawing.Point(116, 280);
            lblTelepon.Text = "Telepon";
            this.pnlLeft.Controls.Add(lblTelepon);

            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.Location = new System.Drawing.Point(116, 296);
            this.txtPhone.MaxLength = 20;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(180, 23);
            this.txtPhone.TabIndex = 8;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            this.pnlLeft.Controls.Add(this.txtPhone);

            // --- Row 7: Email ---
            var lblEmail = new System.Windows.Forms.Label();
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblEmail.Location = new System.Drawing.Point(8, 328);
            lblEmail.Text = "Email";
            this.pnlLeft.Controls.Add(lblEmail);

            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(8, 344);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(396, 23);
            this.txtEmail.TabIndex = 9;
            this.pnlLeft.Controls.Add(this.txtEmail);

            // ── pnlHiddenFields ───────────────────────
            this.txtSalesmanId.Location = new System.Drawing.Point(0, 0);
            this.txtSalesmanId.Name = "txtSalesmanId";
            this.txtSalesmanId.Size = new System.Drawing.Size(175, 23);
            this.txtSalesmanId.TabIndex = 0;

            this.txtModifiedAt.Location = new System.Drawing.Point(185, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(175, 23);
            this.txtModifiedAt.TabIndex = 1;

            this.pnlHiddenFields.Controls.Add(this.txtSalesmanId);
            this.pnlHiddenFields.Controls.Add(this.txtModifiedAt);
            this.pnlHiddenFields.Location = new System.Drawing.Point(0, 900);
            this.pnlHiddenFields.Name = "pnlHiddenFields";
            this.pnlHiddenFields.Size = new System.Drawing.Size(400, 30);
            this.pnlHiddenFields.TabIndex = 99;
            this.pnlHiddenFields.Visible = false;

            // ── dgvSalesman ───────────────────────────
            var dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            var dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvSalesman.AllowUserToAddRows = false;
            this.dgvSalesman.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalesman.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvSalesman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesman.DefaultCellStyle = dgvDefaultStyle;
            this.dgvSalesman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesman.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvSalesman.Name = "dgvSalesman";
            this.dgvSalesman.ReadOnly = true;
            this.dgvSalesman.RowHeadersVisible = false;
            this.dgvSalesman.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesman.TabIndex = 0;
            this.dgvSalesman.Click += new System.EventHandler(this.dgvSalesman_Click);

            // ── FrmSalesman ───────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlHiddenFields);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSalesman";
            this.Text = "Salesman";
            this.Load += new System.EventHandler(this.FrmSalesman_Load);

            this.pnlActionBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlHiddenFields.ResumeLayout(false);
            this.pnlHiddenFields.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesman)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlActionBar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftSpacer;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlHiddenFields;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSalesmanCode;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.GroupBox gbGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgvSalesman;
        private System.Windows.Forms.TextBox txtSalesmanId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
