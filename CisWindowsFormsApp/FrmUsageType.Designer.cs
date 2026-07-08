namespace CisWindowsFormsApp
{
    partial class FrmUsageType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsageType));

            this.txtModifiedAt    = new System.Windows.Forms.TextBox();
            this.txtUsageId       = new System.Windows.Forms.TextBox();
            this.label1           = new System.Windows.Forms.Label();
            this.label2           = new System.Windows.Forms.Label();
            this.dgvUsageType     = new System.Windows.Forms.DataGridView();
            this.btnClear         = new System.Windows.Forms.Button();
            this.btnAdd           = new System.Windows.Forms.Button();
            this.btnSave          = new System.Windows.Forms.Button();
            this.btnDel           = new System.Windows.Forms.Button();
            this.btnReload        = new System.Windows.Forms.Button();
            this.label3           = new System.Windows.Forms.Label();
            this.txtUsageDesc     = new System.Windows.Forms.TextBox();
            this.panel1           = new System.Windows.Forms.Panel();
            this.label4           = new System.Windows.Forms.Label();
            this.txtUsageTypeCode = new System.Windows.Forms.TextBox();
            this.btnSearch        = new System.Windows.Forms.Button();
            this.txtSearch        = new System.Windows.Forms.TextBox();

            System.Windows.Forms.Panel pnlActionBar = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlContent   = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlLeft      = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlSpacer    = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlRight     = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlSearch    = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dgvUsageType)).BeginInit();
            this.panel1.SuspendLayout();
            pnlActionBar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlLeft.SuspendLayout();
            pnlRight.SuspendLayout();
            pnlSearch.SuspendLayout();
            this.SuspendLayout();

            System.Drawing.Font fieldFont  = new System.Drawing.Font("Segoe UI", 9F);
            System.Drawing.Font labelFont  = new System.Drawing.Font("Segoe UI", 8F);
            System.Drawing.Color labelColor = System.Drawing.Color.FromArgb(96, 96, 96);

            // pnlActionBar
            pnlActionBar.BackColor = System.Drawing.Color.FromArgb(228, 230, 233);
            pnlActionBar.Controls.Add(this.btnDel);
            pnlActionBar.Controls.Add(this.btnSave);
            pnlActionBar.Controls.Add(this.btnAdd);
            pnlActionBar.Controls.Add(this.btnClear);
            pnlActionBar.Controls.Add(this.btnReload);
            pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlActionBar.Location = new System.Drawing.Point(0, 0);
            pnlActionBar.Name = "pnlActionBar";
            pnlActionBar.Size = new System.Drawing.Size(800, 52);
            pnlActionBar.TabIndex = 0;

            // btnReload
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(8, 10);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(108, 32);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);

            // btnClear
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(124, 10);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 32);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // btnAdd
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(240, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnSave
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(356, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnDel
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(472, 10);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(108, 32);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);

            // pnlContent
            pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlContent.Controls.Add(pnlRight);
            pnlContent.Controls.Add(pnlSpacer);
            pnlContent.Controls.Add(pnlLeft);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 52);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(8);
            pnlContent.TabIndex = 1;

            // pnlLeft
            pnlLeft.BackColor = System.Drawing.Color.White;
            pnlLeft.Controls.Add(label4);
            pnlLeft.Controls.Add(this.txtUsageTypeCode);
            pnlLeft.Controls.Add(this.label3);
            pnlLeft.Controls.Add(this.txtUsageDesc);
            pnlLeft.Controls.Add(this.panel1);
            pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            pnlLeft.Location = new System.Drawing.Point(8, 8);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Padding = new System.Windows.Forms.Padding(16);
            pnlLeft.Size = new System.Drawing.Size(280, 452);
            pnlLeft.TabIndex = 0;

            // label4 — Kode Pemakaian
            this.label4 = new System.Windows.Forms.Label();
            this.label4.AutoSize = true;
            this.label4.Font = labelFont;
            this.label4.ForeColor = labelColor;
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.TabIndex = 0;
            this.label4.Text = "Kode Pemakaian";

            // txtUsageTypeCode
            this.txtUsageTypeCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsageTypeCode.Font = fieldFont;
            this.txtUsageTypeCode.Location = new System.Drawing.Point(16, 32);
            this.txtUsageTypeCode.Name = "txtUsageTypeCode";
            this.txtUsageTypeCode.Size = new System.Drawing.Size(140, 23);
            this.txtUsageTypeCode.TabIndex = 1;

            // label3 — Keterangan Pemakaian
            this.label3 = new System.Windows.Forms.Label();
            this.label3.AutoSize = true;
            this.label3.Font = labelFont;
            this.label3.ForeColor = labelColor;
            this.label3.Location = new System.Drawing.Point(16, 64);
            this.label3.Name = "label3";
            this.label3.TabIndex = 2;
            this.label3.Text = "Keterangan Pemakaian";

            // txtUsageDesc
            this.txtUsageDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsageDesc.Font = fieldFont;
            this.txtUsageDesc.Location = new System.Drawing.Point(16, 80);
            this.txtUsageDesc.Name = "txtUsageDesc";
            this.txtUsageDesc.Size = new System.Drawing.Size(232, 23);
            this.txtUsageDesc.TabIndex = 2;

            // panel1 (hidden — holds txtUsageId and txtModifiedAt for concurrency)
            this.panel1.Controls.Add(this.txtUsageId);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtModifiedAt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 72);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;

            // label2 — Id
            this.label2.AutoSize = true;
            this.label2.Font = labelFont;
            this.label2.ForeColor = labelColor;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.TabIndex = 0;
            this.label2.Text = "Id";

            // txtUsageId
            this.txtUsageId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsageId.Font = fieldFont;
            this.txtUsageId.Location = new System.Drawing.Point(0, 16);
            this.txtUsageId.Name = "txtUsageId";
            this.txtUsageId.Size = new System.Drawing.Size(110, 23);
            this.txtUsageId.TabIndex = 1;

            // label1 — Modified At
            this.label1.AutoSize = true;
            this.label1.Font = labelFont;
            this.label1.ForeColor = labelColor;
            this.label1.Location = new System.Drawing.Point(120, 0);
            this.label1.Name = "label1";
            this.label1.TabIndex = 2;
            this.label1.Text = "Modified At";

            // txtModifiedAt
            this.txtModifiedAt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtModifiedAt.Font = fieldFont;
            this.txtModifiedAt.Location = new System.Drawing.Point(120, 16);
            this.txtModifiedAt.Name = "txtModifiedAt";
            this.txtModifiedAt.Size = new System.Drawing.Size(110, 23);
            this.txtModifiedAt.TabIndex = 3;

            // pnlSpacer
            pnlSpacer.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            pnlSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            pnlSpacer.Location = new System.Drawing.Point(288, 8);
            pnlSpacer.Name = "pnlSpacer";
            pnlSpacer.Size = new System.Drawing.Size(8, 452);
            pnlSpacer.TabIndex = 1;

            // pnlRight
            pnlRight.BackColor = System.Drawing.Color.White;
            pnlRight.Controls.Add(this.dgvUsageType);
            pnlRight.Controls.Add(pnlSearch);
            pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlRight.Location = new System.Drawing.Point(296, 8);
            pnlRight.Name = "pnlRight";
            pnlRight.Padding = new System.Windows.Forms.Padding(8);
            pnlRight.TabIndex = 2;

            // pnlSearch
            pnlSearch.Controls.Add(this.btnSearch);
            pnlSearch.Controls.Add(this.txtSearch);
            pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            pnlSearch.Location = new System.Drawing.Point(8, 8);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new System.Drawing.Size(468, 32);
            pnlSearch.TabIndex = 0;

            // txtSearch
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = fieldFont;
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(432, 23);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);

            // btnSearch
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = fieldFont;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(436, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "🔍";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // dgvUsageType
            this.dgvUsageType.AllowUserToAddRows = false;
            this.dgvUsageType.AllowUserToDeleteRows = false;
            this.dgvUsageType.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsageType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsageType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsageType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsageType.Font = fieldFont;
            this.dgvUsageType.GridColor = System.Drawing.Color.FromArgb(228, 230, 233);
            this.dgvUsageType.Location = new System.Drawing.Point(8, 40);
            this.dgvUsageType.Name = "dgvUsageType";
            this.dgvUsageType.ReadOnly = true;
            this.dgvUsageType.RowHeadersVisible = false;
            this.dgvUsageType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsageType.TabIndex = 1;
            this.dgvUsageType.Click += new System.EventHandler(this.dgvUsageType_Click);

            // FrmUsageType
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlActionBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUsageType";
            this.Text = "JENIS PEMAKAIAN";
            this.Load += new System.EventHandler(this.FrmUsageType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsageType)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            pnlRight.ResumeLayout(false);
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlActionBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtModifiedAt;
        private System.Windows.Forms.TextBox txtUsageId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUsageType;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsageDesc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsageTypeCode;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}
