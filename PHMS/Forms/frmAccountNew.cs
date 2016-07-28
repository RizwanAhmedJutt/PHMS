
using PHMS.Enums;
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
    public partial class frmAccountNew : Form
    {
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        SqlDataReader reader;

        public frmAccountNew()
        {
            InitializeComponent();

        }

        private void frmAccountNew_Load(object sender, EventArgs e)
        {
            auto();
            getAccountType();
        }
        public void Cus()
        {
            cmbAcType.Text = "Customer";
        }
        public void Sup()
        {
            cmbAcType.Text = "Supplier";
        }
        private void getAccountType()
        {
            var AccountList = Enum.GetValues(typeof(AccountType)).OfType<AccountType>().ToList();

            cmbAcType.Items.Clear();
            foreach (var item in AccountList)
            {
                cmbAcType.Items.Add(item);
            }
        }
        public void auto()
        {
            string sql = "select max(AcCode) from Accounts";
            reader = db.selectQuery(sql);
            if (reader.Read())
            {
                if (!string.IsNullOrEmpty(reader[0].ToString()) && Convert.ToInt32(reader[0]) >= 10)
                {
                    txtAcSerial.Text = (Convert.ToUInt32(reader[0]) + 1).ToString();
                }
                else
                {
                    txtAcSerial.Text = "" + 10;
                }
            }
            db.ConnectionClose();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            Int64 phoneNo = 0;
            if (cmbAcType.Text == "")
            {
                MessageBox.Show("Please Select Account Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbAcType.Focus();
                return;
            }
            if (txtAcTitle.Text == "")
            {
                MessageBox.Show("Please Enter Account Title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAcTitle.Focus();
                return;
            }
            if (!string.IsNullOrEmpty(txtPhoneNo.Text))
            {
                phoneNo = Convert.ToInt64(txtPhoneNo.Text);
            }
            string query = "insert into Accounts (AcCode,AcType,AcTitle,IsActive) values(" + txtAcSerial.Text + ",'" + cmbAcType.Text + "','" + txtAcTitle.Text + "','" + true + "')";
            if (db.Execute(query) > 0)
            {
                query = " INSERT INTO AccountDetails (AcCode,Address,City,PhoneNo,Mail) VALUES(" + txtAcSerial.Text + ",'" + txtAddress.Text + "','" + txtCity.Text + "'," + phoneNo + ",'" + txtEmail.Text + "')";
                db.Execute(query);

                query = "insert into Vouchers(VocNo,VocType,VocDate) values(" + txtAcSerial.Text + ",'" + VoucherType.OPB + "','" + dpInvoice.Value.ToString("yyyy-MM-dd") + "')";
                db.Execute(query);
                string Narration = "@" + txtAcTitle.Text + " Opening Balance";
                query = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtAcSerial.Text + ",'"+VoucherType.OPB+"'," + txtAcSerial.Text + "," + txtDebit.Text + "," + txtCredit.Text + ",'" + Narration + "')";
                db.Execute(query);
                query = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtAcSerial.Text + ",'" + VoucherType.OPB + "','" + (int)Accounts.OpeningBalance+"'," + txtCredit.Text + "," + txtDebit.Text + ",'" + Narration + "')";
                if (db.Execute(query) > 0)
                {
                    MessageBox.Show("Accont Saved Successfully !!!", "Saved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                auto();
                txtAcTitle.Text = "";
                cmbAcType.Text = "";

            }
            else
            {
                MessageBox.Show("Accont Not Saved !!!", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bClear_Click(object sender, EventArgs e)
        {
            cmbAcType.Text = "";
            txtAcTitle.Clear();
            auto();
        }

        private void xDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You really Want to Delete this Value", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string sql = "Update  Accounts set IsActive='false' where AcCode = " + txtAcSerial.Text + " ";
                if (db.Execute(sql) > 0)
                {
                    MessageBox.Show("Accont De Active Successfully !!!", "Deleted Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    auto();
                }
                else
                {
                    MessageBox.Show("Accont Not De Active !!!", "Deleted Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    txtAcSerial.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cmbAcType.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtAcTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    //txtPhone.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    //txtCity.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    //txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    //txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
                    //tabPage4.Hide();
                    TabPage1.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSerch_TextChanged(object sender, EventArgs e)
        {
            string sql = "select * from Accounts where AcTitle like '" + txtSerch.Text + "%'";
            reader = db.selectQuery(sql);
            dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                dataGridView1.Rows.Add(reader["AcCode"], reader["AcType"], reader["AcTitle"], reader["Phone"], reader["City"], reader["Address"], reader["IsActive"], "Edit", reader["Name"]);
            }
            db.ConnectionClose();
        }

        private void GetData_Click_1(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from Accounts acc left join AccountDetails accd on acc.AcCode = accd.AcCode";
                reader = db.selectQuery(sql);
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["AcCode"], reader["AcType"], reader["AcTitle"], reader["PhoneNo"], reader["City"], reader["Address"], reader["IsActive"], "Edit");
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bEdit_Click(object sender, EventArgs e)
        {
            if (cmbAcType.Text == "")
            {
                MessageBox.Show("Please Select Account Type", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbAcType.Focus();
                return;
            }
            if (txtAcTitle.Text == "")
            {
                MessageBox.Show("Please Enter Account Title", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAcTitle.Focus();
                return;
            }
            string Narration = "@" + txtAcTitle.Text + " Opening Balance";
            string sql = "update Accounts set AcTitle= '" + txtAcTitle.Text + "' where AcType='" + cmbAcType.Text + "' and AcCode=" + txtAcSerial.Text + "";
            string sql2 = "update VoucherDetails set Debit=" + txtDebit.Text + ",Credit=" + txtCredit.Text + ",Narration='" + Narration + "' where VocNo =  " + txtAcSerial.Text + " AND VocType='OPB' AND AcCode=" + txtAcSerial.Text + "";
            string sql3 = "update VoucherDetails set Debit=" + txtDebit.Text + ",Credit=" + txtCredit.Text + ",Narration='" + Narration + "' where VocNo =  " + txtAcSerial.Text + " AND VocType='OPB' AND AcCode=7";
            if (db.Execute(sql) > 0)
            {
                if (db.Execute(sql2) > 0)
                {
                    db.Execute(sql3);
                    MessageBox.Show("Recoed Update Successfully", "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbAcType.Text = "";
                    txtAcTitle.Clear();
                }
                else
                {
                    MessageBox.Show("Recoed Not Update", "Error Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Recoed Not Update", "Error Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bBack_Click(object sender, EventArgs e)
        {
            //this.Close();
            MessageBox.Show(VoucherType.OPB.ToString());
        }

        private void cmbAcType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtAcTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtDebit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtCredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql1 = "delete from Accounts where AcCode=" + txtAcSerial.Text + " ";
            string sql2 = "delete from VoucherDetails where AcCode=" + txtAcSerial.Text + " ";
            if (db.Execute(sql1) > 0)
            {
                db.Execute(sql2);
                MessageBox.Show("Recoed Delete Successfully", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
