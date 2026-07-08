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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblPONumber = new System.Windows.Forms.Label();
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlItems = new System.Windows.Forms.Panel();
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblSubTotalLbl = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblVATLbl = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.lblTotalLbl = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlGridTop = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.pnlItemInput = new System.Windows.Forms.Panel();
            this.lblProduct = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.lblBatch = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.dtpExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.lblQty = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.lblQtyPreview = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.pnlHeaderSpacer = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblSupplierLbl = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.lblOrderDateLbl = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedDateLbl = new System.Windows.Forms.Label();
            this.dtpExpectedDate = new System.Windows.Forms.DateTimePicker();
            this.lblNotesLbl = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblSupplierAddressLbl = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.lblSupplierPhoneLbl = new System.Windows.Forms.Label();
            this.txtSupplierPhone = new System.Windows.Forms.TextBox();
            this.lblReceivedDateLbl = new System.Windows.Forms.Label();
            this.dtpReceivedDate = new System.Windows.Forms.DateTimePicker();
            this.pnlHidden = new System.Windows.Forms.Panel();
            this.txtPOId = new System.Windows.Forms.TextBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();
            this.pnlTop.SuspendLayout();
            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlGridTop.SuspendLayout();
            this.pnlItemInput.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlHidden.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlTop.Controls.Add(this.lblPONumber);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.btnFirst);
            this.pnlTop.Controls.Add(this.btnPrev);
            this.pnlTop.Controls.Add(this.btnNext);
            this.pnlTop.Controls.Add(this.btnLast);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1505, 68);
            this.pnlTop.TabIndex = 0;
            // 
            // lblPONumber
            // 
            this.lblPONumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblPONumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblPONumber.Location = new System.Drawing.Point(16, 12);
            this.lblPONumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPONumber.Name = "lblPONumber";
            this.lblPONumber.Size = new System.Drawing.Size(400, 32);
            this.lblPONumber.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(427, 16);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 19);
            this.lblStatus.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(941, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1196, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(77, 30);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnFirst.Location = new System.Drawing.Point(1284, 12);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(40, 30);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnPrev.Location = new System.Drawing.Point(1329, 12);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(40, 30);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnNext.Location = new System.Drawing.Point(1375, 12);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(40, 30);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnLast.Location = new System.Drawing.Point(1420, 12);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(40, 30);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // pnlTopSep
            // 
            this.pnlTopSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.pnlTopSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSep.Location = new System.Drawing.Point(0, 133);
            this.pnlTopSep.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopSep.Name = "pnlTopSep";
            this.pnlTopSep.Size = new System.Drawing.Size(1505, 1);
            this.pnlTopSep.TabIndex = 99;
            // 
            // pnlActionBar
            // 
            this.pnlActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.pnlActionBar.Controls.Add(this.btnClear);
            this.pnlActionBar.Controls.Add(this.btnAdd);
            this.pnlActionBar.Controls.Add(this.btnSave);
            this.pnlActionBar.Controls.Add(this.btnDel);
            this.pnlActionBar.Controls.Add(this.btnReload);
            this.pnlActionBar.Controls.Add(this.btnConfirm);
            this.pnlActionBar.Controls.Add(this.btnReceive);
            this.pnlActionBar.Controls.Add(this.btnCancel);
            this.pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionBar.Location = new System.Drawing.Point(0, 68);
            this.pnlActionBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActionBar.Name = "pnlActionBar";
            this.pnlActionBar.Size = new System.Drawing.Size(1505, 65);
            this.pnlActionBar.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
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
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(131, 9);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(251, 9);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(371, 9);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 34);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(491, 9);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(109, 34);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(611, 9);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 34);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.btnReceive.FlatAppearance.BorderSize = 0;
            this.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceive.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReceive.ForeColor = System.Drawing.Color.White;
            this.btnReceive.Location = new System.Drawing.Point(731, 9);
            this.btnReceive.Margin = new System.Windows.Forms.Padding(4);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(109, 34);
            this.btnReceive.TabIndex = 6;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = false;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(851, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlContent.Controls.Add(this.pnlItems);
            this.pnlContent.Controls.Add(this.pnlHeaderSpacer);
            this.pnlContent.Controls.Add(this.pnlHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 134);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlContent.Size = new System.Drawing.Size(1505, 746);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlItems
            // 
            this.pnlItems.BackColor = System.Drawing.Color.White;
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItems.Controls.Add(this.dgvItems);
            this.pnlItems.Controls.Add(this.pnlFooter);
            this.pnlItems.Controls.Add(this.pnlGridTop);
            this.pnlItems.Controls.Add(this.pnlItemInput);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Location = new System.Drawing.Point(11, 152);
            this.pnlItems.Margin = new System.Windows.Forms.Padding(4);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(1483, 584);
            this.pnlItems.TabIndex = 2;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgvItems.ColumnHeadersHeight = 30;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductId,
            this.colBatchId,
            this.colUomId,
            this.colProductCode,
            this.colProductName,
            this.colBatchCode,
            this.colExpDate,
            this.colQty,
            this.colUomCode,
            this.colPrice,
            this.colDisc,
            this.colSubTotal});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.dgvItems.Location = new System.Drawing.Point(0, 127);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersWidth = 20;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1481, 391);
            this.dgvItems.TabIndex = 2;
            this.dgvItems.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvItems_UserDeletedRow);
            // 
            // colProductId
            // 
            this.colProductId.HeaderText = "PID";
            this.colProductId.MinimumWidth = 6;
            this.colProductId.Name = "colProductId";
            this.colProductId.ReadOnly = true;
            this.colProductId.Visible = false;
            // 
            // colBatchId
            // 
            this.colBatchId.HeaderText = "BID";
            this.colBatchId.MinimumWidth = 6;
            this.colBatchId.Name = "colBatchId";
            this.colBatchId.ReadOnly = true;
            this.colBatchId.Visible = false;
            // 
            // colUomId
            // 
            this.colUomId.HeaderText = "UID";
            this.colUomId.MinimumWidth = 6;
            this.colUomId.Name = "colUomId";
            this.colUomId.ReadOnly = true;
            this.colUomId.Visible = false;
            // 
            // colProductCode
            // 
            this.colProductCode.FillWeight = 70F;
            this.colProductCode.HeaderText = "KODE BRG";
            this.colProductCode.MinimumWidth = 6;
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.ReadOnly = true;
            // 
            // colProductName
            // 
            this.colProductName.FillWeight = 200F;
            this.colProductName.HeaderText = "NAMA BARANG";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            this.colProductName.ReadOnly = true;
            // 
            // colBatchCode
            // 
            this.colBatchCode.FillWeight = 70F;
            this.colBatchCode.HeaderText = "BATCH";
            this.colBatchCode.MinimumWidth = 6;
            this.colBatchCode.Name = "colBatchCode";
            this.colBatchCode.ReadOnly = true;
            // 
            // colExpDate
            // 
            this.colExpDate.FillWeight = 65F;
            this.colExpDate.HeaderText = "EXP.";
            this.colExpDate.MinimumWidth = 6;
            this.colExpDate.Name = "colExpDate";
            this.colExpDate.ReadOnly = true;
            // 
            // colQty
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQty.DefaultCellStyle = dataGridViewCellStyle20;
            this.colQty.FillWeight = 50F;
            this.colQty.HeaderText = "QTY";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colUomCode
            // 
            this.colUomCode.FillWeight = 50F;
            this.colUomCode.HeaderText = "SAT";
            this.colUomCode.MinimumWidth = 6;
            this.colUomCode.Name = "colUomCode";
            this.colUomCode.ReadOnly = true;
            // 
            // colPrice
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colPrice.DefaultCellStyle = dataGridViewCellStyle21;
            this.colPrice.FillWeight = 80F;
            this.colPrice.HeaderText = "HARGA";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colDisc
            // 
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDisc.DefaultCellStyle = dataGridViewCellStyle22;
            this.colDisc.FillWeight = 55F;
            this.colDisc.HeaderText = "DISC%";
            this.colDisc.MinimumWidth = 6;
            this.colDisc.Name = "colDisc";
            this.colDisc.ReadOnly = true;
            // 
            // colSubTotal
            // 
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSubTotal.DefaultCellStyle = dataGridViewCellStyle23;
            this.colSubTotal.FillWeight = 85F;
            this.colSubTotal.HeaderText = "SUBTOTAL";
            this.colSubTotal.MinimumWidth = 6;
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.ReadOnly = true;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlFooter.Controls.Add(this.lblSubTotalLbl);
            this.pnlFooter.Controls.Add(this.txtSubTotal);
            this.pnlFooter.Controls.Add(this.lblVATLbl);
            this.pnlFooter.Controls.Add(this.txtVAT);
            this.pnlFooter.Controls.Add(this.lblTotalLbl);
            this.pnlFooter.Controls.Add(this.lblTotal);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 518);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1481, 64);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblSubTotalLbl
            // 
            this.lblSubTotalLbl.AutoSize = true;
            this.lblSubTotalLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSubTotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblSubTotalLbl.Location = new System.Drawing.Point(13, 7);
            this.lblSubTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotalLbl.Name = "lblSubTotalLbl";
            this.lblSubTotalLbl.Size = new System.Drawing.Size(51, 13);
            this.lblSubTotalLbl.TabIndex = 0;
            this.lblSubTotalLbl.Text = "Subtotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSubTotal.Location = new System.Drawing.Point(13, 27);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(199, 23);
            this.txtSubTotal.TabIndex = 1;
            this.txtSubTotal.Text = "0";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblVATLbl
            // 
            this.lblVATLbl.AutoSize = true;
            this.lblVATLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblVATLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblVATLbl.Location = new System.Drawing.Point(232, 7);
            this.lblVATLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVATLbl.Name = "lblVATLbl";
            this.lblVATLbl.Size = new System.Drawing.Size(57, 13);
            this.lblVATLbl.TabIndex = 2;
            this.lblVATLbl.Text = "PPN (11%)";
            // 
            // txtVAT
            // 
            this.txtVAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtVAT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVAT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtVAT.Location = new System.Drawing.Point(232, 27);
            this.txtVAT.Margin = new System.Windows.Forms.Padding(4);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.ReadOnly = true;
            this.txtVAT.Size = new System.Drawing.Size(173, 23);
            this.txtVAT.TabIndex = 3;
            this.txtVAT.Text = "0";
            this.txtVAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotalLbl
            // 
            this.lblTotalLbl.AutoSize = true;
            this.lblTotalLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTotalLbl.Location = new System.Drawing.Point(1000, 7);
            this.lblTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLbl.Name = "lblTotalLbl";
            this.lblTotalLbl.Size = new System.Drawing.Size(40, 13);
            this.lblTotalLbl.TabIndex = 4;
            this.lblTotalLbl.Text = "TOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblTotal.Location = new System.Drawing.Point(1000, 25);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(427, 37);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlGridTop
            // 
            this.pnlGridTop.BackColor = System.Drawing.Color.White;
            this.pnlGridTop.Controls.Add(this.lblGridTitle);
            this.pnlGridTop.Controls.Add(this.lblItemCount);
            this.pnlGridTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridTop.Location = new System.Drawing.Point(0, 88);
            this.pnlGridTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGridTop.Name = "pnlGridTop";
            this.pnlGridTop.Size = new System.Drawing.Size(1481, 39);
            this.pnlGridTop.TabIndex = 1;
            // 
            // lblGridTitle
            // 
            this.lblGridTitle.AutoSize = true;
            this.lblGridTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGridTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblGridTitle.Location = new System.Drawing.Point(13, 11);
            this.lblGridTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGridTitle.Name = "lblGridTitle";
            this.lblGridTitle.Size = new System.Drawing.Size(102, 15);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "DAFTAR ITEM PO";
            // 
            // lblItemCount
            // 
            this.lblItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblItemCount.Location = new System.Drawing.Point(1528, 11);
            this.lblItemCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(0, 15);
            this.lblItemCount.TabIndex = 1;
            // 
            // pnlItemInput
            // 
            this.pnlItemInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlItemInput.Controls.Add(this.lblProduct);
            this.pnlItemInput.Controls.Add(this.cbProduct);
            this.pnlItemInput.Controls.Add(this.lblBatch);
            this.pnlItemInput.Controls.Add(this.txtBatch);
            this.pnlItemInput.Controls.Add(this.lblExpDate);
            this.pnlItemInput.Controls.Add(this.dtpExpiredDate);
            this.pnlItemInput.Controls.Add(this.lblQty);
            this.pnlItemInput.Controls.Add(this.txtQty);
            this.pnlItemInput.Controls.Add(this.lblUnit);
            this.pnlItemInput.Controls.Add(this.cboUnit);
            this.pnlItemInput.Controls.Add(this.lblQtyPreview);
            this.pnlItemInput.Controls.Add(this.lblPrice);
            this.pnlItemInput.Controls.Add(this.txtPrice);
            this.pnlItemInput.Controls.Add(this.lblDiscount);
            this.pnlItemInput.Controls.Add(this.txtDiscount);
            this.pnlItemInput.Controls.Add(this.btnAddItem);
            this.pnlItemInput.Controls.Add(this.btnRemoveItem);
            this.pnlItemInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItemInput.Location = new System.Drawing.Point(0, 0);
            this.pnlItemInput.Margin = new System.Windows.Forms.Padding(4);
            this.pnlItemInput.Name = "pnlItemInput";
            this.pnlItemInput.Size = new System.Drawing.Size(1481, 88);
            this.pnlItemInput.TabIndex = 0;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblProduct.Location = new System.Drawing.Point(13, 16);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 15);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Barang";
            // 
            // cbProduct
            // 
            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbProduct.Location = new System.Drawing.Point(75, 11);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(265, 23);
            this.cbProduct.TabIndex = 1;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblBatch.Location = new System.Drawing.Point(20, 49);
            this.lblBatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(37, 15);
            this.lblBatch.TabIndex = 2;
            this.lblBatch.Text = "Batch";
            // 
            // txtBatch
            // 
            this.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBatch.Location = new System.Drawing.Point(75, 41);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(265, 23);
            this.txtBatch.TabIndex = 3;
            this.txtBatch.Leave += new System.EventHandler(this.txtBatch_Leave);
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblExpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblExpDate.Location = new System.Drawing.Point(356, 16);
            this.lblExpDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(55, 15);
            this.lblExpDate.TabIndex = 4;
            this.lblExpDate.Text = "Exp. Date";
            // 
            // dtpExpiredDate
            // 
            this.dtpExpiredDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExpiredDate.Location = new System.Drawing.Point(419, 13);
            this.dtpExpiredDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(132, 23);
            this.dtpExpiredDate.TabIndex = 5;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblQty.Location = new System.Drawing.Point(555, 18);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 15);
            this.lblQty.TabIndex = 6;
            this.lblQty.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQty.Location = new System.Drawing.Point(582, 13);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(66, 23);
            this.txtQty.TabIndex = 7;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblUnit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblUnit.Location = new System.Drawing.Point(656, 17);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(55, 15);
            this.lblUnit.TabIndex = 14;
            this.lblUnit.Text = "Kemasan";
            // 
            // cboUnit
            // 
            this.cboUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cboUnit.Location = new System.Drawing.Point(743, 11);
            this.cboUnit.Margin = new System.Windows.Forms.Padding(4);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(150, 23);
            this.cboUnit.TabIndex = 8;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // lblQtyPreview
            // 
            this.lblQtyPreview.AutoSize = true;
            this.lblQtyPreview.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblQtyPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.lblQtyPreview.Location = new System.Drawing.Point(746, 44);
            this.lblQtyPreview.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQtyPreview.Name = "lblQtyPreview";
            this.lblQtyPreview.Size = new System.Drawing.Size(10, 15);
            this.lblQtyPreview.TabIndex = 16;
            this.lblQtyPreview.Text = " ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblPrice.Location = new System.Drawing.Point(911, 16);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 15);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Harga";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(965, 11);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 23);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblDiscount.Location = new System.Drawing.Point(1098, 16);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(42, 15);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Disc %";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscount.Location = new System.Drawing.Point(1151, 11);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(73, 23);
            this.txtDiscount.TabIndex = 11;
            this.txtDiscount.Text = "0";
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(1232, 8);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(112, 32);
            this.btnAddItem.TabIndex = 12;
            this.btnAddItem.Text = "+ Tambah";
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.White;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRemoveItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnRemoveItem.Location = new System.Drawing.Point(1352, 8);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(96, 32);
            this.btnRemoveItem.TabIndex = 13;
            this.btnRemoveItem.Text = "- Hapus";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // pnlHeaderSpacer
            // 
            this.pnlHeaderSpacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlHeaderSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSpacer.Location = new System.Drawing.Point(11, 142);
            this.pnlHeaderSpacer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeaderSpacer.Name = "pnlHeaderSpacer";
            this.pnlHeaderSpacer.Size = new System.Drawing.Size(1483, 10);
            this.pnlHeaderSpacer.TabIndex = 98;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.lblSupplierLbl);
            this.pnlHeader.Controls.Add(this.cbSupplier);
            this.pnlHeader.Controls.Add(this.lblOrderDateLbl);
            this.pnlHeader.Controls.Add(this.dtpOrderDate);
            this.pnlHeader.Controls.Add(this.lblExpectedDateLbl);
            this.pnlHeader.Controls.Add(this.dtpExpectedDate);
            this.pnlHeader.Controls.Add(this.lblNotesLbl);
            this.pnlHeader.Controls.Add(this.txtNotes);
            this.pnlHeader.Controls.Add(this.lblSupplierAddressLbl);
            this.pnlHeader.Controls.Add(this.txtSupplierAddress);
            this.pnlHeader.Controls.Add(this.lblSupplierPhoneLbl);
            this.pnlHeader.Controls.Add(this.txtSupplierPhone);
            this.pnlHeader.Controls.Add(this.lblReceivedDateLbl);
            this.pnlHeader.Controls.Add(this.dtpReceivedDate);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(11, 10);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1483, 132);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblHeaderTitle.Location = new System.Drawing.Point(13, 7);
            this.lblHeaderTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(98, 12);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "HEADER DOKUMEN";
            // 
            // lblSupplierLbl
            // 
            this.lblSupplierLbl.AutoSize = true;
            this.lblSupplierLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSupplierLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblSupplierLbl.Location = new System.Drawing.Point(13, 25);
            this.lblSupplierLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierLbl.Name = "lblSupplierLbl";
            this.lblSupplierLbl.Size = new System.Drawing.Size(107, 15);
            this.lblSupplierLbl.TabIndex = 1;
            this.lblSupplierLbl.Text = "Principal / Supplier";
            // 
            // cbSupplier
            // 
            this.cbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSupplier.Location = new System.Drawing.Point(13, 44);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(4);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(385, 23);
            this.cbSupplier.TabIndex = 2;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);
            // 
            // lblOrderDateLbl
            // 
            this.lblOrderDateLbl.AutoSize = true;
            this.lblOrderDateLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblOrderDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblOrderDateLbl.Location = new System.Drawing.Point(419, 25);
            this.lblOrderDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrderDateLbl.Name = "lblOrderDateLbl";
            this.lblOrderDateLbl.Size = new System.Drawing.Size(68, 15);
            this.lblOrderDateLbl.TabIndex = 3;
            this.lblOrderDateLbl.Text = "Tanggal PO";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(419, 44);
            this.dtpOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(159, 23);
            this.dtpOrderDate.TabIndex = 4;
            // 
            // lblExpectedDateLbl
            // 
            this.lblExpectedDateLbl.AutoSize = true;
            this.lblExpectedDateLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblExpectedDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblExpectedDateLbl.Location = new System.Drawing.Point(597, 25);
            this.lblExpectedDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpectedDateLbl.Name = "lblExpectedDateLbl";
            this.lblExpectedDateLbl.Size = new System.Drawing.Size(76, 15);
            this.lblExpectedDateLbl.TabIndex = 5;
            this.lblExpectedDateLbl.Text = "Estimasi Tiba";
            // 
            // dtpExpectedDate
            // 
            this.dtpExpectedDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExpectedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpectedDate.Location = new System.Drawing.Point(597, 44);
            this.dtpExpectedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpectedDate.Name = "dtpExpectedDate";
            this.dtpExpectedDate.Size = new System.Drawing.Size(159, 23);
            this.dtpExpectedDate.TabIndex = 6;
            // 
            // lblNotesLbl
            // 
            this.lblNotesLbl.AutoSize = true;
            this.lblNotesLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNotesLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblNotesLbl.Location = new System.Drawing.Point(776, 25);
            this.lblNotesLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNotesLbl.Name = "lblNotesLbl";
            this.lblNotesLbl.Size = new System.Drawing.Size(48, 15);
            this.lblNotesLbl.TabIndex = 7;
            this.lblNotesLbl.Text = "Catatan";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNotes.Location = new System.Drawing.Point(776, 44);
            this.txtNotes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(672, 27);
            this.txtNotes.TabIndex = 8;
            // 
            // lblSupplierAddressLbl
            // 
            this.lblSupplierAddressLbl.AutoSize = true;
            this.lblSupplierAddressLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSupplierAddressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblSupplierAddressLbl.Location = new System.Drawing.Point(13, 79);
            this.lblSupplierAddressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierAddressLbl.Name = "lblSupplierAddressLbl";
            this.lblSupplierAddressLbl.Size = new System.Drawing.Size(91, 15);
            this.lblSupplierAddressLbl.TabIndex = 9;
            this.lblSupplierAddressLbl.Text = "Alamat Supplier";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSupplierAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSupplierAddress.Location = new System.Drawing.Point(13, 98);
            this.txtSupplierAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.ReadOnly = true;
            this.txtSupplierAddress.Size = new System.Drawing.Size(386, 23);
            this.txtSupplierAddress.TabIndex = 99;
            // 
            // lblSupplierPhoneLbl
            // 
            this.lblSupplierPhoneLbl.AutoSize = true;
            this.lblSupplierPhoneLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblSupplierPhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblSupplierPhoneLbl.Location = new System.Drawing.Point(419, 79);
            this.lblSupplierPhoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplierPhoneLbl.Name = "lblSupplierPhoneLbl";
            this.lblSupplierPhoneLbl.Size = new System.Drawing.Size(49, 15);
            this.lblSupplierPhoneLbl.TabIndex = 10;
            this.lblSupplierPhoneLbl.Text = "Telepon";
            // 
            // txtSupplierPhone
            // 
            this.txtSupplierPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtSupplierPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSupplierPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSupplierPhone.Location = new System.Drawing.Point(419, 98);
            this.txtSupplierPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplierPhone.Name = "txtSupplierPhone";
            this.txtSupplierPhone.ReadOnly = true;
            this.txtSupplierPhone.Size = new System.Drawing.Size(159, 23);
            this.txtSupplierPhone.TabIndex = 99;
            // 
            // lblReceivedDateLbl
            // 
            this.lblReceivedDateLbl.AutoSize = true;
            this.lblReceivedDateLbl.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblReceivedDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.lblReceivedDateLbl.Location = new System.Drawing.Point(597, 79);
            this.lblReceivedDateLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReceivedDateLbl.Name = "lblReceivedDateLbl";
            this.lblReceivedDateLbl.Size = new System.Drawing.Size(65, 15);
            this.lblReceivedDateLbl.TabIndex = 11;
            this.lblReceivedDateLbl.Text = "Tgl. Terima";
            // 
            // dtpReceivedDate
            // 
            this.dtpReceivedDate.Enabled = false;
            this.dtpReceivedDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpReceivedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReceivedDate.Location = new System.Drawing.Point(597, 98);
            this.dtpReceivedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpReceivedDate.Name = "dtpReceivedDate";
            this.dtpReceivedDate.Size = new System.Drawing.Size(159, 23);
            this.dtpReceivedDate.TabIndex = 99;
            // 
            // pnlHidden
            // 
            this.pnlHidden.Controls.Add(this.txtPOId);
            this.pnlHidden.Controls.Add(this.txtModifiedAt);
            this.pnlHidden.Location = new System.Drawing.Point(0, 0);
            this.pnlHidden.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.Size = new System.Drawing.Size(0, 0);
            this.pnlHidden.TabIndex = 99;
            this.pnlHidden.Visible = false;
            // 
            // txtPOId
            // 
            this.txtPOId.Location = new System.Drawing.Point(0, 0);
            this.txtPOId.Margin = new System.Windows.Forms.Padding(4);
            this.txtPOId.Name = "txtPOId";
            this.txtPOId.Size = new System.Drawing.Size(245, 22);
            this.txtPOId.TabIndex = 0;
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.Location = new System.Drawing.Point(260, 0);
            this.txtModifiedAt.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(309, 22);
            this.txtModifiedAt.TabIndex = 1;
            // 
            // FrmPurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1505, 880);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopSep);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHidden);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPurchaseOrder";
            this.Text = "PEMBELIAN";
            this.Load += new System.EventHandler(this.FrmPurchaseOrder_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlActionBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlGridTop.ResumeLayout(false);
            this.pnlGridTop.PerformLayout();
            this.pnlItemInput.ResumeLayout(false);
            this.pnlItemInput.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHidden.ResumeLayout(false);
            this.pnlHidden.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblPONumber;
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
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lblSupplierLbl;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.Label lblOrderDateLbl;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblExpectedDateLbl;
        private System.Windows.Forms.DateTimePicker dtpExpectedDate;
        private System.Windows.Forms.Label lblNotesLbl;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblSupplierAddressLbl;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label lblSupplierPhoneLbl;
        private System.Windows.Forms.TextBox txtSupplierPhone;
        private System.Windows.Forms.Label lblReceivedDateLbl;
        private System.Windows.Forms.DateTimePicker dtpReceivedDate;
        private System.Windows.Forms.Panel pnlHeaderSpacer;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlItemInput;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.DateTimePicker dtpExpiredDate;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.Label lblQtyPreview;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDisc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubTotal;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblSubTotalLbl;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label lblVATLbl;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label lblTotalLbl;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlHidden;
        private System.Windows.Forms.TextBox txtPOId;
        private System.Windows.Forms.TextBox txtModifiedAt;
    }
}
