namespace CisWindowsFormsApp
{
    partial class FrmBatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatch));

            // panels
            this.pnlActionBar    = new System.Windows.Forms.Panel();
            this.pnlContent      = new System.Windows.Forms.Panel();
            this.pnlLeft         = new System.Windows.Forms.Panel();
            this.pnlLeftSpacer   = new System.Windows.Forms.Panel();
            this.pnlRight        = new System.Windows.Forms.Panel();
            this.pnlSearch       = new System.Windows.Forms.Panel();
            this.pnlNote         = new System.Windows.Forms.Panel();
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
            this.txtBatchCode   = new System.Windows.Forms.TextBox();
            this.cbProductCode  = new System.Windows.Forms.ComboBox();
            this.txtQuantity    = new System.Windows.Forms.TextBox();
            this.dtpEntryDate   = new System.Windows.Forms.DateTimePicker();
            this.dtpExpiredDate = new System.Windows.Forms.DateTimePicker();

            // note
            this.lblNoteDetail = new System.Windows.Forms.Label();

            // grid
            this.dgvBatch = new System.Windows.Forms.DataGridView();

            // hidden
            this.txtBatchId   = new System.Windows.Forms.TextBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();

            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlNote.SuspendLayout();
            this.pnlHiddenFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).BeginInit();
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
            this.pnlLeft.Size = new System.Drawing.Size(380, 600);
            this.pnlLeft.TabIndex = 0;

            // ── pnlLeftSpacer ─────────────────────────
            this.pnlLeftSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSpacer.Name = "pnlLeftSpacer";
            this.pnlLeftSpacer.Size = new System.Drawing.Size(8, 600);
            this.pnlLeftSpacer.TabIndex = 1;

            // ── pnlRight (Fill) ───────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.dgvBatch);
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

            // --- Row 1: Kode Batch ---
            var lblBatchCode = new System.Windows.Forms.Label();
            lblBatchCode.AutoSize = true;
            lblBatchCode.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblBatchCode.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblBatchCode.Location = new System.Drawing.Point(8, 8);
            lblBatchCode.Text = "Kode Batch";
            this.pnlLeft.Controls.Add(lblBatchCode);

            this.txtBatchCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatchCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBatchCode.Location = new System.Drawing.Point(8, 24);
            this.txtBatchCode.Name = "txtBatchCode";
            this.txtBatchCode.Size = new System.Drawing.Size(200, 23);
            this.txtBatchCode.TabIndex = 1;
            this.pnlLeft.Controls.Add(this.txtBatchCode);

            // --- Row 2: Kode Produk ---
            var lblProductCode = new System.Windows.Forms.Label();
            lblProductCode.AutoSize = true;
            lblProductCode.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblProductCode.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblProductCode.Location = new System.Drawing.Point(8, 56);
            lblProductCode.Text = "Kode Produk";
            this.pnlLeft.Controls.Add(lblProductCode);

            this.cbProductCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProductCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProductCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbProductCode.FormattingEnabled = true;
            this.cbProductCode.Location = new System.Drawing.Point(8, 72);
            this.cbProductCode.Name = "cbProductCode";
            this.cbProductCode.Size = new System.Drawing.Size(356, 23);
            this.cbProductCode.TabIndex = 2;
            this.pnlLeft.Controls.Add(this.cbProductCode);

            // --- Row 3: Jumlah ---
            var lblQuantity = new System.Windows.Forms.Label();
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblQuantity.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblQuantity.Location = new System.Drawing.Point(8, 104);
            lblQuantity.Text = "Jumlah";
            this.pnlLeft.Controls.Add(lblQuantity);

            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuantity.Location = new System.Drawing.Point(8, 120);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(120, 23);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.Text = "0";
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            this.pnlLeft.Controls.Add(this.txtQuantity);

            // --- Row 4: Tgl. Masuk / Tgl. Kedaluwarsa ---
            var lblEntryDate = new System.Windows.Forms.Label();
            lblEntryDate.AutoSize = true;
            lblEntryDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblEntryDate.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblEntryDate.Location = new System.Drawing.Point(8, 152);
            lblEntryDate.Text = "Tgl. Masuk";
            this.pnlLeft.Controls.Add(lblEntryDate);

            this.dtpEntryDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpEntryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEntryDate.Location = new System.Drawing.Point(8, 168);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(140, 23);
            this.dtpEntryDate.TabIndex = 4;
            this.pnlLeft.Controls.Add(this.dtpEntryDate);

            var lblExpiredDate = new System.Windows.Forms.Label();
            lblExpiredDate.AutoSize = true;
            lblExpiredDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblExpiredDate.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblExpiredDate.Location = new System.Drawing.Point(156, 152);
            lblExpiredDate.Text = "Tgl. Kedaluwarsa";
            this.pnlLeft.Controls.Add(lblExpiredDate);

            this.dtpExpiredDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiredDate.Location = new System.Drawing.Point(156, 168);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(140, 23);
            this.dtpExpiredDate.TabIndex = 5;
            this.pnlLeft.Controls.Add(this.dtpExpiredDate);

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
            this.pnlNote.Location = new System.Drawing.Point(8, 204);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(356, 52);
            this.pnlNote.TabIndex = 10;
            this.pnlNote.Visible = false;
            this.pnlLeft.Controls.Add(this.pnlNote);

            // ── pnlHiddenFields ───────────────────────
            this.txtBatchId.Location = new System.Drawing.Point(0, 0);
            this.txtBatchId.Name = "txtBatchId";
            this.txtBatchId.Size = new System.Drawing.Size(175, 23);
            this.txtBatchId.TabIndex = 0;

            this.txtModifiedAt.Location = new System.Drawing.Point(185, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(175, 23);
            this.txtModifiedAt.TabIndex = 1;

            this.pnlHiddenFields.Controls.Add(this.txtBatchId);
            this.pnlHiddenFields.Controls.Add(this.txtModifiedAt);
            this.pnlHiddenFields.Location = new System.Drawing.Point(0, 900);
            this.pnlHiddenFields.Name = "pnlHiddenFields";
            this.pnlHiddenFields.Size = new System.Drawing.Size(400, 30);
            this.pnlHiddenFields.TabIndex = 99;
            this.pnlHiddenFields.Visible = false;

            // ── dgvBatch ──────────────────────────────
            var dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            var dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvBatch.AllowUserToAddRows = false;
            this.dgvBatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBatch.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBatch.DefaultCellStyle = dgvDefaultStyle;
            this.dgvBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBatch.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvBatch.Name = "dgvBatch";
            this.dgvBatch.ReadOnly = true;
            this.dgvBatch.RowHeadersVisible = false;
            this.dgvBatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBatch.TabIndex = 0;
            this.dgvBatch.Click += new System.EventHandler(this.dgvBatch_Click);

            // ── FrmBatch ──────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlHiddenFields);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBatch";
            this.Text = "Batch";
            this.Load += new System.EventHandler(this.FrmBatch_Load);

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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBatch)).EndInit();
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
        private System.Windows.Forms.TextBox txtBatchCode;
        private System.Windows.Forms.ComboBox cbProductCode;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.DateTimePicker dtpExpiredDate;
        private System.Windows.Forms.Label lblNoteDetail;
        private System.Windows.Forms.DataGridView dgvBatch;
        private System.Windows.Forms.TextBox txtBatchId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
