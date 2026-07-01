namespace CisWindowsFormsApp
{
    partial class FrmStockAdjustment
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
            System.Windows.Forms.DataGridViewCellStyle dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvNumStyle = new System.Windows.Forms.DataGridViewCellStyle();

            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAdjNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.pnlTopSep = new System.Windows.Forms.Panel();
            this.pnlActionBar = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnVoid = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblAdjDate = new System.Windows.Forms.Label();
            this.dtpAdjDate = new System.Windows.Forms.DateTimePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.cbReason = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pnlHeaderSpacer = new System.Windows.Forms.Panel();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.pnlItemInput = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.cbBatch = new System.Windows.Forms.ComboBox();
            this.lblQtyBefore = new System.Windows.Forms.Label();
            this.txtQtyBefore = new System.Windows.Forms.TextBox();
            this.lblDirection = new System.Windows.Forms.Label();
            this.cbDirection = new System.Windows.Forms.ComboBox();
            this.lblQtyAdj = new System.Windows.Forms.Label();
            this.txtQtyAdj = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.pnlGridTop = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyBefore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDirection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyAdj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyAfter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHidden = new System.Windows.Forms.Panel();
            this.txtAdjId = new System.Windows.Forms.TextBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();

            this.pnlTop.SuspendLayout();
            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlItems.SuspendLayout();
            this.pnlItemInput.SuspendLayout();
            this.pnlGridTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlHidden.SuspendLayout();
            this.SuspendLayout();

            // ── pnlTop ──
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.pnlTop.Controls.Add(this.lblAdjNumber);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.btnFirst);
            this.pnlTop.Controls.Add(this.btnPrev);
            this.pnlTop.Controls.Add(this.btnNext);
            this.pnlTop.Controls.Add(this.btnLast);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 44);
            this.pnlTop.TabIndex = 0;

            this.lblAdjNumber.AutoSize = false;
            this.lblAdjNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblAdjNumber.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.lblAdjNumber.Location = new System.Drawing.Point(12, 10);
            this.lblAdjNumber.Name = "lblAdjNumber";
            this.lblAdjNumber.Size = new System.Drawing.Size(300, 26);
            this.lblAdjNumber.TabIndex = 0;
            this.lblAdjNumber.Text = "";

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblStatus.Location = new System.Drawing.Point(322, 13);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 19);
            this.lblStatus.TabIndex = 1;

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(706, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(184, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(897, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(58, 24);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnFirst.FlatAppearance.BorderSize = 1;
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnFirst.Location = new System.Drawing.Point(963, 10);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 24);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);

            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnPrev.FlatAppearance.BorderSize = 1;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnPrev.Location = new System.Drawing.Point(997, 10);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 24);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);

            this.btnNext.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnNext.FlatAppearance.BorderSize = 1;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnNext.Location = new System.Drawing.Point(1031, 10);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 24);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            this.btnLast.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnLast.FlatAppearance.BorderSize = 1;
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnLast.Location = new System.Drawing.Point(1065, 10);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 24);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);

            // ── pnlTopSep ──
            this.pnlTopSep.BackColor = System.Drawing.Color.FromArgb(208, 212, 218);
            this.pnlTopSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSep.Name = "pnlTopSep";
            this.pnlTopSep.Size = new System.Drawing.Size(1100, 1);
            this.pnlTopSep.TabIndex = 99;

            // ── pnlActionBar ──
            this.pnlActionBar.BackColor = System.Drawing.Color.FromArgb(228, 230, 233);
            this.pnlActionBar.Controls.Add(this.btnClear);
            this.pnlActionBar.Controls.Add(this.btnAdd);
            this.pnlActionBar.Controls.Add(this.btnSave);
            this.pnlActionBar.Controls.Add(this.btnDel);
            this.pnlActionBar.Controls.Add(this.btnReload);
            this.pnlActionBar.Controls.Add(this.btnPost);
            this.pnlActionBar.Controls.Add(this.btnVoid);
            this.pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionBar.Name = "pnlActionBar";
            this.pnlActionBar.Size = new System.Drawing.Size(1100, 42);
            this.pnlActionBar.TabIndex = 1;

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnClear.FlatAppearance.BorderSize = 1;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnClear.Location = new System.Drawing.Point(8, 7);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 28);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(106, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 28);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+ New";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(196, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 28);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDel.BackColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(286, 7);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(82, 28);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);

            this.btnReload.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnReload.FlatAppearance.BorderSize = 1;
            this.btnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(173, 173, 173);
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.FromArgb(26, 26, 26);
            this.btnReload.Location = new System.Drawing.Point(376, 7);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 28);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);

            this.btnPost.BackColor = System.Drawing.Color.FromArgb(202, 80, 16);
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(466, 7);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(82, 28);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);

            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(100, 20, 20);
            this.btnVoid.FlatAppearance.BorderSize = 0;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVoid.ForeColor = System.Drawing.Color.White;
            this.btnVoid.Location = new System.Drawing.Point(556, 7);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(82, 28);
            this.btnVoid.TabIndex = 6;
            this.btnVoid.Text = "Void";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);

            // ── pnlContent ──
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.pnlContent.Controls.Add(this.pnlItems);
            this.pnlContent.Controls.Add(this.pnlHeaderSpacer);
            this.pnlContent.Controls.Add(this.pnlHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(8);
            this.pnlContent.TabIndex = 2;

            // ── pnlHeader ──
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblAdjDate);
            this.pnlHeader.Controls.Add(this.dtpAdjDate);
            this.pnlHeader.Controls.Add(this.lblReason);
            this.pnlHeader.Controls.Add(this.cbReason);
            this.pnlHeader.Controls.Add(this.lblNotes);
            this.pnlHeader.Controls.Add(this.txtNotes);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1084, 62);
            this.pnlHeader.TabIndex = 0;

            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            this.lblHeaderTitle.Location = new System.Drawing.Point(10, 7);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "HEADER DOKUMEN";

            this.lblAdjDate.AutoSize = true;
            this.lblAdjDate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblAdjDate.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblAdjDate.Location = new System.Drawing.Point(10, 33);
            this.lblAdjDate.Name = "lblAdjDate";
            this.lblAdjDate.TabIndex = 1;
            this.lblAdjDate.Text = "Tgl. Adjustment";

            this.dtpAdjDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpAdjDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdjDate.Location = new System.Drawing.Point(104, 30);
            this.dtpAdjDate.Name = "dtpAdjDate";
            this.dtpAdjDate.Size = new System.Drawing.Size(112, 23);
            this.dtpAdjDate.TabIndex = 2;

            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblReason.Location = new System.Drawing.Point(232, 33);
            this.lblReason.Name = "lblReason";
            this.lblReason.TabIndex = 3;
            this.lblReason.Text = "Alasan";

            this.cbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbReason.Location = new System.Drawing.Point(278, 30);
            this.cbReason.Name = "cbReason";
            this.cbReason.Size = new System.Drawing.Size(175, 23);
            this.cbReason.TabIndex = 4;

            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblNotes.Location = new System.Drawing.Point(468, 33);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.TabIndex = 5;
            this.lblNotes.Text = "Notes";

            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(506, 30);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(560, 23);
            this.txtNotes.TabIndex = 6;

            // ── pnlHeaderSpacer ──
            this.pnlHeaderSpacer.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.pnlHeaderSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSpacer.Name = "pnlHeaderSpacer";
            this.pnlHeaderSpacer.Size = new System.Drawing.Size(1084, 8);
            this.pnlHeaderSpacer.TabIndex = 98;

            // ── pnlItems ──
            this.pnlItems.BackColor = System.Drawing.Color.White;
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItems.Controls.Add(this.dgvItems);
            this.pnlItems.Controls.Add(this.pnlGridTop);
            this.pnlItems.Controls.Add(this.pnlItemInput);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.TabIndex = 1;

            // ── pnlItemInput ──
            this.pnlItemInput.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            this.pnlItemInput.Controls.Add(this.lblProduct);
            this.pnlItemInput.Controls.Add(this.cbProduct);
            this.pnlItemInput.Controls.Add(this.lblBatch);
            this.pnlItemInput.Controls.Add(this.cbBatch);
            this.pnlItemInput.Controls.Add(this.lblQtyBefore);
            this.pnlItemInput.Controls.Add(this.txtQtyBefore);
            this.pnlItemInput.Controls.Add(this.lblDirection);
            this.pnlItemInput.Controls.Add(this.cbDirection);
            this.pnlItemInput.Controls.Add(this.lblQtyAdj);
            this.pnlItemInput.Controls.Add(this.txtQtyAdj);
            this.pnlItemInput.Controls.Add(this.btnAddItem);
            this.pnlItemInput.Controls.Add(this.btnRemoveItem);
            this.pnlItemInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItemInput.Name = "pnlItemInput";
            this.pnlItemInput.Size = new System.Drawing.Size(1084, 42);
            this.pnlItemInput.TabIndex = 0;

            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblProduct.Location = new System.Drawing.Point(10, 13);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Barang";

            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbProduct.Location = new System.Drawing.Point(56, 9);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(240, 23);
            this.cbProduct.TabIndex = 1;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);

            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBatch.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblBatch.Location = new System.Drawing.Point(310, 13);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.TabIndex = 2;
            this.lblBatch.Text = "Batch";

            this.cbBatch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBatch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbBatch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbBatch.Location = new System.Drawing.Point(346, 9);
            this.cbBatch.Name = "cbBatch";
            this.cbBatch.Size = new System.Drawing.Size(120, 23);
            this.cbBatch.TabIndex = 3;
            this.cbBatch.SelectedIndexChanged += new System.EventHandler(this.cbBatch_SelectedIndexChanged);

            this.lblQtyBefore.AutoSize = true;
            this.lblQtyBefore.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblQtyBefore.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblQtyBefore.Location = new System.Drawing.Point(480, 13);
            this.lblQtyBefore.Name = "lblQtyBefore";
            this.lblQtyBefore.TabIndex = 4;
            this.lblQtyBefore.Text = "Stok Saat Ini";

            this.txtQtyBefore.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.txtQtyBefore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtyBefore.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQtyBefore.Location = new System.Drawing.Point(566, 9);
            this.txtQtyBefore.Name = "txtQtyBefore";
            this.txtQtyBefore.ReadOnly = true;
            this.txtQtyBefore.Size = new System.Drawing.Size(64, 23);
            this.txtQtyBefore.TabIndex = 5;
            this.txtQtyBefore.Text = "0";
            this.txtQtyBefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDirection.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblDirection.Location = new System.Drawing.Point(644, 13);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.TabIndex = 6;
            this.lblDirection.Text = "Arah";

            this.cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbDirection.Location = new System.Drawing.Point(676, 9);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(70, 23);
            this.cbDirection.TabIndex = 7;

            this.lblQtyAdj.AutoSize = true;
            this.lblQtyAdj.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblQtyAdj.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblQtyAdj.Location = new System.Drawing.Point(760, 13);
            this.lblQtyAdj.Name = "lblQtyAdj";
            this.lblQtyAdj.TabIndex = 8;
            this.lblQtyAdj.Text = "Qty Adj";

            this.txtQtyAdj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtyAdj.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQtyAdj.Location = new System.Drawing.Point(802, 9);
            this.txtQtyAdj.Name = "txtQtyAdj";
            this.txtQtyAdj.Size = new System.Drawing.Size(64, 23);
            this.txtQtyAdj.TabIndex = 9;
            this.txtQtyAdj.Text = "0";
            this.txtQtyAdj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtyAdj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtyAdj_KeyPress);

            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(880, 8);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(90, 26);
            this.btnAddItem.TabIndex = 10;
            this.btnAddItem.Text = "+ Tambah";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);

            this.btnRemoveItem.BackColor = System.Drawing.Color.White;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnRemoveItem.FlatAppearance.BorderSize = 1;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnRemoveItem.Location = new System.Drawing.Point(978, 8);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(90, 26);
            this.btnRemoveItem.TabIndex = 11;
            this.btnRemoveItem.Text = "- Hapus";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);

            // ── pnlGridTop ──
            this.pnlGridTop.BackColor = System.Drawing.Color.White;
            this.pnlGridTop.Controls.Add(this.lblGridTitle);
            this.pnlGridTop.Controls.Add(this.lblItemCount);
            this.pnlGridTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridTop.Name = "pnlGridTop";
            this.pnlGridTop.Size = new System.Drawing.Size(1084, 32);
            this.pnlGridTop.TabIndex = 1;

            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            this.lblGridTitle.Location = new System.Drawing.Point(10, 9);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "DAFTAR ITEM ADJUSTMENT";

            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblItemCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblItemCount.ForeColor = System.Drawing.Color.FromArgb(136, 136, 136);
            this.lblItemCount.Location = new System.Drawing.Point(900, 9);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.TabIndex = 1;
            this.lblItemCount.Text = "";

            // ── dgvItems ──
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(238, 241, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.FromArgb(0, 59, 110);

            dgvNumStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvItems.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvItems.ColumnHeadersHeight = 30;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.DefaultCellStyle = dgvDefaultStyle;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(237, 240, 243);
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colProductId,
                this.colBatchId,
                this.colUomId,
                this.colProductCode,
                this.colProductName,
                this.colBatchCode,
                this.colUomCode,
                this.colQtyBefore,
                this.colDirection,
                this.colQtyAdj,
                this.colQtyAfter });
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 20;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.TabIndex = 2;

            this.colProductId.HeaderText = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = false;

            this.colBatchId.HeaderText = "BatchId";
            this.colBatchId.Name = "colBatchId";
            this.colBatchId.Visible = false;

            this.colUomId.HeaderText = "UomId";
            this.colUomId.Name = "colUomId";
            this.colUomId.Visible = false;

            this.colProductCode.FillWeight = 90F;
            this.colProductCode.HeaderText = "Kode Barang";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.ReadOnly = true;

            this.colProductName.FillWeight = 200F;
            this.colProductName.HeaderText = "Nama Barang";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;

            this.colBatchCode.FillWeight = 80F;
            this.colBatchCode.HeaderText = "Batch";
            this.colBatchCode.Name = "colBatchCode";
            this.colBatchCode.ReadOnly = true;

            this.colUomCode.FillWeight = 60F;
            this.colUomCode.HeaderText = "Satuan";
            this.colUomCode.Name = "colUomCode";
            this.colUomCode.ReadOnly = true;

            this.colQtyBefore.DefaultCellStyle = dgvNumStyle;
            this.colQtyBefore.FillWeight = 80F;
            this.colQtyBefore.HeaderText = "Stok Awal";
            this.colQtyBefore.Name = "colQtyBefore";
            this.colQtyBefore.ReadOnly = true;

            this.colDirection.FillWeight = 60F;
            this.colDirection.HeaderText = "Arah";
            this.colDirection.Name = "colDirection";
            this.colDirection.ReadOnly = true;

            this.colQtyAdj.DefaultCellStyle = dgvNumStyle;
            this.colQtyAdj.FillWeight = 80F;
            this.colQtyAdj.HeaderText = "Qty Adj";
            this.colQtyAdj.Name = "colQtyAdj";
            this.colQtyAdj.ReadOnly = true;

            this.colQtyAfter.DefaultCellStyle = dgvNumStyle;
            this.colQtyAfter.FillWeight = 80F;
            this.colQtyAfter.HeaderText = "Stok Akhir";
            this.colQtyAfter.Name = "colQtyAfter";
            this.colQtyAfter.ReadOnly = true;

            // ── pnlHidden ──
            this.pnlHidden.Controls.Add(this.txtAdjId);
            this.pnlHidden.Controls.Add(this.txtModifiedAt);
            this.pnlHidden.Location = new System.Drawing.Point(0, 0);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.Size = new System.Drawing.Size(0, 0);
            this.pnlHidden.TabIndex = 99;
            this.pnlHidden.Visible = false;

            this.txtAdjId.Location = new System.Drawing.Point(0, 0);
            this.txtAdjId.Name = "txtAdjId";
            this.txtAdjId.Size = new System.Drawing.Size(100, 20);
            this.txtAdjId.TabIndex = 0;

            this.txtModifiedAt.Location = new System.Drawing.Point(110, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(180, 20);
            this.txtModifiedAt.TabIndex = 1;

            // ── Form ──
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.ClientSize = new System.Drawing.Size(1100, 715);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopSep);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHidden);
            this.Name = "FrmStockAdjustment";
            this.Text = "STOCK ADJUSTMENT";
            this.Load += new System.EventHandler(this.FrmStockAdjustment_Load);

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
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlHidden.ResumeLayout(false);
            this.pnlHidden.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblAdjNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel pnlTopSep;
        private System.Windows.Forms.Panel pnlActionBar;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblAdjDate;
        private System.Windows.Forms.DateTimePicker dtpAdjDate;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.ComboBox cbReason;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlHeaderSpacer;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlItemInput;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.ComboBox cbBatch;
        private System.Windows.Forms.Label lblQtyBefore;
        private System.Windows.Forms.TextBox txtQtyBefore;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.ComboBox cbDirection;
        private System.Windows.Forms.Label lblQtyAdj;
        private System.Windows.Forms.TextBox txtQtyAdj;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Panel pnlGridTop;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyBefore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDirection;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyAdj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyAfter;
        private System.Windows.Forms.Panel pnlHidden;
        private System.Windows.Forms.TextBox txtAdjId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
