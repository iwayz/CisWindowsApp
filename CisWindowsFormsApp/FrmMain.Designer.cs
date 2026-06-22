namespace CisWindowsFormsApp
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlLeftPane = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxDate = new System.Windows.Forms.PictureBox();
            this.lblToday = new System.Windows.Forms.Label();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnMasterData = new System.Windows.Forms.Button();
            this.pnlSeparatorLeftPane = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblCurrentUser = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlChildren = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblCompanyWeb = new System.Windows.Forms.Label();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLeftPane.SuspendLayout();
            this.pnlDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDate)).BeginInit();
            this.pnlSeparatorLeftPane.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel8.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftPane
            // 
            this.pnlLeftPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.pnlLeftPane.Controls.Add(this.btnLogout);
            this.pnlLeftPane.Controls.Add(this.pnlDateTime);
            this.pnlLeftPane.Controls.Add(this.btnReporting);
            this.pnlLeftPane.Controls.Add(this.btnInventory);
            this.pnlLeftPane.Controls.Add(this.btnTransaksi);
            this.pnlLeftPane.Controls.Add(this.btnMasterData);
            this.pnlLeftPane.Controls.Add(this.pnlSeparatorLeftPane);
            this.pnlLeftPane.Controls.Add(this.pnlLogo);
            this.pnlLeftPane.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftPane.Location = new System.Drawing.Point(0, 28);
            this.pnlLeftPane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLeftPane.Name = "pnlLeftPane";
            this.pnlLeftPane.Size = new System.Drawing.Size(229, 869);
            this.pnlLeftPane.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(239)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 447);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(229, 37);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(50)))), ((int)(((byte)(77)))));
            this.pnlDateTime.Controls.Add(this.panel3);
            this.pnlDateTime.Controls.Add(this.pictureBoxDate);
            this.pnlDateTime.Controls.Add(this.lblToday);
            this.pnlDateTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlDateTime.Location = new System.Drawing.Point(0, 731);
            this.pnlDateTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(229, 138);
            this.pnlDateTime.TabIndex = 3;
            this.toolTip.SetToolTip(this.pnlDateTime, "Such a beautiful day");
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(73, 5);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 2);
            this.panel3.TabIndex = 2;
            // 
            // pictureBoxDate
            // 
            this.pictureBoxDate.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxDate.Image")));
            this.pictureBoxDate.Location = new System.Drawing.Point(108, 20);
            this.pictureBoxDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxDate.Name = "pictureBoxDate";
            this.pictureBoxDate.Size = new System.Drawing.Size(16, 16);
            this.pictureBoxDate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDate.TabIndex = 1;
            this.pictureBoxDate.TabStop = false;
            // 
            // lblToday
            // 
            this.lblToday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblToday.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic);
            this.lblToday.ForeColor = System.Drawing.Color.White;
            this.lblToday.Location = new System.Drawing.Point(-4, 53);
            this.lblToday.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(237, 36);
            this.lblToday.TabIndex = 0;
            this.lblToday.Text = "Beautiful Day";
            this.lblToday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReporting
            // 
            this.btnReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(239)))));
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnReporting.ForeColor = System.Drawing.Color.White;
            this.btnReporting.Image = ((System.Drawing.Image)(resources.GetObject("btnReporting.Image")));
            this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.Location = new System.Drawing.Point(0, 410);
            this.btnReporting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnReporting.Size = new System.Drawing.Size(229, 37);
            this.btnReporting.TabIndex = 2;
            this.btnReporting.Text = "  Reporting";
            this.btnReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporting.UseVisualStyleBackColor = false;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(239)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 373);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(229, 37);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "  Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(239)))));
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnTransaksi.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaksi.Image")));
            this.btnTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 336);
            this.btnTransaksi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnTransaksi.Size = new System.Drawing.Size(229, 37);
            this.btnTransaksi.TabIndex = 2;
            this.btnTransaksi.Text = "  Transaksi";
            this.btnTransaksi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTransaksi.UseVisualStyleBackColor = false;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnMasterData
            // 
            this.btnMasterData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMasterData.FlatAppearance.BorderSize = 0;
            this.btnMasterData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(125)))), ((int)(((byte)(239)))));
            this.btnMasterData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasterData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnMasterData.ForeColor = System.Drawing.Color.White;
            this.btnMasterData.Image = ((System.Drawing.Image)(resources.GetObject("btnMasterData.Image")));
            this.btnMasterData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterData.Location = new System.Drawing.Point(0, 299);
            this.btnMasterData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMasterData.Name = "btnMasterData";
            this.btnMasterData.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMasterData.Size = new System.Drawing.Size(229, 37);
            this.btnMasterData.TabIndex = 2;
            this.btnMasterData.Text = "  Master Data";
            this.btnMasterData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMasterData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMasterData.UseVisualStyleBackColor = false;
            this.btnMasterData.Click += new System.EventHandler(this.btnMasterData_Click);
            // 
            // pnlSeparatorLeftPane
            // 
            this.pnlSeparatorLeftPane.BackColor = System.Drawing.Color.Transparent;
            this.pnlSeparatorLeftPane.Controls.Add(this.panel5);
            this.pnlSeparatorLeftPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparatorLeftPane.Location = new System.Drawing.Point(0, 257);
            this.pnlSeparatorLeftPane.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSeparatorLeftPane.Name = "pnlSeparatorLeftPane";
            this.pnlSeparatorLeftPane.Size = new System.Drawing.Size(229, 42);
            this.pnlSeparatorLeftPane.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(52, 20);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(133, 2);
            this.panel5.TabIndex = 2;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogo.Controls.Add(this.label3);
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Controls.Add(this.label2);
            this.pnlLogo.Controls.Add(this.lblYear);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(229, 257);
            this.pnlLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.Font = new System.Drawing.Font("Calibri", 48F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "C I S";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-3, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Capung Inventory and  Sales";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblYear.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(-5, 144);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(237, 28);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(229, 28);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 869);
            this.panel2.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(169)))), ((int)(((byte)(130)))));
            this.pnlHeader.Controls.Add(this.panel7);
            this.pnlHeader.Controls.Add(this.panel6);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(232, 28);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1568, 37);
            this.pnlHeader.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblHeader);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(644, 37);
            this.panel7.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(8, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(584, 41);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Great App";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pictureBox2);
            this.panel6.Controls.Add(this.lblCurrentUser);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1260, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(308, 37);
            this.panel6.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(239, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lblCurrentUser
            // 
            this.lblCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCurrentUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentUser.ForeColor = System.Drawing.Color.White;
            this.lblCurrentUser.Location = new System.Drawing.Point(36, 0);
            this.lblCurrentUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentUser.Name = "lblCurrentUser";
            this.lblCurrentUser.Size = new System.Drawing.Size(196, 32);
            this.lblCurrentUser.TabIndex = 0;
            this.lblCurrentUser.Text = "Georgeous";
            this.lblCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(232, 65);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1568, 4);
            this.panel4.TabIndex = 3;
            // 
            // pnlChildren
            // 
            this.pnlChildren.BackColor = System.Drawing.Color.White;
            this.pnlChildren.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildren.Location = new System.Drawing.Point(232, 69);
            this.pnlChildren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChildren.Name = "pnlChildren";
            this.pnlChildren.Size = new System.Drawing.Size(1568, 828);
            this.pnlChildren.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.lblCompanyWeb);
            this.panel8.Controls.Add(this.lblCompanyName);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(232, 848);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1568, 49);
            this.panel8.TabIndex = 5;
            // 
            // lblCompanyWeb
            // 
            this.lblCompanyWeb.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyWeb.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyWeb.Location = new System.Drawing.Point(0, 22);
            this.lblCompanyWeb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyWeb.Name = "lblCompanyWeb";
            this.lblCompanyWeb.Size = new System.Drawing.Size(1568, 21);
            this.lblCompanyWeb.TabIndex = 1;
            this.lblCompanyWeb.Text = "Website";
            this.lblCompanyWeb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCompanyName.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(0, 0);
            this.lblCompanyName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.lblCompanyName.Size = new System.Drawing.Size(1568, 22);
            this.lblCompanyName.TabIndex = 0;
            this.lblCompanyName.Text = "Company Name";
            this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.backupDatabaseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.settingToolStripMenuItem.Text = "Setting";
            this.settingToolStripMenuItem.Click += new System.EventHandler(this.settingToolStripMenuItem_Click);
            // 
            // backupDatabaseToolStripMenuItem
            // 
            this.backupDatabaseToolStripMenuItem.Name = "backupDatabaseToolStripMenuItem";
            this.backupDatabaseToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.backupDatabaseToolStripMenuItem.Text = "Backup Database";
            this.backupDatabaseToolStripMenuItem.Click += new System.EventHandler(this.backupDatabaseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(204, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualBookToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // manualBookToolStripMenuItem
            // 
            this.manualBookToolStripMenuItem.Name = "manualBookToolStripMenuItem";
            this.manualBookToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.manualBookToolStripMenuItem.Text = "Manual Book";
            this.manualBookToolStripMenuItem.Click += new System.EventHandler(this.manualBookToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 200;
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 200;
            this.toolTip.ReshowDelay = 40;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 28);
            this.label3.TabIndex = 1;
            this.label3.Text = "Management System";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.pnlChildren);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlLeftPane);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1701, 875);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIS - Capung Inventory and Sales Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.FrmMain_Resize);
            this.pnlLeftPane.ResumeLayout(false);
            this.pnlDateTime.ResumeLayout(false);
            this.pnlDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDate)).EndInit();
            this.pnlSeparatorLeftPane.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel8.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftPane;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlChildren;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlSeparatorLeftPane;
        private System.Windows.Forms.Button btnMasterData;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Panel pnlDateTime;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.PictureBox pictureBoxDate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblCurrentUser;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyWeb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label3;
    }
}