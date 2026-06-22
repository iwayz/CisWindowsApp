namespace CisWindowsFormsApp
{
    partial class FrmStockTransfer
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
            this.lblTransferNumber = new System.Windows.Forms.Label();
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
            this.lblTransferDate = new System.Windows.Forms.Label();
            this.dtpTransferDate = new System.Windows.Forms.DateTimePicker();
            this.lblTransferType = new System.Windows.Forms.Label();
            this.cbTransferType = new System.Windows.Forms.ComboBox();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.cbBatch = new System.Windows.Forms.ComboBox();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
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
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHidden = new System.Windows.Forms.Panel();
            this.txtTransferId = new System.Windows.Forms.TextBox();
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
            this.pnlTop.Controls.Add(this.lblTransferNumber);
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
            // lblTransferNumber
            //
            this.lblTransferNumber.AutoSize = false;
            this.lblTransferNumber.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblTransferNumber.ForeColor = System.Drawing.Color.White;
            this.lblTransferNumber.Location = new System.Drawing.Point(12, 14);
            this.lblTransferNumber.Name = "lblTransferNumber";
            this.lblTransferNumber.Size = new System.Drawing.Size(350, 28);
            this.lblTransferNumber.TabIndex = 0;
            this.lblTransferNumber.Text = "";
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
            this.gbHeader.Controls.Add(this.lblTransferDate);
            this.gbHeader.Controls.Add(this.dtpTransferDate);
            this.gbHeader.Controls.Add(this.lblTransferType);
            this.gbHeader.Controls.Add(this.cbTransferType);
            this.gbHeader.Controls.Add(this.lblBranchName);
            this.gbHeader.Controls.Add(this.txtBranchName);
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
            // lblTransferDate
            //
            this.lblTransferDate.AutoSize = true;
            this.lblTransferDate.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTransferDate.Location = new System.Drawing.Point(10, 28);
            this.lblTransferDate.Name = "lblTransferDate";
            this.lblTransferDate.TabIndex = 0;
            this.lblTransferDate.Text = "Tgl. Transfer";
            //
            // dtpTransferDate
            //
            this.dtpTransferDate.Font = new System.Drawing.Font("Calibri", 9F);
            this.dtpTransferDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTransferDate.Location = new System.Drawing.Point(100, 24);
            this.dtpTransferDate.Name = "dtpTransferDate";
            this.dtpTransferDate.Size = new System.Drawing.Size(120, 21);
            this.dtpTransferDate.TabIndex = 1;
            //
            // lblTransferType
            //
            this.lblTransferType.AutoSize = true;
            this.lblTransferType.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblTransferType.Location = new System.Drawing.Point(234, 28);
            this.lblTransferType.Name = "lblTransferType";
            this.lblTransferType.TabIndex = 2;
            this.lblTransferType.Text = "Jenis Transfer";
            //
            // cbTransferType
            //
            this.cbTransferType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransferType.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbTransferType.Location = new System.Drawing.Point(330, 24);
            this.cbTransferType.Name = "cbTransferType";
            this.cbTransferType.Size = new System.Drawing.Size(180, 22);
            this.cbTransferType.TabIndex = 3;
            //
            // lblBranchName
            //
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblBranchName.Location = new System.Drawing.Point(524, 28);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.TabIndex = 4;
            this.lblBranchName.Text = "Nama Cabang *";
            //
            // txtBranchName
            //
            this.txtBranchName.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtBranchName.Location = new System.Drawing.Point(624, 24);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(200, 21);
            this.txtBranchName.TabIndex = 5;
            //
            // lblNotes
            //
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblNotes.Location = new System.Drawing.Point(10, 56);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes";
            //
            // txtNotes
            //
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtNotes.Location = new System.Drawing.Point(100, 52);
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(870, 21);
            this.txtNotes.TabIndex = 7;
            //
            // gbItems
            //
            this.gbItems.Controls.Add(this.lblProduct);
            this.gbItems.Controls.Add(this.cbProduct);
            this.gbItems.Controls.Add(this.lblBatch);
            this.gbItems.Controls.Add(this.cbBatch);
            this.gbItems.Controls.Add(this.lblQty);
            this.gbItems.Controls.Add(this.txtQty);
            this.gbItems.Controls.Add(this.btnAddItem);
            this.gbItems.Controls.Add(this.btnRemoveItem);
            this.gbItems.Controls.Add(this.dgvItems);
            this.gbItems.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.gbItems.Location = new System.Drawing.Point(100, 155);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(990, 490);
            this.gbItems.TabIndex = 3;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Item Transfer";
            //
            // lblProduct
            //
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblProduct.Location = new System.Drawing.Point(10, 28);
            this.lblProduct.Name = "lblProduct";
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
            this.cbProduct.Size = new System.Drawing.Size(300, 22);
            this.cbProduct.TabIndex = 1;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            //
            // lblBatch
            //
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblBatch.Location = new System.Drawing.Point(382, 28);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.TabIndex = 2;
            this.lblBatch.Text = "Batch";
            //
            // cbBatch
            //
            this.cbBatch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBatch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbBatch.Font = new System.Drawing.Font("Calibri", 9F);
            this.cbBatch.Location = new System.Drawing.Point(420, 24);
            this.cbBatch.Name = "cbBatch";
            this.cbBatch.Size = new System.Drawing.Size(160, 22);
            this.cbBatch.TabIndex = 3;
            //
            // lblQty
            //
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Calibri", 9F);
            this.lblQty.Location = new System.Drawing.Point(594, 28);
            this.lblQty.Name = "lblQty";
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "Qty";
            //
            // txtQty
            //
            this.txtQty.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtQty.Location = new System.Drawing.Point(620, 24);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(90, 21);
            this.txtQty.TabIndex = 5;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            //
            // btnAddItem
            //
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(36, 141, 193);
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(724, 22);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(80, 26);
            this.btnAddItem.TabIndex = 6;
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
            this.btnRemoveItem.Location = new System.Drawing.Point(814, 22);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(80, 26);
            this.btnRemoveItem.TabIndex = 7;
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
                this.colQty });
            this.dgvItems.Location = new System.Drawing.Point(10, 58);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 25;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(970, 420);
            this.dgvItems.TabIndex = 8;
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
            this.colProductCode.FillWeight = 90F;
            this.colProductCode.HeaderText = "Kode Barang";
            this.colProductCode.Name = "colProductCode";
            //
            // colProductName
            //
            this.colProductName.FillWeight = 220F;
            this.colProductName.HeaderText = "Nama Barang";
            this.colProductName.Name = "colProductName";
            //
            // colBatchCode
            //
            this.colBatchCode.FillWeight = 90F;
            this.colBatchCode.HeaderText = "Batch";
            this.colBatchCode.Name = "colBatchCode";
            //
            // colUomCode
            //
            this.colUomCode.FillWeight = 70F;
            this.colUomCode.HeaderText = "Satuan";
            this.colUomCode.Name = "colUomCode";
            //
            // colQty
            //
            this.colQty.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQty.FillWeight = 80F;
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            //
            // pnlHidden
            //
            this.pnlHidden.Controls.Add(this.txtTransferId);
            this.pnlHidden.Controls.Add(this.txtModifiedAt);
            this.pnlHidden.Location = new System.Drawing.Point(0, 660);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.Size = new System.Drawing.Size(0, 0);
            this.pnlHidden.TabIndex = 99;
            this.pnlHidden.Visible = false;
            //
            // txtTransferId
            //
            this.txtTransferId.Location = new System.Drawing.Point(0, 0);
            this.txtTransferId.Name = "txtTransferId";
            this.txtTransferId.Size = new System.Drawing.Size(100, 20);
            this.txtTransferId.TabIndex = 0;
            //
            // txtModifiedAt
            //
            this.txtModifiedAt.Location = new System.Drawing.Point(110, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(180, 20);
            this.txtModifiedAt.TabIndex = 1;
            //
            // FrmStockTransfer
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
            this.Name = "FrmStockTransfer";
            this.Text = "TRANSFER STOK";
            this.Load += new System.EventHandler(this.FrmStockTransfer_Load);
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
        private System.Windows.Forms.Label lblTransferNumber;
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
        private System.Windows.Forms.Label lblTransferDate;
        private System.Windows.Forms.DateTimePicker dtpTransferDate;
        private System.Windows.Forms.Label lblTransferType;
        private System.Windows.Forms.ComboBox cbTransferType;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.ComboBox cbBatch;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.Panel pnlHidden;
        private System.Windows.Forms.TextBox txtTransferId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
