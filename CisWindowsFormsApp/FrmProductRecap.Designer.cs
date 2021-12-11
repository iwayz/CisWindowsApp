
namespace CisWindowsFormsApp
{
    partial class FrmProductRecap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductRecap));
            this.pnlProgress = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbExport = new System.Windows.Forms.ProgressBar();
            this.pnlCriteria = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.pnlResult = new System.Windows.Forms.Panel();
            this.txtFileLocation = new System.Windows.Forms.TextBox();
            this.lblFileLocation = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pnlProgress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlCriteria.SuspendLayout();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProgress
            // 
            this.pnlProgress.Controls.Add(this.groupBox1);
            this.pnlProgress.Location = new System.Drawing.Point(16, 90);
            this.pnlProgress.Name = "pnlProgress";
            this.pnlProgress.Size = new System.Drawing.Size(363, 92);
            this.pnlProgress.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbExport);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 71);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress";
            // 
            // pbExport
            // 
            this.pbExport.Location = new System.Drawing.Point(6, 28);
            this.pbExport.Name = "pbExport";
            this.pbExport.Size = new System.Drawing.Size(322, 23);
            this.pbExport.TabIndex = 24;
            // 
            // pnlCriteria
            // 
            this.pnlCriteria.Controls.Add(this.btnExport);
            this.pnlCriteria.Location = new System.Drawing.Point(16, 34);
            this.pnlCriteria.Name = "pnlCriteria";
            this.pnlCriteria.Size = new System.Drawing.Size(363, 44);
            this.pnlCriteria.TabIndex = 29;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(122, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(104, 30);
            this.btnExport.TabIndex = 23;
            this.btnExport.Text = "  EXPORT";
            this.btnExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.txtFileLocation);
            this.pnlResult.Controls.Add(this.lblFileLocation);
            this.pnlResult.Controls.Add(this.btnBrowse);
            this.pnlResult.Location = new System.Drawing.Point(16, 271);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(363, 100);
            this.pnlResult.TabIndex = 31;
            // 
            // txtFileLocation
            // 
            this.txtFileLocation.Font = new System.Drawing.Font("Calibri", 12F);
            this.txtFileLocation.Location = new System.Drawing.Point(12, 31);
            this.txtFileLocation.Name = "txtFileLocation";
            this.txtFileLocation.ReadOnly = true;
            this.txtFileLocation.Size = new System.Drawing.Size(334, 27);
            this.txtFileLocation.TabIndex = 24;
            // 
            // lblFileLocation
            // 
            this.lblFileLocation.AutoSize = true;
            this.lblFileLocation.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblFileLocation.Location = new System.Drawing.Point(9, 13);
            this.lblFileLocation.Name = "lblFileLocation";
            this.lblFileLocation.Size = new System.Drawing.Size(66, 15);
            this.lblFileLocation.TabIndex = 1;
            this.lblFileLocation.Text = "Lokasi File:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(141)))), ((int)(((byte)(193)))));
            this.btnBrowse.FlatAppearance.BorderSize = 0;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(242, 64);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(104, 30);
            this.btnBrowse.TabIndex = 23;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // FrmProductRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 221);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.pnlCriteria);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(410, 260);
            this.Name = "FrmProductRecap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REKAPITULASI PRODUK";
            this.Load += new System.EventHandler(this.FrmProductRecap_Load);
            this.pnlProgress.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.pnlCriteria.ResumeLayout(false);
            this.pnlResult.ResumeLayout(false);
            this.pnlResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar pbExport;
        private System.Windows.Forms.Panel pnlCriteria;
        private System.Windows.Forms.Button btnExport;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Panel pnlResult;
        private System.Windows.Forms.TextBox txtFileLocation;
        private System.Windows.Forms.Label lblFileLocation;
        private System.Windows.Forms.Button btnBrowse;
    }
}