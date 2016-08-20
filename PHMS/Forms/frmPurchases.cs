
using PHMS.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace PHMS
{
    public partial class frmPurchases: Form
    {
        #region Variables
        Validation validate = new Validation();
        DbAdapter db = new DbAdapter();
        SqlDataReader reader;
        DataTable dt;
        string currentType = "SV";
        int affactedRows = 0;
        int rowIndex = -1;
        #endregion
        #region Evants
        public frmPurchases()
        {
            InitializeComponent();
        }
        private void frmCottonCake_Load(object sender, EventArgs e)
        {
            atuoKeyGenrate();     
            BindItems(comboItem);
            BindItems(ddItems);
            BindSuplier(ddSupplier);
            BindSuplier(comboSupName);        
            GridSaleDetails.RowTemplate.MinimumHeight = 30;
            btnInvoiceUpdate.Enabled = false;
        }
        private void txtQty_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtQty.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                {

                    txtTotalAmount.Text = (Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtPrice.Text)).ToString();
                    txtQty.BackColor = Color.LightGreen;
                }
                else
                {
                    txtTotalAmount.Text = 0 + "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            txtClear();
            atuoKeyGenrate();
            btnInvoiceSave.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddToCart();
            //if (Convert.ToDouble(txtQty.Text) > Convert.ToDouble(txtTotalDueQty.Text))
            //{
            //    DialogResult dig = MessageBox.Show("Sale Quantity Is Grater then Stock Qty" + Environment.NewLine + "Do You want To Sale This Voucher", "Delete Record Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //    if (dig == DialogResult.Yes)
            //    {
            //        AddToCart();
            //    }
            //    else
            //    {
            //        txtClear2();
            //    }
            //}
            //else
            //{
            //    AddToCart();
            //}

        }
        private void comboCusName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GetCusID();
            GetDuePayment();
            comboItem.Focus();
        }
      private void comboItem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "Select PurchasePrice from items where ItemCode = " + comboItem.SelectedValue + "";
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    txtPrice.Text = reader["PurchasePrice"].ToString();
                }
                else
                {
                    txtPrice.Text = "" + 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtQty);
        }
        private void txtPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtAmount);
        }
        private void btnInvoiceSave_Click(object sender, EventArgs e)
        {
            if (comboSupName.Text == "Select Supplier")
            {
                MessageBox.Show("Please Select Supplier Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboSupName.Focus();
                return;
            }
            if (dataGridViewShopingCart.Rows.Count == 0)
            {
                MessageBox.Show("Please Enter the Sale Order", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            String Narration = null;
            string supName = comboSupName.Text;

            string sql = "Insert into Purchases (PurVocNo,Date,AcCode,TotalQuantity,Discount,PurchaseTax,TotalAmount,Comments) Values(" + txtInvoiceId.Text + ",'" + dpInvoice.Value.ToString("yyyy-MM-dd") + "'," + txtCusID.Text + "," + txtCartQty.Text + "," + txtDiscount.Text + "," + txtPurchaseTax.Text + "," + ((Convert.ToDecimal(txtCartAmount.Text) + Convert.ToDecimal(txtPurchaseTax.Text)) - Convert.ToDecimal(txtDiscount.Text)) + ",'" + txtComments.Text + "')";
            if (db.Execute(sql) > 0)
            {
                for (int i = 0; i < dataGridViewShopingCart.Rows.Count; i++)
                {
                    String sql2 = "Insert into PurchasesDetails (PurVocNo,ItemCode,Quantity,Price,SubTotalAmount) Values(" + txtInvoiceId.Text + "," + dataGridViewShopingCart.Rows[i].Cells[1].Value + "," + dataGridViewShopingCart.Rows[i].Cells[3].Value + "," + dataGridViewShopingCart.Rows[i].Cells[4].Value + "," + dataGridViewShopingCart.Rows[i].Cells[5].Value + ")";
                    db.Execute(sql2);
                
                }
                //for voucher
                String sql3 = "insert into Vouchers(VocNo,VocType,VocDate) values(" + txtInvoiceId.Text + ",'" + VoucherType.PV + "','" + dpInvoice.Value.ToString("yyyy-MM-dd") + "')";
                if (db.Execute(sql3) > 0)
                {
                    //Debit Entry for sales entery
                    Narration = comboItem.Text + " A/C " + comboSupName.Text + "@WT " + txtCartQty.Text + "Sale VocNo:" + txtInvoiceId.Text;
                    String sql4 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'" + VoucherType.PV + "'," + txtCusID.Text + "," + ((Convert.ToDecimal(txtCartAmount.Text) + Convert.ToDecimal(txtCartAmount.Text)) - Convert.ToDecimal(txtDiscount.Text)) + ",0,'" + Narration + "')";
                    if (db.Execute(sql4) > 0)
                    {
                        //Credit Entry for sales
                        String sql5 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtInvoiceId.Text + ",'" + VoucherType.PV + "'," + (int)Accounts.PurchaseAccount + ",0," + ((Convert.ToDecimal(txtCartAmount.Text) + Convert.ToDecimal(txtCartAmount.Text)) - Convert.ToDecimal(txtDiscount.Text)) + ",'" + Narration + "')";
                        if (db.Execute(sql5) > 0)
                        {


                            DataHolder.InvoiceNo = Convert.ToInt32(txtInvoiceId.Text);
                            MessageBox.Show("Saved Successfully!!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Record Not Saved !!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            txtClear();
            atuoKeyGenrate();

        }
        private void dataGridViewShopingCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dataGridViewShopingCart.Rows[e.RowIndex].Cells[0].Value) == false)
                {
                    dataGridViewShopingCart.Rows[e.RowIndex].Cells[0].Value = true;
                }
                else
                {
                    dataGridViewShopingCart.Rows[e.RowIndex].Cells[0].Value = false;
                }
                countCartCount();
            }
            if (e.ColumnIndex == 6)
            {
                try
                {
                    comboItem.SelectedValue = dataGridViewShopingCart.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtQty.Text = dataGridViewShopingCart.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtPrice.Text = dataGridViewShopingCart.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtTotalAmount.Text = dataGridViewShopingCart.Rows[e.RowIndex].Cells[5].Value.ToString();
                    dataGridViewShopingCart.Rows.RemoveAt(e.RowIndex);
                    countCartCount();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Select any Row Then Pess It", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            db.Execute("delete from Temp");
            db.Execute("insert into Temp (F1) values(" + DataHolder.InvoiceNo + ")");
            //frmReport frm = new frmReport();
            //frm.rptViewer.ReportSource = new Invoice();
            //frm.Text = "Inovice";
            //frm.Show();
        }
        private void btnInvoiceUpdate_Click(object sender, EventArgs e)
        {
            string sql = "update Purchases set Date='" + dpInvoice.Value.ToString("yyyy-MM-dd") + "', AcCode = '" + txtCusID.Text + "',TotalQuantity=" + txtCartQty.Text+ ",Discount=" + txtDiscount.Text+ ",PurchaseTax=" + txtPurchaseTax.Text+ ",TotalAmount=" + txtAmount.Text + ",Comments='" + txtComments.Text + "'    where PurVocNo = " + txtInvoiceId.Text + " ";
            try
            {
                if (db.Execute(sql) > 0)
                {
                    var a = db.Execute("delete from PurchasesDetails where PurVocNo = " + txtInvoiceId.Text + "");
                    if (a > 0)
                        for (int i = 0; i < dataGridViewShopingCart.Rows.Count; i++)
                        {
                            if (Convert.ToBoolean(dataGridViewShopingCart.Rows[i].Cells[0].Value) == false)
                            {
                                String sql2 = "Insert into PurchasesDetails (PurVocNo,ItemCode,Quantity,Price,SubTotalAmount) Values(" + txtInvoiceId.Text + "," + dataGridViewShopingCart.Rows[i].Cells[1].Value + "," + dataGridViewShopingCart.Rows[i].Cells[3].Value + "," + dataGridViewShopingCart.Rows[i].Cells[4].Value + "," + dataGridViewShopingCart.Rows[i].Cells[5].Value + ")";
                                db.Execute(sql2);
                            }
                            else
                            {
                                String sql2 = "insert into PurchaseReturn(VocNo,date,ItemCode,Quantity,Rate,SubTotalAmount,SupplierID) values(" + txtInvoiceId.Text + ",'" + dpInvoice.Value.ToString("yyyy-MM-dd") + "'," + dataGridViewShopingCart.Rows[i].Cells[1].Value + "," + dataGridViewShopingCart.Rows[i].Cells[3].Value + "," + dataGridViewShopingCart.Rows[i].Cells[4].Value + "," + dataGridViewShopingCart.Rows[i].Cells[5].Value + "," + txtCusID.Text + ")";
                                db.Execute(sql2);
                            }
                        }
                    // MessageBox.Show("Insert");


                }
                string Narration = "(" + comboItem.Text + ") Sale To  A/C " + comboSupName.Text + " @Rate Rs: " + txtPrice.Text + "Bill:" + txtInvoiceId.Text;

                String sql4 = "update VoucherDetails set  Debit=" + txtCartAmount.Text + ",Narration='" + Narration + "' where  VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.PV + "' AND AcCode=" + txtCusID.Text + " AND Credit=0 And Debit !=0";
                if (db.Execute(sql4) > 0)
                {
                    //Credit Entry for sales
                    String sql5 = "update  VoucherDetails set  Debit=0,Credit=" + txtCartAmount.Text + ", Narration='" + Narration + "' where VocNo=" + txtInvoiceId.Text + " AND VocType='" + VoucherType.PV + "' AND AcCode="+(int)Accounts.PurchaseAccount+"";
                    db.Execute(sql5);
                    MessageBox.Show("Update  Successfully!!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record Not Update !!!", "Record Saved Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnInvoiceUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewItem.Rows.Count > 0)
                {
                    db.Execute("delete from SaleRpt");
                    for (int i = 0; i < dataGridViewItem.Rows.Count; i++)
                    {
                        db.Execute("insert into SaleRpt(VocNo,VocDate,CustomerName,ItemCode,ItemName,Qty,Rate,Weight,TotalAmount) values(" + dataGridViewItem.Rows[i].Cells[0].Value + ",'" + Convert.ToDateTime(dataGridViewItem.Rows[i].Cells[1].Value).ToString("yyyy-MM-dd") + "','" + dataGridViewItem.Rows[i].Cells[2].Value + "','" + dataGridViewItem.Rows[i].Cells[3].Value + "','" + dataGridViewItem.Rows[i].Cells[4].Value + "'," + dataGridViewItem.Rows[i].Cells[5].Value + "," + dataGridViewItem.Rows[i].Cells[6].Value + "," + dataGridViewItem.Rows[i].Cells[7].Value + "," + dataGridViewItem.Rows[i].Cells[8].Value + ")");
                    }
                    //frmReport frm = new frmReport();
                    //frm.rptViewer.ReportSource = new CustomerSaleRpt();
                    //frm.Text = "Inovice";
                    //frm.Show();
                }
                else
                {
                    MessageBox.Show("No Row Exist in The Table ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCartAmount.Text != "" && txtDiscount.Text != "" && txtCartAmount.Text != "")
                {
                    txtAmount.Text = (Convert.ToDecimal(txtCartAmount.Text) - Convert.ToDecimal(txtDiscount.Text) + Convert.ToDecimal(txtCartAmount.Text)).ToString();
                }
                else
                {
                    txtAmount.Text = txtCartAmount.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      private void GridSaleDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                string cusName = null;
                string sql = "select * from Purchases where PurVocNo = " + GridSaleDetails.Rows[e.RowIndex].Cells[0].Value + "";
                try
                {
                    using (SqlConnection con = new SqlConnection(db.cs))
                    {
                        SqlCommand cmd = new SqlCommand("SP_PurchaseDetails", con);
                        cmd.Parameters.AddWithValue("@StartDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@EndDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@SupplierID", DBNull.Value);
                        cmd.Parameters.AddWithValue("@ItemID", DBNull.Value);
                        cmd.Parameters.AddWithValue("@InvoiceID", GridSaleDetails.Rows[e.RowIndex].Cells[0].Value);
                        cmd.CommandType = CommandType.StoredProcedure;
                        con.Open();
                        reader = cmd.ExecuteReader();
                        dataGridViewShopingCart.Rows.Clear();
                        while (reader.Read())
                        {
                            dataGridViewShopingCart.Rows.Add(false,reader["ItemCode"], reader["ItemName"], reader["Quantity"], reader["Price"], reader["SubTotalAmount"], "Edit");
                            cusName = reader["AcTitle"].ToString();
                        }
                        con.Close();
                    }
                    countCartCount();

                    reader = db.selectQuery(sql);
                    if (reader.Read())
                    {
                        txtInvoiceId.Text = reader["PurVocNo"].ToString();
                        DataHolder.InvoiceNo = Convert.ToInt32(reader["PurVocNo"]);
                        dpInvoice.Value = Convert.ToDateTime(reader["Date"]);
                        txtCusID.Text = reader["AcCode"].ToString();
                        comboSupName.Text = cusName;
                        txtDiscount.Text = reader["Discount"].ToString();
                        txtPurchaseTax.Text = reader["PurchaseTax"].ToString();
                        txtComments.Text = reader["Comments"].ToString();
                    }
                    tabPage2.Hide();
                    tabPage1.Show();
                    tabPage1.Focus();
                    btnInvoiceSave.Enabled = false;
                    btnInvoiceUpdate.Enabled = true;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }


            }
            if (e.ColumnIndex == 8)
            {
                try
                {
                    DialogResult dig = MessageBox.Show("Really you want to delete this record !!!!!", "Delete Record Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dig == DialogResult.Yes)
                    {
                        string sql = "delete from ItemInfo_tb where InvoiceID =" + GridSaleDetails.Rows[e.RowIndex].Cells[0].Value + "";
                        if (db.Execute(sql) > 0)
                        {
                            sql = "delete from CustomerInfo_tb where InvoiceID = " + GridSaleDetails.Rows[e.RowIndex].Cells[0].Value + " ";
                            db.Execute(sql);
                            sql = "delete from VoucherDetails where VocNo=" + GridSaleDetails.Rows[e.RowIndex].Cells[0].Value + " AND VocType = '" + VoucherType.PV + "'";
                            db.Execute(sql);
                            sql = "delete from Vouchers where VocNo=" + GridSaleDetails.Rows[e.RowIndex].Cells[0].Value + " AND VocType = '" + VoucherType.PV + "' ";
                            db.Execute(sql);
                            sql = "delete from SaleReturn where VocNo=" + GridSaleDetails.Rows[e.RowIndex].Cells[0].Value + "";
                            db.Execute(sql);
                            MessageBox.Show("Record Deleted Successfully !!!", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           
                        }
                        else
                        {
                            MessageBox.Show("Record Not Deleted!!!", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (GridSaleDetails.Rows.Count > 0)
            {
                db.Execute("delete from SaleRpt");
                for (int i = 0; i < GridSaleDetails.Rows.Count; i++)
                {
                    db.Execute("insert into SaleRpt(VocNo,VocDate,CustomerName,ItemCode,ItemName,Qty,Rate,Weight,TotalAmount) values(" + GridSaleDetails.Rows[i].Cells[0].Value + ",'" + Convert.ToDateTime(GridSaleDetails.Rows[i].Cells[1].Value).ToString("yyyy-MM-dd") + "','" + GridSaleDetails.Rows[i].Cells[2].Value + "','" + GridSaleDetails.Rows[i].Cells[3].Value + "','" + GridSaleDetails.Rows[i].Cells[4].Value + "'," + GridSaleDetails.Rows[i].Cells[5].Value + "," + GridSaleDetails.Rows[i].Cells[6].Value + "," + GridSaleDetails.Rows[i].Cells[7].Value + "," + GridSaleDetails.Rows[i].Cells[8].Value + ")");
                }
                //frmReport frm = new frmReport();
                //frm.rptViewer.ReportSource = new CustomerSaleRpt();
                //frm.Text = "Inovice";
                //frm.Show();
            }
            else
            {
                MessageBox.Show("No Row Exist in The Table ", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtSaleTax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCartAmount.Text != "" && txtPurchaseTax.Text != "" && txtCartAmount.Text != "")
                {
                    txtAmount.Text = (Convert.ToDecimal(txtCartAmount.Text) + Convert.ToDecimal(txtPurchaseTax.Text) - Convert.ToDecimal(txtDiscount.Text)).ToString();
                }
                else
                {
                    txtAmount.Text = txtCartAmount.Text;
                }
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
                    SqlCommand cmd = new SqlCommand("SP_PurchaseDetails", con);
                    cmd.Parameters.AddWithValue("@StartDate", StartDate.Value);
                    cmd.Parameters.AddWithValue("@EndDate", EndDate.Value);
                    cmd.Parameters.AddWithValue("@SupplierID", (ddSupplier.SelectedValue.ToString() == "0") ? (object)DBNull.Value : ddSupplier.SelectedValue);
                    cmd.Parameters.AddWithValue("@ItemID", string.IsNullOrEmpty(ddItems.SelectedValue.ToString()) ? (object)DBNull.Value : ddItems.SelectedValue);
                    cmd.Parameters.AddWithValue("@InvoiceID", DBNull.Value);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    reader = cmd.ExecuteReader();
                    GridSaleDetails.Rows.Clear();
                    while (reader.Read())
                    {
                        GridSaleDetails.Rows.Add(reader["PurVocNo"], reader["Date"],reader["AcTitle"], reader["ItemName"], reader["Quantity"], reader["Price"], reader["SubTotalAmount"],"Edit","Delete");
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion
        #region Mathods
        public void atuoKeyGenrate()
        {
            string sql = "select max(PurVocNo) from Purchases";
            reader = db.selectQuery(sql);
            if (reader.Read())
            {
                if (Convert.ToString(reader[0]) != "")
                {
                    txtInvoiceId.Text = "" + (Convert.ToInt64(reader[0]) + 1);
                }
                else
                {
                    txtInvoiceId.Text = 1 + "";
                }
            }
        }
        public void BindItems(ComboBox items)
        {
            try
            {
                this.comboItem.SelectedIndexChanged -= new EventHandler(comboItem_SelectedIndexChanged_1);
                DataTable dt = db.selectDatatable("select ItemCode,ItemName from Items");
                DataRow row = dt.NewRow();
                row["ItemName"] = "Select Item Name";
                row["ItemCode"] = "";
                dt.Rows.InsertAt(row, 0);
                items.DataSource = dt;
                items.DisplayMember = "ItemName";
                items.ValueMember = "ItemCode";
                this.comboItem.SelectedIndexChanged += new EventHandler(comboItem_SelectedIndexChanged_1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindSuplier(ComboBox customer)
        {
            try
            {
                this.comboSupName.SelectedIndexChanged -= new EventHandler(comboCusName_SelectedIndexChanged_1);
                string sql = "select AcTitle as SupplierName, ACCode As SupplierID from Accounts where AcType = 'Supplier'";
                DataTable dt = db.selectDatatable(sql);
                DataRow row = dt.NewRow();
                row["SupplierName"] = "Select Supplier";
                row["SupplierID"] = 0;
                dt.Rows.InsertAt(row, 0);
                customer.DataSource = dt;
                customer.DisplayMember = "SupplierName";
                customer.ValueMember = "SupplierID";
                this.comboSupName.SelectedIndexChanged += new EventHandler(comboCusName_SelectedIndexChanged_1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void txtClear()
        {
            //txtName.Clear();
            txtAmount.Text = "" + 0;
            txtQty.Clear();
            txtTotalAmount.Text = "" + 0;
            txtCartAmount.Text = "" + 0;
            txtCartQty.Text = "" + 0;
            txtAmount.Text = "" + 0;
            txtCartAmount.Text = "" + 0;
            txtDiscount.Text = "" + 0;
            txtCartQty.Clear();
            txtPrice.Clear();
            comboSupName.Focus();
            dataGridViewShopingCart.Rows.Clear();
        }
        public void txtClear2()
        {
            txtQty.Clear();
            //txtWeight.Clear();
            txtTotalAmount.Text = "" + 0;
            txtQty.Focus();
        }
        private void countCartCount()
        {
            int i, j = 0;
            decimal cartAmount, cartQty;
            cartAmount = cartQty = 0;
            try
            {
                j = dataGridViewShopingCart.Rows.Count - 1;
                for (i = 0; i <= j; i++)
                {
                    if (Convert.ToBoolean(dataGridViewShopingCart.Rows[i].Cells[0].Value) == false)
                    {
                        cartQty = cartQty + Convert.ToDecimal(dataGridViewShopingCart.Rows[i].Cells[3].Value.ToString());
                        cartAmount = cartAmount + Convert.ToDecimal(dataGridViewShopingCart.Rows[i].Cells[5].Value.ToString());
                    }
                }
                txtCartAmount.Text = Decimal.Round(cartAmount, 0).ToString();
                txtCartQty.Text = Decimal.Round(cartQty).ToString();
                txtAmount.Text = Decimal.Round(cartAmount, 0).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AddToCart()
        {
            try
            {
                if (comboSupName.Text == "Select Supplier")
                {
                    MessageBox.Show("Please Select Supplier Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboSupName.Focus();
                    return;
                }

                if (comboItem.Text == "Select Item Name")
                {
                    MessageBox.Show("Please Select Item name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    comboItem.Focus();
                    return;
                }
                if (txtQty.Text == "")
                {
                    MessageBox.Show("Please enter product sale quantity", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtQty.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Please Select Item Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPrice.Focus();
                    return;
                }
                for (int i = 0; i < dataGridViewShopingCart.Rows.Count; i++)
                {
                    if (dataGridViewShopingCart.Rows[i].Cells[1].Value.ToString().Trim() == comboItem.SelectedValue.ToString().Trim())
                    {
                        MessageBox.Show("This Item Already Exist the Shopping Cart " + ("\r\n" + "You Do Not Add Duplicate Items in The Shopping Cart"), "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtClear2();
                        return;
                    }
                }

                dataGridViewShopingCart.Rows.Add(false, comboItem.SelectedValue, comboItem.Text, txtQty.Text, txtPrice.Text,txtTotalAmount.Text, "Edit");
                countCartCount();
                txtClear2();
                comboItem.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetDuePayment()
        {
            try
            {
                string sql = "select sum(debit-Credit) from GeneralLagerRpt where AcCode=" + txtCusID.Text + " AND AcType != 'Cash' ";
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    if (Convert.ToString(reader[0]) != "")
                    {
                        txtTotalDuePayment.Text = String.Format("{0:0.00}", reader[0]);
                    }
                    else
                    {
                        txtTotalDuePayment.Text = "0";
                    }
                    txtPrice.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetCusID()
        {
            string sql = "select AcCode as CustomerID from Accounts where AcTitle = '" + comboSupName.Text + "'";
            try
            {
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    txtCusID.Text = reader[0].ToString();
                }
                if (Convert.ToString(reader[0]) == "")
                {
                    txtCusID.Text = "" + 0;
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetStock()
        {
            double purQty, saleQty, purWt, saleWt;
            purQty = saleQty = purWt = saleWt = purWt = 0;
            try
            {
                string sql = "select p.ItemID,p.ItemName,SUM(p.Quantity) as PurQty,(select SUM(s.Quantity)  from dbo.ItemInfo_tb s where s.ItemID = p.ItemID group by s.ItemID) as SaleQTY,SUM(p.Weight) as PurWt,(select SUM(s.Weight)  from dbo.ItemInfo_tb s where s.ItemID = p.ItemID  group by s.ItemID) as SaleWt from dbo.PurchaseItemInfo p where p.ItemID=" + comboItem.SelectedValue + " group by p.ItemID,p.ItemName order by p.ItemID";
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    purQty = purQty + Convert.ToDouble(reader["PurQty"]);
                    saleQty = (Convert.IsDBNull(reader["SaleQTY"])) ? (saleQty + 0) : (saleQty + Convert.ToDouble(reader["SaleQTY"]));
                    purWt = purWt + Convert.ToDouble(reader["PurWt"]);
                    saleWt = (Convert.IsDBNull(reader["SaleWt"])) ? (saleWt + 0) : (saleWt + Convert.ToDouble(reader["SaleWt"]));
                }
                db.ConnectionClose();
                txtTotalDueQty.Text = (purQty - saleQty).ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        #endregion
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddToCart();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtQty.Text) && !string.IsNullOrEmpty(txtPrice.Text))
                {

                    txtTotalAmount.Text = (Convert.ToDouble(txtQty.Text) * Convert.ToDouble(txtPrice.Text)).ToString();
                    txtQty.BackColor = Color.LightGreen;
                }
                else
                {
                    txtTotalAmount.Text = 0 + "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddToCart();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtPrice);
        }

        private void comboItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtQty.Focus();
            }
        }

       

       
    }
}



