﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDesktop
{
    public partial class FormMenuUtama : Form
    {
        public static FormMenuUtama menu;
        MenuStrip mnstrip;
        FormLogin frmLogin;
        FormTransJual frmTransJual;
        void frmLogin_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin = null;
        }

        FormMasterKasir frmKasir;
        void frmKasir_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmKasir = null;
        }

        FormMasterBarang frmBarang;
        void frmBarang_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmBarang = null;
        }
        void frmTransJual_fromClosed(object sender, FormClosedEventArgs e)
        {
            frmTransJual = null;
        }
        void MenuTerkunci()
        {
            menuLogin.Enabled = true;
            menuLogout.Enabled = false;
            menuMaster.Enabled = false;
            menuTransaksi.Enabled = false;
            menuUtiliti.Enabled = false;
            menuLaporan.Enabled = false;
            toolSST2.Text = "";
            toolSST4.Text = "";
            menu = this;
        }
        public FormMenuUtama()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void menuExiit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuLogin_Click(object sender, EventArgs e)
        {
            if (frmLogin == null)
            {
                frmLogin = new FormLogin();
                frmLogin.FormClosed += new FormClosedEventHandler(frmLogin_fromClosed);
                frmLogin.ShowDialog();
            }
            else
            {
                frmLogin.Activate();
            }

            //frmLogin = new FormLogin();
            //frmLogin.Show();
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            MenuTerkunci();
        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmKasir == null)
            {
                frmKasir = new FormMasterKasir();
                frmKasir.FormClosed += new FormClosedEventHandler(frmKasir_fromClosed);
                frmKasir.ShowDialog();
            }
            else
            {
                frmKasir.Activate();
            }
        }

        private void barangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmBarang == null)
            {
                frmBarang = new FormMasterBarang();
                frmBarang.FormClosed += new FormClosedEventHandler(frmBarang_fromClosed);
                frmBarang.ShowDialog();
            }
            else
            {
                frmBarang.Activate();
            }
        }

        private void penjualanToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmTransJual == null)
            {
                frmTransJual = new FormTransJual();
                frmTransJual.FormClosed += new FormClosedEventHandler(frmTransJual_fromClosed);
                frmTransJual.ShowDialog();
            }
            else
            {
                frmBarang.Activate();
            }
        }
    }
}
