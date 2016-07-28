
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
    public partial class frmCashPayment : Form
    {
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        SqlDataReader reader;
        int rowIndex = -1;
        public frmCashPayment()
        {
            InitializeComponent();
        }
        private void GetAuto()
        {
            try
            {
                string sql = "select max(VocNo) from Vouchers where VocType= '"+ VoucherType.CP+ "' ";
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
        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (Flex.Rows.Count < 1)
            {
                MessageBox.Show("No row in the Grid" + Environment.NewLine + "insert Row in the Grid","Input Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            String sql3 = "insert into Vouchers(VocNo,VocType,VocDate) values(" + txtVocNo.Text + ",'" + VoucherType.CP + "','" + dpVocDate.Value.ToString("yyyy-MM-dd") + "')";
            if (db.Execute(sql3) > 0)
            {
                for (int i = 0; i < Flex.Rows.Count; i++)
                {
                    //Debit Entry for sales entery
                    String Narration = "Cash Paid To " + comboAcTitle.Text;
                    sql3 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtVocNo.Text + ",'"+VoucherType.CP+"'," + txtAcCode.Text + "," + Flex.Rows[i].Cells[3].Value + ",0,'" + Flex.Rows[i].Cells[2].Value + "')";
                    db.Execute(sql3);
                    sql3 = "insert into VoucherDetails(VocNo,VocType,AcCode,Debit,Credit,Narration) values(" + txtVocNo.Text + ",'" + VoucherType.CP + "'," + txtCashAcCode.Text + ",0," + Flex.Rows[i].Cells[3].Value + ",'" + Flex.Rows[i].Cells[2].Value + "')";
                    db.Execute(sql3);
                        MessageBox.Show("Record Saved Successfully !!", "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Clear();
                comboAcTitle.Focus();
                GetAuto(); 
            }
            else 
            {
                MessageBox.Show("No Record Saved!!", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void frmCashPayment_Load(object sender, EventArgs e)
        {
            getSupplierData();
            GetAuto();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            getCashAccountData();
            comboCashAc.SelectedIndex = 0;
            comboAcTitle.Focus();
           
           
        }
       
        public void getSupplierData()
        {
            try
            {
                string sql = "select AcTitle, ACCode  from Accounts ";
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    comboAcTitle.Items.Add(reader["AcTitle"]);
                }
                comboAcTitle.SelectedIndex = 0;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void getCashAccountData()
        {
            try
            {
                string sql = "select AcTitle, ACCode  from Accounts ";
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
        private void comboAcTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select (AcCode) from Accounts where AcTitle='" + comboAcTitle.Text + "'";
                reader = db.selectQuery(sql);
                if (reader.Read())
                {
                    txtAcCode.Text = reader[0].ToString();
                }
                db.ConnectionClose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           // Flex.Rows.Clear();
            Flex.Rows.Add(txtAcCode.Text,comboAcTitle.Text,txtNarration.Text,txtAmount.Text);
        }

        private void Flex_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rowIndex = e.RowIndex;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Flex.Rows.RemoveAt(rowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select any Row Then Pess It","Error",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddRecord();
            }
               
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddRecord();
        }
        private void AddRecord()
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
            Flex.Rows.Add(txtAcCode.Text, comboAcTitle.Text, txtNarration.Text, txtAmount.Text, "Delete");
            txtAmount.Clear();
            txtNarration.Clear();
            btnSave.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            GetAuto();
        }

        private void Clear()
        {
            Flex.Rows.Clear();
            txtAmount.Clear();
            txtNarration.Clear();
            txtVocNo2.Clear();
            txtAcCode.Clear();
            comboAcTitle.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dig = MessageBox.Show("Do you realy want to Delete this Voucher!!", "New Product Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dig == DialogResult.Yes)
            {
                string sql = "delete from Vouchers where VocNo=" + txtVocNo.Text + " And VocType = '" + VoucherType.CP + "' ";
                string sql2 = "delete from VoucherDetails where  VocNo=" + txtVocNo.Text + " And VocType = '" + VoucherType.CP + "'";
                if (db.Execute(sql2) > 0)
                {
                    db.Execute(sql);
                    MessageBox.Show("Record Deleted Successfully!!!", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
           string value = "";
           if (InputClass.InputBox("Cash Payment Voucher Number", "Please Enter Desired Voucher That you want to update", ref value) == DialogResult.OK)
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
        private void GetRecord(Int32 VocNo)
        {
            try
            {
                Flex.Rows.Clear();
                string acNo = null;
                string acCode = null;
                string acTitle = null;
                DateTime dt = DateTime.Today;

                string sql = "select * from PaymentsRpt where vocNo=" + VocNo + " and VocType='" + VoucherType.CP + "' and Credit=0 ";
                reader = db.selectQuery(sql);
                while (reader.Read())
                {
                    Flex.Rows.Add(reader["AcCode"], reader["AcTitle"], reader["Narration"],String.Format("{0:0}", reader["Debit"]),"Delete");
                    acCode = reader["AcCode"].ToString();
                    acNo = reader["VocNo"].ToString();
                    dt = Convert.ToDateTime(reader["VocDate"]);
                    acTitle = reader["AcTitle"].ToString();
                }
                db.ConnectionClose();
                txtVocNo.Text = acNo;
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void Flex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                try
                {
                    Flex.Rows.RemoveAt(rowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Select any Row Then Pess It", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnMin_Click(object sender, EventArgs e)
        {
            try
            {
                reader = db.selectQuery("select min(VocNo) from Vouchers where VocType='" + VoucherType.CP + "'");
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
                reader = db.selectQuery("select max(VocNo) from Vouchers where VocType='" + VoucherType.CP + "'  ");
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
                reader = db.selectQuery("select max(VocNo) from Vouchers where VocType='" + VoucherType.CP + "' and VocNo < " + Convert.ToInt32(txtVocNo.Text)+ " ");
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
                reader = db.selectQuery("select max(VocNo) from Vouchers where VocType='" + VoucherType.CP + "' and VocNo > " + Convert.ToInt32(txtVocNo.Text) + "  ");
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

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtVocNo2.Text !="")
                {
                GetRecord(Convert.ToInt32(txtVocNo2.Text));
               
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Flex.Rows.Count; i++)
            {
                //Debit Entry for recive payment
                string sql3 = "update VoucherDetails set Debit=" + Flex.Rows[i].Cells[3].Value + ",Credit=0,Narration='" + Flex.Rows[i].Cells[2].Value + "' where VocNo=" + txtVocNo.Text + " AND VocType='" + VoucherType.CP + "' AND AcCode=" + txtAcCode.Text + " ";
                if (db.Execute(sql3) > 0)
                {
                    //Credit Entry for recive payment 
                    sql3 = "update VoucherDetails set Debit=0,Credit=" + Flex.Rows[i].Cells[3].Value + ",Narration='" + Flex.Rows[i].Cells[2].Value + "' where VocNo=" + txtVocNo.Text + " AND VocType='" + VoucherType.CP + "' AND AcCode=" + txtCashAcCode.Text + "";
                    db.Execute(sql3);
                    MessageBox.Show("Record Updated Successfully", "Record Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
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

        private void txtVocNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validate.digitValidationMathod(e, txtVocNo2);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

