using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
namespace PHMS
{
    public partial class UsersForm : Form
    {
        // Create Object of DBAdapter Class
        DbAdapter db = new DbAdapter();
        // Create Object of FormValidation Class
        Validation validate = new Validation();

        SqlDataReader reader;
        public frmMain main;
        public UsersForm()
        {
            InitializeComponent();
        }
     
       

        private void UsersForm_Load(object sender, EventArgs e)
        {
            txtUserPass.PasswordChar = '*';
            txtConfirmPass.PasswordChar = '*';
            dataGridView1.RowTemplate.MinimumHeight = 30;
            getData();
           
            RightOption.Start();
            updateUser.Enabled = false;
            
        }

      private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

      private void button5_Click_1(object sender, EventArgs e)
      {
          frmMain main = new frmMain();
            main.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you realy want Exit the Application ", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void getData()
        {

            try
            {
                String query = "SELECT * FROM Users order by UserName";
                reader = db.selectQuery(query);
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7], "Edit", "Delete");
                }
                db.ConnectionClose();
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception is :" + ex);
            }
        }

        
        private void btnAddUsers_Click(object sender, EventArgs e)
        {
            gbUsersDetails.Hide();
            gbuserRegister.Show();
        }

        private void btnUsersDetail_Click(object sender, EventArgs e)
        {
            gbUsersDetails.Show();
            gbuserRegister.Hide();
            txtUserSearch.Focus();
        }
        private void btnWebUser_Click(object sender, EventArgs e)
        {
           
            gbUsersDetails.Hide();
            gbuserRegister.Hide();
        }
         

        private void registerUser_Click(object sender, EventArgs e)
        {
            string fullName = null;
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtFirstName.Focus();
                return;
            }

            if (txtUserPass.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Question);
                txtUserPass.Focus();
                return;
            }
             if (txtUserPass.TextLength < 6)
            {
                MessageBox.Show("The New Password Should be of Atleast 6 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPass.Clear();
                txtConfirmPass.Clear();
                return;
            }
             else if (txtUserPass.Text != txtConfirmPass.Text)
             {
                 MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtUserPass.Clear();
                 txtConfirmPass.Clear();
                 txtUserPass.Focus();
                 return;
             }
            if (txtUserContect.Text == "")
            {
                MessageBox.Show("Please enter Contect Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserContect.Focus();
                return;
            }
            if (txtUserMail.Text == "")
            {
                MessageBox.Show("Please enter Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserMail.Focus();
                return;
            }

            if (comboRole.Text == "")
            {
                MessageBox.Show("Please select Role", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboRole.Focus();
                return;
            }
            try 
            {
                fullName = txtFirstName.Text + "" + txtLastName.Text;
                String query = "insert into Users values('" + comboRole.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" +fullName+ "','" + txtUserPass.Text + "','" + txtUserContect.Text + "','" + txtUserMail.Text + "')";
                if (db.Execute(query) > 0)
                {
                    MessageBox.Show("User Register Successfully", "Saved Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Record Saved", "Saved Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               registerUser.Enabled = false;
               dataGridView1.Rows.Clear();
               getData();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
          
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            String query = "delete from Users  where  UserName = '" + txtFirstName.Text + "' And UserRole = '"+comboRole.Text+"' ";

            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                if (db.Execute(query) > 0)
                {
                    MessageBox.Show("User Deleted Successfully", "Deleted Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No Record Deleted", "Deleted Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            dataGridView1.Rows.Clear();
            getData();
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            if (txtUserPass.TextLength < 6)
            {
                MessageBox.Show("The New Password Should be of Atleast 6 Characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPass.Clear();
                txtConfirmPass.Clear();
                return;
            }
            else if (txtUserPass.Text != txtConfirmPass.Text)
            {
                MessageBox.Show("Password do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserPass.Clear();
                txtConfirmPass.Clear();
                txtUserPass.Focus();
                return;
            }

             try{
                 string fullName = txtFirstName.Text + "" + txtLastName.Text;
                 String query = "update  Users  set UserRole = '" + comboRole.Text + "',UserName = '" + fullName + "',FirstName='" + txtFirstName.Text + "',LastName='" + txtLastName.Text + "',Password = '" + txtUserPass.Text + "',ContactNo = '" + txtUserContect.Text + "',Email = '" + txtUserMail.Text + "' where UserId = " + txtUserID.Text + " ";
                 if (db.Execute(query) > 0)
                 {
                     MessageBox.Show("Updated Successfully", "Updated Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                 {
                     MessageBox.Show("No Record Updated", "Updated Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
              
                registerUser.Enabled = false;
                dataGridView1.Rows.Clear();
                getData();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            //String query = "update sims.registration_tb set UserRole = '" + comboRole.Text + "',UserName = '" + txtUserName.Text + "',UserPassword = '" + txtUserPass.Text + "',ContactNo = '" + txtUserContect.Text + "',Email = '" + txtUserMail.Text + "',JoiningDate = '" + dpUserJoining.Text + "'  where UserName = '" + txtUserName2.Text + "' ";
            //db.updateQuery(query);
            //dataGridView1.Rows.Clear();
            //getData();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            gbuserRegister.Hide();
            gbUsersDetails.Show();
            
             
        }

       
        private void newUser_Click(object sender, EventArgs e)
        {
            ResetTextfields();
            
        }

        private void ResetTextfields()
        {
            comboRole.Text = "";
            txtFirstName.Clear();
            txtUserContect.Clear();
            txtUserMail.Clear();
            txtConfirmPass.Clear();
            txtUserPass.Clear();
            txtLastName.Clear();
          
            //userPicture.Image = Properties.Resources.photo;
            registerUser.Enabled = true;
            deleteUser.Enabled = false;
            updateUser.Enabled = false;
        }
        private void txtUserSearch_TextChanged(object sender, EventArgs e)
        {
            String query = "select * from Users where UserName like '" + txtUserSearch.Text + "%' ";
            try
            {
                reader = db.selectQuery(query);
                dataGridView1.Rows.Clear();
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7], "Edit", "Delete");
                }
                db.ConnectionClose();
                for (int i = 0; i <= dataGridView1.RowCount - 1; i++)
                {
                    if (i % 2 != 0)
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void txtUserMail_Validating_1(object sender, CancelEventArgs e)
        {
            //validate.EmailValidationMathod(e, txtUserMail);

        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
           // validate.nameValidationMathod(e);
        }

        private void txtUserContect_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  validate.digitValidationMathod(e);
        }

        
        

        private void comboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
                SendKeys.Send("{TAB}");
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            validate.EnterKey(e);
        }

        private void txtUserPass_KeyDown(object sender, KeyEventArgs e)
        {
            validate.EnterKey(e);
        }

        private void txtConfirmPass_KeyDown(object sender, KeyEventArgs e)
        {
            validate.EnterKey(e);
        }

        private void txtUserContect_KeyDown(object sender, KeyEventArgs e)
        {
            validate.EnterKey(e);
        }

        private void btnMinimze_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
          
        }

       
        private void btnUserReport_Click(object sender, EventArgs e)
        {
            userPrintPreviewDialog.Document = userPrintDocument;
            userPrintPreviewDialog.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 8)
            
                gbUsersDetails.Hide();
                gbuserRegister.Show();
                try
                {
                    txtUserID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    comboRole.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtFirstName.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtLastName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtUserPass.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtConfirmPass.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtUserContect.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                    txtUserMail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                    gbuserRegister.Enabled = true;
                    deleteUser.Enabled = true;
                    updateUser.Enabled = true;
                    btnUsersDetail.BackColor = Color.FromArgb(34, 34, 34);
                    btnAddUsers.BackColor = Color.FromArgb(0, 119, 0);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("Do you really Want to Delete this Value", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    String sql = "delete from Users where  UserId= '"+ dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString() + "' ";
                    db.Execute(sql);
                    getData();
                }
            }
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
            validate.DataGridSetColor(dataGridView1);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            validate.rowNumberMathod(e,dataGridView1,this);
        }
     private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void txtUserMail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validate.EnterKey(e);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
