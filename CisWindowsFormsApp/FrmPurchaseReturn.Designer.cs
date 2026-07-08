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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleProductCode = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleProductName = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleBatchCode = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleExpDate = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleUomCode = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleQty = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStylePrice = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyleSubTotal = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblReturnNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.pnlTopSep = new System.Windows.Forms.Panel();
            this.pnlActionBar = new System.Windows.Forms.Panel();
            this.btnVoid = new System.Windows.Forms.Button();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
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
            this.colSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.pnlGridTop = new System.Windows.Forms.Panel();
            this.lblItemsTitle = new System.Windows.Forms.Label();
            this.pnlItemInput = new System.Windows.Forms.Panel();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.txtBatch = new System.Windows.Forms.TextBox();
            this.dtpExpiredDate = new System.Windows.Forms.DateTimePicker();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pnlHeaderSpacer = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.cbPO = new System.Windows.Forms.ComboBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.lblPO = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.lblReason = new System.Windows.Forms.Label();
            this.pnlHidden = new System.Windows.Forms.Panel();
            this.txtReturnId = new System.Windows.Forms.TextBox();
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
            this.pnlTop.Controls.Add(this.lblReturnNumber);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.txtSearch);
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.btnLast);
            this.pnlTop.Controls.Add(this.btnNext);
            this.pnlTop.Controls.Add(this.btnPrev);
            this.pnlTop.Controls.Add(this.btnFirst);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1813, 66);
            this.pnlTop.TabIndex = 0;
            // 
            // lblReturnNumber
            // 
            this.lblReturnNumber.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblReturnNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblReturnNumber.Location = new System.Drawing.Point(21, 15);
            this.lblReturnNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lblReturnNumber.Name = "lblReturnNumber";
            this.lblReturnNumber.Size = new System.Drawing.Size(293, 39);
            this.lblReturnNumber.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStatus.Location = new System.Drawing.Point(325, 20);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 23);
            this.lblStatus.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(1333, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(293, 27);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1637, 15);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 37);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLast.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnLast.Location = new System.Drawing.Point(1904, 15);
            this.btnLast.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(53, 37);
            this.btnLast.TabIndex = 15;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnNext.Location = new System.Drawing.Point(1845, 15);
            this.btnNext.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(53, 37);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnPrev.Location = new System.Drawing.Point(1787, 15);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(53, 37);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnFirst.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnFirst.Location = new System.Drawing.Point(1728, 15);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(53, 37);
            this.btnFirst.TabIndex = 12;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // pnlTopSep
            // 
            this.pnlTopSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(218)))));
            this.pnlTopSep.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSep.Location = new System.Drawing.Point(0, 66);
            this.pnlTopSep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTopSep.Name = "pnlTopSep";
            this.pnlTopSep.Size = new System.Drawing.Size(1813, 1);
            this.pnlTopSep.TabIndex = 1;
            // 
            // pnlActionBar
            // 
            this.pnlActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.pnlActionBar.Controls.Add(this.btnVoid);
            this.pnlActionBar.Controls.Add(this.btnPost);
            this.pnlActionBar.Controls.Add(this.btnReload);
            this.pnlActionBar.Controls.Add(this.btnDel);
            this.pnlActionBar.Controls.Add(this.btnSave);
            this.pnlActionBar.Controls.Add(this.btnAdd);
            this.pnlActionBar.Controls.Add(this.btnClear);
            this.pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionBar.Location = new System.Drawing.Point(0, 67);
            this.pnlActionBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlActionBar.Name = "pnlActionBar";
            this.pnlActionBar.Size = new System.Drawing.Size(1813, 64);
            this.pnlActionBar.TabIndex = 2;
            // 
            // btnVoid
            // 
            this.btnVoid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnVoid.FlatAppearance.BorderSize = 0;
            this.btnVoid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoid.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVoid.ForeColor = System.Drawing.Color.White;
            this.btnVoid.Location = new System.Drawing.Point(988, 11);
            this.btnVoid.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnVoid.Name = "btnVoid";
            this.btnVoid.Size = new System.Drawing.Size(145, 42);
            this.btnVoid.TabIndex = 6;
            this.btnVoid.Text = "Void";
            this.btnVoid.UseVisualStyleBackColor = false;
            this.btnVoid.Click += new System.EventHandler(this.btnVoid_Click);
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(828, 11);
            this.btnPost.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(145, 42);
            this.btnPost.TabIndex = 5;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(668, 11);
            this.btnReload.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(145, 42);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(508, 11);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(145, 42);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(348, 11);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 42);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(188, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 42);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(15, 11);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 42);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnlContent.Controls.Add(this.pnlItems);
            this.pnlContent.Controls.Add(this.pnlHeaderSpacer);
            this.pnlContent.Controls.Add(this.pnlHeader);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 131);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlContent.Size = new System.Drawing.Size(1813, 755);
            this.pnlContent.TabIndex = 3;
            // 
            // pnlItems
            // 
            this.pnlItems.BackColor = System.Drawing.Color.White;
            this.pnlItems.Controls.Add(this.dgvItems);
            this.pnlItems.Controls.Add(this.pnlFooter);
            this.pnlItems.Controls.Add(this.pnlGridTop);
            this.pnlItems.Controls.Add(this.pnlItemInput);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Location = new System.Drawing.Point(11, 153);
            this.pnlItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlItems.Size = new System.Drawing.Size(1791, 592);
            this.pnlItems.TabIndex = 2;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.colSubTotal});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvItems.Location = new System.Drawing.Point(11, 101);
            this.dgvItems.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1769, 417);
            this.dgvItems.TabIndex = 2;
            // 
            // colProductId
            // 
            this.colProductId.FillWeight = 1F;
            this.colProductId.HeaderText = "colProductId";
            this.colProductId.MinimumWidth = 6;
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = false;
            // 
            // colBatchId
            // 
            this.colBatchId.FillWeight = 1F;
            this.colBatchId.HeaderText = "colBatchId";
            this.colBatchId.MinimumWidth = 6;
            this.colBatchId.Name = "colBatchId";
            this.colBatchId.Visible = false;
            // 
            // colUomId
            // 
            this.colUomId.FillWeight = 1F;
            this.colUomId.HeaderText = "colUomId";
            this.colUomId.MinimumWidth = 6;
            this.colUomId.Name = "colUomId";
            this.colUomId.Visible = false;
            // 
            // colProductCode
            //
            dataGridViewCellStyleProductCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleProductCode.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyleProductCode.SelectionForeColor = System.Drawing.Color.Black;
            this.colProductCode.DefaultCellStyle = dataGridViewCellStyleProductCode;
            this.colProductCode.FillWeight = 60F;
            this.colProductCode.HeaderText = "Kode";
            this.colProductCode.MinimumWidth = 6;
            this.colProductCode.Name = "colProductCode";
            //
            // colProductName
            //
            dataGridViewCellStyleProductName.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleProductName.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyleProductName.SelectionForeColor = System.Drawing.Color.Black;
            this.colProductName.DefaultCellStyle = dataGridViewCellStyleProductName;
            this.colProductName.FillWeight = 200F;
            this.colProductName.HeaderText = "Nama Barang";
            this.colProductName.MinimumWidth = 6;
            this.colProductName.Name = "colProductName";
            //
            // colBatchCode
            //
            dataGridViewCellStyleBatchCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleBatchCode.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyleBatchCode.SelectionForeColor = System.Drawing.Color.Black;
            this.colBatchCode.DefaultCellStyle = dataGridViewCellStyleBatchCode;
            this.colBatchCode.FillWeight = 60F;
            this.colBatchCode.HeaderText = "Batch";
            this.colBatchCode.MinimumWidth = 6;
            this.colBatchCode.Name = "colBatchCode";
            //
            // colExpDate
            //
            dataGridViewCellStyleExpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleExpDate.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyleExpDate.SelectionForeColor = System.Drawing.Color.Black;
            this.colExpDate.DefaultCellStyle = dataGridViewCellStyleExpDate;
            this.colExpDate.FillWeight = 50F;
            this.colExpDate.HeaderText = "Exp.";
            this.colExpDate.MinimumWidth = 6;
            this.colExpDate.Name = "colExpDate";
            //
            // colQty
            //
            dataGridViewCellStyleQty.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyleQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleQty.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyleQty.SelectionForeColor = System.Drawing.Color.Black;
            this.colQty.DefaultCellStyle = dataGridViewCellStyleQty;
            this.colQty.FillWeight = 40F;
            this.colQty.HeaderText = "Qty";
            this.colQty.MinimumWidth = 6;
            this.colQty.Name = "colQty";
            //
            // colUomCode
            //
            dataGridViewCellStyleUomCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleUomCode.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyleUomCode.SelectionForeColor = System.Drawing.Color.Black;
            this.colUomCode.DefaultCellStyle = dataGridViewCellStyleUomCode;
            this.colUomCode.FillWeight = 40F;
            this.colUomCode.HeaderText = "UOM";
            this.colUomCode.MinimumWidth = 6;
            this.colUomCode.Name = "colUomCode";
            //
            // colPrice
            //
            dataGridViewCellStylePrice.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStylePrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStylePrice.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStylePrice.SelectionForeColor = System.Drawing.Color.Black;
            this.colPrice.DefaultCellStyle = dataGridViewCellStylePrice;
            this.colPrice.FillWeight = 80F;
            this.colPrice.HeaderText = "Harga";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            //
            // colSubTotal
            //
            dataGridViewCellStyleSubTotal.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyleSubTotal.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyleSubTotal.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(228)))), ((int)(((byte)(247)))));
            dataGridViewCellStyleSubTotal.SelectionForeColor = System.Drawing.Color.Black;
            this.colSubTotal.DefaultCellStyle = dataGridViewCellStyleSubTotal;
            this.colSubTotal.FillWeight = 90F;
            this.colSubTotal.HeaderText = "Subtotal";
            this.colSubTotal.MinimumWidth = 6;
            this.colSubTotal.Name = "colSubTotal";
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblTotal);
            this.pnlFooter.Controls.Add(this.lblTotalLabel);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(11, 518);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1769, 64);
            this.pnlFooter.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.lblTotal.Location = new System.Drawing.Point(107, 7);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(347, 49);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "0";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTotalLabel.Location = new System.Drawing.Point(11, 17);
            this.lblTotalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(61, 23);
            this.lblTotalLabel.TabIndex = 1;
            this.lblTotalLabel.Text = "TOTAL";
            // 
            // pnlGridTop
            // 
            this.pnlGridTop.Controls.Add(this.lblItemsTitle);
            this.pnlGridTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGridTop.Location = new System.Drawing.Point(11, 62);
            this.pnlGridTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlGridTop.Name = "pnlGridTop";
            this.pnlGridTop.Size = new System.Drawing.Size(1769, 39);
            this.pnlGridTop.TabIndex = 1;
            // 
            // lblItemsTitle
            // 
            this.lblItemsTitle.AutoSize = true;
            this.lblItemsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblItemsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblItemsTitle.Location = new System.Drawing.Point(5, 10);
            this.lblItemsTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblItemsTitle.Name = "lblItemsTitle";
            this.lblItemsTitle.Size = new System.Drawing.Size(87, 19);
            this.lblItemsTitle.TabIndex = 0;
            this.lblItemsTitle.Text = "Item Return";
            // 
            // pnlItemInput
            // 
            this.pnlItemInput.Controls.Add(this.cbProduct);
            this.pnlItemInput.Controls.Add(this.txtBatch);
            this.pnlItemInput.Controls.Add(this.dtpExpiredDate);
            this.pnlItemInput.Controls.Add(this.txtQty);
            this.pnlItemInput.Controls.Add(this.txtPrice);
            this.pnlItemInput.Controls.Add(this.btnAddItem);
            this.pnlItemInput.Controls.Add(this.btnRemoveItem);
            this.pnlItemInput.Controls.Add(this.lblProduct);
            this.pnlItemInput.Controls.Add(this.lblBatch);
            this.pnlItemInput.Controls.Add(this.lblExpDate);
            this.pnlItemInput.Controls.Add(this.lblQty);
            this.pnlItemInput.Controls.Add(this.lblPrice);
            this.pnlItemInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItemInput.Location = new System.Drawing.Point(11, 10);
            this.pnlItemInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlItemInput.Name = "pnlItemInput";
            this.pnlItemInput.Size = new System.Drawing.Size(1769, 52);
            this.pnlItemInput.TabIndex = 0;
            // 
            // cbProduct
            // 
            this.cbProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbProduct.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(5, 17);
            this.cbProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(372, 28);
            this.cbProduct.TabIndex = 5;
            this.cbProduct.SelectedIndexChanged += new System.EventHandler(this.cbProduct_SelectedIndexChanged);
            // 
            // txtBatch
            // 
            this.txtBatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtBatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBatch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBatch.Location = new System.Drawing.Point(389, 17);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.ReadOnly = true;
            this.txtBatch.Size = new System.Drawing.Size(119, 27);
            this.txtBatch.TabIndex = 99;
            // 
            // dtpExpiredDate
            // 
            this.dtpExpiredDate.Enabled = false;
            this.dtpExpiredDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpExpiredDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiredDate.Location = new System.Drawing.Point(520, 17);
            this.dtpExpiredDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpExpiredDate.Name = "dtpExpiredDate";
            this.dtpExpiredDate.Size = new System.Drawing.Size(145, 27);
            this.dtpExpiredDate.TabIndex = 99;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQty.Location = new System.Drawing.Point(677, 17);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(79, 27);
            this.txtQty.TabIndex = 6;
            this.txtQty.Text = "0";
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrice.Location = new System.Drawing.Point(768, 17);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(133, 27);
            this.txtPrice.TabIndex = 99;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnAddItem.FlatAppearance.BorderSize = 0;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnAddItem.ForeColor = System.Drawing.Color.White;
            this.btnAddItem.Location = new System.Drawing.Point(912, 17);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(120, 28);
            this.btnAddItem.TabIndex = 7;
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
            this.btnRemoveItem.Location = new System.Drawing.Point(1043, 17);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(120, 28);
            this.btnRemoveItem.TabIndex = 8;
            this.btnRemoveItem.Text = "- Hapus";
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblProduct.Location = new System.Drawing.Point(5, 2);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 15);
            this.lblProduct.TabIndex = 100;
            this.lblProduct.Text = "Barang";
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblBatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblBatch.Location = new System.Drawing.Point(389, 2);
            this.lblBatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(37, 15);
            this.lblBatch.TabIndex = 101;
            this.lblBatch.Text = "Batch";
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblExpDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblExpDate.Location = new System.Drawing.Point(520, 2);
            this.lblExpDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(55, 15);
            this.lblExpDate.TabIndex = 102;
            this.lblExpDate.Text = "Exp. Date";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblQty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblQty.Location = new System.Drawing.Point(677, 2);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(26, 15);
            this.lblQty.TabIndex = 103;
            this.lblQty.Text = "Qty";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblPrice.Location = new System.Drawing.Point(768, 2);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(39, 15);
            this.lblPrice.TabIndex = 104;
            this.lblPrice.Text = "Harga";
            // 
            // pnlHeaderSpacer
            // 
            this.pnlHeaderSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderSpacer.Location = new System.Drawing.Point(11, 143);
            this.pnlHeaderSpacer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeaderSpacer.Name = "pnlHeaderSpacer";
            this.pnlHeaderSpacer.Size = new System.Drawing.Size(1791, 10);
            this.pnlHeaderSpacer.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.cbSupplier);
            this.pnlHeader.Controls.Add(this.cbPO);
            this.pnlHeader.Controls.Add(this.dtpReturnDate);
            this.pnlHeader.Controls.Add(this.txtReason);
            this.pnlHeader.Controls.Add(this.lblSupplier);
            this.pnlHeader.Controls.Add(this.lblPO);
            this.pnlHeader.Controls.Add(this.lblReturnDate);
            this.pnlHeader.Controls.Add(this.lblReason);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(11, 10);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.pnlHeader.Size = new System.Drawing.Size(1791, 133);
            this.pnlHeader.TabIndex = 0;
            // 
            // cbSupplier
            // 
            this.cbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbSupplier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Location = new System.Drawing.Point(11, 30);
            this.cbSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(385, 28);
            this.cbSupplier.TabIndex = 1;
            this.cbSupplier.SelectedIndexChanged += new System.EventHandler(this.cbSupplier_SelectedIndexChanged);
            // 
            // cbPO
            // 
            this.cbPO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbPO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbPO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbPO.FormattingEnabled = true;
            this.cbPO.Location = new System.Drawing.Point(408, 30);
            this.cbPO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPO.Name = "cbPO";
            this.cbPO.Size = new System.Drawing.Size(265, 28);
            this.cbPO.TabIndex = 2;
            this.cbPO.SelectedIndexChanged += new System.EventHandler(this.cbPO_SelectedIndexChanged);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReturnDate.Location = new System.Drawing.Point(685, 30);
            this.dtpReturnDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(185, 27);
            this.dtpReturnDate.TabIndex = 3;
            // 
            // txtReason
            // 
            this.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReason.Location = new System.Drawing.Point(11, 89);
            this.txtReason.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(1066, 27);
            this.txtReason.TabIndex = 4;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblSupplier.Location = new System.Drawing.Point(11, 10);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(122, 19);
            this.lblSupplier.TabIndex = 5;
            this.lblSupplier.Text = "Principal / Supplier";
            // 
            // lblPO
            // 
            this.lblPO.AutoSize = true;
            this.lblPO.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblPO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblPO.Location = new System.Drawing.Point(408, 10);
            this.lblPO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(120, 19);
            this.lblPO.TabIndex = 6;
            this.lblPO.Text = "No. PO (Referensi)";
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblReturnDate.Location = new System.Drawing.Point(685, 10);
            this.lblReturnDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(74, 19);
            this.lblReturnDate.TabIndex = 7;
            this.lblReturnDate.Text = "Tgl. Return";
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.lblReason.Location = new System.Drawing.Point(11, 69);
            this.lblReason.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(94, 19);
            this.lblReason.TabIndex = 8;
            this.lblReason.Text = "Alasan Return";
            // 
            // pnlHidden
            // 
            this.pnlHidden.Controls.Add(this.txtReturnId);
            this.pnlHidden.Controls.Add(this.txtModifiedAt);
            this.pnlHidden.Location = new System.Drawing.Point(0, 985);
            this.pnlHidden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHidden.Name = "pnlHidden";
            this.pnlHidden.Size = new System.Drawing.Size(533, 37);
            this.pnlHidden.TabIndex = 99;
            this.pnlHidden.Visible = false;
            // 
            // txtReturnId
            // 
            this.txtReturnId.Location = new System.Drawing.Point(0, 0);
            this.txtReturnId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtReturnId.Name = "txtReturnId";
            this.txtReturnId.Size = new System.Drawing.Size(239, 22);
            this.txtReturnId.TabIndex = 0;
            // 
            // txtModifiedAt
            // 
            this.txtModifiedAt.Location = new System.Drawing.Point(253, 0);
            this.txtModifiedAt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(239, 22);
            this.txtModifiedAt.TabIndex = 1;
            // 
            // FrmPurchaseReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1813, 886);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlTopSep);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlHidden);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmPurchaseReturn";
            this.Text = "RETUR BELI";
            this.Load += new System.EventHandler(this.FrmPurchaseReturn_Load);
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
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.Label lblItemsTitle;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.Label lblReason;
    }
}
