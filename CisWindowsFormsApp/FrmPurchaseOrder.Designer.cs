namespace CisWindowsFormsApp
{
    partial class FrmPurchaseOrder
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
            this.lblPONumberLabel = new System.Windows.Forms.Label();
            this.lblPONumber = new System.Windows.Forms.Label();
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedDate = new System.Windows.Forms.Label();
            this.dtpExpectedDate = new System.Windows.Forms.DateTimePicker();
            this.lblReceivedDate = new System.Windows.Forms.Label();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pnlTotals = new System.Windows.Forms.Panel();
            this.lblSubTotalLbl = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblVATLbl = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
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
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
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
            this.colDisc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHidden = new System.Windows.Forms.Panel();
            this.txtPOId = new System.Windows.Forms.TextBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.gbHeader.SuspendLayout();
            this.pnlTotals.SuspendLayout();
            this.gbItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlHidden.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlTop
            //
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.pnlTop.Controls.Add(this.lblPONumberLabel);
            this.pnlTop.Controls.Add(this.lblPONumber);
            this.pnlTop.Controls.Add(this.lblStatusLabel);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.btnFirst);
            this.pnlTop.Controls.Add(this.btnPrev);
            this.pnlTop.Controls.Add(this.btnNext);
            this.pnlTop.Controls.Add(this.btnLast);
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 56);
            this.pnlTop.TabIndex = 0;
            //
            // lblPONumberLabel
            //
            this.lblPONumberLabel.AutoSize = true;
            this.lblPONumberLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPONumberLabel.ForeColor = System.Drawing.Color.White;
            this.lblPONumberLabel.Location = new System.Drawing.Point(12, 8);
            this.lblPONumberLabel.Name = "lblPONumberLabel";
            this.lblPONumberLabel.Size = new System.Drawing.Size(50, 15);
            this.lblPONumberLabel.TabIndex = 0;
            this.lblPONumberLabel.Text = "No. PO:";
            //
            // lblPONumber
            //
            this.lblPONumber.AutoSize = false;
            this.lblPONumber.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.lblPONumber.ForeColor = System.Drawing.Color.White;
            this.lblPONumber.Location = new System.Drawing.Point(68, 4);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Size = new System.Drawing.Size(160, 26);
            this.lblPONumber.TabIndex = 1;
            this.lblPONumber.Text = "";
            //
            // lblStatusLabel
            //
            this.lblStatusLabel.AutoSize = true;
            this.lblStatusLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblStatusLabel.ForeColor = System.Drawing.Color.White;
            this.lblStatusLabel.Location = new System.Drawing.Point(240, 8);
            this.lblStatusLabel.Name = "lblStatusLabel";
            this.lblStatusLabel.TabIndex = 2;
            this.lblStatusLabel.Text = "Status:";
            //
            // lblStatus
            //
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(295, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.TabIndex = 3;
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
            this.pnlActions.Controls.Add(this.btnConfirm);
            this.pnlActions.Controls.Add(this.btnReceive);
            this.pnlActions.Controls.Add(this.btnCancel);
            this.pnlActions.Location = new System.Drawing.Point(0, 58);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(110, 650);
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
            // btnConfirm
            //
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(14, 300);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(82, 50);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            //
            // btnReceive
            //
            this.btnReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.btnReceive.FlatAppearance.BorderSize = 0;
            this.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceive.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReceive.ForeColor = System.Drawing.Color.White;
            this.btnReceive.Location = new System.Drawing.Point(14, 356);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(82, 50);
            this.btnReceive.TabIndex = 7;
            this.btnReceive.Text = "RECEIVE";
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            //
            // btnCancel
            //
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(14, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 50);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            //
            // gbHeader
            //
            this.gbHeader.Controls.Add(this.lblSupplier);
            this.gbHeader.Controls.Add(this.cbSupplier);
            this.gbHeader.Controls.Add(this.lblSupplierAddress);
            this.gbHeader.Controls.Add(this.txtSupplierAddress);
            this.gbHeader.Controls.Add(this.lblSupplierPhone);
            this.gbHeader.Controls.Add(this.txtSupplierPhone);
            this.gbHeader.Controls.Add(this.lblOrderDate);
            this.gbHeader.Controls.Add(this.dtpOrderDate);
            this.gbHeader.Controls.Add(this.lblExpectedDate);
            this.gbHeader.Controls.Add(this.dtpExpectedDate);
            this.gbHeader.Controls.Add(this.lblReceivedDate);
            this.gbHeader.Controls.Add(this.dtpReceivedDate);
            this.gbHeader.Controls.Add(this.lblNotes);
            this.gbHeader.Controls.Add(this.txtNotes);
            this.gbHeader.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbHeader.Location = new System.Drawing.Point(116, 58);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(484, 282);
            this.gbHeader.TabIndex = 2;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "Data PO";
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
            this.cbSupplier.Size = new System.Drawing.Size(454, 27);
            this.cbSupplier.TabIndex = 1;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);
            //
            // lblSupplierAddress
            //
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSupplierAddress.Location = new System.Drawing.Point(12, 76);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Text = "Alamat Supplier";
            //
            // txtSupplierAddress
            //
            this.txtSupplierAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSupplierAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierAddress.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSupplierAddress.Location = new System.Drawing.Point(12, 92);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.ReadOnly = true;
            this.txtSupplierAddress.Size = new System.Drawing.Size(280, 52);
            this.txtSupplierAddress.TabIndex = 99;
            //
            // lblSupplierPhone
            //
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSupplierPhone.Location = new System.Drawing.Point(300, 76);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Text = "Telepon";
            //
            // txtSupplierPhone
            //
            this.txtSupplierPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSupplierPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierPhone.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSupplierPhone.Location = new System.Drawing.Point(300, 92);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.ReadOnly = true;
            this.txtSupplierPhone.Size = new System.Drawing.Size(150, 27);
            this.txtSupplierPhone.TabIndex = 99;
            //
            // lblOrderDate
            //
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblOrderDate.Location = new System.Drawing.Point(12, 155);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Text = "Tanggal PO";
            //
            // dtpOrderDate
            //
            this.dtpOrderDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(12, 170);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(140, 27);
            this.dtpOrderDate.TabIndex = 2;
            //
            // lblExpectedDate
            //
            this.lblExpectedDate.AutoSize = true;
            this.lblExpectedDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExpectedDate.Location = new System.Drawing.Point(162, 155);
            this.lblExpectedDate.Name = "lblExpectedDate";
            this.lblExpectedDate.Text = "Estimasi Tiba";
            //
            // dtpExpectedDate
            //
            this.dtpExpectedDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpExpectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpectedDate.Location = new System.Drawing.Point(162, 170);
            this.dtpExpectedDate.Name = "dtpExpectedDate";
            this.dtpExpectedDate.Size = new System.Drawing.Size(140, 27);
            this.dtpExpectedDate.TabIndex = 3;
            //
            // lblReceivedDate
            //
            this.lblReceivedDate.AutoSize = true;
            this.lblReceivedDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblReceivedDate.Location = new System.Drawing.Point(312, 155);
            this.lblReceivedDate.Name = "lblReceivedDate";
            this.lblReceivedDate.Text = "Tgl. Terima";
            //
            // dtpReceivedDate
            //
            this.dtpReceivedDate.Enabled = false;
            this.dtpReceivedDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceivedDate.Location = new System.Drawing.Point(312, 170);
            this.dtpReceivedDate.Name = "dtpReceivedDate";
            this.dtpReceivedDate.Size = new System.Drawing.Size(140, 27);
            this.dtpReceivedDate.TabIndex = 99;
            //
            // lblNotes
            //
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNotes.Location = new System.Drawing.Point(12, 210);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Text = "Catatan";
            //
            // txtNotes
            //
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtNotes.Location = new System.Drawing.Point(12, 226);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(454, 44);
            this.txtNotes.TabIndex = 4;
            //
            // pnlTotals
            //
            this.pnlTotals.Controls.Add(this.lblSubTotalLbl);
            this.pnlTotals.Controls.Add(this.txtSubTotal);
            this.pnlTotals.Controls.Add(this.lblVATLbl);
            this.pnlTotals.Controls.Add(this.txtVAT);
            this.pnlTotals.Controls.Add(this.lblTotalLbl);
            this.pnlTotals.Controls.Add(this.lblTotal);
            this.pnlTotals.Location = new System.Drawing.Point(608, 58);
            this.pnlTotals.Name = "pnlTotals";
            this.pnlTotals.Size = new System.Drawing.Size(484, 282);
            this.pnlTotals.TabIndex = 3;
            //
            // lblSubTotalLbl
            //
            this.lblSubTotalLbl.AutoSize = true;
            this.lblSubTotalLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblSubTotalLbl.Location = new System.Drawing.Point(10, 12);
            this.lblSubTotalLbl.Name = "lblSubTotalLbl";
            this.lblSubTotalLbl.Text = "Subtotal";
            //
            // txtSubTotal
            //
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSubTotal.Location = new System.Drawing.Point(230, 8);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(200, 27);
            this.txtSubTotal.TabIndex = 99;
            this.txtSubTotal.Text = "0";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblVATLbl
            //
            this.lblVATLbl.AutoSize = true;
            this.lblVATLbl.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVATLbl.Location = new System.Drawing.Point(10, 50);
            this.lblVATLbl.Name = "lblVATLbl";
            this.lblVATLbl.Text = "PPN (11%)";
            //
            // txtVAT
            //
            this.txtVAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVAT.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtVAT.Location = new System.Drawing.Point(230, 46);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(200, 27);
            this.txtVAT.TabIndex = 99;
            this.txtVAT.Text = "0";
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblTotalLbl
            //
            this.lblTotalLbl.AutoSize = true;
            this.lblTotalLbl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalLbl.Location = new System.Drawing.Point(10, 92);
            this.lblTotalLbl.Name = "lblTotalLbl";
            this.lblTotalLbl.Text = "TOTAL";
            //
            // lblTotal
            //
            this.lblTotal.AutoSize = false;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.lblTotal.Location = new System.Drawing.Point(150, 88);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(280, 32);
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
            this.gbItems.Controls.Add(this.lblDiscount);
            this.gbItems.Controls.Add(this.txtDiscount);
            this.gbItems.Controls.Add(this.btnAddItem);
            this.gbItems.Controls.Add(this.dgvItems);
            this.gbItems.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbItems.Location = new System.Drawing.Point(116, 346);
            this.gbItems.Name = "gbItems";
            this.gbItems.Size = new System.Drawing.Size(976, 355);
            this.gbItems.TabIndex = 4;
            this.gbItems.TabStop = false;
            this.gbItems.Text = "Item PO";
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
            this.cbProduct.Size = new System.Drawing.Size(280, 27);
            this.cbProduct.TabIndex = 5;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            //
            // lblBatch
            //
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblBatch.Location = new System.Drawing.Point(296, 22);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Text = "Batch";
            //
            // txtBatch
            //
            this.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatch.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBatch.Location = new System.Drawing.Point(296, 38);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(90, 27);
            this.txtBatch.TabIndex = 6;
            this.txtBatch.Leave += new System.EventHandler(this.txtBatch_Leave);
            //
            // lblExpDate
            //
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblExpDate.Location = new System.Drawing.Point(394, 22);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Text = "Exp. Date";
            //
            // dtpExpiredDate
            //
            this.dtpExpiredDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpExpiredDate.Location = new System.Drawing.Point(394, 38);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(110, 27);
            this.dtpExpiredDate.TabIndex = 7;
            //
            // lblQty
            //
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblQty.Location = new System.Drawing.Point(512, 22);
            this.lblQty.Name = "lblQty";
            this.lblQty.Text = "Qty";
            //
            // txtQty
            //
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtQty.Location = new System.Drawing.Point(512, 38);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(60, 27);
            this.txtQty.TabIndex = 8;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            //
            // lblPrice
            //
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(580, 22);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Text = "Harga";
            //
            // txtPrice
            //
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPrice.Location = new System.Drawing.Point(580, 38);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(90, 27);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            //
            // lblDiscount
            //
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblDiscount.Location = new System.Drawing.Point(678, 22);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Text = "Disc %";
            //
            // txtDiscount
            //
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtDiscount.Location = new System.Drawing.Point(678, 38);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(60, 27);
            this.txtDiscount.TabIndex = 10;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            //
            // btnAddItem
            //
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(748, 34);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(80, 30);
            this.btnAddItem.TabIndex = 11;
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
                this.colPrice, this.colDisc, this.colSubTotal });
            this.dgvItems.Location = new System.Drawing.Point(8, 75);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(960, 268);
            this.dgvItems.TabIndex = 12;
            this.dgvItems.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvItems_UserDeletedRow);
            // hidden columns
            this.colProductId.Name = "colProductId"; this.colProductId.Visible = false; this.colProductId.Width = 1;
            this.colBatchId.Name = "colBatchId";   this.colBatchId.Visible = false;   this.colBatchId.Width = 1;
            this.colUomId.Name = "colUomId";       this.colUomId.Visible = false;     this.colUomId.Width = 1;
            // visible columns
            this.colProductCode.Name = "colProductCode"; this.colProductCode.HeaderText = "Kode";       this.colProductCode.Width = 80;
            this.colProductName.Name = "colProductName"; this.colProductName.HeaderText = "Nama Barang"; this.colProductName.Width = 220;
            this.colBatchCode.Name = "colBatchCode";     this.colBatchCode.HeaderText = "Batch";        this.colBatchCode.Width = 70;
            this.colExpDate.Name = "colExpDate";         this.colExpDate.HeaderText = "Exp.";           this.colExpDate.Width = 60;
            this.colQty.Name = "colQty";                 this.colQty.HeaderText = "Qty";                this.colQty.Width = 60;
            this.colQty.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colUomCode.Name = "colUomCode";         this.colUomCode.HeaderText = "UOM";            this.colUomCode.Width = 50;
            this.colPrice.Name = "colPrice";             this.colPrice.HeaderText = "Harga";            this.colPrice.Width = 90;
            this.colPrice.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDisc.Name = "colDisc";               this.colDisc.HeaderText = "Disc%";             this.colDisc.Width = 60;
            this.colDisc.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSubTotal.Name = "colSubTotal";       this.colSubTotal.HeaderText = "Subtotal";      this.colSubTotal.Width = 100;
            this.colSubTotal.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            //
            // pnlHidden
            //
            this.pnlHidden.Controls.Add(this.txtPOId);
            this.pnlHidden.Controls.Add(this.txtModifiedAt);
            this.pnlHidden.Location = new System.Drawing.Point(0, 720);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.Size = new System.Drawing.Size(400, 40);
            this.pnlHidden.TabIndex = 99;
            this.pnlHidden.Visible = false;
            //
            // txtPOId
            //
            this.txtPOId.Location = new System.Drawing.Point(0, 0);
            this.txtPOId.Name = "txtPOId";
            this.txtPOId.Size = new System.Drawing.Size(180, 27);
            this.txtPOId.TabIndex = 0;
            //
            // txtModifiedAt
            //
            this.txtModifiedAt.Location = new System.Drawing.Point(190, 0);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(180, 27);
            this.txtModifiedAt.TabIndex = 1;
            //
            // FrmPurchaseOrder
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 715);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlActions);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.pnlTotals);
            this.Controls.Add(this.gbItems);
            this.Controls.Add(this.pnlHidden);
            this.Name = "FrmPurchaseOrder";
            this.Text = "PURCHASE ORDER";
            this.Load += new System.EventHandler(this.FrmPurchaseOrder_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.pnlTotals.ResumeLayout(false);
            this.pnlTotals.PerformLayout();
            this.gbItems.ResumeLayout(false);
            this.gbItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlHidden.ResumeLayout(false);
            this.pnlHidden.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPONumberLabel;
        private System.Windows.Forms.Label lblPONumber;
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label lblSupplierPhone;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblExpectedDate;
        private System.Windows.Forms.DateTimePicker dtpExpectedDate;
        private System.Windows.Forms.Label lblReceivedDate;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Panel pnlTotals;
        private System.Windows.Forms.Label lblSubTotalLbl;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblVATLbl;
        private System.Windows.Forms.TextBox txtVAT;
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
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.Panel pnlHidden;
        private System.Windows.Forms.TextBox txtPOId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
