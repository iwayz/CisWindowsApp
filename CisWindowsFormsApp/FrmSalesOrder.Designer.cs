namespace CisWindowsFormsApp
{
    partial class FrmSalesOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblSalesNo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.txtSalesNo = new System.Windows.Forms.TextBox();
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
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.dgvSalesOrderItem = new System.Windows.Forms.DataGridView();
            this.productId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.batchCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uomCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtExtraDiscount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTaxBaseAmount = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtValueAddedTaxAmount = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbPic = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlGridTop = new System.Windows.Forms.Panel();
            this.lblGridTitle = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.pnlItemInput = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.pnlNote = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNoteDetail = new System.Windows.Forms.Label();
            this.pnlHeaderSpacer = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSalesman = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTermOfPayment = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.dtpSalesOrderDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.cbSalesArea = new System.Windows.Forms.ComboBox();
            this.pnlHiddenFields = new System.Windows.Forms.Panel();
            this.txtSalesOrderId = new System.Windows.Forms.TextBox();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();
            this.txtRealSalesNo = new System.Windows.Forms.TextBox();
            this.toolTipSales = new System.Windows.Forms.ToolTip(this.components);
            this.pnlTop.SuspendLayout();
            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderItem)).BeginInit();
            this.pnlFooter.SuspendLayout();
            this.pnlGridTop.SuspendLayout();
            this.pnlItemInput.SuspendLayout();
            this.pnlNote.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlHiddenFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlTop.Controls.Add(this.lblSalesNo);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.lblMark);
            this.pnlTop.Controls.Add(this.txtSalesNo);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.btnFirst);
            this.pnlTop.Controls.Add(this.btnPrev);
            this.pnlTop.Controls.Add(this.btnNext);
            this.pnlTop.Controls.Add(this.btnLast);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1467, 54);
            this.pnlTop.TabIndex = 0;
            // 
            // lblSalesNo
            // 
            this.lblSalesNo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblSalesNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblSalesNo.Location = new System.Drawing.Point(16, 12);
            this.lblSalesNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesNo.Name = "lblSalesNo";
            this.lblSalesNo.Size = new System.Drawing.Size(427, 32);
            this.lblSalesNo.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(456, 16);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 19);
            this.lblStatus.TabIndex = 1;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.BackColor = System.Drawing.Color.Red;
            this.lblMark.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblMark.ForeColor = System.Drawing.Color.White;
            this.lblMark.Location = new System.Drawing.Point(707, 12);
            this.lblMark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMark.Name = "lblMark";
            this.lblMark.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.lblMark.Size = new System.Drawing.Size(82, 24);
            this.lblMark.TabIndex = 2;
            this.lblMark.Text = "DELETED";
            this.lblMark.Visible = false;
            // 
            // txtSalesNo
            // 
            this.txtSalesNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSalesNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSalesNo.Location = new System.Drawing.Point(941, 12);
            this.txtSalesNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalesNo.Name = "txtSalesNo";
            this.txtSalesNo.Size = new System.Drawing.Size(245, 23);
            this.txtSalesNo.TabIndex = 3;
            this.toolTipSales.SetToolTip(this.txtSalesNo, "Tambahkan digit tahun pada awal No. Faktur. Contoh: 23S1-090015");
            this.txtSalesNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalesNo_KeyPress);
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
            this.btnSearch.TabIndex = 4;
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
            this.btnFirst.TabIndex = 5;
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
            this.btnPrev.TabIndex = 6;
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
            this.btnNext.TabIndex = 7;
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
            this.btnLast.TabIndex = 8;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // pnlTopSep
            // 
            this.pnlTopSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.pnlTopSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSep.Location = new System.Drawing.Point(0, 106);
            this.pnlTopSep.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTopSep.Name = "pnlTopSep";
            this.pnlTopSep.Size = new System.Drawing.Size(1467, 1);
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
            this.pnlActionBar.Controls.Add(this.btnInvoice);
            this.pnlActionBar.Controls.Add(this.btnPost);
            this.pnlActionBar.Controls.Add(this.btnCancel);
            this.pnlActionBar.Controls.Add(this.btnPrint);
            this.pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionBar.Location = new System.Drawing.Point(0, 54);
            this.pnlActionBar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlActionBar.Name = "pnlActionBar";
            this.pnlActionBar.Size = new System.Drawing.Size(1467, 52);
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
            this.btnAdd.Location = new System.Drawing.Point(141, 9);
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
            this.btnSave.Location = new System.Drawing.Point(261, 9);
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
            this.btnDel.Location = new System.Drawing.Point(381, 9);
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
            this.btnReload.Location = new System.Drawing.Point(501, 9);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(109, 34);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.Location = new System.Drawing.Point(621, 9);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(109, 34);
            this.btnInvoice.TabIndex = 5;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = false;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(80)))), ((int)(((byte)(16)))));
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(741, 9);
            this.btnPost.Margin = new System.Windows.Forms.Padding(4);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(109, 34);
            this.btnPost.TabIndex = 6;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(861, 9);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 34);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(981, 9);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(109, 34);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlContent.Controls.Add(this.pnlItems);
            this.pnlContent.Controls.Add(this.pnlNote);
            this.pnlContent.Controls.Add(this.pnlHeaderSpacer);
            this.pnlContent.Controls.Add(this.pnlHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 107);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlContent.Size = new System.Drawing.Size(1467, 773);
            this.pnlContent.TabIndex = 2;
            // 
            // pnlItems
            // 
            this.pnlItems.BackColor = System.Drawing.Color.White;
            this.pnlItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlItems.Controls.Add(this.dgvSalesOrderItem);
            this.pnlItems.Controls.Add(this.pnlFooter);
            this.pnlItems.Controls.Add(this.pnlGridTop);
            this.pnlItems.Controls.Add(this.pnlItemInput);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Location = new System.Drawing.Point(11, 191);
            this.pnlItems.Margin = new System.Windows.Forms.Padding(4);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(1445, 572);
            this.pnlItems.TabIndex = 2;
            // 
            // dgvSalesOrderItem
            // 
            this.dgvSalesOrderItem.AllowUserToAddRows = false;
            this.dgvSalesOrderItem.AllowUserToDeleteRows = false;
            this.dgvSalesOrderItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesOrderItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvSalesOrderItem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSalesOrderItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvSalesOrderItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSalesOrderItem.ColumnHeadersHeight = 30;
            this.dgvSalesOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSalesOrderItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productId,
            this.productCode,
            this.productName,
            this.batchId,
            this.batchCode,
            this.expDate,
            this.qty,
            this.uomId,
            this.uomCode,
            this.price,
            this.discPercent,
            this.subTotal,
            this.priceReal});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(110)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalesOrderItem.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSalesOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesOrderItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(243)))));
            this.dgvSalesOrderItem.Location = new System.Drawing.Point(0, 91);
            this.dgvSalesOrderItem.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSalesOrderItem.Name = "dgvSalesOrderItem";
            this.dgvSalesOrderItem.ReadOnly = true;
            this.dgvSalesOrderItem.RowHeadersWidth = 20;
            this.dgvSalesOrderItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOrderItem.Size = new System.Drawing.Size(1443, 415);
            this.dgvSalesOrderItem.TabIndex = 2;
            this.dgvSalesOrderItem.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvSalesOrderItem_UserDeletedRow);
            // 
            // productId
            // 
            this.productId.HeaderText = "PRODUCT ID";
            this.productId.Name = "productId";
            this.productId.ReadOnly = true;
            this.productId.Visible = false;
            // 
            // productCode
            // 
            this.productCode.FillWeight = 80F;
            this.productCode.HeaderText = "KODE BRG";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            // 
            // productName
            // 
            this.productName.FillWeight = 210F;
            this.productName.HeaderText = "NAMA BARANG";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            // 
            // batchId
            // 
            this.batchId.HeaderText = "BATCH ID";
            this.batchId.Name = "batchId";
            this.batchId.ReadOnly = true;
            this.batchId.Visible = false;
            // 
            // batchCode
            // 
            this.batchCode.FillWeight = 75F;
            this.batchCode.HeaderText = "BATCH";
            this.batchCode.Name = "batchCode";
            this.batchCode.ReadOnly = true;
            // 
            // expDate
            // 
            this.expDate.FillWeight = 80F;
            this.expDate.HeaderText = "EXP. DATE";
            this.expDate.Name = "expDate";
            this.expDate.ReadOnly = true;
            // 
            // qty
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qty.DefaultCellStyle = dataGridViewCellStyle5;
            this.qty.FillWeight = 50F;
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            // 
            // uomId
            // 
            this.uomId.HeaderText = "UOM ID";
            this.uomId.Name = "uomId";
            this.uomId.ReadOnly = true;
            this.uomId.Visible = false;
            // 
            // uomCode
            // 
            this.uomCode.FillWeight = 50F;
            this.uomCode.HeaderText = "SAT";
            this.uomCode.Name = "uomCode";
            this.uomCode.ReadOnly = true;
            // 
            // price
            // 
            this.price.DefaultCellStyle = dataGridViewCellStyle5;
            this.price.FillWeight = 75F;
            this.price.HeaderText = "HARGA";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // discPercent
            // 
            this.discPercent.FillWeight = 55F;
            this.discPercent.HeaderText = "DISKON";
            this.discPercent.Name = "discPercent";
            this.discPercent.ReadOnly = true;
            // 
            // subTotal
            // 
            this.subTotal.DefaultCellStyle = dataGridViewCellStyle5;
            this.subTotal.FillWeight = 90F;
            this.subTotal.HeaderText = "JML. HARGA";
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            // 
            // priceReal
            // 
            this.priceReal.HeaderText = "PRICEREAL";
            this.priceReal.Name = "priceReal";
            this.priceReal.ReadOnly = true;
            this.priceReal.Visible = false;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlFooter.Controls.Add(this.label14);
            this.pnlFooter.Controls.Add(this.txtSubTotal);
            this.pnlFooter.Controls.Add(this.label16);
            this.pnlFooter.Controls.Add(this.txtExtraDiscount);
            this.pnlFooter.Controls.Add(this.label17);
            this.pnlFooter.Controls.Add(this.txtTaxBaseAmount);
            this.pnlFooter.Controls.Add(this.lblTax);
            this.pnlFooter.Controls.Add(this.txtValueAddedTaxAmount);
            this.pnlFooter.Controls.Add(this.label23);
            this.pnlFooter.Controls.Add(this.cbPic);
            this.pnlFooter.Controls.Add(this.label13);
            this.pnlFooter.Controls.Add(this.lblTotal);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 506);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1443, 64);
            this.pnlFooter.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label14.Location = new System.Drawing.Point(13, 7);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Total Harga";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSubTotal.Location = new System.Drawing.Point(13, 27);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(157, 23);
            this.txtSubTotal.TabIndex = 1;
            this.txtSubTotal.Text = "0";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotal.Enter += new System.EventHandler(this.txtExtraDiscount_Enter);
            this.txtSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraDiscount_KeyPress);
            this.txtSubTotal.Leave += new System.EventHandler(this.txtExtraDiscount_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label16.Location = new System.Drawing.Point(187, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "Ekstra Diskon";
            // 
            // txtExtraDiscount
            // 
            this.txtExtraDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtraDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtExtraDiscount.Location = new System.Drawing.Point(187, 27);
            this.txtExtraDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtraDiscount.Name = "txtExtraDiscount";
            this.txtExtraDiscount.Size = new System.Drawing.Size(133, 23);
            this.txtExtraDiscount.TabIndex = 3;
            this.txtExtraDiscount.Text = "0";
            this.txtExtraDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExtraDiscount.Enter += new System.EventHandler(this.txtExtraDiscount_Enter);
            this.txtExtraDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraDiscount_KeyPress);
            this.txtExtraDiscount.Leave += new System.EventHandler(this.txtExtraDiscount_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label17.Location = new System.Drawing.Point(336, 7);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Total DPP";
            // 
            // txtTaxBaseAmount
            // 
            this.txtTaxBaseAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxBaseAmount.Enabled = false;
            this.txtTaxBaseAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTaxBaseAmount.Location = new System.Drawing.Point(336, 27);
            this.txtTaxBaseAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaxBaseAmount.Name = "txtTaxBaseAmount";
            this.txtTaxBaseAmount.Size = new System.Drawing.Size(133, 23);
            this.txtTaxBaseAmount.TabIndex = 5;
            this.txtTaxBaseAmount.Text = "0";
            this.txtTaxBaseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxBaseAmount.Enter += new System.EventHandler(this.txtExtraDiscount_Enter);
            this.txtTaxBaseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraDiscount_KeyPress);
            this.txtTaxBaseAmount.Leave += new System.EventHandler(this.txtExtraDiscount_Leave);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblTax.Location = new System.Drawing.Point(485, 7);
            this.lblTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(51, 13);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "PPN 11%";
            // 
            // txtValueAddedTaxAmount
            // 
            this.txtValueAddedTaxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValueAddedTaxAmount.Enabled = false;
            this.txtValueAddedTaxAmount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtValueAddedTaxAmount.Location = new System.Drawing.Point(485, 27);
            this.txtValueAddedTaxAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueAddedTaxAmount.Name = "txtValueAddedTaxAmount";
            this.txtValueAddedTaxAmount.Size = new System.Drawing.Size(133, 23);
            this.txtValueAddedTaxAmount.TabIndex = 7;
            this.txtValueAddedTaxAmount.Text = "0";
            this.txtValueAddedTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValueAddedTaxAmount.Enter += new System.EventHandler(this.txtExtraDiscount_Enter);
            this.txtValueAddedTaxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraDiscount_KeyPress);
            this.txtValueAddedTaxAmount.Leave += new System.EventHandler(this.txtExtraDiscount_Leave);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label23.Location = new System.Drawing.Point(635, 7);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(109, 13);
            this.label23.TabIndex = 8;
            this.label23.Text = "Penanggung Jawab";
            // 
            // cbPic
            // 
            this.cbPic.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPic.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbPic.Location = new System.Drawing.Point(635, 27);
            this.cbPic.Margin = new System.Windows.Forms.Padding(4);
            this.cbPic.Name = "cbPic";
            this.cbPic.Size = new System.Drawing.Size(245, 23);
            this.cbPic.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label13.Location = new System.Drawing.Point(1000, 7);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "TOTAL TAGIHAN:";
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblTotal.Location = new System.Drawing.Point(1103, 7);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(209, 43);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "999.999.999";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlGridTop
            // 
            this.pnlGridTop.BackColor = System.Drawing.Color.White;
            this.pnlGridTop.Controls.Add(this.lblGridTitle);
            this.pnlGridTop.Controls.Add(this.lblItemCount);
            this.pnlGridTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridTop.Location = new System.Drawing.Point(0, 52);
            this.pnlGridTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlGridTop.Name = "pnlGridTop";
            this.pnlGridTop.Size = new System.Drawing.Size(1443, 39);
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
            this.lblGridTitle.Size = new System.Drawing.Size(131, 15);
            this.lblGridTitle.TabIndex = 0;
            this.lblGridTitle.Text = "DAFTAR ITEM FAKTUR";
            // 
            // lblItemCount
            // 
            this.lblItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.lblItemCount.Location = new System.Drawing.Point(1197, 11);
            this.lblItemCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(0, 15);
            this.lblItemCount.TabIndex = 1;
            // 
            // pnlItemInput
            // 
            this.pnlItemInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlItemInput.Controls.Add(this.label5);
            this.pnlItemInput.Controls.Add(this.cbProduct);
            this.pnlItemInput.Controls.Add(this.label10);
            this.pnlItemInput.Controls.Add(this.txtBatch);
            this.pnlItemInput.Controls.Add(this.label7);
            this.pnlItemInput.Controls.Add(this.dtpExpiredDate);
            this.pnlItemInput.Controls.Add(this.label8);
            this.pnlItemInput.Controls.Add(this.txtQty);
            this.pnlItemInput.Controls.Add(this.label6);
            this.pnlItemInput.Controls.Add(this.txtPrice);
            this.pnlItemInput.Controls.Add(this.label11);
            this.pnlItemInput.Controls.Add(this.txtDiscount);
            this.pnlItemInput.Controls.Add(this.btnAddItem);
            this.pnlItemInput.Controls.Add(this.btnRemoveItem);
            this.pnlItemInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItemInput.Location = new System.Drawing.Point(0, 0);
            this.pnlItemInput.Margin = new System.Windows.Forms.Padding(4);
            this.pnlItemInput.Name = "pnlItemInput";
            this.pnlItemInput.Size = new System.Drawing.Size(1443, 52);
            this.pnlItemInput.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Barang";
            // 
            // cbProduct
            // 
            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbProduct.Location = new System.Drawing.Point(75, 11);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(252, 23);
            this.cbProduct.TabIndex = 1;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label10.Location = new System.Drawing.Point(347, 16);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 2;
            this.label10.Text = "Batch";
            // 
            // txtBatch
            // 
            this.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBatch.Location = new System.Drawing.Point(395, 11);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(106, 23);
            this.txtBatch.TabIndex = 3;
            this.txtBatch.Leave += new System.EventHandler(this.txtBatch_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label7.Location = new System.Drawing.Point(515, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tgl. Ked.";
            // 
            // dtpExpiredDate
            // 
            this.dtpExpiredDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiredDate.Location = new System.Drawing.Point(584, 11);
            this.dtpExpiredDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(132, 23);
            this.dtpExpiredDate.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label8.Location = new System.Drawing.Point(731, 16);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQty.Location = new System.Drawing.Point(760, 11);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtQty.MaxLength = 6;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(73, 23);
            this.txtQty.TabIndex = 7;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label6.Location = new System.Drawing.Point(848, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Harga (HNA)";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(949, 11);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(119, 23);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label11.Location = new System.Drawing.Point(1085, 16);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 15);
            this.label11.TabIndex = 10;
            this.label11.Text = "Disc.(%)";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscount.Location = new System.Drawing.Point(1141, 11);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.MaxLength = 5;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(63, 23);
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
            this.btnAddItem.Location = new System.Drawing.Point(1216, 8);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(96, 28);
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
            this.btnRemoveItem.Location = new System.Drawing.Point(1320, 8);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(96, 28);
            this.btnRemoveItem.TabIndex = 13;
            this.btnRemoveItem.Text = "- Hapus";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // pnlNote
            // 
            this.pnlNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(220)))));
            this.pnlNote.Controls.Add(this.label15);
            this.pnlNote.Controls.Add(this.lblNoteDetail);
            this.pnlNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNote.Location = new System.Drawing.Point(11, 152);
            this.pnlNote.Margin = new System.Windows.Forms.Padding(4);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(1445, 39);
            this.pnlNote.TabIndex = 97;
            this.pnlNote.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.label15.Location = new System.Drawing.Point(11, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "PERHATIAN!";
            // 
            // lblNoteDetail
            // 
            this.lblNoteDetail.AutoSize = true;
            this.lblNoteDetail.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblNoteDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.lblNoteDetail.Location = new System.Drawing.Point(107, 10);
            this.lblNoteDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoteDetail.Name = "lblNoteDetail";
            this.lblNoteDetail.Size = new System.Drawing.Size(66, 15);
            this.lblNoteDetail.TabIndex = 1;
            this.lblNoteDetail.Text = "Note Detail";
            // 
            // pnlHeaderSpacer
            // 
            this.pnlHeaderSpacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.pnlHeaderSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSpacer.Location = new System.Drawing.Point(11, 142);
            this.pnlHeaderSpacer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeaderSpacer.Name = "pnlHeaderSpacer";
            this.pnlHeaderSpacer.Size = new System.Drawing.Size(1445, 10);
            this.pnlHeaderSpacer.TabIndex = 98;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblHeaderTitle);
            this.pnlHeader.Controls.Add(this.label9);
            this.pnlHeader.Controls.Add(this.cbCustomer);
            this.pnlHeader.Controls.Add(this.label4);
            this.pnlHeader.Controls.Add(this.cbSalesman);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.cbTermOfPayment);
            this.pnlHeader.Controls.Add(this.label27);
            this.pnlHeader.Controls.Add(this.dtpSalesOrderDate);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.dtpDueDate);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.txtDeliveryAddress);
            this.pnlHeader.Controls.Add(this.label20);
            this.pnlHeader.Controls.Add(this.cbProvince);
            this.pnlHeader.Controls.Add(this.label21);
            this.pnlHeader.Controls.Add(this.cbDistrict);
            this.pnlHeader.Controls.Add(this.label29);
            this.pnlHeader.Controls.Add(this.cbSalesArea);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(11, 10);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1445, 132);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label9.Location = new System.Drawing.Point(13, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Kode Pelanggan";
            // 
            // cbCustomer
            // 
            this.cbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbCustomer.Location = new System.Drawing.Point(13, 44);
            this.cbCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(252, 23);
            this.cbCustomer.TabIndex = 2;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label4.Location = new System.Drawing.Point(285, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Salesman";
            // 
            // cbSalesman
            // 
            this.cbSalesman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSalesman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSalesman.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSalesman.Location = new System.Drawing.Point(285, 44);
            this.cbSalesman.Margin = new System.Windows.Forms.Padding(4);
            this.cbSalesman.Name = "cbSalesman";
            this.cbSalesman.Size = new System.Drawing.Size(205, 23);
            this.cbSalesman.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label1.Location = new System.Drawing.Point(511, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Term of Payment";
            // 
            // cbTermOfPayment
            // 
            this.cbTermOfPayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTermOfPayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTermOfPayment.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbTermOfPayment.Location = new System.Drawing.Point(511, 44);
            this.cbTermOfPayment.Margin = new System.Windows.Forms.Padding(4);
            this.cbTermOfPayment.Name = "cbTermOfPayment";
            this.cbTermOfPayment.Size = new System.Drawing.Size(185, 23);
            this.cbTermOfPayment.TabIndex = 6;
            this.cbTermOfPayment.SelectedIndexChanged += new System.EventHandler(this.cbTermOfPayment_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label27.Location = new System.Drawing.Point(13, 79);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 15);
            this.label27.TabIndex = 13;
            this.label27.Text = "Tgl. Faktur";
            // 
            // dtpSalesOrderDate
            // 
            this.dtpSalesOrderDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSalesOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSalesOrderDate.Location = new System.Drawing.Point(13, 98);
            this.dtpSalesOrderDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSalesOrderDate.Name = "dtpSalesOrderDate";
            this.dtpSalesOrderDate.Size = new System.Drawing.Size(159, 23);
            this.dtpSalesOrderDate.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label3.Location = new System.Drawing.Point(192, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tgl. Jatuh Tempo";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(192, 98);
            this.dtpDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(159, 23);
            this.dtpDueDate.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label2.Location = new System.Drawing.Point(723, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Alamat Kirim";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDeliveryAddress.Location = new System.Drawing.Point(723, 44);
            this.txtDeliveryAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeliveryAddress.Multiline = true;
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(235, 76);
            this.txtDeliveryAddress.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label20.Location = new System.Drawing.Point(969, 24);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 15);
            this.label20.TabIndex = 9;
            this.label20.Text = "Provinsi";
            // 
            // cbProvince
            // 
            this.cbProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProvince.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbProvince.Location = new System.Drawing.Point(969, 43);
            this.cbProvince.Margin = new System.Windows.Forms.Padding(4);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(205, 23);
            this.cbProvince.TabIndex = 10;
            this.cbProvince.SelectedIndexChanged += new System.EventHandler(this.cbProvince_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label21.Location = new System.Drawing.Point(1195, 24);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 15);
            this.label21.TabIndex = 11;
            this.label21.Text = "Kabupaten / Kota";
            // 
            // cbDistrict
            // 
            this.cbDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDistrict.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbDistrict.Location = new System.Drawing.Point(1195, 43);
            this.cbDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(205, 23);
            this.cbDistrict.TabIndex = 12;
            this.cbDistrict.SelectedIndexChanged += new System.EventHandler(this.cbDistrict_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.label29.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.label29.Location = new System.Drawing.Point(969, 78);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 15);
            this.label29.TabIndex = 17;
            this.label29.Text = "Sales Area";
            // 
            // cbSalesArea
            // 
            this.cbSalesArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSalesArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSalesArea.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSalesArea.Location = new System.Drawing.Point(969, 97);
            this.cbSalesArea.Margin = new System.Windows.Forms.Padding(4);
            this.cbSalesArea.Name = "cbSalesArea";
            this.cbSalesArea.Size = new System.Drawing.Size(205, 23);
            this.cbSalesArea.TabIndex = 18;
            // 
            // pnlHiddenFields
            // 
            this.pnlHiddenFields.Controls.Add(this.txtSalesOrderId);
            this.pnlHiddenFields.Controls.Add(this.txtModifiedAt);
            this.pnlHiddenFields.Controls.Add(this.txtRealSalesNo);
            this.pnlHiddenFields.Location = new System.Drawing.Point(0, 0);
            this.pnlHiddenFields.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHiddenFields.Name = "pnlHiddenFields";
            this.pnlHiddenFields.Size = new System.Drawing.Size(0, 0);
            this.pnlHiddenFields.TabIndex = 99;
            this.pnlHiddenFields.Visible = false;
            // 
            // txtSalesOrderId
            // 
            this.txtSalesOrderId.Location = new System.Drawing.Point(0, 0);
            this.txtSalesOrderId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalesOrderId.Name = "txtSalesOrderId";
            this.txtSalesOrderId.Size = new System.Drawing.Size(245, 22);
            this.txtSalesOrderId.TabIndex = 0;
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.Location = new System.Drawing.Point(260, 0);
            this.txtModifiedAt.Margin = new System.Windows.Forms.Padding(4);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(309, 22);
            this.txtModifiedAt.TabIndex = 1;
            // 
            // txtRealSalesNo
            // 
            this.txtRealSalesNo.Location = new System.Drawing.Point(584, 0);
            this.txtRealSalesNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRealSalesNo.Name = "txtRealSalesNo";
            this.txtRealSalesNo.Size = new System.Drawing.Size(309, 22);
            this.txtRealSalesNo.TabIndex = 2;
            // 
            // toolTipSales
            // 
            this.toolTipSales.AutomaticDelay = 200;
            this.toolTipSales.AutoPopDelay = 5000;
            this.toolTipSales.InitialDelay = 200;
            this.toolTipSales.ReshowDelay = 40;
            // 
            // FrmSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1467, 880);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTopSep);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHiddenFields);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSalesOrder";
            this.Text = "PENJUALAN";
            this.Load += new System.EventHandler(this.FrmSalesOrder_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlActionBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderItem)).EndInit();
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.pnlGridTop.ResumeLayout(false);
            this.pnlGridTop.PerformLayout();
            this.pnlItemInput.ResumeLayout(false);
            this.pnlItemInput.PerformLayout();
            this.pnlNote.ResumeLayout(false);
            this.pnlNote.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlHiddenFields.ResumeLayout(false);
            this.pnlHiddenFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblSalesNo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.TextBox txtSalesNo;
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
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSalesman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTermOfPayment;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dtpSalesOrderDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cbSalesArea;
        private System.Windows.Forms.Panel pnlHeaderSpacer;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNoteDetail;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlItemInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBatch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpExpiredDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.Panel pnlGridTop;
        private System.Windows.Forms.Label lblGridTitle;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.DataGridView dgvSalesOrderItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn productId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn batchCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn expDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn uomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn uomCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn discPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceReal;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtExtraDiscount;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTaxBaseAmount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtValueAddedTaxAmount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cbPic;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlHiddenFields;
        private System.Windows.Forms.TextBox txtSalesOrderId;
        private System.Windows.Forms.TextBox txtModifiedAt;
        private System.Windows.Forms.TextBox txtRealSalesNo;
        private System.Windows.Forms.ToolTip toolTipSales;
    }
}
