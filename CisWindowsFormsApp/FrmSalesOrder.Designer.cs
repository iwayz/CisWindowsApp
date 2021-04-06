namespace CisWindowsFormsApp
{
    partial class FrmSalesOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalesOrder));
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.cbDistrict = new System.Windows.Forms.ComboBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.gbShippingAddress = new System.Windows.Forms.GroupBox();
            this.cbSalesArea = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCustomerDetail = new System.Windows.Forms.GroupBox();
            this.cbSalesman = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTermOfPayment = new System.Windows.Forms.ComboBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpSalesOrderDate = new System.Windows.Forms.DateTimePicker();
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
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.gbSalesOrderDetail = new System.Windows.Forms.GroupBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtValueAddedTaxAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTaxBaseAmount = new System.Windows.Forms.TextBox();
            this.txtExtraDiscount = new System.Windows.Forms.TextBox();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlNote = new System.Windows.Forms.Panel();
            this.lblNoteDetail = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSalesNo = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlButtonGroup = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlHiddenFields = new System.Windows.Forms.Panel();
            this.txtModifiedAt = new System.Windows.Forms.TextBox();
            this.txtSalesOrderId = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.lblSalesNo = new System.Windows.Forms.Label();
            this.lblMark = new System.Windows.Forms.Label();
            this.gbShippingAddress.SuspendLayout();
            this.gbCustomerDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderItem)).BeginInit();
            this.gbSalesOrderDetail.SuspendLayout();
            this.pnlNote.SuspendLayout();
            this.pnlButtonGroup.SuspendLayout();
            this.pnlHiddenFields.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtDeliveryAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDeliveryAddress.Location = new System.Drawing.Point(15, 37);
            this.txtDeliveryAddress.Multiline = true;
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(240, 117);
            this.txtDeliveryAddress.TabIndex = 20;
            // 
            // cbDistrict
            // 
            this.cbDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbDistrict.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbDistrict.FormattingEnabled = true;
            this.cbDistrict.Location = new System.Drawing.Point(261, 82);
            this.cbDistrict.Name = "cbDistrict";
            this.cbDistrict.Size = new System.Drawing.Size(235, 27);
            this.cbDistrict.TabIndex = 22;
            this.cbDistrict.SelectedIndexChanged += new System.EventHandler(this.cbDistrict_SelectedIndexChanged);
            // 
            // cbProvince
            // 
            this.cbProvince.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProvince.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProvince.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbProvince.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(261, 37);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(235, 27);
            this.cbProvince.TabIndex = 21;
            this.cbProvince.SelectedIndexChanged += new System.EventHandler(this.cbProvince_SelectedIndexChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(261, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 15);
            this.label21.TabIndex = 16;
            this.label21.Text = "Kabupaten/ Kota";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label20.Location = new System.Drawing.Point(261, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 15);
            this.label20.TabIndex = 17;
            this.label20.Text = "Provinsi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(16, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 15);
            this.label9.TabIndex = 25;
            this.label9.Text = "Kode Pelanggan";
            // 
            // cbCustomer
            // 
            this.cbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbCustomer.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(17, 36);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(225, 27);
            this.cbCustomer.TabIndex = 11;
            this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
            // 
            // gbShippingAddress
            // 
            this.gbShippingAddress.Controls.Add(this.cbSalesArea);
            this.gbShippingAddress.Controls.Add(this.txtDeliveryAddress);
            this.gbShippingAddress.Controls.Add(this.label29);
            this.gbShippingAddress.Controls.Add(this.cbProvince);
            this.gbShippingAddress.Controls.Add(this.label2);
            this.gbShippingAddress.Controls.Add(this.label20);
            this.gbShippingAddress.Controls.Add(this.label21);
            this.gbShippingAddress.Controls.Add(this.cbDistrict);
            this.gbShippingAddress.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbShippingAddress.Location = new System.Drawing.Point(464, 65);
            this.gbShippingAddress.Name = "gbShippingAddress";
            this.gbShippingAddress.Size = new System.Drawing.Size(509, 164);
            this.gbShippingAddress.TabIndex = 5;
            this.gbShippingAddress.TabStop = false;
            this.gbShippingAddress.Text = "ALAMAT KIRIM";
            // 
            // cbSalesArea
            // 
            this.cbSalesArea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSalesArea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSalesArea.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbSalesArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSalesArea.FormattingEnabled = true;
            this.cbSalesArea.Location = new System.Drawing.Point(261, 129);
            this.cbSalesArea.Name = "cbSalesArea";
            this.cbSalesArea.Size = new System.Drawing.Size(240, 27);
            this.cbSalesArea.TabIndex = 24;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(261, 112);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(63, 15);
            this.label29.TabIndex = 30;
            this.label29.Text = "Sales Area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Alamat";
            // 
            // gbCustomerDetail
            // 
            this.gbCustomerDetail.Controls.Add(this.cbSalesman);
            this.gbCustomerDetail.Controls.Add(this.label9);
            this.gbCustomerDetail.Controls.Add(this.label4);
            this.gbCustomerDetail.Controls.Add(this.cbTermOfPayment);
            this.gbCustomerDetail.Controls.Add(this.label27);
            this.gbCustomerDetail.Controls.Add(this.label1);
            this.gbCustomerDetail.Controls.Add(this.dtpDueDate);
            this.gbCustomerDetail.Controls.Add(this.label3);
            this.gbCustomerDetail.Controls.Add(this.cbCustomer);
            this.gbCustomerDetail.Controls.Add(this.dtpSalesOrderDate);
            this.gbCustomerDetail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbCustomerDetail.Location = new System.Drawing.Point(23, 65);
            this.gbCustomerDetail.Name = "gbCustomerDetail";
            this.gbCustomerDetail.Size = new System.Drawing.Size(426, 164);
            this.gbCustomerDetail.TabIndex = 4;
            this.gbCustomerDetail.TabStop = false;
            this.gbCustomerDetail.Text = "FAKTUR";
            // 
            // cbSalesman
            // 
            this.cbSalesman.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSalesman.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSalesman.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbSalesman.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbSalesman.FormattingEnabled = true;
            this.cbSalesman.Location = new System.Drawing.Point(16, 80);
            this.cbSalesman.Name = "cbSalesman";
            this.cbSalesman.Size = new System.Drawing.Size(225, 27);
            this.cbSalesman.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Salesman";
            // 
            // cbTermOfPayment
            // 
            this.cbTermOfPayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbTermOfPayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbTermOfPayment.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbTermOfPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTermOfPayment.FormattingEnabled = true;
            this.cbTermOfPayment.Location = new System.Drawing.Point(18, 127);
            this.cbTermOfPayment.Name = "cbTermOfPayment";
            this.cbTermOfPayment.Size = new System.Drawing.Size(225, 27);
            this.cbTermOfPayment.TabIndex = 14;
            this.cbTermOfPayment.SelectedIndexChanged += new System.EventHandler(this.cbTermOfPayment_SelectedIndexChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(250, 62);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(62, 15);
            this.label27.TabIndex = 28;
            this.label27.Text = "Tgl. Faktur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(15, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Term of Payment";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpDueDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpDueDate.Location = new System.Drawing.Point(250, 127);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(164, 27);
            this.dtpDueDate.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(250, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Tgl. Jatuh Tempo";
            // 
            // dtpSalesOrderDate
            // 
            this.dtpSalesOrderDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpSalesOrderDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpSalesOrderDate.Location = new System.Drawing.Point(250, 80);
            this.dtpSalesOrderDate.Name = "dtpSalesOrderDate";
            this.dtpSalesOrderDate.Size = new System.Drawing.Size(164, 27);
            this.dtpSalesOrderDate.TabIndex = 13;
            // 
            // dgvSalesOrderItem
            // 
            this.dgvSalesOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgvSalesOrderItem.Location = new System.Drawing.Point(16, 71);
            this.dgvSalesOrderItem.Name = "dgvSalesOrderItem";
            this.dgvSalesOrderItem.ReadOnly = true;
            this.dgvSalesOrderItem.Size = new System.Drawing.Size(921, 170);
            this.dgvSalesOrderItem.TabIndex = 37;
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
            this.productCode.HeaderText = "KODE BRG";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            this.productCode.Width = 90;
            // 
            // productName
            // 
            this.productName.HeaderText = "NAMA BARANG";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Width = 290;
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
            this.batchCode.HeaderText = "BATCH";
            this.batchCode.Name = "batchCode";
            this.batchCode.ReadOnly = true;
            this.batchCode.Width = 75;
            // 
            // expDate
            // 
            this.expDate.HeaderText = "EXP. DATE";
            this.expDate.Name = "expDate";
            this.expDate.ReadOnly = true;
            // 
            // qty
            // 
            this.qty.HeaderText = "QTY";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 50;
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
            this.uomCode.HeaderText = "SAT";
            this.uomCode.Name = "uomCode";
            this.uomCode.ReadOnly = true;
            this.uomCode.Width = 50;
            // 
            // price
            // 
            this.price.HeaderText = "HARGA";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Width = 70;
            // 
            // discPercent
            // 
            this.discPercent.HeaderText = "DISKON";
            this.discPercent.Name = "discPercent";
            this.discPercent.ReadOnly = true;
            this.discPercent.Width = 55;
            // 
            // subTotal
            // 
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
            // cbProduct
            // 
            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProduct.Font = new System.Drawing.Font("Calibri", 12F);
            this.cbProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(16, 34);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(227, 27);
            this.cbProduct.TabIndex = 30;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kode Barang";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(366, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tgl. Kedaluwarsa";
            // 
            // dtpExpiredDate
            // 
            this.dtpExpiredDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpExpiredDate.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiredDate.Location = new System.Drawing.Point(366, 35);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(114, 27);
            this.dtpExpiredDate.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(484, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQty.Location = new System.Drawing.Point(484, 35);
            this.txtQty.MaxLength = 6;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(57, 27);
            this.txtQty.TabIndex = 33;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(250, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "Batch";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(548, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Harga (HNA)";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.Location = new System.Drawing.Point(548, 35);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(109, 27);
            this.txtPrice.TabIndex = 34;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            this.txtPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(663, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Disc. (%)";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDiscount.Location = new System.Drawing.Point(663, 35);
            this.txtDiscount.MaxLength = 5;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(51, 27);
            this.txtDiscount.TabIndex = 35;
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
            this.btnAddItem.Location = new System.Drawing.Point(728, 31);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(71, 31);
            this.btnAddItem.TabIndex = 36;
            this.btnAddItem.Text = "ADD ITEM";
            this.btnAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // gbSalesOrderDetail
            // 
            this.gbSalesOrderDetail.Controls.Add(this.dgvSalesOrderItem);
            this.gbSalesOrderDetail.Controls.Add(this.btnAddItem);
            this.gbSalesOrderDetail.Controls.Add(this.dtpExpiredDate);
            this.gbSalesOrderDetail.Controls.Add(this.cbProduct);
            this.gbSalesOrderDetail.Controls.Add(this.txtDiscount);
            this.gbSalesOrderDetail.Controls.Add(this.label7);
            this.gbSalesOrderDetail.Controls.Add(this.txtSubTotal);
            this.gbSalesOrderDetail.Controls.Add(this.lblTotal);
            this.gbSalesOrderDetail.Controls.Add(this.txtValueAddedTaxAmount);
            this.gbSalesOrderDetail.Controls.Add(this.label13);
            this.gbSalesOrderDetail.Controls.Add(this.txtTaxBaseAmount);
            this.gbSalesOrderDetail.Controls.Add(this.txtExtraDiscount);
            this.gbSalesOrderDetail.Controls.Add(this.txtPrice);
            this.gbSalesOrderDetail.Controls.Add(this.txtQty);
            this.gbSalesOrderDetail.Controls.Add(this.txtBatch);
            this.gbSalesOrderDetail.Controls.Add(this.label8);
            this.gbSalesOrderDetail.Controls.Add(this.label14);
            this.gbSalesOrderDetail.Controls.Add(this.label23);
            this.gbSalesOrderDetail.Controls.Add(this.label17);
            this.gbSalesOrderDetail.Controls.Add(this.label16);
            this.gbSalesOrderDetail.Controls.Add(this.label10);
            this.gbSalesOrderDetail.Controls.Add(this.label6);
            this.gbSalesOrderDetail.Controls.Add(this.label5);
            this.gbSalesOrderDetail.Controls.Add(this.label11);
            this.gbSalesOrderDetail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbSalesOrderDetail.Location = new System.Drawing.Point(23, 235);
            this.gbSalesOrderDetail.Name = "gbSalesOrderDetail";
            this.gbSalesOrderDetail.Size = new System.Drawing.Size(950, 308);
            this.gbSalesOrderDetail.TabIndex = 6;
            this.gbSalesOrderDetail.TabStop = false;
            this.gbSalesOrderDetail.Text = "FAKTUR DETAIL";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSubTotal.Location = new System.Drawing.Point(17, 270);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(131, 27);
            this.txtSubTotal.TabIndex = 37;
            this.txtSubTotal.Text = "0";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSubTotal.Enter += new System.EventHandler(this.txtExtraDiscount_Enter);
            this.txtSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraDiscount_KeyPress);
            this.txtSubTotal.Leave += new System.EventHandler(this.txtExtraDiscount_Leave);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTotal.Location = new System.Drawing.Point(683, 260);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(254, 42);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtValueAddedTaxAmount
            // 
            this.txtValueAddedTaxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValueAddedTaxAmount.Enabled = false;
            this.txtValueAddedTaxAmount.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtValueAddedTaxAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValueAddedTaxAmount.Location = new System.Drawing.Point(384, 270);
            this.txtValueAddedTaxAmount.Name = "txtValueAddedTaxAmount";
            this.txtValueAddedTaxAmount.Size = new System.Drawing.Size(109, 27);
            this.txtValueAddedTaxAmount.TabIndex = 37;
            this.txtValueAddedTaxAmount.Text = "0";
            this.txtValueAddedTaxAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValueAddedTaxAmount.Enter += new System.EventHandler(this.txtExtraDiscount_Enter);
            this.txtValueAddedTaxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraDiscount_KeyPress);
            this.txtValueAddedTaxAmount.Leave += new System.EventHandler(this.txtExtraDiscount_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(840, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "TOTAL TAGIHAN:";
            // 
            // txtTaxBaseAmount
            // 
            this.txtTaxBaseAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTaxBaseAmount.Enabled = false;
            this.txtTaxBaseAmount.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtTaxBaseAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTaxBaseAmount.Location = new System.Drawing.Point(269, 270);
            this.txtTaxBaseAmount.Name = "txtTaxBaseAmount";
            this.txtTaxBaseAmount.Size = new System.Drawing.Size(109, 27);
            this.txtTaxBaseAmount.TabIndex = 37;
            this.txtTaxBaseAmount.Text = "0";
            this.txtTaxBaseAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxBaseAmount.Enter += new System.EventHandler(this.txtExtraDiscount_Enter);
            this.txtTaxBaseAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraDiscount_KeyPress);
            this.txtTaxBaseAmount.Leave += new System.EventHandler(this.txtExtraDiscount_Leave);
            // 
            // txtExtraDiscount
            // 
            this.txtExtraDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtExtraDiscount.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtExtraDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtExtraDiscount.Location = new System.Drawing.Point(154, 270);
            this.txtExtraDiscount.Name = "txtExtraDiscount";
            this.txtExtraDiscount.Size = new System.Drawing.Size(109, 27);
            this.txtExtraDiscount.TabIndex = 37;
            this.txtExtraDiscount.Text = "0";
            this.txtExtraDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtExtraDiscount.Enter += new System.EventHandler(this.txtExtraDiscount_Enter);
            this.txtExtraDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtraDiscount_KeyPress);
            this.txtExtraDiscount.Leave += new System.EventHandler(this.txtExtraDiscount_Leave);
            // 
            // txtBatch
            // 
            this.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatch.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtBatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBatch.Location = new System.Drawing.Point(249, 35);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(111, 27);
            this.txtBatch.TabIndex = 31;
            this.txtBatch.Leave += new System.EventHandler(this.txtBatch_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(15, 252);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 15);
            this.label14.TabIndex = 17;
            this.label14.Text = "Total Harga";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(381, 252);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(56, 15);
            this.label23.TabIndex = 17;
            this.label23.Text = "PPN 10%";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(269, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 15);
            this.label17.TabIndex = 17;
            this.label17.Text = "Total DPP";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(154, 252);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 15);
            this.label16.TabIndex = 17;
            this.label16.Text = "Ekstra Diskon";
            // 
            // pnlNote
            // 
            this.pnlNote.Controls.Add(this.lblNoteDetail);
            this.pnlNote.Controls.Add(this.label15);
            this.pnlNote.Location = new System.Drawing.Point(23, 549);
            this.pnlNote.Name = "pnlNote";
            this.pnlNote.Size = new System.Drawing.Size(950, 49);
            this.pnlNote.TabIndex = 42;
            this.pnlNote.Visible = false;
            // 
            // lblNoteDetail
            // 
            this.lblNoteDetail.AutoSize = true;
            this.lblNoteDetail.BackColor = System.Drawing.Color.Gold;
            this.lblNoteDetail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNoteDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNoteDetail.Location = new System.Drawing.Point(9, 24);
            this.lblNoteDetail.Name = "lblNoteDetail";
            this.lblNoteDetail.Padding = new System.Windows.Forms.Padding(3);
            this.lblNoteDetail.Size = new System.Drawing.Size(76, 21);
            this.lblNoteDetail.TabIndex = 4;
            this.lblNoteDetail.Text = "Note Detail";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(9, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "PERHATIAN!";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(36, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cari No. Faktur";
            // 
            // txtSalesNo
            // 
            this.txtSalesNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSalesNo.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtSalesNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSalesNo.Location = new System.Drawing.Point(36, 28);
            this.txtSalesNo.Name = "txtSalesNo";
            this.txtSalesNo.Size = new System.Drawing.Size(168, 27);
            this.txtSalesNo.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(210, 28);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(35, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlButtonGroup
            // 
            this.pnlButtonGroup.Controls.Add(this.btnAdd);
            this.pnlButtonGroup.Controls.Add(this.btnReload);
            this.pnlButtonGroup.Controls.Add(this.btnDel);
            this.pnlButtonGroup.Controls.Add(this.btnSave);
            this.pnlButtonGroup.Controls.Add(this.btnClear);
            this.pnlButtonGroup.Location = new System.Drawing.Point(979, 235);
            this.pnlButtonGroup.Name = "pnlButtonGroup";
            this.pnlButtonGroup.Size = new System.Drawing.Size(90, 196);
            this.pnlButtonGroup.TabIndex = 41;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(9, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(71, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.Location = new System.Drawing.Point(9, 154);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(71, 30);
            this.btnReload.TabIndex = 15;
            this.btnReload.Text = "RELOAD";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(9, 118);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(71, 30);
            this.btnDel.TabIndex = 14;
            this.btnDel.Text = "DELETE";
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(9, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(71, 30);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(9, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 30);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLEAR";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlHiddenFields
            // 
            this.pnlHiddenFields.Controls.Add(this.txtModifiedAt);
            this.pnlHiddenFields.Controls.Add(this.txtSalesOrderId);
            this.pnlHiddenFields.Controls.Add(this.label18);
            this.pnlHiddenFields.Controls.Add(this.label19);
            this.pnlHiddenFields.Location = new System.Drawing.Point(23, 906);
            this.pnlHiddenFields.Name = "pnlHiddenFields";
            this.pnlHiddenFields.Size = new System.Drawing.Size(1101, 72);
            this.pnlHiddenFields.TabIndex = 43;
            this.pnlHiddenFields.Visible = false;
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModifiedAt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModifiedAt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModifiedAt.Location = new System.Drawing.Point(161, 31);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(175, 27);
            this.txtModifiedAt.TabIndex = 1;
            // 
            // txtSalesOrderId
            // 
            this.txtSalesOrderId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalesOrderId.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesOrderId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSalesOrderId.Location = new System.Drawing.Point(9, 31);
            this.txtSalesOrderId.Name = "txtSalesOrderId";
            this.txtSalesOrderId.Size = new System.Drawing.Size(139, 27);
            this.txtSalesOrderId.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(161, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 15);
            this.label18.TabIndex = 4;
            this.label18.Text = "Modified At";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(9, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 15);
            this.label19.TabIndex = 4;
            this.label19.Text = "Id";
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.btnPrev);
            this.pnlNavigation.Controls.Add(this.btnLast);
            this.pnlNavigation.Controls.Add(this.btnNext);
            this.pnlNavigation.Controls.Add(this.btnFirst);
            this.pnlNavigation.Location = new System.Drawing.Point(979, 73);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(89, 156);
            this.pnlNavigation.TabIndex = 41;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.Location = new System.Drawing.Point(8, 45);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(71, 30);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "PREV";
            this.btnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnLast.FlatAppearance.BorderSize = 0;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
            this.btnLast.Location = new System.Drawing.Point(8, 117);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(71, 30);
            this.btnLast.TabIndex = 14;
            this.btnLast.Text = "LAST";
            this.btnLast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.Location = new System.Drawing.Point(8, 81);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(71, 30);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "NEXT";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnFirst.FlatAppearance.BorderSize = 0;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
            this.btnFirst.Location = new System.Drawing.Point(8, 9);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(71, 30);
            this.btnFirst.TabIndex = 11;
            this.btnFirst.Text = "FIRST";
            this.btnFirst.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(987, 450);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(71, 52);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label24.Location = new System.Drawing.Point(482, 19);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 15);
            this.label24.TabIndex = 30;
            this.label24.Text = "NO. FAKTUR:";
            // 
            // lblSalesNo
            // 
            this.lblSalesNo.AutoSize = true;
            this.lblSalesNo.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesNo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalesNo.Location = new System.Drawing.Point(564, 9);
            this.lblSalesNo.Name = "lblSalesNo";
            this.lblSalesNo.Size = new System.Drawing.Size(0, 42);
            this.lblSalesNo.TabIndex = 30;
            this.lblSalesNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMark
            // 
            this.lblMark.AutoSize = true;
            this.lblMark.BackColor = System.Drawing.Color.Red;
            this.lblMark.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMark.ForeColor = System.Drawing.Color.White;
            this.lblMark.Location = new System.Drawing.Point(810, 19);
            this.lblMark.Name = "lblMark";
            this.lblMark.Size = new System.Drawing.Size(154, 45);
            this.lblMark.TabIndex = 30;
            this.lblMark.Text = "DELETED";
            this.lblMark.Visible = false;
            // 
            // FrmSalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 749);
            this.Controls.Add(this.pnlHiddenFields);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlNote);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlButtonGroup);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSalesNo);
            this.Controls.Add(this.gbSalesOrderDetail);
            this.Controls.Add(this.gbCustomerDetail);
            this.Controls.Add(this.lblMark);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.gbShippingAddress);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSalesNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSalesOrder";
            this.Text = "PENJUALAN";
            this.Load += new System.EventHandler(this.FrmSalesOrder_Load);
            this.gbShippingAddress.ResumeLayout(false);
            this.gbShippingAddress.PerformLayout();
            this.gbCustomerDetail.ResumeLayout(false);
            this.gbCustomerDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrderItem)).EndInit();
            this.gbSalesOrderDetail.ResumeLayout(false);
            this.gbSalesOrderDetail.PerformLayout();
            this.pnlNote.ResumeLayout(false);
            this.pnlNote.PerformLayout();
            this.pnlButtonGroup.ResumeLayout(false);
            this.pnlHiddenFields.ResumeLayout(false);
            this.pnlHiddenFields.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtDeliveryAddress;
        private System.Windows.Forms.ComboBox cbDistrict;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.GroupBox gbShippingAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbCustomerDetail;
        private System.Windows.Forms.DateTimePicker dtpSalesOrderDate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbSalesArea;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cbSalesman;
        private System.Windows.Forms.ComboBox cbTermOfPayment;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSalesOrderItem;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpExpiredDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.GroupBox gbSalesOrderDetail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSalesNo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Panel pnlButtonGroup;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlNote;
        private System.Windows.Forms.Label lblNoteDetail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlHiddenFields;
        private System.Windows.Forms.TextBox txtModifiedAt;
        private System.Windows.Forms.TextBox txtSalesOrderId;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtExtraDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtValueAddedTaxAmount;
        private System.Windows.Forms.TextBox txtTaxBaseAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblSalesNo;
        private System.Windows.Forms.Label lblMark;
        private System.Windows.Forms.TextBox txtBatch;
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
    }
}