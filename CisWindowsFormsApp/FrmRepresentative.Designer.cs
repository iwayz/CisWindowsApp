namespace CisWindowsFormsApp
{
    partial class FrmRepresentative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepresentative));

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
            this.txtRepresentativeCode = new System.Windows.Forms.TextBox();
            this.txtRepresentative     = new System.Windows.Forms.TextBox();

            // grid
            this.dgvRepresentative = new System.Windows.Forms.DataGridView();

            // hidden
            this.txtRepresentativeId = new System.Windows.Forms.TextBox();
            this.txtModifiedAt       = new System.Windows.Forms.TextBox();

            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlHiddenFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepresentative)).BeginInit();
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

            // ── pnlLeft ───────────────────────────────
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLeft.Size = new System.Drawing.Size(340, 600);
            this.pnlLeft.TabIndex = 0;

            // ── pnlLeftSpacer ─────────────────────────
            this.pnlLeftSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSpacer.Name = "pnlLeftSpacer";
            this.pnlLeftSpacer.Size = new System.Drawing.Size(8, 600);
            this.pnlLeftSpacer.TabIndex = 1;

            // ── pnlRight ──────────────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.dgvRepresentative);
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

            // --- Row 1: Kode Perwakilan ---
            var lblRepresentativeCode = new System.Windows.Forms.Label();
            lblRepresentativeCode.AutoSize = true;
            lblRepresentativeCode.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblRepresentativeCode.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblRepresentativeCode.Location = new System.Drawing.Point(8, 8);
            lblRepresentativeCode.Text = "Kode Perwakilan";
            this.pnlLeft.Controls.Add(lblRepresentativeCode);

            this.txtRepresentativeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepresentativeCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRepresentativeCode.Location = new System.Drawing.Point(8, 24);
            this.txtRepresentativeCode.Name = "txtRepresentativeCode";
            this.txtRepresentativeCode.Size = new System.Drawing.Size(160, 23);
            this.txtRepresentativeCode.TabIndex = 1;
            this.pnlLeft.Controls.Add(this.txtRepresentativeCode);

            // --- Row 2: Keterangan ---
            var lblRepresentative = new System.Windows.Forms.Label();
            lblRepresentative.AutoSize = true;
            lblRepresentative.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblRepresentative.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblRepresentative.Location = new System.Drawing.Point(8, 56);
            lblRepresentative.Text = "Keterangan";
            this.pnlLeft.Controls.Add(lblRepresentative);

            this.txtRepresentative.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRepresentative.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRepresentative.Location = new System.Drawing.Point(8, 72);
            this.txtRepresentative.Name = "txtRepresentative";
            this.txtRepresentative.Size = new System.Drawing.Size(316, 23);
            this.txtRepresentative.TabIndex = 2;
            this.pnlLeft.Controls.Add(this.txtRepresentative);

            // ── pnlHiddenFields ───────────────────────
            this.txtRepresentativeId.Location = new System.Drawing.Point(0, 0);
            this.txtRepresentativeId.Name = "txtRepresentativeId";
            this.txtRepresentativeId.Size = new System.Drawing.Size(175, 23);
            this.txtRepresentativeId.TabIndex = 0;

            this.txtModifiedAt.Location = new System.Drawing.Point(185, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(175, 23);
            this.txtModifiedAt.TabIndex = 1;

            this.pnlHiddenFields.Controls.Add(this.txtRepresentativeId);
            this.pnlHiddenFields.Controls.Add(this.txtModifiedAt);
            this.pnlHiddenFields.Location = new System.Drawing.Point(0, 900);
            this.pnlHiddenFields.Name = "pnlHiddenFields";
            this.pnlHiddenFields.Size = new System.Drawing.Size(400, 30);
            this.pnlHiddenFields.TabIndex = 99;
            this.pnlHiddenFields.Visible = false;

            // ── dgvRepresentative ─────────────────────
            var dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            var dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvRepresentative.AllowUserToAddRows = false;
            this.dgvRepresentative.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRepresentative.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvRepresentative.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepresentative.DefaultCellStyle = dgvDefaultStyle;
            this.dgvRepresentative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRepresentative.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvRepresentative.Name = "dgvRepresentative";
            this.dgvRepresentative.ReadOnly = true;
            this.dgvRepresentative.RowHeadersVisible = false;
            this.dgvRepresentative.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepresentative.TabIndex = 0;
            this.dgvRepresentative.Click += new System.EventHandler(this.dgvRepresentative_Click);

            // ── FrmRepresentative ─────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlHiddenFields);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRepresentative";
            this.Text = "Perwakilan";
            this.Load += new System.EventHandler(this.FrmRepresentative_Load);

            this.pnlActionBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlHiddenFields.ResumeLayout(false);
            this.pnlHiddenFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepresentative)).EndInit();
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
        private System.Windows.Forms.TextBox txtRepresentativeCode;
        private System.Windows.Forms.TextBox txtRepresentative;
        private System.Windows.Forms.DataGridView dgvRepresentative;
        private System.Windows.Forms.TextBox txtRepresentativeId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
