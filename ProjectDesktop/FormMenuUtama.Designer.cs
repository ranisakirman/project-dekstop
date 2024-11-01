namespace ProjectDesktop
{
    partial class FormMenuUtama
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
            menuExit = new ToolStripMenuItem();
            kasirToolStripMenuItem = new ToolStripMenuItem();
            barangToolStripMenuItem = new ToolStripMenuItem();
            penjualanToolStripMenuItem = new ToolStripMenuItem();
            lapDataMasterToolStripMenuItem = new ToolStripMenuItem();
            lapPenjualanToolStripMenuItem = new ToolStripMenuItem();
            menuUtility = new ToolStripMenuItem();
            gantiPasswordToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuLogin = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            menuExiit = new ToolStripMenuItem();
            menuMaster = new ToolStripMenuItem();
            transaksiToolStripMenuItem = new ToolStripMenuItem();
            barangToolStripMenuItem1 = new ToolStripMenuItem();
            menuTransaksi = new ToolStripMenuItem();
            penjualanToolStripMenuItem1 = new ToolStripMenuItem();
            menuLaporan = new ToolStripMenuItem();
            lapDataMasterToolStripMenuItem1 = new ToolStripMenuItem();
            lapPenjualanToolStripMenuItem1 = new ToolStripMenuItem();
            menuUtiliti = new ToolStripMenuItem();
            gantiPasswordToolStripMenuItem1 = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolSST1 = new ToolStripStatusLabel();
            toolSST2 = new ToolStripStatusLabel();
            toolSST3 = new ToolStripStatusLabel();
            toolSST4 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(32, 19);
            // 
            // kasirToolStripMenuItem
            // 
            kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            kasirToolStripMenuItem.Size = new Size(139, 26);
            kasirToolStripMenuItem.Text = "Kasir";
            // 
            // barangToolStripMenuItem
            // 
            barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            barangToolStripMenuItem.Size = new Size(139, 26);
            barangToolStripMenuItem.Text = "Barang";
            // 
            // penjualanToolStripMenuItem
            // 
            penjualanToolStripMenuItem.Name = "penjualanToolStripMenuItem";
            penjualanToolStripMenuItem.Size = new Size(32, 19);
            // 
            // lapDataMasterToolStripMenuItem
            // 
            lapDataMasterToolStripMenuItem.Name = "lapDataMasterToolStripMenuItem";
            lapDataMasterToolStripMenuItem.Size = new Size(204, 26);
            lapDataMasterToolStripMenuItem.Text = "Lap. Data Master";
            // 
            // lapPenjualanToolStripMenuItem
            // 
            lapPenjualanToolStripMenuItem.Name = "lapPenjualanToolStripMenuItem";
            lapPenjualanToolStripMenuItem.Size = new Size(204, 26);
            lapPenjualanToolStripMenuItem.Text = "Lap. Penjualan";
            // 
            // menuUtility
            // 
            menuUtility.Name = "menuUtility";
            menuUtility.Size = new Size(32, 19);
            // 
            // gantiPasswordToolStripMenuItem
            // 
            gantiPasswordToolStripMenuItem.Name = "gantiPasswordToolStripMenuItem";
            gantiPasswordToolStripMenuItem.Size = new Size(155, 22);
            gantiPasswordToolStripMenuItem.Text = "Ganti Password";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(155, 22);
            aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile, menuMaster, menuTransaksi, menuLaporan, menuUtiliti });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(800, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuLogin, menuLogout, menuExiit });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(46, 24);
            menuFile.Text = "File";
            // 
            // menuLogin
            // 
            menuLogin.Name = "menuLogin";
            menuLogin.Size = new Size(139, 26);
            menuLogin.Text = "Login";
            menuLogin.Click += menuLogin_Click;
            // 
            // menuLogout
            // 
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(139, 26);
            menuLogout.Text = "Logout";
            menuLogout.Click += menuLogout_Click;
            // 
            // menuExiit
            // 
            menuExiit.Name = "menuExiit";
            menuExiit.Size = new Size(139, 26);
            menuExiit.Text = "Exit";
            menuExiit.Click += menuExiit_Click;
            // 
            // menuMaster
            // 
            menuMaster.DropDownItems.AddRange(new ToolStripItem[] { transaksiToolStripMenuItem, barangToolStripMenuItem1 });
            menuMaster.Name = "menuMaster";
            menuMaster.Size = new Size(68, 24);
            menuMaster.Text = "Master";
            // 
            // transaksiToolStripMenuItem
            // 
            transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            transaksiToolStripMenuItem.Size = new Size(139, 26);
            transaksiToolStripMenuItem.Text = "Kasir";
            transaksiToolStripMenuItem.Click += transaksiToolStripMenuItem_Click;
            // 
            // barangToolStripMenuItem1
            // 
            barangToolStripMenuItem1.Name = "barangToolStripMenuItem1";
            barangToolStripMenuItem1.Size = new Size(139, 26);
            barangToolStripMenuItem1.Text = "Barang";
            barangToolStripMenuItem1.Click += barangToolStripMenuItem1_Click;
            // 
            // menuTransaksi
            // 
            menuTransaksi.DropDownItems.AddRange(new ToolStripItem[] { penjualanToolStripMenuItem1 });
            menuTransaksi.Name = "menuTransaksi";
            menuTransaksi.Size = new Size(82, 24);
            menuTransaksi.Text = "Transaksi";
            // 
            // penjualanToolStripMenuItem1
            // 
            penjualanToolStripMenuItem1.Name = "penjualanToolStripMenuItem1";
            penjualanToolStripMenuItem1.Size = new Size(155, 26);
            penjualanToolStripMenuItem1.Text = "Penjualan";
            penjualanToolStripMenuItem1.Click += penjualanToolStripMenuItem1_Click;
            // 
            // menuLaporan
            // 
            menuLaporan.DropDownItems.AddRange(new ToolStripItem[] { lapDataMasterToolStripMenuItem1, lapPenjualanToolStripMenuItem1 });
            menuLaporan.Name = "menuLaporan";
            menuLaporan.Size = new Size(77, 24);
            menuLaporan.Text = "Laporan";
            // 
            // lapDataMasterToolStripMenuItem1
            // 
            lapDataMasterToolStripMenuItem1.Name = "lapDataMasterToolStripMenuItem1";
            lapDataMasterToolStripMenuItem1.Size = new Size(197, 26);
            lapDataMasterToolStripMenuItem1.Text = "Lap DataMaster";
            // 
            // lapPenjualanToolStripMenuItem1
            // 
            lapPenjualanToolStripMenuItem1.Name = "lapPenjualanToolStripMenuItem1";
            lapPenjualanToolStripMenuItem1.Size = new Size(197, 26);
            lapPenjualanToolStripMenuItem1.Text = "Lap Penjualan";
            // 
            // menuUtiliti
            // 
            menuUtiliti.DropDownItems.AddRange(new ToolStripItem[] { gantiPasswordToolStripMenuItem1, aboutToolStripMenuItem1 });
            menuUtiliti.Name = "menuUtiliti";
            menuUtiliti.Size = new Size(62, 24);
            menuUtiliti.Text = "Utility";
            // 
            // gantiPasswordToolStripMenuItem1
            // 
            gantiPasswordToolStripMenuItem1.Name = "gantiPasswordToolStripMenuItem1";
            gantiPasswordToolStripMenuItem1.Size = new Size(192, 26);
            gantiPasswordToolStripMenuItem1.Text = "Ganti Password";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(192, 26);
            aboutToolStripMenuItem1.Text = "About";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolSST1, toolSST2, toolSST3, toolSST4 });
            statusStrip1.Location = new Point(0, 425);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolSST1
            // 
            toolSST1.Name = "toolSST1";
            toolSST1.Size = new Size(54, 20);
            toolSST1.Text = "KODE :";
            // 
            // toolSST2
            // 
            toolSST2.Name = "toolSST2";
            toolSST2.Size = new Size(0, 20);
            // 
            // toolSST3
            // 
            toolSST3.Name = "toolSST3";
            toolSST3.Size = new Size(60, 20);
            toolSST3.Text = "NAMA :";
            // 
            // toolSST4
            // 
            toolSST4.Name = "toolSST4";
            toolSST4.Size = new Size(0, 20);
            // 
            // FormMenuUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Name = "FormMenuUtama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMenuUtama";
            WindowState = FormWindowState.Maximized;
            Load += FormMenuUtama_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem1;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem menuExit;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem kasirToolStripMenuItem;
        private ToolStripMenuItem barangToolStripMenuItem;
        private ToolStripMenuItem transaksiToolStripMenuItem;
        private ToolStripMenuItem penjualanToolStripMenuItem;
        private ToolStripMenuItem lapDataMasterToolStripMenuItem;
        private ToolStripMenuItem lapPenjualanToolStripMenuItem;
        private ToolStripMenuItem menuUtility;
        private ToolStripMenuItem gantiPasswordToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuExiit;
        private ToolStripMenuItem barangToolStripMenuItem1;
        private ToolStripMenuItem penjualanToolStripMenuItem1;
        private ToolStripMenuItem lapDataMasterToolStripMenuItem1;
        private ToolStripMenuItem lapPenjualanToolStripMenuItem1;
        private ToolStripMenuItem gantiPasswordToolStripMenuItem1;
        private ToolStripMenuItem aboutToolStripMenuItem1;
        public ToolStripMenuItem menuLaporan;
        public ToolStripMenuItem menuFile;
        public ToolStripMenuItem menuLogin;
        public ToolStripMenuItem menuLogout;
        public ToolStripMenuItem menuMaster;
        public ToolStripMenuItem menuTransaksi;
        public ToolStripMenuItem menuUtiliti;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolSST1;
        private ToolStripStatusLabel toolSST3;
        public ToolStripStatusLabel toolSST2;
        public ToolStripStatusLabel toolSST4;
    }
}