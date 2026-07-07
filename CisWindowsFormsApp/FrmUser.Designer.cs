namespace CisWindowsFormsApp
{
    partial class FrmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));

            // panels
            this.pnlActionBar      = new System.Windows.Forms.Panel();
            this.pnlContent        = new System.Windows.Forms.Panel();
            this.pnlLeft           = new System.Windows.Forms.Panel();
            this.pnlLeftSpacer     = new System.Windows.Forms.Panel();
            this.pnlRight          = new System.Windows.Forms.Panel();
            this.pnlSearch         = new System.Windows.Forms.Panel();
            this.pnlRetypePassword = new System.Windows.Forms.Panel();
            this.pnlHiddenFields   = new System.Windows.Forms.Panel();

            // action bar buttons
            this.btnClear  = new System.Windows.Forms.Button();
            this.btnAdd    = new System.Windows.Forms.Button();
            this.btnSave   = new System.Windows.Forms.Button();
            this.btnDel    = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();

            // search
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            // form fields
            this.txtUsername       = new System.Windows.Forms.TextBox();
            this.cbRole            = new System.Windows.Forms.ComboBox();
            this.txtFullName       = new System.Windows.Forms.TextBox();
            this.txtPassword       = new System.Windows.Forms.TextBox();
            this.chkChangePassword = new System.Windows.Forms.CheckBox();
            this.txtRetypePassword = new System.Windows.Forms.TextBox();
            this.txtDescription    = new System.Windows.Forms.TextBox();

            // grid
            this.dgvUser = new System.Windows.Forms.DataGridView();

            // hidden
            this.txtUserId            = new System.Windows.Forms.TextBox();
            this.txtUserRoleId        = new System.Windows.Forms.TextBox();
            this.txtRoleId            = new System.Windows.Forms.TextBox();
            this.txtUserModifiedAt    = new System.Windows.Forms.TextBox();
            this.txtUserRoleModifiedAt = new System.Windows.Forms.TextBox();

            this.pnlActionBar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlRetypePassword.SuspendLayout();
            this.pnlHiddenFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.SuspendLayout();

            // ── pnlActionBar ──────────────────────────
            this.pnlActionBar.BackColor = System.Drawing.Color.FromArgb(228, 230, 233);
            this.pnlActionBar.Controls.Add(this.btnReload);
            this.pnlActionBar.Controls.Add(this.btnDel);
            this.pnlActionBar.Controls.Add(this.btnSave);
            this.pnlActionBar.Controls.Add(this.btnAdd);
            this.pnlActionBar.Controls.Add(this.btnClear);
            this.pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActionBar.Name = "pnlActionBar";
            this.pnlActionBar.Size = new System.Drawing.Size(1360, 52);
            this.pnlActionBar.TabIndex = 0;

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(11, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 34);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(141, 9);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSave.BackColor = System.Drawing.Color.FromArgb(16, 124, 16);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(261, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 34);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnDel.BackColor = System.Drawing.Color.FromArgb(196, 43, 28);
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(381, 9);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(109, 34);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);

            this.btnReload.BackColor = System.Drawing.Color.FromArgb(100, 100, 100);
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(501, 9);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(109, 34);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);

            // ── pnlContent ────────────────────────────
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.pnlContent.Controls.Add(this.pnlRight);
            this.pnlContent.Controls.Add(this.pnlLeftSpacer);
            this.pnlContent.Controls.Add(this.pnlLeft);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(8);
            this.pnlContent.TabIndex = 1;

            // ── pnlLeft (white card) ──────────────────
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(8);
            this.pnlLeft.Size = new System.Drawing.Size(400, 600);
            this.pnlLeft.TabIndex = 0;

            // ── pnlLeftSpacer ─────────────────────────
            this.pnlLeftSpacer.BackColor = System.Drawing.Color.Transparent;
            this.pnlLeftSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftSpacer.Name = "pnlLeftSpacer";
            this.pnlLeftSpacer.Size = new System.Drawing.Size(8, 600);
            this.pnlLeftSpacer.TabIndex = 1;

            // ── pnlRight ──────────────────────────────
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.Controls.Add(this.dgvUser);
            this.pnlRight.Controls.Add(this.pnlSearch);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Padding = new System.Windows.Forms.Padding(4);
            this.pnlRight.TabIndex = 2;

            // ── pnlSearch (Top, 42px) ─────────────────
            this.pnlSearch.BackColor = System.Drawing.Color.White;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(900, 42);
            this.pnlSearch.TabIndex = 0;

            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(4, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 23);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);

            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(312, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 28);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // ── Form fields inside pnlLeft ────────────

            // --- Row 1: Username ---
            var lblUsername = new System.Windows.Forms.Label();
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblUsername.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblUsername.Location = new System.Drawing.Point(8, 8);
            lblUsername.Text = "Username";
            this.pnlLeft.Controls.Add(lblUsername);

            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Location = new System.Drawing.Point(8, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 23);
            this.txtUsername.TabIndex = 1;
            this.pnlLeft.Controls.Add(this.txtUsername);

            // --- Row 2: User Role ---
            var lblRole = new System.Windows.Forms.Label();
            lblRole.AutoSize = true;
            lblRole.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblRole.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblRole.Location = new System.Drawing.Point(8, 56);
            lblRole.Text = "User Role";
            this.pnlLeft.Controls.Add(lblRole);

            this.cbRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(8, 72);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(300, 23);
            this.cbRole.TabIndex = 2;
            this.pnlLeft.Controls.Add(this.cbRole);

            // --- Row 3: Nama Lengkap ---
            var lblFullName = new System.Windows.Forms.Label();
            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblFullName.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblFullName.Location = new System.Drawing.Point(8, 104);
            lblFullName.Text = "Nama Lengkap";
            this.pnlLeft.Controls.Add(lblFullName);

            this.txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFullName.Location = new System.Drawing.Point(8, 120);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(364, 23);
            this.txtFullName.TabIndex = 3;
            this.pnlLeft.Controls.Add(this.txtFullName);

            // --- Row 4: Password ---
            var lblPassword = new System.Windows.Forms.Label();
            lblPassword.AutoSize = true;
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblPassword.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblPassword.Location = new System.Drawing.Point(8, 152);
            lblPassword.Text = "Password";
            this.pnlLeft.Controls.Add(lblPassword);

            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(8, 168);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 23);
            this.txtPassword.TabIndex = 4;
            this.pnlLeft.Controls.Add(this.txtPassword);

            // --- Row 5: Change Password checkbox ---
            this.chkChangePassword.AutoSize = true;
            this.chkChangePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkChangePassword.ForeColor = System.Drawing.Color.Gray;
            this.chkChangePassword.Location = new System.Drawing.Point(8, 200);
            this.chkChangePassword.Name = "chkChangePassword";
            this.chkChangePassword.Size = new System.Drawing.Size(110, 19);
            this.chkChangePassword.TabIndex = 5;
            this.chkChangePassword.Text = "Ganti Password";
            this.chkChangePassword.Visible = false;
            this.chkChangePassword.CheckedChanged += new System.EventHandler(this.chkChangePassword_CheckedChanged);
            this.pnlLeft.Controls.Add(this.chkChangePassword);

            // --- Row 6: pnlRetypePassword (conditionally visible) ---
            var lblRetypePassword = new System.Windows.Forms.Label();
            lblRetypePassword.AutoSize = true;
            lblRetypePassword.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblRetypePassword.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblRetypePassword.Location = new System.Drawing.Point(0, 0);
            lblRetypePassword.Text = "Retype Password";

            this.txtRetypePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRetypePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRetypePassword.Location = new System.Drawing.Point(0, 16);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.PasswordChar = '*';
            this.txtRetypePassword.Size = new System.Drawing.Size(300, 23);
            this.txtRetypePassword.TabIndex = 6;

            this.pnlRetypePassword.Controls.Add(this.txtRetypePassword);
            this.pnlRetypePassword.Controls.Add(lblRetypePassword);
            this.pnlRetypePassword.Location = new System.Drawing.Point(8, 224);
            this.pnlRetypePassword.Name = "pnlRetypePassword";
            this.pnlRetypePassword.Size = new System.Drawing.Size(364, 44);
            this.pnlRetypePassword.TabIndex = 7;
            this.pnlRetypePassword.Visible = false;
            this.pnlLeft.Controls.Add(this.pnlRetypePassword);

            // --- Row 7: Keterangan ---
            var lblDescription = new System.Windows.Forms.Label();
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblDescription.ForeColor = System.Drawing.Color.FromArgb(96, 96, 96);
            lblDescription.Location = new System.Drawing.Point(8, 276);
            lblDescription.Text = "Keterangan";
            this.pnlLeft.Controls.Add(lblDescription);

            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescription.Location = new System.Drawing.Point(8, 292);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(364, 52);
            this.txtDescription.TabIndex = 8;
            this.pnlLeft.Controls.Add(this.txtDescription);

            // ── pnlHiddenFields ───────────────────────
            this.txtUserId.Location = new System.Drawing.Point(0, 0);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(175, 23);
            this.txtUserId.TabIndex = 0;

            this.txtUserRoleId.Location = new System.Drawing.Point(185, 0);
            this.txtUserRoleId.Name = "txtUserRoleId";
            this.txtUserRoleId.Size = new System.Drawing.Size(175, 23);
            this.txtUserRoleId.TabIndex = 1;

            this.txtRoleId.Location = new System.Drawing.Point(370, 0);
            this.txtRoleId.Name = "txtRoleId";
            this.txtRoleId.Size = new System.Drawing.Size(175, 23);
            this.txtRoleId.TabIndex = 2;

            this.txtUserModifiedAt.Location = new System.Drawing.Point(0, 30);
            this.txtUserModifiedAt.Name = "txtUserModifiedAt";
            this.txtUserModifiedAt.Size = new System.Drawing.Size(175, 23);
            this.txtUserModifiedAt.TabIndex = 3;

            this.txtUserRoleModifiedAt.Location = new System.Drawing.Point(185, 30);
            this.txtUserRoleModifiedAt.Name = "txtUserRoleModifiedAt";
            this.txtUserRoleModifiedAt.Size = new System.Drawing.Size(175, 23);
            this.txtUserRoleModifiedAt.TabIndex = 4;

            this.pnlHiddenFields.Controls.Add(this.txtUserId);
            this.pnlHiddenFields.Controls.Add(this.txtUserRoleId);
            this.pnlHiddenFields.Controls.Add(this.txtRoleId);
            this.pnlHiddenFields.Controls.Add(this.txtUserModifiedAt);
            this.pnlHiddenFields.Controls.Add(this.txtUserRoleModifiedAt);
            this.pnlHiddenFields.Location = new System.Drawing.Point(0, 900);
            this.pnlHiddenFields.Name = "pnlHiddenFields";
            this.pnlHiddenFields.Size = new System.Drawing.Size(600, 60);
            this.pnlHiddenFields.TabIndex = 99;
            this.pnlHiddenFields.Visible = false;

            // ── dgvUser ───────────────────────────────
            var dgvHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvHeaderStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            dgvHeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dgvHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);

            var dgvDefaultStyle = new System.Windows.Forms.DataGridViewCellStyle();
            dgvDefaultStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dgvDefaultStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 228, 247);
            dgvDefaultStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUser.ColumnHeadersDefaultCellStyle = dgvHeaderStyle;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.DefaultCellStyle = dgvDefaultStyle;
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.GridColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);

            // ── FrmUser ───────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlActionBar);
            this.Controls.Add(this.pnlHiddenFields);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUser";
            this.Text = "User";
            this.Load += new System.EventHandler(this.FrmUser_Load);

            this.pnlActionBar.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlRetypePassword.ResumeLayout(false);
            this.pnlRetypePassword.PerformLayout();
            this.pnlHiddenFields.ResumeLayout(false);
            this.pnlHiddenFields.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlActionBar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLeftSpacer;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlRetypePassword;
        private System.Windows.Forms.Panel pnlHiddenFields;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkChangePassword;
        private System.Windows.Forms.TextBox txtRetypePassword;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtUserRoleId;
        private System.Windows.Forms.TextBox txtRoleId;
        private System.Windows.Forms.TextBox txtUserModifiedAt;
        private System.Windows.Forms.TextBox txtUserRoleModifiedAt;
    }
}
