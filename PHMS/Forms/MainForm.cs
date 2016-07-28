using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using System.Configuration;
using PHMS;

namespace PHMS
{
    public partial class frmMain : Form
    {
        DbAdapter db = new DbAdapter();
        SqlDataReader reader;
        // LoginForm login = new LoginForm();
        public frmMain()
        {
            InitializeComponent();
        }
    
        //method to set the position of the main panel that holds the controls to center of the form.
    
        private void frmMain_Load(object sender, EventArgs e)
        {
           
           pnlShutdown.Hide();    
        }
        private void btnCashPay_Click(object sender, EventArgs e)
        {
            frmCashPayment frm = new frmCashPayment();
            frm.ShowDialog();
        }

        private void btnExpences_Click(object sender, EventArgs e)
        {
            frmExpance frm = new frmExpance();
            frm.ShowDialog();
        }

        private void btnAccountLager_Click(object sender, EventArgs e)
        {
            frmAccountLager frm = new frmAccountLager();
            frm.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.ShowDialog();

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmPurchaseReturn frm = new frmPurchaseReturn();
            frm.ShowDialog();
        }



        private void btnPaperModule_Click(object sender, EventArgs e)
        {
            frmSales frm = new frmSales();
            frm.ShowDialog();

        }

        private void btnMasterEntry_Click(object sender, EventArgs e)
        {
            frmMasterEntry frm = new frmMasterEntry();
            frm.ShowDialog();
        }

        private void btnStockModule_Click(object sender, EventArgs e)
        {
            frmPurchases frm = new frmPurchases();
            frm.ShowDialog();
     
        }

        private void btnChartOfAccount_Click(object sender, EventArgs e)
        {
            frmAccountNew frm = new frmAccountNew();
            frm.ShowDialog();
        }

        private void btnGenralLager_Click(object sender, EventArgs e)
        {
            frmGeneralLager frm = new frmGeneralLager();
            frm.ShowDialog();
        }

        private void btnMainCashbook_Click(object sender, EventArgs e)
        {
            frmCashBook frm = new frmCashBook();
            frm.ShowDialog();

        }

        private void btnCashRecive_Click(object sender, EventArgs e)
        {
            frmRecivedCash frm = new frmRecivedCash(this);
            frm.ShowDialog();
        }

        private void btnProfitloss_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            frm.Show();
        }

        private void btnRestoreBackUp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOldPurchases_Click(object sender, EventArgs e)
        {
            frmSaleReturn frm = new frmSaleReturn();
            frm.ShowDialog();
        }

        private void btnShutdown_MouseEnter(object sender, EventArgs e)
        {
            pnlShutdown.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
        }

        private void btnShoutdown_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void frmMain_Click(object sender, EventArgs e)
        {
            pnlShutdown.Hide();
        }
    }



}
