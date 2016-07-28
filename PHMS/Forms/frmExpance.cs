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
    public partial class frmExpance : Form
    {
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        SqlDataReader reader;
        int rowIndex = -1;

        public frmExpance()
        {
            InitializeComponent();
        }

        private void frmExpance_Load(object sender, EventArgs e)
        {
            auto();
            dataGridView1.RowTemplate.MinimumHeight = 30;
            btnUpdate.Enabled = false;
            GetExpenceType();
            getEpenceAC();
        }
        public void getEpenceAC()
        {
            try
            {
                string sql = "select AcTitle as CustomerName, ACCode As CustomerID from Accounts";
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    comboExpenceAccount.Items.Add(reader[0]);
                }
                comboExpenceAccount.SelectedIndex = 0;
          
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetExpenceType()
        {
            try
            {
                reader = db.selectQuery("select * from ExpenceType");
                comboExpenceType.Items.Clear();
                while (reader.Read())
                {
                    comboExpenceType.Items.Add(reader["ExpenceType"]);
                    comboExpenceSerch.Items.Add(reader["ExpenceType"]);
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void auto()
        {
            string sql = "select max(VocNo) from Vouchers where VocType= 'EP' ";
            reader = db.selectQuery(sql);
            if (reader.Read())
            {
                if (Convert.ToString(reader[0]) != "")
                {
                    txtVocNo.Text = (Convert.ToUInt32(reader[0]) + 1).ToString();
                }
                else
                {
                    txtVocNo.Text = "" + 1;
                }
            }
            db.ConnectionClose();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearData();
            auto();
        }

        private void ClearData()
        {
            dpExpence.Value = DateTime.Today;
            comboExpenceType.Text = "";
            txtExpenceAmount.Clear();
            txtExpenceDis.Clear();
            txtNotes.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (comboExpenceType.Text == "")
            {
                MessageBox.Show("Please Select Expence Type !!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboExpenceType.Focus();
                return;
            }
            if (txtExpenceAmount.Text == "")
            {
                MessageBox.Show("Please Enter Expence Amount !!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExpenceAmount.Focus();
                return;
            }
            string sql = "insert into Expence (ExpenceID,ExpenceDate,ExpenceType,ExpenceDis,ExpenceAmount,Notes) values(" + txtVocNo.Text + ",'" + dpExpence.Value.ToString("yyyy-MM-dd") + "','" + comboExpenceType.Text + "','" + txtExpenceDis.Text + "'," + txtExpenceAmount.Text + ",'" + txtNotes.Text + "')";
            if (db.Execute(sql) > 0)
            {
                 String query = "insert into Vouchers(VocNo,VocType,VocDate) values(" + txtVocNo.Text + ",'EP','" + dpExpence.Value.ToString("yyyy-MM-dd") + "')";
                 if (db.Execute(query) > 0)
                 {
                     //Debit Entry for sales entery
                     String Narration = "Cash Paid For " + comboExpenceType.Text;
                     string sql3 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtVocNo.Text + ",'EP',4," + txtExpenceAmount.Text + ",0,'" + Narration + "')";
                     if (db.Execute(sql3) > 0)
                     {
                         sql3 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtVocNo.Text + ",'EP',"+txtCashAcCode.Text+",0," + txtExpenceAmount.Text + ",'" + Narration + "')";
                         db.Execute(sql3);
                         MessageBox.Show("Saved Successfully !!!", "Saved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         ClearData();
                         auto();
                     }
                     else
                     {
                         MessageBox.Show("Vouchers Not Saved  !!!", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     }
                 }
               
            }
            else
            {
                MessageBox.Show("Record Not Saved  !!!", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (comboExpenceType.Text == "")
            {
                MessageBox.Show("Please Select Expence Type !!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboExpenceType.Focus();
                return;
            }
            if (txtExpenceAmount.Text == "")
            {
                MessageBox.Show("Please Enter Expence Amount !!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtExpenceAmount.Focus();
                return;
            }
            string sql = "update Expence set ExpenceDate='" + dpExpence.Value + "',ExpenceType='" + comboExpenceType.Text + "',ExpenceDis='" + txtExpenceDis.Text + "',ExpenceAmount=" + txtExpenceAmount.Text + ",Notes='" + txtNotes.Text + "' where ExpenceID="+txtVocNo.Text+"";
            if (db.Execute(sql) > 0)
            {
                    //Debit Entry for sales entery
                    String Narration = "Cash Paid For " + comboExpenceType.Text;
                    string sql3 = "update  VoucherDetails set Debit=" + txtExpenceAmount.Text + ",Credit=0,Narration ='" + Narration + "' where VocNo=" + txtVocNo.Text + " AND VocType='EP' AND AcCode=4";
                    if (db.Execute(sql3) > 0)
                    {
                        string sql4 = "update  VoucherDetails set Debit=0,Credit=" + txtExpenceAmount.Text + ",Narration ='" + Narration + "' where VocNo=" + txtVocNo.Text + " AND VocType='EP' AND AcCode=1";
                        db.Execute(sql4);
                        MessageBox.Show("Updated Successfully !!!", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        auto();
                    }
                    else
                    {
                      //  MessageBox.Show("Updated Successfully!", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            else
            {
                MessageBox.Show("Record Not Saved  !!!", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            string sql = "select * from Expence";
            double expenceAmount = 0;
            reader = db.selectQuery(sql);
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["ExpenceID"], Convert.ToDateTime(reader["ExpenceDate"]).ToString("dd-MMM-yyyy"), reader["ExpenceType"], reader["ExpenceAmount"], reader["ExpenceDis"], "Edit", "Delete", reader["Notes"]);
                expenceAmount = Convert.ToDouble(reader["ExpenceAmount"]);
            }
            db.ConnectionClose();
            txtTotalExpenceAmount.Text = String.Format("{0:0.00}",expenceAmount);
            lbExpence.Text = "Total Amount Of All Expences ";
            for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                if (i % 2 != 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (e.ColumnIndex == 5)
                {
                    txtVocNo.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    dpExpence.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                   //MessageBox.Show("" + dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    comboExpenceType.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtExpenceAmount.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtExpenceDis.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    txtNotes.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                    tabPage2.Hide();
                    tabPage1.Show();
                    btnUpdate.Enabled = true;
                    btnSave.Enabled = false;
                }
                if (e.ColumnIndex == 6)
                {
                    DialogResult dig = MessageBox.Show("Really you want to delete this record !!!!!", "Delete Record Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dig == DialogResult.Yes)
                    {
                        string sql = "delete from Expence where ExpenceID = " + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "";
                        string sql1 = "delete from Vouchers where VocNo=" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + " and VocType='EP'";
                        string sql2 = "delete from VoucherDetails where  VocNo=" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + " and VocType='EP'";
                        if (db.Execute(sql) > 0)
                        {
                            if (db.Execute(sql2) > 0)
                            {
                                db.Execute(sql1);
                                MessageBox.Show("Record Deleted Successfully !!!", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                GetData();
                                auto();
                            }
                            else
                            {
                                MessageBox.Show("No Record Deleted !!!", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Expence Deleted !!!", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        


        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboExpenceSerch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double expenceAmount = 0;
                reader = db.selectQuery("select * from Expence where ExpenceType='"+comboExpenceSerch.Text+"'");
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["ExpenceID"],Convert.ToDateTime(reader["ExpenceDate"]).ToString("dd-MM-yyyy"),reader["ExpenceType"],reader["ExpenceDis"],reader["ExpenceAmount"],"Edit","Delete",reader["Notes"]);
                    expenceAmount = Convert.ToDouble(reader["ExpenceAmount"]);
                }
                db.ConnectionClose();
                txtTotalExpenceAmount.Text = String.Format("{0:0.00}", expenceAmount);
                lbExpence.Text = "Total Amount Of " + comboExpenceSerch.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            validate.DataGridSetColor(dataGridView1);
        }

        private void comboExpenceAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select (AcCode) from Accounts where AcTitle='" + comboExpenceAccount.Text + "'";
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    txtCashAcCode.Text = reader[0].ToString();
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboExpenceType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtExpenceDis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtExpenceAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void comboExpenceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtExpenceDis.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtExpenceAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.DecimalValiation(e, txtExpenceAmount);
        }
    }
}
