using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
namespace PHMS
{

    public partial class frmMasterEntry : Form
    {
        //Object of the DBAdapter Class
        DbAdapter db = new DbAdapter();
        //Object of the FormValidation  Class
        Validation validate = new Validation();
        public frmMain main;
        SqlDataReader reader = null;
        public frmMasterEntry()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
              getMax();
            //dataGridViewItemType.Hide();
            dataGridViewCategory.Hide();
            dataGridViewCompany.Hide();
            dataGridViewItemType.RowTemplate.MinimumHeight = 30;
            dataGridViewCategory.RowTemplate.MinimumHeight = 30;
            btnCategoryDelete.Enabled = false;
            btnCategoryUpdate.Enabled = false;
            btnItemDelete.Enabled = false;
            btnItemUpdate.Enabled = false;
            btnCompanyDelete.Enabled = false;
            btnCompanyUpdate.Enabled = false;
        }
      
        #region Save,Upate AND Delete Drags      
        private void btnItemSave_Click(object sender, EventArgs e)
        {
            if (txtItemName.Text == "")
            {
                MessageBox.Show("Enter Item Name !!!", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtItemName.Focus();
                return;
            }
            if (txtSalePrice.Text == "")
            {
                MessageBox.Show("Enter Sale Price !!!", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSalePrice.Focus();
                return;
            }
            if (txtPurPrice.Text == "")
            {
                MessageBox.Show("Enter Purchase Price !!!", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPurPrice.Focus();
                return;
            }
            string query = "INSERT INTO Items (ItemCode,ItemName,CompanyName,SellingPrice,PurchasePrice,MinQuanty,ExpiryDate) values('" + txtItemID.Text + "','" + txtItemName.Text + "','"+txtCompName.Text+"'," + txtSalePrice.Text + "," + txtPurPrice.Text + "," + txtMinQty.Text + ",'"+dtExpiryDate.Value.ToString("yyyy-MM-dd")+"')";
            if (db.Execute(query) > 0)
            {
                MessageBox.Show("Record Saved Successfully!!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClear();
                getMax();
                GetData();
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            txtClear();
            getMax();
        }
        public void getMax()
        {
            String sql = "select MAX(ItemCode) from Items";
            try
            {
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    if (Convert.ToString(reader[0]) != "")
                    {
                        txtItemID.Text = ""+(Convert.ToInt32(reader[0]) + 1);
                    }
                    else
                    {
                        txtItemID.Text = ""+1;
                    }
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetData()
        {
            try
            {
                // dataGridViewItemType.Show();
                reader = db.selectQuery("select * from Items");
                dataGridViewItemType.Rows.Clear();
                while (reader.Read())
                {
                    dataGridViewItemType.Rows.Add(reader["ItemCode"], reader["ItemName"], reader["SellingPrice"], reader["PurchasePrice"], reader["MinQuanty"],reader["CompanyName"],reader["ExpiryDate"],"Edit");
                }
                db.ConnectionClose();
                for (int i = 0; i < dataGridViewItemType.RowCount; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridViewItemType.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtClear()
        {
            txtItemName.Clear();
            txtSalePrice.Clear();
            txtPurPrice.Clear();
            txtMinQty.Clear();
            txtCompName.Clear();
            btnItemDelete.Enabled = false;
            btnItemUpdate.Enabled = false;
            btnItemSave.Enabled = true;
        }
        private void btnItemGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }
        private void dataGridViewItemType_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    txtItemID.Text = dataGridViewItemType.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtItemName.Text = dataGridViewItemType.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtSalePrice.Text = dataGridViewItemType.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtPurPrice.Text = dataGridViewItemType.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtMinQty.Text = dataGridViewItemType.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtCompName.Text = dataGridViewItemType.Rows[e.RowIndex].Cells[5].Value.ToString();
                    dtExpiryDate.Value = Convert.ToDateTime(dataGridViewItemType.Rows[e.RowIndex].Cells[6].Value);
                    btnItemUpdate.Enabled = true;
                    btnItemSave.Enabled = false;
                    btnItemDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnItemUpdate_Click(object sender, EventArgs e)
        {
            if (db.Execute("update  Items set ItemName='" + txtItemName.Text + "',CompanyName='" + txtCompName.Text + "',SellingPrice=" + txtSalePrice.Text + ",PurchasePrice=" + txtPurPrice.Text + ",MinQuanty=" + txtMinQty.Text + ",ExpiryDate='" + dtExpiryDate.Value.ToString("yyyy-MM-dd") + "' where  ItemCode=" + txtItemID.Text + " ") > 0)
            {

                MessageBox.Show("Record Has Been Updated Successfully!!", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtClear();
                GetData();
            }
            else
            {
                MessageBox.Show("Record Not Updated !!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            double purQty = 0, saleQty = 0, stockQty = 0;
            try
            {
                DialogResult dialog = MessageBox.Show("Do You Really Want To Delete Drags ??", "Deletetion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    //string sql = "select p.ItemID,p.ItemName,SUM(p.Quantity) as PurQty,(select SUM(s.Quantity)  from dbo.ItemInfo_tb s where s.ItemID = p.ItemID group by s.ItemID) as SaleQTY,SUM(p.Weight) as PurWt,(select SUM(s.Weight)  from dbo.ItemInfo_tb s where s.ItemID = p.ItemID  group by s.ItemID) as SaleWt from dbo.PurchaseItemInfo p where p.ItemID=" + txtItemID.Text + " group by p.ItemID,p.ItemName order by p.ItemID";
                    //reader = db.selectQuery(sql);
                    //if (reader.Read())
                    //{
                    //    purQty = purQty + Convert.ToDouble(reader["PurQty"]);
                    //    saleQty = (Convert.IsDBNull(reader["SaleQTY"])) ? (saleQty + 0) : (saleQty + Convert.ToDouble(reader["SaleQTY"]));
                    //    stockQty = purQty - saleQty;
                    //}
                    //db.ConnectionClose();
                    //if (stockQty == 0)
                    //{
                        if (db.Execute("delete from Items where ItemCode=" + txtItemID.Text + " ") > 0)
                        {
                            MessageBox.Show("Record Has Been Deleted Successfully!!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtClear();
                            GetData();
                            getMax();
                        }
                        else
                        {
                            MessageBox.Show("Record Not Deleted !!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot delete this Record Because This has " + stockQty + " Quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
               // }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Insert,Update and Delete Category
        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text == "")
            {
                MessageBox.Show("Enter Category Name !!!", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategory.Focus();
                return;
            }
            if (db.Execute("insert into Category(CategoryName) values('" + txtCategory.Text + "')") > 0)
            {
                MessageBox.Show("Record Successfully Saved !!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategory.Clear();
            }
            else
            {
                MessageBox.Show("Record Not Saved !!", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Do You Really Want To Delete Category ??", "Deletetion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    if (db.Execute("delete from Category where CategoryID=" + txtCategoryID.Text + " ") > 0)
                    {
                        MessageBox.Show("Record Has Been Deleted Successfully!!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCategory.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Record Not Deleted !!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            if (db.Execute("update  Category set CategoryName='" + txtCategory.Text + "' where  CategoryID=" + txtCategoryID.Text + " ") > 0)
            {
                MessageBox.Show("Record Has Been Updated Successfully!!", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategory.Clear();
            }
            else
            {
                MessageBox.Show("Record Not Updated !!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCategoryNew_Click(object sender, EventArgs e)
        {
            txtCategory.Clear();
            btnCategoryDelete.Enabled = false;
            btnCategoryUpdate.Enabled = false;
            btnCategorySave.Enabled = true;
        }
        private void btnCategoryGetdata_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridViewCategory.Show();
                reader = db.selectQuery("select * from Category");
                dataGridViewCategory.Rows.Clear();
                while (reader.Read())
                {
                    dataGridViewCategory.Rows.Add(reader["CategoryID"], reader["CategoryName"], "Edit");
                }
                db.ConnectionClose();
                for (int i = 0; i < dataGridViewCategory.RowCount; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridViewCategory.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataGridViewCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                txtCategoryID.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCategory.Text = dataGridViewCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                dataGridViewCategory.Hide();
                btnCategoryUpdate.Enabled = true;
                btnCategorySave.Enabled = false;
                btnCategoryDelete.Enabled = true;
            }
        }
        #endregion
        #region
        private void btnCompanySave_Click_1(object sender, EventArgs e)
        {
            if (txtCompanyName.Text == "")
            {
                MessageBox.Show("Enter Company Name !!!", "Insertion Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategory.Focus();
                return;
            }
            if (db.Execute("insert into Company(CompanyName) values('" + txtCompanyName.Text + "')") > 0)
            {
                MessageBox.Show("Record Successfully Saved !!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategory.Clear();
            }
            else
            {
                MessageBox.Show("Record Not Saved !!", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCompanyDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want To Delete Category ??", "Deletetion Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                if (db.Execute("delete from Company where CompanyID=" + txtCompanyID.Text + " ") > 0)
                {
                    MessageBox.Show("Record Has Been Deleted Successfully!!", "Record Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCategory.Clear();
                }
                else
                {
                    MessageBox.Show("Record Not Deleted !!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private void btnCompanyUpdate_Click(object sender, EventArgs e)
        {
            if (db.Execute("update  Company set CompanyName='" + txtCompanyName.Text + "' where  CompanyID=" + txtCompanyID.Text + " ") > 0)
            {
                MessageBox.Show("Record Has Been Updated Successfully!!", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategory.Clear();
            }
            else
            {
                MessageBox.Show("Record Not Updated !!", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCompanyGetdata_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewCompany.Show();
                reader = db.selectQuery("select * from Company");
                dataGridViewCompany.Rows.Clear();
                while (reader.Read())
                {
                    dataGridViewCompany.Rows.Add(reader["CompanyID"], reader["CompanyName"], "Edit");
                }
                db.ConnectionClose();
                for (int i = 0; i < dataGridViewCategory.RowCount; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridViewCompany.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtCompanyNew_Click(object sender, EventArgs e)
        {
            txtCompanyName.Clear();
            dataGridViewCompany.Hide();
            btnCompanySave.Enabled = true;
            btnCompanyUpdate.Enabled = false;
            btnCompanyDelete.Enabled = false;
        }
        private void dataGridViewCompany_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                txtCompanyID.Text = dataGridViewCompany.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCompanyName.Text = dataGridViewCompany.Rows[e.RowIndex].Cells[1].Value.ToString();
                dataGridViewCompany.Hide();
                btnCompanyUpdate.Enabled = true;
                btnCompanySave.Enabled = false;
                btnCompanyDelete.Enabled = true;
            }
        }
        private void dataGridViewCompany_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                txtCompanyID.Text = dataGridViewCompany.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCompanyName.Text = dataGridViewCompany.Rows[e.RowIndex].Cells[1].Value.ToString();
                dataGridViewCompany.Hide();
                btnCompanyUpdate.Enabled = true;
                btnCompanySave.Enabled = false;
                btnCompanyDelete.Enabled = true;
            }
        }
        #endregion
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e,txtSalePrice);
        }

        private void txtPurPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtPurPrice);
        }

        private void txtMinQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.digitValidationMathod(e, txtMinQty);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

