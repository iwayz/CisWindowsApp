namespace CisWindowsFormsApp
{
    partial class FrmRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRole));

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
            this.txtRoleCode   = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();

            // permission group boxes
            this.gbMaster   = new System.Windows.Forms.GroupBox();
            this.groupBox1  = new System.Windows.Forms.GroupBox();
            this.groupBox2  = new System.Windows.Forms.GroupBox();
            this.groupBox3  = new System.Windows.Forms.GroupBox();

            // checked list boxes
            this.cblMasterData = new System.Windows.Forms.CheckedListBox();
            this.cblTransaksi  = new System.Windows.Forms.CheckedListBox();
            this.cblReporting  = new System.Windows.Forms.CheckedListBox();
            this.cblInventory  = new System.Windows.Forms.CheckedListBox();

            // grid
            this.dgvRole = new System.Windows.Forms.DataGridView();

            // hidden
            this.txtRoleId      = new System.Windows.Forms.TextBox();
            this.txtPermissionId = new System.Windows.Forms.TextBox();
            this.txtModifiedAt  = new System.Windows.Forms.TextBox();

            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlHiddenFields.SuspendLayout();
            this.gbMaster.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).BeginInit();
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

            // ── pnlLeft (wider for permission groups) ─
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLeft.Size = new System.Drawing.Size(460, 600);
            this.pnlLeft.TabIndex = 0;

            // ── pnlLeftSpacer ─────────────────────────
            this.pnlLeftSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSpacer.Name = "pnlLeftSpacer";
            this.pnlLeftSpacer.Size = new System.Drawing.Size(8, 600);
            this.pnlLeftSpacer.TabIndex = 1;

            // ── pnlRight ──────────────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.dgvRole);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(4);
            this.pnlRight.TabIndex = 2;

            // ── pnlSearch ─────────────────────────────
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

            // --- Row 1: Kode Role ---
            var lblRoleCode = new System.Windows.Forms.Label();
            lblRoleCode.AutoSize = true;
            lblRoleCode.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblRoleCode.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblRoleCode.Location = new System.Drawing.Point(8, 8);
            lblRoleCode.Text = "Kode Role";
            this.pnlLeft.Controls.Add(lblRoleCode);

            this.txtRoleCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRoleCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRoleCode.Location = new System.Drawing.Point(8, 24);
            this.txtRoleCode.Name = "txtRoleCode";
            this.txtRoleCode.Size = new System.Drawing.Size(160, 23);
            this.txtRoleCode.TabIndex = 1;
            this.pnlLeft.Controls.Add(this.txtRoleCode);

            // --- Row 2: Keterangan ---
            var lblDescription = new System.Windows.Forms.Label();
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblDescription.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblDescription.Location = new System.Drawing.Point(8, 56);
            lblDescription.Text = "Keterangan";
            this.pnlLeft.Controls.Add(lblDescription);

            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(8, 72);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(432, 23);
            this.txtDescription.TabIndex = 2;
            this.pnlLeft.Controls.Add(this.txtDescription);

            // ── Permission GroupBoxes (2 × 2 grid) ────

            // gbMaster — Master Data (top-left)
            this.cblMasterData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblMasterData.CheckOnClick = true;
            this.cblMasterData.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cblMasterData.FormattingEnabled = true;
            this.cblMasterData.Location = new System.Drawing.Point(6, 20);
            this.cblMasterData.Name = "cblMasterData";
            this.cblMasterData.Size = new System.Drawing.Size(194, 196);
            this.cblMasterData.TabIndex = 0;

            this.gbMaster.Controls.Add(this.cblMasterData);
            this.gbMaster.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.gbMaster.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.gbMaster.Location = new System.Drawing.Point(8, 108);
            this.gbMaster.Name = "gbMaster";
            this.gbMaster.Size = new System.Drawing.Size(212, 224);
            this.gbMaster.TabIndex = 3;
            this.gbMaster.TabStop = false;
            this.gbMaster.Text = "Master Data";
            this.pnlLeft.Controls.Add(this.gbMaster);

            // groupBox1 — Transaksi (top-right)
            this.cblTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblTransaksi.CheckOnClick = true;
            this.cblTransaksi.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cblTransaksi.FormattingEnabled = true;
            this.cblTransaksi.Location = new System.Drawing.Point(6, 20);
            this.cblTransaksi.Name = "cblTransaksi";
            this.cblTransaksi.Size = new System.Drawing.Size(194, 196);
            this.cblTransaksi.TabIndex = 0;

            this.groupBox1.Controls.Add(this.cblTransaksi);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.groupBox1.Location = new System.Drawing.Point(228, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 224);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transaksi";
            this.pnlLeft.Controls.Add(this.groupBox1);

            // groupBox2 — Pelaporan (bottom-left)
            this.cblReporting.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblReporting.CheckOnClick = true;
            this.cblReporting.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cblReporting.FormattingEnabled = true;
            this.cblReporting.Location = new System.Drawing.Point(6, 20);
            this.cblReporting.Name = "cblReporting";
            this.cblReporting.Size = new System.Drawing.Size(194, 148);
            this.cblReporting.TabIndex = 0;

            this.groupBox2.Controls.Add(this.cblReporting);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.groupBox2.Location = new System.Drawing.Point(8, 340);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 176);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pelaporan";
            this.pnlLeft.Controls.Add(this.groupBox2);

            // groupBox3 — Inventory (bottom-right)
            this.cblInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cblInventory.CheckOnClick = true;
            this.cblInventory.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.cblInventory.FormattingEnabled = true;
            this.cblInventory.Location = new System.Drawing.Point(6, 20);
            this.cblInventory.Name = "cblInventory";
            this.cblInventory.Size = new System.Drawing.Size(194, 148);
            this.cblInventory.TabIndex = 0;

            this.groupBox3.Controls.Add(this.cblInventory);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.groupBox3.Location = new System.Drawing.Point(228, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 176);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inventory";
            this.pnlLeft.Controls.Add(this.groupBox3);

            // ── pnlHiddenFields ───────────────────────
            this.txtRoleId.Location = new System.Drawing.Point(0, 0);
            this.txtRoleId.Name = "txtRoleId";
            this.txtRoleId.Size = new System.Drawing.Size(160, 23);
            this.txtRoleId.TabIndex = 0;

            this.txtPermissionId.Location = new System.Drawing.Point(170, 0);
            this.txtPermissionId.Name = "txtPermissionId";
            this.txtPermissionId.Size = new System.Drawing.Size(160, 23);
            this.txtPermissionId.TabIndex = 1;

            this.txtModifiedAt.Location = new System.Drawing.Point(340, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(160, 23);
            this.txtModifiedAt.TabIndex = 2;

            this.pnlHiddenFields.Controls.Add(this.txtRoleId);
            this.pnlHiddenFields.Controls.Add(this.txtPermissionId);
            this.pnlHiddenFields.Controls.Add(this.txtModifiedAt);
            this.pnlHiddenFields.Location = new System.Drawing.Point(0, 900);
            this.pnlHiddenFields.Name = "pnlHiddenFields";
            this.pnlHiddenFields.Size = new System.Drawing.Size(520, 30);
            this.pnlHiddenFields.TabIndex = 99;
            this.pnlHiddenFields.Visible = false;

            // ── dgvRole ───────────────────────────────
            var dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            var dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvRole.AllowUserToAddRows = false;
            this.dgvRole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRole.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRole.DefaultCellStyle = dgvDefaultStyle;
            this.dgvRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRole.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvRole.Name = "dgvRole";
            this.dgvRole.ReadOnly = true;
            this.dgvRole.RowHeadersVisible = false;
            this.dgvRole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRole.TabIndex = 0;
            this.dgvRole.Click += new System.EventHandler(this.dgvRole_Click);

            // ── FrmRole ───────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlHiddenFields);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRole";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.FrmRole_Load);

            this.pnlActionBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlHiddenFields.ResumeLayout(false);
            this.pnlHiddenFields.PerformLayout();
            this.gbMaster.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRole)).EndInit();
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
        private System.Windows.Forms.TextBox txtRoleCode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.GroupBox gbMaster;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckedListBox cblMasterData;
        private System.Windows.Forms.CheckedListBox cblTransaksi;
        private System.Windows.Forms.CheckedListBox cblReporting;
        private System.Windows.Forms.CheckedListBox cblInventory;
        private System.Windows.Forms.DataGridView dgvRole;
        private System.Windows.Forms.TextBox txtRoleId;
        private System.Windows.Forms.TextBox txtPermissionId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
