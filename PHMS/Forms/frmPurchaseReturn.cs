
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PHMS
{
    public partial class frmPurchaseReturn: Form
    {
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        DataTable dt;
        SqlDataReader reader;
        public frmPurchaseReturn()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            dataGridViewPurchaseReturn.RowTemplate.MinimumHeight = 25;
            db.BindCategory(ddCategory);
            db.BindCompany(ddCompany);
            BindItems(ddItems);
            BindCustomer(ddSupplier);
        }
        public void BindCustomer(ComboBox customer)
        {
            try
            {
                string sql = "select AcTitle as CustomerName, ACCode As CustomerID from Accounts where AcType = 'Customer' OR AcType = 'Cash'";
                 dt = db.selectDatatable(sql);
                DataRow row = dt.NewRow();
                row["CustomerName"] = "Select Customer";
                row["CustomerID"] = 0;
                dt.Rows.InsertAt(row, 0);
                customer.DataSource = dt;
                customer.DisplayMember = "CustomerName";
                customer.ValueMember = "CustomerID";
               // this.comboCusName.SelectedIndexChanged += new EventHandler(comboCusName_SelectedIndexChanged_1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void BindItems(ComboBox items)
        {
            try
            {
               // this.ddItems.SelectedIndexChanged -= new EventHandler(comboItem_SelectedIndexChanged);
               DataTable dt = db.selectDatatable("select ItemCode,ItemName from Items");
                DataRow row = dt.NewRow();
                row["ItemName"] = "Select Item Name";
                row["ItemCode"] = "";
                dt.Rows.InsertAt(row, 0);
                items.DataSource = dt;
                items.DisplayMember = "ItemName";
                items.ValueMember = "ItemCode";
                //this.ddItems.SelectedIndexChanged += new EventHandler(comboItem_SelectedIndexChanged);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(db.cs))
                {
                    SqlCommand cmd = new SqlCommand("SP_PurchaseReturn", con);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", EndDate.Value);
                    cmd.Parameters.AddWithValue("@SupplierID", (ddSupplier.SelectedValue.ToString() == "0") ? (object)DBNull.Value : ddSupplier.SelectedValue);
                    cmd.Parameters.AddWithValue("@ItemID", string.IsNullOrEmpty(ddItems.SelectedValue.ToString()) ? (object)DBNull.Value : ddItems.SelectedValue);
                    cmd.Parameters.AddWithValue("@InvoiceID",string.IsNullOrEmpty(txtVoucherNo.Text)? (object)DBNull.Value : txtVoucherNo.Text);
                    cmd.Parameters.AddWithValue("@CategoryID", (ddCategory.SelectedValue.ToString() == "0") ? (object)DBNull.Value : ddCategory.SelectedValue);
                    cmd.Parameters.AddWithValue("@CompanyID", (ddCompany.SelectedValue.ToString() == "0") ? (object)DBNull.Value : ddCompany.SelectedValue);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    reader = cmd.ExecuteReader();
                    dataGridViewPurchaseReturn.Rows.Clear();
                    while (reader.Read())
                    {
                        dataGridViewPurchaseReturn.Rows.Add(reader["VocNo"], reader["date"], reader["AcTitle"], reader["ItemName"], reader["CategoryName"], reader["CompanyName"], reader["Quantity"], reader["Rate"], reader["SubTotalAmount"]);
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}