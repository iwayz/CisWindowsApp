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
            this.components = new System.ComponentModel.Container();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblReturnNumberLabel = new System.Windows.Forms.Label();
            this.lblReturnNumber = new System.Windows.Forms.Label();
            this.lblStatusLabel = new System.Windows.Forms.Label();
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
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblPO = new System.Windows.Forms.Label();
            this.cbPO = new System.Windows.Forms.ComboBox();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblTotalLbl = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbItems = new System.Windows.Forms.GroupBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.dtpExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.colProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBatchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHidden = new System.Windows.Forms.Panel();
            this.txtReturnId = new System.Windows.Forms.TextBox();
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
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.pnlTop.Controls.Add(this.lblReturnNumberLabel);
            this.pnlTop.Controls.Add(this.lblReturnNumber);
            this.pnlTop.Controls.Add(this.lblStatusLabel);
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
            // lblReturnNumberLabel
            //
            this.lblReturnNumberLabel.AutoSize = true;
            this.lblReturnNumberLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReturnNumberLabel.ForeColor = System.Drawing.Color.White;
            this.lblReturnNumberLabel.Location = new System.Drawing.Point(12, 8);
            this.lblReturnNumberLabel.Name = "lblReturnNumberLabel";
            this.lblReturnNumberLabel.Text = "No. Return:";
            //
            // lblReturnNumber
            //
            this.lblReturnNumber.AutoSize = false;
            this.lblReturnNumber.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblReturnNumber.ForeColor = System.Drawing.Color.White;
            this.lblReturnNumber.Location = new System.Drawing.Point(90, 4);
            this.lblReturnNumber.Name = "lblReturnNumber";
            this.lblReturnNumber.Size = new System.Drawing.Size(160, 26);
            this.lblReturnNumber.Text = "";
            //
            // lblStatusLabel
            //
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStatusLabel.ForeColor = System.Drawing.Color.White;
            this.lblStatusLabel.Location = new System.Drawing.Point(264, 8);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.Text = "Status:";
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(318, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "";
            //
            // txtSearch
            //
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSearch.Location = new System.Drawing.Point(700, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 27);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            //
            // btnSearch
            //
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnSearch.Location = new System.Drawing.Point(866, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(28, 28);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "?";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // btnFirst
            //
            this.btnFirst.BackColor = System.Drawing.Color.White;
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnFirst.Location = new System.Drawing.Point(998, 14);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(28, 28);
            this.btnFirst.TabIndex = 12;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            //
            // btnPrev
            //
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnPrev.Location = new System.Drawing.Point(1028, 14);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(28, 28);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            //
            // btnNext
            //
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnNext.Location = new System.Drawing.Point(1058, 14);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(28, 28);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            //
            // btnLast
            //
            this.btnLast.BackColor = System.Drawing.Color.White;
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnLast.Location = new System.Drawing.Point(1088, 14);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(28, 28);
            this.btnLast.TabIndex = 15;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            //
            // pnlActions
            //
            this.pnlActions.Controls.Add(this.btnClear);
            this.pnlActions.Controls.Add(this.btnAdd);
            this.pnlActions.Controls.Add(this.btnSave);
            this.pnlActions.Controls.Add(this.btnDel);
            this.pnlActions.Controls.Add(this.btnReload);
            this.pnlActions.Controls.Add(this.btnPost);
            this.pnlActions.Controls.Add(this.btnVoid);
            this.pnlActions.Location = new System.Drawing.Point(0, 58);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(110, 600);
            this.pnlActions.TabIndex = 1;
            //
            // btnClear
            //
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(14, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 50);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // btnAdd
            //
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(14, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 50);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(14, 122);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 50);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // btnDel
            //
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(14, 178);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(82, 50);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            //
            // btnReload
            //
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(14, 234);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 50);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "RELOAD";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            //
            // btnPost
            //
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(14, 300);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(82, 50);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "POST";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            //
            // btnVoid
            //
            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnVoid.FlatAppearance.BorderSize = 0;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVoid.ForeColor = System.Drawing.Color.White;
            this.btnVoid.Location = new System.Drawing.Point(14, 356);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(82, 50);
            this.btnVoid.TabIndex = 7;
            this.btnVoid.Text = "VOID";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            //
            // gbHeader
            //
            this.gbHeader.Controls.Add(this.lblSupplier);
            this.gbHeader.Controls.Add(this.cbSupplier);
            this.gbHeader.Controls.Add(this.lblPO);
            this.gbHeader.Controls.Add(this.cbPO);
            this.gbHeader.Controls.Add(this.lblReturnDate);
            this.gbHeader.Controls.Add(this.dtpReturnDate);
            this.gbHeader.Controls.Add(this.lblReason);
            this.gbHeader.Controls.Add(this.txtReason);
            this.gbHeader.Controls.Add(this.lblTotalLbl);
            this.gbHeader.Controls.Add(this.lblTotal);
            this.gbHeader.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbHeader.Location = new System.Drawing.Point(116, 58);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(976, 248);
            this.gbHeader.TabIndex = 2;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Data Purchase Return";
            //
            // lblSupplier
            //
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSupplier.Location = new System.Drawing.Point(12, 22);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Text = "Principal / Supplier";
            //
            // cbSupplier
            //
            this.cbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSupplier.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(12, 38);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(300, 27);
            this.cbSupplier.TabIndex = 1;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);
            //
            // lblPO
            //
            this.lblPO.AutoSize = true;
            this.lblPO.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPO.Location = new System.Drawing.Point(320, 22);
            this.lblPO.Name = "lblPO";
            this.lblPO.Text = "No. PO (Referensi)";
            //
            // cbPO
            //
            this.cbPO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPO.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbPO.FormattingEnabled = true;
            this.cbPO.Location = new System.Drawing.Point(320, 38);
            this.cbPO.Name = "cbPO";
            this.cbPO.Size = new System.Drawing.Size(330, 27);
            this.cbPO.TabIndex = 2;
            this.cbPO.SelectedIndexChanged += new System.EventHandler(this.cbPO_SelectedIndexChanged);
            //
            // lblReturnDate
            //
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReturnDate.Location = new System.Drawing.Point(12, 80);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Text = "Tanggal Return";
            //
            // dtpReturnDate
            //
            this.dtpReturnDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(12, 96);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(140, 27);
            this.dtpReturnDate.TabIndex = 3;
            //
            // lblReason
            //
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReason.Location = new System.Drawing.Point(12, 136);
            this.lblReason.Name = "lblReason";
            this.lblReason.Text = "Alasan Return";
            //
            // txtReason
            //
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtReason.Location = new System.Drawing.Point(12, 152);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(646, 52);
            this.txtReason.TabIndex = 4;
            //
            // lblTotalLbl
            //
            this.lblTotalLbl.AutoSize = true;
            this.lblTotalLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalLbl.Location = new System.Drawing.Point(700, 152);
            this.lblTotalLbl.Name = "lblTotalLbl";
            this.lblTotalLbl.Text = "TOTAL";
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = false;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.lblTotal.Location = new System.Drawing.Point(760, 148);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 32);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // gbItems
            //
            this.gbItems.Controls.Add(this.lblProduct);
            this.gbItems.Controls.Add(this.cbProduct);
            this.gbItems.Controls.Add(this.lblBatch);
            this.gbItems.Controls.Add(this.txtBatch);
            this.gbItems.Controls.Add(this.lblExpDate);
            this.gbItems.Controls.Add(this.dtpExpiredDate);
            this.gbItems.Controls.Add(this.lblQty);
            this.gbItems.Controls.Add(this.txtQty);
            this.gbItems.Controls.Add(this.lblPrice);
            this.gbItems.Controls.Add(this.txtPrice);
            this.gbItems.Controls.Add(this.btnAddItem);
            this.gbItems.Controls.Add(this.dgvItems);
            this.gbItems.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbItems.Location = new System.Drawing.Point(116, 312);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(976, 355);
            this.gbItems.TabIndex = 3;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Item Return";
            //
            // lblProduct
            //
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblProduct.Location = new System.Drawing.Point(8, 22);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Text = "Barang";
            //
            // cbProduct
            //
            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProduct.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(8, 38);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(320, 27);
            this.cbProduct.TabIndex = 5;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            //
            // lblBatch
            //
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBatch.Location = new System.Drawing.Point(336, 22);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Text = "Batch";
            //
            // txtBatch
            //
            this.txtBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatch.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBatch.Location = new System.Drawing.Point(336, 38);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = true;
            this.txtBatch.Size = new System.Drawing.Size(90, 27);
            this.txtBatch.TabIndex = 99;
            //
            // lblExpDate
            //
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExpDate.Location = new System.Drawing.Point(434, 22);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Text = "Exp. Date";
            //
            // dtpExpiredDate
            //
            this.dtpExpiredDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpExpiredDate.Location = new System.Drawing.Point(434, 38);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(110, 27);
            this.dtpExpiredDate.TabIndex = 99;
            this.dtpExpiredDate.Enabled = false;
            //
            // lblQty
            //
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblQty.Location = new System.Drawing.Point(552, 22);
            this.lblQty.Name = "lblQty";
            this.lblQty.Text = "Qty";
            //
            // txtQty
            //
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtQty.Location = new System.Drawing.Point(552, 38);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(60, 27);
            this.txtQty.TabIndex = 6;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            //
            // lblPrice
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(620, 22);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Text = "Harga";
            //
            // txtPrice
            //
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPrice.Location = new System.Drawing.Point(620, 38);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(90, 27);
            this.txtPrice.TabIndex = 99;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // btnAddItem
            //
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(720, 34);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(80, 30);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "+ Item";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            //
            // dgvItems
            //
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = true;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colProductId, this.colBatchId, this.colUomId,
                this.colProductCode, this.colProductName, this.colBatchCode,
                this.colExpDate, this.colQty, this.colUomCode,
                this.colPrice, this.colSubTotal });
            this.dgvItems.Location = new System.Drawing.Point(8, 75);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(960, 268);
            this.dgvItems.TabIndex = 8;
            this.dgvItems.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvItems_UserDeletedRow);
            // hidden
            this.colProductId.Name = "colProductId"; this.colProductId.Visible = false; this.colProductId.Width = 1;
            this.colBatchId.Name = "colBatchId";   this.colBatchId.Visible = false;   this.colBatchId.Width = 1;
            this.colUomId.Name = "colUomId";       this.colUomId.Visible = false;     this.colUomId.Width = 1;
            // visible
            this.colProductCode.Name = "colProductCode"; this.colProductCode.HeaderText = "Kode";        this.colProductCode.Width = 80;
            this.colProductName.Name = "colProductName"; this.colProductName.HeaderText = "Nama Barang"; this.colProductName.Width = 240;
            this.colBatchCode.Name = "colBatchCode";     this.colBatchCode.HeaderText = "Batch";         this.colBatchCode.Width = 80;
            this.colExpDate.Name = "colExpDate";         this.colExpDate.HeaderText = "Exp.";            this.colExpDate.Width = 70;
            this.colQty.Name = "colQty";                 this.colQty.HeaderText = "Qty";                 this.colQty.Width = 60;
            this.colQty.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUomCode.Name = "colUomCode";         this.colUomCode.HeaderText = "UOM";             this.colUomCode.Width = 50;
            this.colPrice.Name = "colPrice";             this.colPrice.HeaderText = "Harga";             this.colPrice.Width = 100;
            this.colPrice.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSubTotal.Name = "colSubTotal";       this.colSubTotal.HeaderText = "Subtotal";       this.colSubTotal.Width = 110;
            this.colSubTotal.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            //
            // pnlHidden
            //
            this.pnlHidden.Controls.Add(this.txtReturnId);
            this.pnlHidden.Controls.Add(this.txtModifiedAt);
            this.pnlHidden.Location = new System.Drawing.Point(0, 700);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.Size = new System.Drawing.Size(400, 30);
            this.pnlHidden.TabIndex = 99;
            this.pnlHidden.Visible = false;
            //
            // txtReturnId
            //
            this.txtReturnId.Location = new System.Drawing.Point(0, 0);
            this.txtReturnId.Name = "txtReturnId";
            this.txtReturnId.Size = new System.Drawing.Size(180, 27);
            this.txtReturnId.TabIndex = 0;
            //
            // txtModifiedAt
            //
            this.txtModifiedAt.Location = new System.Drawing.Point(190, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(180, 27);
            this.txtModifiedAt.TabIndex = 1;
            //
            // FrmPurchaseReturn
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 680);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.gbItems);
            this.Controls.Add(this.pnlHidden);
            this.Name = "FrmPurchaseReturn";
            this.Text = "PURCHASE RETURN";
            this.Load += new System.EventHandler(this.FrmPurchaseReturn_Load);
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
        private System.Windows.Forms.Label lblReturnNumberLabel;
        private System.Windows.Forms.Label lblReturnNumber;
        private System.Windows.Forms.Label lblStatusLabel;
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
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.ComboBox cbPO;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblTotalLbl;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gbItems;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.DateTimePicker dtpExpiredDate;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddItem;
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
        private System.Windows.Forms.Panel pnlHidden;
        private System.Windows.Forms.TextBox txtReturnId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
