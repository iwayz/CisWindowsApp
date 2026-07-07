
namespace CisWindowsFormsApp
{
    partial class FrmBackupDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackupDatabase));
            this.btnBackup = new System.Windows.Forms.Button();
            this.pbExport = new System.Windows.Forms.ProgressBar();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.backgroundWorkerBackup = new System.ComponentModel.BackgroundWorker();
            System.Windows.Forms.Panel pnlActionBar = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlContent = new System.Windows.Forms.Panel();
            System.Windows.Forms.Panel pnlCard = new System.Windows.Forms.Panel();
            System.Windows.Forms.GroupBox gbProgress = new System.Windows.Forms.GroupBox();
            System.Windows.Forms.Label lblNoticeHeader = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblNoticeText = new System.Windows.Forms.Label();
            System.Windows.Forms.Label lblFileLocation = new System.Windows.Forms.Label();
            pnlContent.SuspendLayout();
            pnlCard.SuspendLayout();
            gbProgress.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlActionBar
            //
            pnlActionBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            pnlActionBar.Controls.Add(this.btnBackup);
            pnlActionBar.Dock = System.Windows.Forms.DockStyle.Top;
            pnlActionBar.Location = new System.Drawing.Point(0, 0);
            pnlActionBar.Name = "pnlActionBar";
            pnlActionBar.Size = new System.Drawing.Size(680, 52);
            pnlActionBar.TabIndex = 0;
            //
            // btnBackup
            //
            this.btnBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnBackup.FlatAppearance.BorderSize = 0;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBackup.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Location = new System.Drawing.Point(564, 10);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(108, 32);
            this.btnBackup.TabIndex = 0;
            this.btnBackup.Text = "Back Up";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            //
            // pnlContent
            //
            pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            pnlContent.Controls.Add(pnlCard);
            pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlContent.Location = new System.Drawing.Point(0, 52);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new System.Windows.Forms.Padding(8);
            pnlContent.Size = new System.Drawing.Size(680, 268);
            pnlContent.TabIndex = 1;
            //
            // pnlCard
            //
            pnlCard.BackColor = System.Drawing.Color.White;
            pnlCard.Controls.Add(lblNoticeHeader);
            pnlCard.Controls.Add(lblNoticeText);
            pnlCard.Controls.Add(gbProgress);
            pnlCard.Controls.Add(lblFileLocation);
            pnlCard.Controls.Add(this.txtFileLocation);
            pnlCard.Controls.Add(this.btnBrowse);
            pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlCard.Location = new System.Drawing.Point(8, 8);
            pnlCard.Name = "pnlCard";
            pnlCard.Padding = new System.Windows.Forms.Padding(16);
            pnlCard.Size = new System.Drawing.Size(664, 252);
            pnlCard.TabIndex = 0;
            //
            // lblNoticeHeader
            //
            lblNoticeHeader.AutoSize = true;
            lblNoticeHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            lblNoticeHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
            lblNoticeHeader.Location = new System.Drawing.Point(16, 16);
            lblNoticeHeader.Name = "lblNoticeHeader";
            lblNoticeHeader.TabIndex = 0;
            lblNoticeHeader.Text = "Perhatian:";
            //
            // lblNoticeText
            //
            lblNoticeText.AutoSize = true;
            lblNoticeText.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblNoticeText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblNoticeText.Location = new System.Drawing.Point(16, 32);
            lblNoticeText.Name = "lblNoticeText";
            lblNoticeText.TabIndex = 1;
            lblNoticeText.Text = "Untuk kelancaran proses backup, pastikan tidak ada transaksi yang diproses di aplikasi client.";
            //
            // gbProgress
            //
            gbProgress.Controls.Add(this.pbExport);
            gbProgress.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            gbProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            gbProgress.Location = new System.Drawing.Point(16, 60);
            gbProgress.Name = "gbProgress";
            gbProgress.Size = new System.Drawing.Size(632, 68);
            gbProgress.TabIndex = 2;
            gbProgress.TabStop = false;
            gbProgress.Text = "Progress";
            //
            // pbExport
            //
            this.pbExport.Location = new System.Drawing.Point(8, 24);
            this.pbExport.Name = "pbExport";
            this.pbExport.Size = new System.Drawing.Size(616, 24);
            this.pbExport.TabIndex = 0;
            //
            // lblFileLocation
            //
            lblFileLocation.AutoSize = true;
            lblFileLocation.Font = new System.Drawing.Font("Segoe UI", 8F);
            lblFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            lblFileLocation.Location = new System.Drawing.Point(16, 144);
            lblFileLocation.Name = "lblFileLocation";
            lblFileLocation.TabIndex = 3;
            lblFileLocation.Text = "Lokasi File";
            //
            // txtFileLocation
            //
            this.txtFileLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtFileLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileLocation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFileLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFileLocation.Location = new System.Drawing.Point(16, 160);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(516, 23);
            this.txtFileLocation.TabIndex = 4;
            //
            // btnBrowse
            //
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(540, 160);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(108, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Buka Folder";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            //
            // backgroundWorkerBackup
            //
            this.backgroundWorkerBackup.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerBackup_DoWork);
            this.backgroundWorkerBackup.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerBackup_ProgressChanged);
            this.backgroundWorkerBackup.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerBackup_RunWorkerCompleted);
            //
            // FrmBackupDatabase
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(680, 320);
            this.Controls.Add(pnlContent);
            this.Controls.Add(pnlActionBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackupDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BACKUP DATABASE";
            this.Load += new System.EventHandler(this.FrmBackupDatabase_Load);
            gbProgress.ResumeLayout(false);
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.ProgressBar pbExport;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.Button btnBrowse;
        private System.ComponentModel.BackgroundWorker backgroundWorkerBackup;
    }
}
