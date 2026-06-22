namespace CisWindowsFormsApp
{
    partial class FrmStockOpname
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblOpnameNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.lblOpnameDate = new System.Windows.Forms.Label();
            this.dtpOpnameDate = new System.Windows.Forms.DateTimePicker();
            this.lblOpnameType = new System.Windows.Forms.Label();
            this.cbOpnameType = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.btnLoadProducts = new System.Windows.Forms.Button();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtySystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtyPhysical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHidden = new System.Windows.Forms.Panel();
            this.txtOpnameId = new System.Windows.Forms.TextBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.gbHeader.SuspendLayout();
            this.gbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlHidden.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlTop
            //
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.pnlTop.Controls.Add(this.lblOpnameNumber);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.btnFirst);
            this.pnlTop.Controls.Add(this.btnPrev);
            this.pnlTop.Controls.Add(this.btnNext);
            this.pnlTop.Controls.Add(this.btnLast);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 56);
            this.pnlTop.TabIndex = 0;
            //
            // lblOpnameNumber
            //
            this.lblOpnameNumber.AutoSize = false;
            this.lblOpnameNumber.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblOpnameNumber.ForeColor = System.Drawing.Color.White;
            this.lblOpnameNumber.Location = new System.Drawing.Point(12, 14);
            this.lblOpnameNumber.Name = "lblOpnameNumber";
            this.lblOpnameNumber.Size = new System.Drawing.Size(350, 28);
            this.lblOpnameNumber.TabIndex = 0;
            this.lblOpnameNumber.Text = "";
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 13F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(370, 16);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 22);
            this.lblStatus.TabIndex = 1;
            //
            // txtSearch
            //
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 11F);
            this.txtSearch.Location = new System.Drawing.Point(724, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            //
            // btnSearch
            //
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(892, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 28);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "CARI";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // btnFirst
            //
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnFirst.Location = new System.Drawing.Point(960, 14);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(30, 28);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            //
            // btnPrev
            //
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnPrev.Location = new System.Drawing.Point(994, 14);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(30, 28);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            //
            // btnNext
            //
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnNext.Location = new System.Drawing.Point(1028, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 28);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            //
            // btnLast
            //
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.btnLast.Location = new System.Drawing.Point(1062, 14);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(30, 28);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            //
            // pnlActions
            //
            this.pnlActions.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlActions.Controls.Add(this.btnClear);
            this.pnlActions.Controls.Add(this.btnAdd);
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Controls.Add(this.btnDel);
            this.pnlActions.Controls.Add(this.btnReload);
            this.pnlActions.Controls.Add(this.btnPost);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlActions.Location = new System.Drawing.Point(0, 56);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(90, 659);
            this.pnlActions.TabIndex = 1;
            //
            // btnClear
            //
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(9, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 30);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(9, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(9, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnDel
            //
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(9, 118);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(71, 30);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            //
            // btnReload
            //
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(9, 154);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(71, 30);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            //
            // btnPost
            //
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(9, 196);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(71, 30);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            //
            // gbHeader
            //
            this.gbHeader.Controls.Add(this.lblOpnameDate);
            this.gbHeader.Controls.Add(this.dtpOpnameDate);
            this.gbHeader.Controls.Add(this.lblOpnameType);
            this.gbHeader.Controls.Add(this.cbOpnameType);
            this.gbHeader.Controls.Add(this.lblNotes);
            this.gbHeader.Controls.Add(this.txtNotes);
            this.gbHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.gbHeader.Location = new System.Drawing.Point(100, 65);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(990, 56);
            this.gbHeader.TabIndex = 2;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Header";
            //
            // lblOpnameDate
            //
            this.lblOpnameDate.AutoSize = true;
            this.lblOpnameDate.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblOpnameDate.Location = new System.Drawing.Point(10, 24);
            this.lblOpnameDate.Name = "lblOpnameDate";
            this.lblOpnameDate.TabIndex = 0;
            this.lblOpnameDate.Text = "Tgl. Opname";
            //
            // dtpOpnameDate
            //
            this.dtpOpnameDate.Font = new System.Drawing.Font("Calibri", 9F);
            this.dtpOpnameDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOpnameDate.Location = new System.Drawing.Point(100, 20);
            this.dtpOpnameDate.Name = "dtpOpnameDate";
            this.dtpOpnameDate.Size = new System.Drawing.Size(120, 21);
            this.dtpOpnameDate.TabIndex = 1;
            //
            // lblOpnameType
            //
            this.lblOpnameType.AutoSize = true;
            this.lblOpnameType.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblOpnameType.Location = new System.Drawing.Point(234, 24);
            this.lblOpnameType.Name = "lblOpnameType";
            this.lblOpnameType.TabIndex = 2;
            this.lblOpnameType.Text = "Tipe";
            //
            // cbOpnameType
            //
            this.cbOpnameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOpnameType.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbOpnameType.Location = new System.Drawing.Point(264, 20);
            this.cbOpnameType.Name = "cbOpnameType";
            this.cbOpnameType.Size = new System.Drawing.Size(160, 22);
            this.cbOpnameType.TabIndex = 3;
            //
            // lblNotes
            //
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblNotes.Location = new System.Drawing.Point(440, 24);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes";
            //
            // txtNotes
            //
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtNotes.Location = new System.Drawing.Point(488, 20);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(490, 21);
            this.txtNotes.TabIndex = 5;
            //
            // gbItems
            //
            this.gbItems.Controls.Add(this.btnLoadProducts);
            this.gbItems.Controls.Add(this.lblItemCount);
            this.gbItems.Controls.Add(this.dgvItems);
            this.gbItems.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.gbItems.Location = new System.Drawing.Point(100, 130);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(990, 520);
            this.gbItems.TabIndex = 3;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Daftar Item Opname";
            //
            // btnLoadProducts
            //
            this.btnLoadProducts.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.btnLoadProducts.FlatAppearance.BorderSize = 0;
            this.btnLoadProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadProducts.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadProducts.ForeColor = System.Drawing.Color.White;
            this.btnLoadProducts.Location = new System.Drawing.Point(10, 22);
            this.btnLoadProducts.Name = "btnLoadProducts";
            this.btnLoadProducts.Size = new System.Drawing.Size(130, 26);
            this.btnLoadProducts.TabIndex = 0;
            this.btnLoadProducts.Text = "Load Semua Produk";
            this.btnLoadProducts.UseVisualStyleBackColor = false;
            this.btnLoadProducts.Click += new System.EventHandler(this.btnLoadProducts_Click);
            //
            // lblItemCount
            //
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblItemCount.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
            this.lblItemCount.Location = new System.Drawing.Point(152, 27);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.TabIndex = 1;
            this.lblItemCount.Text = "";
            //
            // dgvItems
            //
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colProductId,
                this.colBatchId,
                this.colUomId,
                this.colProductCode,
                this.colProductName,
                this.colBatchCode,
                this.colUomCode,
                this.colQtySystem,
                this.colQtyPhysical,
                this.colDifference });
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.Location = new System.Drawing.Point(10, 56);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 25;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(970, 454);
            this.dgvItems.TabIndex = 2;
            this.dgvItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellValueChanged);
            //
            // colProductId (hidden)
            //
            this.colProductId.HeaderText = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            //
            // colBatchId (hidden)
            //
            this.colBatchId.HeaderText = "BatchId";
            this.colBatchId.Name = "colBatchId";
            this.colBatchId.ReadOnly = true;
            this.colBatchId.Visible = false;
            //
            // colUomId (hidden)
            //
            this.colUomId.HeaderText = "UomId";
            this.colUomId.Name = "colUomId";
            this.colUomId.ReadOnly = true;
            this.colUomId.Visible = false;
            //
            // colProductCode
            //
            this.colProductCode.FillWeight = 80F;
            this.colProductCode.HeaderText = "Kode Barang";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.ReadOnly = true;
            //
            // colProductName
            //
            this.colProductName.FillWeight = 220F;
            this.colProductName.HeaderText = "Nama Barang";
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            //
            // colBatchCode
            //
            this.colBatchCode.FillWeight = 80F;
            this.colBatchCode.HeaderText = "Batch";
            this.colBatchCode.Name = "colBatchCode";
            this.colBatchCode.ReadOnly = true;
            //
            // colUomCode
            //
            this.colUomCode.FillWeight = 60F;
            this.colUomCode.HeaderText = "Satuan";
            this.colUomCode.Name = "colUomCode";
            this.colUomCode.ReadOnly = true;
            //
            // colQtySystem
            //
            this.colQtySystem.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtySystem.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.colQtySystem.FillWeight = 80F;
            this.colQtySystem.HeaderText = "Qty System";
            this.colQtySystem.Name = "colQtySystem";
            this.colQtySystem.ReadOnly = true;
            //
            // colQtyPhysical
            //
            this.colQtyPhysical.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtyPhysical.FillWeight = 80F;
            this.colQtyPhysical.HeaderText = "Qty Fisik *";
            this.colQtyPhysical.Name = "colQtyPhysical";
            //
            // colDifference
            //
            this.colDifference.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDifference.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.colDifference.FillWeight = 80F;
            this.colDifference.HeaderText = "Selisih";
            this.colDifference.Name = "colDifference";
            this.colDifference.ReadOnly = true;
            //
            // pnlHidden
            //
            this.pnlHidden.Controls.Add(this.txtOpnameId);
            this.pnlHidden.Controls.Add(this.txtModifiedAt);
            this.pnlHidden.Location = new System.Drawing.Point(0, 680);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.Size = new System.Drawing.Size(0, 0);
            this.pnlHidden.TabIndex = 99;
            this.pnlHidden.Visible = false;
            //
            // txtOpnameId
            //
            this.txtOpnameId.Location = new System.Drawing.Point(0, 0);
            this.txtOpnameId.Name = "txtOpnameId";
            this.txtOpnameId.Size = new System.Drawing.Size(100, 20);
            this.txtOpnameId.TabIndex = 0;
            //
            // txtModifiedAt
            //
            this.txtModifiedAt.Location = new System.Drawing.Point(110, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(180, 20);
            this.txtModifiedAt.TabIndex = 1;
            //
            // FrmStockOpname
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 715);
            this.Controls.Add(this.gbItems);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHidden);
            this.Name = "FrmStockOpname";
            this.Text = "STOCK OPNAME";
            this.Load += new System.EventHandler(this.FrmStockOpname_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.gbItems.ResumeLayout(false);
            this.gbItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlHidden.ResumeLayout(false);
            this.pnlHidden.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblOpnameNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.Label lblOpnameDate;
        private System.Windows.Forms.DateTimePicker dtpOpnameDate;
        private System.Windows.Forms.Label lblOpnameType;
        private System.Windows.Forms.ComboBox cbOpnameType;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.Button btnLoadProducts;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBatchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtySystem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtyPhysical;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDifference;
        private System.Windows.Forms.Panel pnlHidden;
        private System.Windows.Forms.TextBox txtOpnameId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
