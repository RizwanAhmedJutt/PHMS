using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHMS.UserControls
{
    public partial class UcMainManu : UserControl
    {
        public UcMainManu()
        {
            InitializeComponent();
        }
        private void UcMainManu_Load(object sender, EventArgs e)
        {
            pnlShutdown.Hide();
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

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.WindowState = FormWindowState.Minimized;
        }

        private void UcMainManu_Click(object sender, EventArgs e)
        {
            pnlShutdown.Hide();
        }

        private void btnCashPay_Click(object sender, EventArgs e)
        {
            frmCashPayment frm = new frmCashPayment();
            frm.ShowDialog();
        }

        private void btnSaleModule_Click(object sender, EventArgs e)
        {
            frmSales frm = new frmSales();
            frm.Show();
        }

        private void btnProfitloss_Click(object sender, EventArgs e)
        {
            frmStock frm = new frmStock();
            frm.ShowDialog();
        }

        private void btnStockModule_Click(object sender, EventArgs e)
        {
            frmPurchases frm = new frmPurchases();
            frm.ShowDialog();
        }

        private void btnGenralLager_Click(object sender, EventArgs e)
        {
            frmGeneralLager frm = new frmGeneralLager();
            frm.ShowDialog();
        }

        private void btnMasterEntry_Click(object sender, EventArgs e)
        {
            frmMasterEntry frm = new frmMasterEntry();
            frm.ShowDialog();
        }

        private void btnMainCashbook_Click(object sender, EventArgs e)
        {
            frmCashBook frm = new frmCashBook();
            frm.ShowDialog();
        }

        private void btnChartOfAccount_Click(object sender, EventArgs e)
        {
            frmAccountNew frm = new frmAccountNew();
            frm.ShowDialog();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            frmPurchaseReturn frm = new frmPurchaseReturn();
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

        private void btnOldPurchases_Click(object sender, EventArgs e)
        {
            frmSaleReturn frm = new frmSaleReturn();
            frm.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UsersForm frm = new UsersForm();
            frm.ShowDialog();
        }

        private void btnCashRecive_Click(object sender, EventArgs e)
        {
            frmRecivedCash frm = new frmRecivedCash();
            frm.ShowDialog();
        }

      
    }
}
