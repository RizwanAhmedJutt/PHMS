
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
    public partial class frmRecivedCash: Form
    {
        int selectedRow = -1;
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        SqlDataReader reader;
        frmMain frm;
        public frmRecivedCash(frmMain frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (Flex.Rows.Count < 1)
            {
                MessageBox.Show("No row in the Grid" + Environment.NewLine + "insert Row in the Grid","input Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            try
            {
                String sql3 = "insert into Vouchers(VocNo,VocType,VocDate) values(" + txtVocNo.Text + ",'"+VoucherType.CR+"','" + dpVocDate.Value.ToString("yyyy-MM-dd") + "')";
                if (db.Execute(sql3) > 0)
                {
                    for (int i = 0; i < Flex.Rows.Count; i++)
                    {
                        //Debit Entry for recive payment
                        sql3 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtVocNo.Text + ",'"+VoucherType.CR+"'," + txtCashAcCode.Text + "," + Flex.Rows[i].Cells[3].Value + ",0,'" + Flex.Rows[i].Cells[2].Value + "')";
                        db.Execute(sql3);
                       //Credit Entry for recive payment 
                       sql3 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" +txtVocNo.Text+ ",'"+VoucherType.CR+"'," + txtAcCode.Text + ",0," + Flex.Rows[i].Cells[3].Value + ",'" + Flex.Rows[i].Cells[2].Value + "')";
                       db.Execute(sql3);
                       MessageBox.Show("Record Saved Successfully", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                   
                    ClearData();
                    GetAuto();
                    comboAcTitle.Focus();
                }
                else
                {
                    MessageBox.Show("No Record Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmCashPayment_Load(object sender, EventArgs e)
        {
             getCusData();
             GetAuto();
            getSupplierData();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        public void getSupplierData()
        {
            try
            {
                string sql = "select AcTitle, ACCode  from Accounts";
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    comboCashAc.Items.Add(reader[0]);
                }
                comboCashAc.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetAuto()
        {
            try
            {
                string sql = "select max(VocNo) from Vouchers where VocType= '"+VoucherType.CR+"' ";
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    if (Convert.ToString(reader[0]) != "")
                    {
                        txtVocNo.Text = (Convert.ToInt32(reader[0]) + 1).ToString();
                    }
                    else
                    {
                        txtVocNo.Text = "" + 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getCusData()
        {
            try
            {
                string sql = "select AcTitle as CustomerName, ACCode As CustomerID from Accounts";
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    comboAcTitle.Items.Add(reader[0]);
                }
                comboAcTitle.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboAcTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select AcCode from Accounts where AcTitle = '" + comboAcTitle.Text + "'";
            reader = db.selectQuery(sql);
            if (reader.Read())
            {
                txtAcCode.Text = reader[0].ToString();
            }
            db.ConnectionClose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
             DialogResult dig = MessageBox.Show("Do you realy want to Delete this Voucher!!", "New Product Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
             if (dig == DialogResult.Yes)
             {
                 string sql = "delete from Vouchers where VocNo=" + txtVocNo.Text + " And VocType = '"+VoucherType.CR+"' ";
                 string sql2 = "delete from VoucherDetails where  VocNo=" + txtVocNo.Text + " And VocType = '"+VoucherType.CR+"'";
                 if (db.Execute(sql2) > 0)
                 {
                     db.Execute(sql);
                     MessageBox.Show("Record Deleted Successfully!!!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     ClearData();
                     GetAuto();
                     btnDelete.Enabled = false;
                     btnSave.Enabled = true;
                 }
                 else
                 {
                     MessageBox.Show("Record Not Deleted !!!", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
             }
        }
        private void cmdEdit_Click(object sender, EventArgs e)
        {
            string value = "";
            if (InputClass.InputBox("Cash Recive Voucher Number", "Please Enter Desired Voucher That you want to update", ref value) == DialogResult.OK)
            {
                if (Convert.ToString(value) != "")
                {
                    GetRecord(Convert.ToInt32(value));
                }
                else
                {
                    MessageBox.Show("Please Enter Desired Voucher That you want to update", "Voucher Number Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
         
                }
             

        private void button6_Click(object sender, EventArgs e)
        {
            Flex.Rows.Clear();
            string acNo = null;
            string acTitle = null, txtAcCode2 = null;
            DateTime dt = DateTime.Today;

            string sql = "select * from PaymentsRpt where vocNo=" + txtCashAcCode.Text + " and VocType='"+VoucherType.CR+"' and Debit=0 ";
            reader = db.selectQuery(sql);
            while (reader.Read())
            {
                Flex.Rows.Add(reader["AcCode"], reader["AcTitle"], reader["Narration"], reader["Credit"]);
                acNo = reader["VocNo"].ToString();
                dt = Convert.ToDateTime(reader["VocDate"]);
                acTitle = reader["AcTitle"].ToString();
                txtAcCode2 = reader["AcCode"].ToString();
            }
            txtVocNo.Text = acNo;
            dpVocDate.Value = dt;
            comboAcTitle.Text = acTitle;
            txtAcCode.Text = txtAcCode2;
        }

        private void Flex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    Flex.Rows.RemoveAt(selectedRow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Select any Row Then Pess It", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void cmdBack_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            ClearData();
            GetAuto();
        }

        private void ClearData()
        {
            Flex.Rows.Clear();
            txtNarration.Clear();
            txtAmount.Clear();
            txtAcCode.Clear();
            txtNarration.Clear();
            txtAmount.Clear();
            btnSave.Enabled = true;
            comboAcTitle.Text = "";
        }

        private void Flex_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedRow = e.RowIndex;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Flex.Rows.RemoveAt(selectedRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select any Row Then Pess It", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void GetRecord(Int32 VocNo)
        {
            try
            {
                Flex.Rows.Clear();
                string voNo = null;
                string acCode = null;
                string acTitle = null;
                DateTime dt = DateTime.Today;

                string sql = "select * from PaymentsRpt where vocNo=" + VocNo + " and VocType='"+VoucherType.CR+"' and Debit=0 ";
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    Flex.Rows.Add(reader["AcCode"], reader["AcTitle"], reader["Narration"], String.Format("{0:0}",reader["Credit"],"Delete"));
                    acCode = reader["AcCode"].ToString();
                    voNo = reader["VocNo"].ToString();
                    dt = Convert.ToDateTime(reader["VocDate"]);
                    acTitle = reader["AcTitle"].ToString();
                }
                db.ConnectionClose();
                txtVocNo.Text = voNo;
                dpVocDate.Value = dt;
                txtAcCode.Text = acCode;
                comboAcTitle.Text = acTitle;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtNarration.Text == "")
                {
                    MessageBox.Show("Please Enter Narration", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNarration.Focus();
                    return;
                }
                if (txtAmount.Text == "")
                {
                    MessageBox.Show("Please Enter Amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Focus();
                    return;
                }
                Flex.Rows.Add(txtAcCode.Text, comboAcTitle.Text, txtNarration.Text, txtAmount.Text,"Delete");
                txtAmount.Clear();
                txtNarration.Clear();
                btnSave.Focus();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                reader = db.selectQuery("select min(VocNo) from Vouchers where VocType='"+VoucherType.CR+"'");
                if (reader.Read())
                {
                    GetRecord(Convert.ToInt32(reader[0]));
                }
                else
                {
                    MessageBox.Show("Minimum Record Cannot Exist", "Voucher No Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            try
            {
                reader = db.selectQuery("select max(VocNo) from Vouchers where VocType='"+VoucherType.CR+"'  ");
                if (reader.Read())
                {
                    GetRecord(Convert.ToInt32(reader[0]));
                }
                else
                {
                    MessageBox.Show("Maximum Record Cannot Exist", "Voucher No Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            try
            {
                reader = db.selectQuery("select max(VocNo) from Vouchers where VocType='"+VoucherType.CR+"' and VocNo < " + Convert.ToInt32(txtVocNo.Text) + " ");
                if (reader.Read())
                {
                    GetRecord(Convert.ToInt32(reader[0]));
                }
                else
                {
                    MessageBox.Show("Record Cannot Exist", "Voucher No Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                reader = db.selectQuery("select max(VocNo) from Vouchers where VocType='"+VoucherType.CR+"' and VocNo > " + Convert.ToInt32(txtVocNo.Text) + " ");
                if (reader.Read())
                {
                    GetRecord(Convert.ToInt32(reader[0]));
                }
                else
                {
                    MessageBox.Show("Record Cannot Exist", "Voucher No Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <Flex.Rows.Count; i++)
                   {
                       //Debit Entry for recive payment
                       string sql3 = "update  VoucherDetails set Debit=" + Flex.Rows[i].Cells[3].Value + ", Credit=0, Narration='" + Flex.Rows[i].Cells[2].Value + "' where VocNo=" + txtVocNo.Text + " and VocType='"+VoucherType.CR+"' and AcCode=1 ";
                       if (db.Execute(sql3) > 0) 
                       {
                           //Credit Entry for recive payment 
                           sql3 = "update  VoucherDetails set Debit=0,Credit=" + Flex.Rows[i].Cells[3].Value + ",Narration ='" + Flex.Rows[i].Cells[2].Value + "' where VocNo=" + txtVocNo.Text + " and VocType='"+VoucherType.CR+"' and  AcCode=" + txtAcCode.Text + " ";
                           db.Execute(sql3);
                           MessageBox.Show("Record Updated Successfully", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                           ClearData();
                           GetAuto();
                           btnUpdate.Enabled = false;
                           btnSave.Enabled = true;
                       }
                       else
                       {
                           MessageBox.Show("No Record Updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       }
                   }   
        }

        private void txtVocNo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtVocNo2.Text != "")
                {
                    GetRecord(Convert.ToInt32(txtVocNo2.Text));
                   
                }
                else
                {
                    MessageBox.Show("Please Enter Desired Voucher That you want to update", "Voucher Number Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void txtVocNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.digitValidationMathod(e, txtVocNo2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtNarration.Text == "")
            {
                MessageBox.Show("Please Enter Narration", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNarration.Focus();
                return;
            }
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Please Enter Amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Focus();
                return;
            }
            Flex.Rows.Add(txtAcCode.Text, comboAcTitle.Text, txtNarration.Text, txtAmount.Text,"Delete");
            txtAmount.Clear();
            txtNarration.Clear();
            btnSave.Focus();
        }

        private void comboAcTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtNarration_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.digitValidationMathod(e, txtAmount);
        }

        private void comboCashAc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select (AcCode) from Accounts where AcTitle='" + comboCashAc.Text + "'";
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
        private void btnClose_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
