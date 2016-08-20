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
            dataGridViewItemType.RowTemplate.MinimumHeight = 30;
      
            btnItemDelete.Enabled = false;
            btnItemUpdate.Enabled = false;
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
        #endregion
    }

    }

