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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblAdjNumber = new System.Windows.Forms.Label();
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
            this.btnVoid = new System.Windows.Forms.Button();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.lblAdjDate = new System.Windows.Forms.Label();
            this.dtpAdjDate = new System.Windows.Forms.DateTimePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.cbReason = new System.Windows.Forms.ComboBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.gbItems = new System.Windows.Forms.GroupBox();
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
            this.pnlTop.Controls.Add(this.lblAdjNumber);
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
            // lblAdjNumber
            //
            this.lblAdjNumber.AutoSize = false;
            this.lblAdjNumber.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblAdjNumber.ForeColor = System.Drawing.Color.White;
            this.lblAdjNumber.Location = new System.Drawing.Point(12, 14);
            this.lblAdjNumber.Name = "lblAdjNumber";
            this.lblAdjNumber.Size = new System.Drawing.Size(350, 28);
            this.lblAdjNumber.TabIndex = 0;
            this.lblAdjNumber.Text = "";
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
            this.pnlActions.Controls.Add(this.btnVoid);
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
            // btnVoid
            //
            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnVoid.FlatAppearance.BorderSize = 0;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold);
            this.btnVoid.ForeColor = System.Drawing.Color.White;
            this.btnVoid.Location = new System.Drawing.Point(9, 240);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(71, 30);
            this.btnVoid.TabIndex = 6;
            this.btnVoid.Text = "VOID";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            //
            // gbHeader
            //
            this.gbHeader.Controls.Add(this.lblAdjDate);
            this.gbHeader.Controls.Add(this.dtpAdjDate);
            this.gbHeader.Controls.Add(this.lblReason);
            this.gbHeader.Controls.Add(this.cbReason);
            this.gbHeader.Controls.Add(this.lblNotes);
            this.gbHeader.Controls.Add(this.txtNotes);
            this.gbHeader.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.gbHeader.Location = new System.Drawing.Point(100, 65);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(990, 80);
            this.gbHeader.TabIndex = 2;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Header";
            //
            // lblAdjDate
            //
            this.lblAdjDate.AutoSize = true;
            this.lblAdjDate.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblAdjDate.Location = new System.Drawing.Point(10, 28);
            this.lblAdjDate.Name = "lblAdjDate";
            this.lblAdjDate.Size = new System.Drawing.Size(80, 14);
            this.lblAdjDate.TabIndex = 0;
            this.lblAdjDate.Text = "Tanggal Adj.";
            //
            // dtpAdjDate
            //
            this.dtpAdjDate.Font = new System.Drawing.Font("Calibri", 9F);
            this.dtpAdjDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAdjDate.Location = new System.Drawing.Point(100, 24);
            this.dtpAdjDate.Name = "dtpAdjDate";
            this.dtpAdjDate.Size = new System.Drawing.Size(120, 21);
            this.dtpAdjDate.TabIndex = 1;
            //
            // lblReason
            //
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblReason.Location = new System.Drawing.Point(240, 28);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(48, 14);
            this.lblReason.TabIndex = 2;
            this.lblReason.Text = "Alasan";
            //
            // cbReason
            //
            this.cbReason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbReason.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbReason.Location = new System.Drawing.Point(300, 24);
            this.cbReason.Name = "cbReason";
            this.cbReason.Size = new System.Drawing.Size(160, 22);
            this.cbReason.TabIndex = 3;
            //
            // lblNotes
            //
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblNotes.Location = new System.Drawing.Point(480, 28);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(36, 14);
            this.lblNotes.TabIndex = 4;
            this.lblNotes.Text = "Notes";
            //
            // txtNotes
            //
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtNotes.Location = new System.Drawing.Point(530, 24);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(440, 21);
            this.txtNotes.TabIndex = 5;
            //
            // gbItems
            //
            this.gbItems.Controls.Add(this.lblProduct);
            this.gbItems.Controls.Add(this.cbProduct);
            this.gbItems.Controls.Add(this.lblBatch);
            this.gbItems.Controls.Add(this.cbBatch);
            this.gbItems.Controls.Add(this.lblQtyBefore);
            this.gbItems.Controls.Add(this.txtQtyBefore);
            this.gbItems.Controls.Add(this.lblDirection);
            this.gbItems.Controls.Add(this.cbDirection);
            this.gbItems.Controls.Add(this.lblQtyAdj);
            this.gbItems.Controls.Add(this.txtQtyAdj);
            this.gbItems.Controls.Add(this.btnAddItem);
            this.gbItems.Controls.Add(this.btnRemoveItem);
            this.gbItems.Controls.Add(this.dgvItems);
            this.gbItems.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.gbItems.Location = new System.Drawing.Point(100, 155);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(990, 490);
            this.gbItems.TabIndex = 3;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Item Adjustment";
            //
            // lblProduct
            //
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblProduct.Location = new System.Drawing.Point(10, 28);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(45, 14);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Barang";
            //
            // cbProduct
            //
            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProduct.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbProduct.Location = new System.Drawing.Point(70, 24);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(280, 22);
            this.cbProduct.TabIndex = 1;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            //
            // lblBatch
            //
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblBatch.Location = new System.Drawing.Point(362, 28);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(33, 14);
            this.lblBatch.TabIndex = 2;
            this.lblBatch.Text = "Batch";
            //
            // cbBatch
            //
            this.cbBatch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBatch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbBatch.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbBatch.Location = new System.Drawing.Point(408, 24);
            this.cbBatch.Name = "cbBatch";
            this.cbBatch.Size = new System.Drawing.Size(160, 22);
            this.cbBatch.TabIndex = 3;
            this.cbBatch.SelectedIndexChanged += new System.EventHandler(this.cbBatch_SelectedIndexChanged);
            //
            // lblQtyBefore
            //
            this.lblQtyBefore.AutoSize = true;
            this.lblQtyBefore.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblQtyBefore.Location = new System.Drawing.Point(582, 28);
            this.lblQtyBefore.Name = "lblQtyBefore";
            this.lblQtyBefore.Size = new System.Drawing.Size(54, 14);
            this.lblQtyBefore.TabIndex = 4;
            this.lblQtyBefore.Text = "Stok Saat Ini";
            //
            // txtQtyBefore
            //
            this.txtQtyBefore.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.txtQtyBefore.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtQtyBefore.Location = new System.Drawing.Point(660, 24);
            this.txtQtyBefore.Name = "txtQtyBefore";
            this.txtQtyBefore.ReadOnly = true;
            this.txtQtyBefore.Size = new System.Drawing.Size(80, 21);
            this.txtQtyBefore.TabIndex = 5;
            this.txtQtyBefore.Text = "0";
            this.txtQtyBefore.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblDirection
            //
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblDirection.Location = new System.Drawing.Point(10, 58);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(48, 14);
            this.lblDirection.TabIndex = 6;
            this.lblDirection.Text = "Arah (+/-)";
            //
            // cbDirection
            //
            this.cbDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDirection.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbDirection.Location = new System.Drawing.Point(70, 54);
            this.cbDirection.Name = "cbDirection";
            this.cbDirection.Size = new System.Drawing.Size(100, 22);
            this.cbDirection.TabIndex = 7;
            //
            // lblQtyAdj
            //
            this.lblQtyAdj.AutoSize = true;
            this.lblQtyAdj.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblQtyAdj.Location = new System.Drawing.Point(182, 58);
            this.lblQtyAdj.Name = "lblQtyAdj";
            this.lblQtyAdj.Size = new System.Drawing.Size(60, 14);
            this.lblQtyAdj.TabIndex = 8;
            this.lblQtyAdj.Text = "Qty Adj.";
            //
            // txtQtyAdj
            //
            this.txtQtyAdj.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtQtyAdj.Location = new System.Drawing.Point(255, 54);
            this.txtQtyAdj.Name = "txtQtyAdj";
            this.txtQtyAdj.Size = new System.Drawing.Size(100, 21);
            this.txtQtyAdj.TabIndex = 9;
            this.txtQtyAdj.Text = "0";
            this.txtQtyAdj.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQtyAdj.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtyAdj_KeyPress);
            //
            // btnAddItem
            //
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(380, 52);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(80, 26);
            this.btnAddItem.TabIndex = 10;
            this.btnAddItem.Text = "+ Tambah";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            //
            // btnRemoveItem
            //
            this.btnRemoveItem.BackColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnRemoveItem.FlatAppearance.BorderSize = 0;
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.White;
            this.btnRemoveItem.Location = new System.Drawing.Point(470, 52);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(80, 26);
            this.btnRemoveItem.TabIndex = 11;
            this.btnRemoveItem.Text = "- Hapus";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            //
            // dgvItems
            //
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
                this.colQtyBefore,
                this.colDirection,
                this.colQtyAdj,
                this.colQtyAfter });
            this.dgvItems.Location = new System.Drawing.Point(10, 88);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 25;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(970, 390);
            this.dgvItems.TabIndex = 12;
            //
            // colProductId (hidden)
            //
            this.colProductId.HeaderText = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = false;
            //
            // colBatchId (hidden)
            //
            this.colBatchId.HeaderText = "BatchId";
            this.colBatchId.Name = "colBatchId";
            this.colBatchId.Visible = false;
            //
            // colUomId (hidden)
            //
            this.colUomId.HeaderText = "UomId";
            this.colUomId.Name = "colUomId";
            this.colUomId.Visible = false;
            //
            // colProductCode
            //
            this.colProductCode.FillWeight = 80F;
            this.colProductCode.HeaderText = "Kode Barang";
            this.colProductCode.Name = "colProductCode";
            //
            // colProductName
            //
            this.colProductName.FillWeight = 180F;
            this.colProductName.HeaderText = "Nama Barang";
            this.colProductName.Name = "colProductName";
            //
            // colBatchCode
            //
            this.colBatchCode.FillWeight = 80F;
            this.colBatchCode.HeaderText = "Batch";
            this.colBatchCode.Name = "colBatchCode";
            //
            // colUomCode
            //
            this.colUomCode.FillWeight = 60F;
            this.colUomCode.HeaderText = "Satuan";
            this.colUomCode.Name = "colUomCode";
            //
            // colQtyBefore
            //
            this.colQtyBefore.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtyBefore.FillWeight = 70F;
            this.colQtyBefore.HeaderText = "Stok Sebelum";
            this.colQtyBefore.Name = "colQtyBefore";
            //
            // colDirection
            //
            this.colDirection.FillWeight = 50F;
            this.colDirection.HeaderText = "Arah";
            this.colDirection.Name = "colDirection";
            //
            // colQtyAdj
            //
            this.colQtyAdj.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtyAdj.FillWeight = 70F;
            this.colQtyAdj.HeaderText = "Qty Adj.";
            this.colQtyAdj.Name = "colQtyAdj";
            //
            // colQtyAfter
            //
            this.colQtyAfter.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQtyAfter.FillWeight = 70F;
            this.colQtyAfter.HeaderText = "Stok Sesudah";
            this.colQtyAfter.Name = "colQtyAfter";
            //
            // pnlHidden
            //
            this.pnlHidden.Controls.Add(this.txtAdjId);
            this.pnlHidden.Controls.Add(this.txtModifiedAt);
            this.pnlHidden.Location = new System.Drawing.Point(0, 660);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.Size = new System.Drawing.Size(0, 0);
            this.pnlHidden.TabIndex = 99;
            this.pnlHidden.Visible = false;
            //
            // txtAdjId
            //
            this.txtAdjId.Location = new System.Drawing.Point(0, 0);
            this.txtAdjId.Name = "txtAdjId";
            this.txtAdjId.Size = new System.Drawing.Size(100, 20);
            this.txtAdjId.TabIndex = 0;
            //
            // txtModifiedAt
            //
            this.txtModifiedAt.Location = new System.Drawing.Point(110, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(180, 20);
            this.txtModifiedAt.TabIndex = 1;
            //
            // FrmStockAdjustment
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
            this.Name = "FrmStockAdjustment";
            this.Text = "PENYESUAIAN STOK";
            this.Load += new System.EventHandler(this.FrmStockAdjustment_Load);
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
        private System.Windows.Forms.Label lblAdjNumber;
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
        private System.Windows.Forms.Button btnVoid;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.Label lblAdjDate;
        private System.Windows.Forms.DateTimePicker dtpAdjDate;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.ComboBox cbReason;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox gbItems;
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
