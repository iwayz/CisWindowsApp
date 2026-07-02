namespace CisWindowsFormsApp
{
    partial class FrmPurchaseReturn
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
            // panels
            this.pnlTop          = new System.Windows.Forms.Panel();
            this.pnlTopSep       = new System.Windows.Forms.Panel();
            this.pnlActionBar    = new System.Windows.Forms.Panel();
            this.pnlContent      = new System.Windows.Forms.Panel();
            this.pnlHeader       = new System.Windows.Forms.Panel();
            this.pnlHeaderSpacer = new System.Windows.Forms.Panel();
            this.pnlItems        = new System.Windows.Forms.Panel();
            this.pnlItemInput    = new System.Windows.Forms.Panel();
            this.pnlGridTop      = new System.Windows.Forms.Panel();
            this.pnlFooter       = new System.Windows.Forms.Panel();
            this.pnlHidden       = new System.Windows.Forms.Panel();
            // top bar
            this.lblReturnNumber = new System.Windows.Forms.Label();
            this.lblStatus       = new System.Windows.Forms.Label();
            this.txtSearch       = new System.Windows.Forms.TextBox();
            this.btnSearch       = new System.Windows.Forms.Button();
            this.btnFirst        = new System.Windows.Forms.Button();
            this.btnPrev         = new System.Windows.Forms.Button();
            this.btnNext         = new System.Windows.Forms.Button();
            this.btnLast         = new System.Windows.Forms.Button();
            // action bar
            this.btnClear  = new System.Windows.Forms.Button();
            this.btnAdd    = new System.Windows.Forms.Button();
            this.btnSave   = new System.Windows.Forms.Button();
            this.btnDel    = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnPost   = new System.Windows.Forms.Button();
            this.btnVoid   = new System.Windows.Forms.Button();
            // header fields
            this.cbSupplier    = new System.Windows.Forms.ComboBox();
            this.cbPO          = new System.Windows.Forms.ComboBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtReason     = new System.Windows.Forms.TextBox();
            // item input
            this.cbProduct      = new System.Windows.Forms.ComboBox();
            this.txtBatch       = new System.Windows.Forms.TextBox();
            this.dtpExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtQty         = new System.Windows.Forms.TextBox();
            this.txtPrice       = new System.Windows.Forms.TextBox();
            this.btnAddItem     = new System.Windows.Forms.Button();
            this.btnRemoveItem  = new System.Windows.Forms.Button();
            // grid
            this.dgvItems       = new System.Windows.Forms.DataGridView();
            this.colProductId   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchId     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUomId       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCode   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDate     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUomCode     = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            // footer
            this.lblTotal = new System.Windows.Forms.Label();
            // hidden
            this.txtReturnId   = new System.Windows.Forms.TextBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();

            this.pnlTop.SuspendLayout();
            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlItems.SuspendLayout();
            this.pnlItemInput.SuspendLayout();
            this.pnlGridTop.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlHidden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();

            // ── pnlTop ────────────────────────────────
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.pnlTop.Controls.Add(this.lblReturnNumber);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.btnLast);
            this.pnlTop.Controls.Add(this.btnNext);
            this.pnlTop.Controls.Add(this.btnPrev);
            this.pnlTop.Controls.Add(this.btnFirst);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1360, 54);
            this.pnlTop.TabIndex = 0;

            this.lblReturnNumber.AutoSize = false;
            this.lblReturnNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblReturnNumber.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.lblReturnNumber.Location = new System.Drawing.Point(16, 12);
            this.lblReturnNumber.Margin = new System.Windows.Forms.Padding(4);
            this.lblReturnNumber.Name = "lblReturnNumber";
            this.lblReturnNumber.Size = new System.Drawing.Size(220, 32);
            this.lblReturnNumber.Text = "";

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblStatus.Location = new System.Drawing.Point(244, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "";

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(1000, 15);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(220, 23);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1228, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 30);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnFirst.Location = new System.Drawing.Point(1296, 12);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(40, 30);
            this.btnFirst.TabIndex = 12;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);

            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnPrev.Location = new System.Drawing.Point(1340, 12);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 30);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);

            this.btnNext.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnNext.Location = new System.Drawing.Point(1384, 12);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 30);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            this.btnLast.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnLast.Location = new System.Drawing.Point(1428, 12);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(40, 30);
            this.btnLast.TabIndex = 15;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);

            // ── pnlTopSep ─────────────────────────────
            this.pnlTopSep.BackColor = System.Drawing.Color.FromArgb(208, 212, 218);
            this.pnlTopSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSep.Name = "pnlTopSep";
            this.pnlTopSep.Size = new System.Drawing.Size(1360, 1);
            this.pnlTopSep.TabIndex = 1;

            // ── pnlActionBar ──────────────────────────
            this.pnlActionBar.BackColor = System.Drawing.Color.FromArgb(228, 230, 233);
            this.pnlActionBar.Controls.Add(this.btnVoid);
            this.pnlActionBar.Controls.Add(this.btnPost);
            this.pnlActionBar.Controls.Add(this.btnReload);
            this.pnlActionBar.Controls.Add(this.btnDel);
            this.pnlActionBar.Controls.Add(this.btnSave);
            this.pnlActionBar.Controls.Add(this.btnAdd);
            this.pnlActionBar.Controls.Add(this.btnClear);
            this.pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionBar.Name = "pnlActionBar";
            this.pnlActionBar.Size = new System.Drawing.Size(1360, 52);
            this.pnlActionBar.TabIndex = 2;

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(11, 9);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
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
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(109, 34);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);

            this.btnPost.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(621, 9);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(109, 34);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);

            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(100, 20, 20);
            this.btnVoid.FlatAppearance.BorderSize = 0;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVoid.ForeColor = System.Drawing.Color.White;
            this.btnVoid.Location = new System.Drawing.Point(741, 9);
            this.btnVoid.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(109, 34);
            this.btnVoid.TabIndex = 6;
            this.btnVoid.Text = "Void";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);

            // ── pnlContent ────────────────────────────
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlContent.Controls.Add(this.pnlItems);
            this.pnlContent.Controls.Add(this.pnlHeaderSpacer);
            this.pnlContent.Controls.Add(this.pnlHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(8);
            this.pnlContent.TabIndex = 3;

            // ── pnlHeader (white card, 108px) ─────────
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.cbSupplier);
            this.pnlHeader.Controls.Add(this.cbPO);
            this.pnlHeader.Controls.Add(this.dtpReturnDate);
            this.pnlHeader.Controls.Add(this.txtReason);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(8);
            this.pnlHeader.Size = new System.Drawing.Size(1344, 108);
            this.pnlHeader.TabIndex = 0;

            var lblSupplier = new System.Windows.Forms.Label();
            lblSupplier.AutoSize = true;
            lblSupplier.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblSupplier.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblSupplier.Location = new System.Drawing.Point(8, 8);
            lblSupplier.Text = "Principal / Supplier";
            this.pnlHeader.Controls.Add(lblSupplier);

            this.cbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(8, 24);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(290, 23);
            this.cbSupplier.TabIndex = 1;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);

            var lblPO = new System.Windows.Forms.Label();
            lblPO.AutoSize = true;
            lblPO.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblPO.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblPO.Location = new System.Drawing.Point(306, 8);
            lblPO.Text = "No. PO (Referensi)";
            this.pnlHeader.Controls.Add(lblPO);

            this.cbPO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbPO.FormattingEnabled = true;
            this.cbPO.Location = new System.Drawing.Point(306, 24);
            this.cbPO.Name = "cbPO";
            this.cbPO.Size = new System.Drawing.Size(200, 23);
            this.cbPO.TabIndex = 2;
            this.cbPO.SelectedIndexChanged += new System.EventHandler(this.cbPO_SelectedIndexChanged);

            var lblReturnDate = new System.Windows.Forms.Label();
            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblReturnDate.Location = new System.Drawing.Point(514, 8);
            lblReturnDate.Text = "Tgl. Return";
            this.pnlHeader.Controls.Add(lblReturnDate);

            this.dtpReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(514, 24);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(140, 23);
            this.dtpReturnDate.TabIndex = 3;

            var lblReason = new System.Windows.Forms.Label();
            lblReason.AutoSize = true;
            lblReason.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblReason.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblReason.Location = new System.Drawing.Point(8, 56);
            lblReason.Text = "Alasan Return";
            this.pnlHeader.Controls.Add(lblReason);

            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReason.Location = new System.Drawing.Point(8, 72);
            this.txtReason.Multiline = false;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(800, 23);
            this.txtReason.TabIndex = 4;

            // ── pnlHeaderSpacer ───────────────────────
            this.pnlHeaderSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSpacer.Name = "pnlHeaderSpacer";
            this.pnlHeaderSpacer.Size = new System.Drawing.Size(1344, 8);
            this.pnlHeaderSpacer.TabIndex = 1;

            // ── pnlItems (Fill, white card) ───────────
            this.pnlItems.BackColor = System.Drawing.Color.White;
            this.pnlItems.Controls.Add(this.dgvItems);
            this.pnlItems.Controls.Add(this.pnlFooter);
            this.pnlItems.Controls.Add(this.pnlGridTop);
            this.pnlItems.Controls.Add(this.pnlItemInput);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Padding = new System.Windows.Forms.Padding(8);
            this.pnlItems.TabIndex = 2;

            // ── pnlItemInput (Top, 42px) ──────────────
            this.pnlItemInput.Controls.Add(this.cbProduct);
            this.pnlItemInput.Controls.Add(this.txtBatch);
            this.pnlItemInput.Controls.Add(this.dtpExpiredDate);
            this.pnlItemInput.Controls.Add(this.txtQty);
            this.pnlItemInput.Controls.Add(this.txtPrice);
            this.pnlItemInput.Controls.Add(this.btnAddItem);
            this.pnlItemInput.Controls.Add(this.btnRemoveItem);
            this.pnlItemInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItemInput.Name = "pnlItemInput";
            this.pnlItemInput.Size = new System.Drawing.Size(1344, 42);
            this.pnlItemInput.TabIndex = 0;

            var lblProduct = new System.Windows.Forms.Label();
            lblProduct.AutoSize = true;
            lblProduct.Font = new System.Drawing.Font("Segoe UI", 7F);
            lblProduct.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblProduct.Location = new System.Drawing.Point(4, 2);
            lblProduct.Text = "Barang";
            this.pnlItemInput.Controls.Add(lblProduct);

            var lblBatch = new System.Windows.Forms.Label();
            lblBatch.AutoSize = true;
            lblBatch.Font = new System.Drawing.Font("Segoe UI", 7F);
            lblBatch.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblBatch.Location = new System.Drawing.Point(292, 2);
            lblBatch.Text = "Batch";
            this.pnlItemInput.Controls.Add(lblBatch);

            var lblExpDate = new System.Windows.Forms.Label();
            lblExpDate.AutoSize = true;
            lblExpDate.Font = new System.Drawing.Font("Segoe UI", 7F);
            lblExpDate.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblExpDate.Location = new System.Drawing.Point(390, 2);
            lblExpDate.Text = "Exp. Date";
            this.pnlItemInput.Controls.Add(lblExpDate);

            var lblQty = new System.Windows.Forms.Label();
            lblQty.AutoSize = true;
            lblQty.Font = new System.Drawing.Font("Segoe UI", 7F);
            lblQty.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblQty.Location = new System.Drawing.Point(508, 2);
            lblQty.Text = "Qty";
            this.pnlItemInput.Controls.Add(lblQty);

            var lblPrice = new System.Windows.Forms.Label();
            lblPrice.AutoSize = true;
            lblPrice.Font = new System.Drawing.Font("Segoe UI", 7F);
            lblPrice.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblPrice.Location = new System.Drawing.Point(576, 2);
            lblPrice.Text = "Harga";
            this.pnlItemInput.Controls.Add(lblPrice);

            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(4, 14);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(280, 23);
            this.cbProduct.TabIndex = 5;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);

            this.txtBatch.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBatch.Location = new System.Drawing.Point(292, 14);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = true;
            this.txtBatch.Size = new System.Drawing.Size(90, 23);
            this.txtBatch.TabIndex = 99;

            this.dtpExpiredDate.Enabled = false;
            this.dtpExpiredDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiredDate.Location = new System.Drawing.Point(390, 14);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(110, 23);
            this.dtpExpiredDate.TabIndex = 99;

            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQty.Location = new System.Drawing.Point(508, 14);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(60, 23);
            this.txtQty.TabIndex = 6;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);

            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(576, 14);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 23);
            this.txtPrice.TabIndex = 99;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);

            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(684, 14);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(90, 23);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "+ Tambah";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            this.btnRemoveItem.BackColor = System.Drawing.Color.White;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnRemoveItem.Location = new System.Drawing.Point(782, 14);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(90, 23);
            this.btnRemoveItem.TabIndex = 8;
            this.btnRemoveItem.Text = "- Hapus";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);

            // ── pnlGridTop (Top, 32px) ────────────────
            var lblItemsTitle = new System.Windows.Forms.Label();
            lblItemsTitle.AutoSize = true;
            lblItemsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblItemsTitle.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblItemsTitle.Location = new System.Drawing.Point(4, 8);
            lblItemsTitle.Text = "Item Return";

            this.pnlGridTop.Controls.Add(lblItemsTitle);
            this.pnlGridTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridTop.Name = "pnlGridTop";
            this.pnlGridTop.Size = new System.Drawing.Size(1344, 32);
            this.pnlGridTop.TabIndex = 1;

            // ── dgvItems (Fill) ───────────────────────
            var dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            var dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.Black;

            var dgvNumStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvNumStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvNumStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dgvNumStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvNumStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.DefaultCellStyle = dgvDefaultStyle;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.TabIndex = 2;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colProductId, this.colBatchId, this.colUomId,
                this.colProductCode, this.colProductName, this.colBatchCode,
                this.colExpDate, this.colQty, this.colUomCode,
                this.colPrice, this.colSubTotal });

            this.colProductId.Name = "colProductId"; this.colProductId.HeaderText = "colProductId"; this.colProductId.Visible = false; this.colProductId.FillWeight = 1;
            this.colBatchId.Name   = "colBatchId";   this.colBatchId.HeaderText   = "colBatchId";   this.colBatchId.Visible   = false; this.colBatchId.FillWeight   = 1;
            this.colUomId.Name     = "colUomId";     this.colUomId.HeaderText     = "colUomId";     this.colUomId.Visible     = false; this.colUomId.FillWeight     = 1;

            this.colProductCode.Name = "colProductCode"; this.colProductCode.HeaderText = "Kode";        this.colProductCode.FillWeight = 60;  this.colProductCode.DefaultCellStyle = dgvDefaultStyle;
            this.colProductName.Name = "colProductName"; this.colProductName.HeaderText = "Nama Barang"; this.colProductName.FillWeight = 200; this.colProductName.DefaultCellStyle = dgvDefaultStyle;
            this.colBatchCode.Name   = "colBatchCode";   this.colBatchCode.HeaderText   = "Batch";        this.colBatchCode.FillWeight   = 60;  this.colBatchCode.DefaultCellStyle   = dgvDefaultStyle;
            this.colExpDate.Name     = "colExpDate";     this.colExpDate.HeaderText     = "Exp.";         this.colExpDate.FillWeight     = 50;  this.colExpDate.DefaultCellStyle     = dgvDefaultStyle;
            this.colQty.Name         = "colQty";         this.colQty.HeaderText         = "Qty";          this.colQty.FillWeight         = 40;  this.colQty.DefaultCellStyle         = dgvNumStyle;
            this.colUomCode.Name     = "colUomCode";     this.colUomCode.HeaderText     = "UOM";          this.colUomCode.FillWeight     = 40;  this.colUomCode.DefaultCellStyle     = dgvDefaultStyle;
            this.colPrice.Name       = "colPrice";       this.colPrice.HeaderText       = "Harga";        this.colPrice.FillWeight       = 80;  this.colPrice.DefaultCellStyle       = dgvNumStyle;
            this.colSubTotal.Name    = "colSubTotal";    this.colSubTotal.HeaderText    = "Subtotal";     this.colSubTotal.FillWeight    = 90;  this.colSubTotal.DefaultCellStyle    = dgvNumStyle;

            // ── pnlFooter (Bottom, 52px) ──────────────
            var lblTotalLabel = new System.Windows.Forms.Label();
            lblTotalLabel.AutoSize = true;
            lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            lblTotalLabel.Location = new System.Drawing.Point(8, 14);
            lblTotalLabel.Text = "TOTAL";

            this.lblTotal.AutoSize = false;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.lblTotal.Location = new System.Drawing.Point(80, 6);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(260, 40);
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.pnlFooter.Controls.Add(this.lblTotal);
            this.pnlFooter.Controls.Add(lblTotalLabel);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1344, 52);
            this.pnlFooter.TabIndex = 3;

            // ── pnlHidden ─────────────────────────────
            this.pnlHidden.Controls.Add(this.txtReturnId);
            this.pnlHidden.Controls.Add(this.txtModifiedAt);
            this.pnlHidden.Location = new System.Drawing.Point(0, 800);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.Size = new System.Drawing.Size(400, 30);
            this.pnlHidden.TabIndex = 99;
            this.pnlHidden.Visible = false;

            this.txtReturnId.Location = new System.Drawing.Point(0, 0);
            this.txtReturnId.Name = "txtReturnId";
            this.txtReturnId.Size = new System.Drawing.Size(180, 23);
            this.txtReturnId.TabIndex = 0;

            this.txtModifiedAt.Location = new System.Drawing.Point(190, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(180, 23);
            this.txtModifiedAt.TabIndex = 1;

            // ── FrmPurchaseReturn ─────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlTopSep);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHidden);
            this.Name = "FrmPurchaseReturn";
            this.Text = "Purchase Return";
            this.Load += new System.EventHandler(this.FrmPurchaseReturn_Load);

            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlActionBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlItems.ResumeLayout(false);
            this.pnlItemInput.ResumeLayout(false);
            this.pnlItemInput.PerformLayout();
            this.pnlGridTop.ResumeLayout(false);
            this.pnlGridTop.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlHidden.ResumeLayout(false);
            this.pnlHidden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlTopSep;
        private System.Windows.Forms.Panel pnlActionBar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderSpacer;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlItemInput;
        private System.Windows.Forms.Panel pnlGridTop;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Panel pnlHidden;
        private System.Windows.Forms.Label lblReturnNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.ComboBox cbPO;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.DateTimePicker dtpExpiredDate;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtReturnId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
