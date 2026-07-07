namespace CisWindowsFormsApp
{
    partial class FrmCompanyInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCompanyInfo));
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.txtPbf = new System.Windows.Forms.TextBox();
            this.txtNpwp = new System.Windows.Forms.TextBox();
            this.txtPicName = new System.Windows.Forms.TextBox();
            this.txtPicLincenseNo = new System.Windows.Forms.TextBox();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.gbLicense = new System.Windows.Forms.GroupBox();
            this.gbPic = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            System.Windows.Forms.Panel pnlActionBar = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlContent = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlCard = new System.Windows.Forms.Panel();
            System.Windows.Forms.Label lblName = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblAddress = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblPhone = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblEmail = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblWeb = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblPbf = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblNpwp = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblPicName = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblPicLicense = new System.Windows.Forms.Label();
            this.gbContact.SuspendLayout();
            this.gbLicense.SuspendLayout();
            this.gbPic.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlCard.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlActionBar
            //
            pnlActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            pnlActionBar.Controls.Add(this.btnSave);
            pnlActionBar.Controls.Add(this.btnReload);
            pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlActionBar.Location = new System.Drawing.Point(0, 0);
            pnlActionBar.Name = "pnlActionBar";
            pnlActionBar.Size = new System.Drawing.Size(980, 52);
            pnlActionBar.TabIndex = 0;
            //
            // btnReload
            //
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.Location = new System.Drawing.Point(762, 10);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(100, 32);
            this.btnReload.TabIndex = 0;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            //
            // btnSave
            //
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(16)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(870, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 32);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Simpan";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            //
            // pnlContent
            //
            pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            pnlContent.Controls.Add(pnlCard);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 52);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(8);
            pnlContent.Size = new System.Drawing.Size(980, 468);
            pnlContent.TabIndex = 1;
            //
            // pnlCard
            //
            pnlCard.BackColor = System.Drawing.Color.White;
            pnlCard.Controls.Add(this.gbContact);
            pnlCard.Controls.Add(this.gbLicense);
            pnlCard.Controls.Add(this.gbPic);
            pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCard.Location = new System.Drawing.Point(8, 8);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new System.Windows.Forms.Padding(16);
            pnlCard.Size = new System.Drawing.Size(964, 452);
            pnlCard.TabIndex = 0;
            //
            // gbContact
            //
            this.gbContact.Controls.Add(lblName);
            this.gbContact.Controls.Add(this.txtName);
            this.gbContact.Controls.Add(lblAddress);
            this.gbContact.Controls.Add(this.txtAddress);
            this.gbContact.Controls.Add(lblPhone);
            this.gbContact.Controls.Add(this.txtPhone);
            this.gbContact.Controls.Add(lblEmail);
            this.gbContact.Controls.Add(this.txtEmail);
            this.gbContact.Controls.Add(lblWeb);
            this.gbContact.Controls.Add(this.txtWeb);
            this.gbContact.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.gbContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbContact.Location = new System.Drawing.Point(16, 16);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(448, 408);
            this.gbContact.TabIndex = 0;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Kontak Perusahaan";
            //
            // lblName
            //
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblName.Location = new System.Drawing.Point(8, 22);
            lblName.Name = "lblName";
            lblName.TabIndex = 0;
            lblName.Text = "Nama Perusahaan";
            //
            // txtName
            //
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(8, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(424, 23);
            this.txtName.TabIndex = 1;
            //
            // lblAddress
            //
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblAddress.Location = new System.Drawing.Point(8, 72);
            lblAddress.Name = "lblAddress";
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Alamat Perusahaan";
            //
            // txtAddress
            //
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress.Location = new System.Drawing.Point(8, 88);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(424, 64);
            this.txtAddress.TabIndex = 2;
            //
            // lblPhone
            //
            lblPhone.AutoSize = true;
            lblPhone.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblPhone.Location = new System.Drawing.Point(8, 164);
            lblPhone.Name = "lblPhone";
            lblPhone.TabIndex = 0;
            lblPhone.Text = "No. Telepon";
            //
            // txtPhone
            //
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.Location = new System.Drawing.Point(8, 180);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(200, 23);
            this.txtPhone.TabIndex = 3;
            //
            // lblEmail
            //
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblEmail.Location = new System.Drawing.Point(8, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            //
            // txtEmail
            //
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(8, 232);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.TabIndex = 4;
            //
            // lblWeb
            //
            lblWeb.AutoSize = true;
            lblWeb.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblWeb.Location = new System.Drawing.Point(8, 268);
            lblWeb.Name = "lblWeb";
            lblWeb.TabIndex = 0;
            lblWeb.Text = "Website";
            //
            // txtWeb
            //
            this.txtWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWeb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtWeb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWeb.Location = new System.Drawing.Point(8, 284);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(300, 23);
            this.txtWeb.TabIndex = 5;
            //
            // gbLicense
            //
            this.gbLicense.Controls.Add(lblPbf);
            this.gbLicense.Controls.Add(this.txtPbf);
            this.gbLicense.Controls.Add(lblNpwp);
            this.gbLicense.Controls.Add(this.txtNpwp);
            this.gbLicense.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.gbLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbLicense.Location = new System.Drawing.Point(480, 16);
            this.gbLicense.Name = "gbLicense";
            this.gbLicense.Size = new System.Drawing.Size(448, 160);
            this.gbLicense.TabIndex = 1;
            this.gbLicense.TabStop = false;
            this.gbLicense.Text = "Ijin Perusahaan";
            //
            // lblPbf
            //
            lblPbf.AutoSize = true;
            lblPbf.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblPbf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblPbf.Location = new System.Drawing.Point(8, 22);
            lblPbf.Name = "lblPbf";
            lblPbf.TabIndex = 0;
            lblPbf.Text = "No. Izin PBOT";
            //
            // txtPbf
            //
            this.txtPbf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPbf.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPbf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPbf.Location = new System.Drawing.Point(8, 38);
            this.txtPbf.Name = "txtPbf";
            this.txtPbf.Size = new System.Drawing.Size(424, 23);
            this.txtPbf.TabIndex = 1;
            //
            // lblNpwp
            //
            lblNpwp.AutoSize = true;
            lblNpwp.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblNpwp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblNpwp.Location = new System.Drawing.Point(8, 76);
            lblNpwp.Name = "lblNpwp";
            lblNpwp.TabIndex = 0;
            lblNpwp.Text = "NPWP";
            //
            // txtNpwp
            //
            this.txtNpwp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNpwp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNpwp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNpwp.Location = new System.Drawing.Point(8, 92);
            this.txtNpwp.Name = "txtNpwp";
            this.txtNpwp.Size = new System.Drawing.Size(424, 23);
            this.txtNpwp.TabIndex = 2;
            //
            // gbPic
            //
            this.gbPic.Controls.Add(lblPicName);
            this.gbPic.Controls.Add(this.txtPicName);
            this.gbPic.Controls.Add(lblPicLicense);
            this.gbPic.Controls.Add(this.txtPicLincenseNo);
            this.gbPic.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.gbPic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbPic.Location = new System.Drawing.Point(480, 192);
            this.gbPic.Name = "gbPic";
            this.gbPic.Size = new System.Drawing.Size(448, 160);
            this.gbPic.TabIndex = 2;
            this.gbPic.TabStop = false;
            this.gbPic.Text = "Penanggung Jawab";
            //
            // lblPicName
            //
            lblPicName.AutoSize = true;
            lblPicName.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblPicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblPicName.Location = new System.Drawing.Point(8, 22);
            lblPicName.Name = "lblPicName";
            lblPicName.TabIndex = 0;
            lblPicName.Text = "Nama";
            //
            // txtPicName
            //
            this.txtPicName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPicName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPicName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPicName.Location = new System.Drawing.Point(8, 38);
            this.txtPicName.Name = "txtPicName";
            this.txtPicName.Size = new System.Drawing.Size(424, 23);
            this.txtPicName.TabIndex = 1;
            //
            // lblPicLicense
            //
            lblPicLicense.AutoSize = true;
            lblPicLicense.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblPicLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblPicLicense.Location = new System.Drawing.Point(8, 76);
            lblPicLicense.Name = "lblPicLicense";
            lblPicLicense.TabIndex = 0;
            lblPicLicense.Text = "No. SIPTTK";
            //
            // txtPicLincenseNo
            //
            this.txtPicLincenseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPicLincenseNo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPicLincenseNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPicLincenseNo.Location = new System.Drawing.Point(8, 92);
            this.txtPicLincenseNo.Name = "txtPicLincenseNo";
            this.txtPicLincenseNo.Size = new System.Drawing.Size(424, 23);
            this.txtPicLincenseNo.TabIndex = 2;
            //
            // FrmCompanyInfo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 520);
            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlActionBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompanyInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INFO PERUSAHAAN";
            this.Load += new System.EventHandler(this.FrmCompanyInfo_Load);
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbLicense.ResumeLayout(false);
            this.gbLicense.PerformLayout();
            this.gbPic.ResumeLayout(false);
            this.gbPic.PerformLayout();
            pnlCard.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.TextBox txtPbf;
        private System.Windows.Forms.TextBox txtNpwp;
        private System.Windows.Forms.TextBox txtPicName;
        private System.Windows.Forms.TextBox txtPicLincenseNo;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.GroupBox gbLicense;
        private System.Windows.Forms.GroupBox gbPic;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReload;
    }
}
