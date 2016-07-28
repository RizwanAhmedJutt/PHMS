using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Net.Mail;
namespace PHMS
{
    public partial class frmLogin : Form
    {
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        SqlDataReader reader;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public frmLogin()
        {
            InitializeComponent();
          //  Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            roleCombo.SelectedIndex = 0;
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginMathod();
        }
        private void LoginMathod()
        {
            String userName = null;
            String userpass = null;
            String userRole = null;
            String userFName = null;
            String userLName = null;
           

            if (txtName.Text == "")
            {
                MessageBox.Show("Please Enter Your Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Please Enter Your Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPass.Focus();
                return;
            }
            if (roleCombo.Text == "")
            {
                MessageBox.Show("Please Select Your Role", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                String query = "SELECT * FROM Users WHERE UserName='" + txtName.Text + "' ";
                reader = db.selectQuery(query);
                if (reader.Read())
                {
                    userRole = reader[1].ToString();
                    userFName = reader[2].ToString();
                    userLName = reader[3].ToString();
                    userName = reader[4].ToString();
                    userpass = reader[5].ToString();
                }
                db.ConnectionClose();
                if (txtName.Text.Equals(userName) && roleCombo.Text.Equals(userRole))
                {
                    if (txtPass.Text.Equals(userpass))
                    {
                        frmMain mainfrm = new frmMain();
                        mainfrm.Show();
                        mainfrm.lblFirstName.Text = userFName+":";
                        mainfrm.lblLastName.Text = userLName;
                        mainfrm.lblUserRole.Text = userRole +":";
                        this.Hide();
                    }
                    else
                    {
                        txtPass.Clear();
                        txtPass.Focus();
                        MessageBox.Show("Your Password is Invalid !!"+Environment.NewLine+"Please Enter Your Valid Password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Your User Name OR User Role is Invalid !!" + Environment.NewLine + "Please Enter Your Valid Name OR Role", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void lbPasswordFarget_Click(object sender, EventArgs e)
        {
            pnlLogin.Hide();
            pnlEmail.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Enter your email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            try
            {

                Cursor = Cursors.WaitCursor;
                timer1.Enabled = true;

                String query = "SELECT Password,UserName FROM users_tb Where Email = '" + txtEmail.Text + "'";
                reader = db.selectQuery(query);
                if (reader.Read())
                {
                    MailMessage Msg = new MailMessage();
                    // Sender e-mail address.
                    Msg.From = new MailAddress("imranalijutt67@gmail.com");
                    // Recipient e-mail address.
                    Msg.To.Add(txtEmail.Text);
                    Msg.Subject = "Your Password Details";
                    Msg.Body = "User Name:    " + Convert.ToString(reader["UserName"]) + "  ||  " + " Your Password:" + Convert.ToString(reader["Password"]) + "";
                    Msg.IsBodyHtml = true;
                    // your remote SMTP server IP.
                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.Credentials = new System.Net.NetworkCredential("imranalijutt67@gmail.com", "imran6768");
                    smtp.EnableSsl = true;
                    smtp.Send(Msg);
                    MessageBox.Show("Password Successfully sent " + ("\r\n" + "Please check your mail"), "Mail Sent", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Hide();
                    frmLogin frm = new frmLogin();
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Your Email Address is Invalid!!" + Environment.NewLine + "Please Enter Valid Email Address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtName.Clear();
                    txtName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            //btnClose.BackgroundImage = Resources.close_2;
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            //btnMinimize.BackgroundImage = Resources.min_2;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            //btnClose.BackgroundImage = Resources.close_1;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            //btnMinimize.BackgroundImage = Resources.min_1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            validate.EmailValidationMathod(e, txtEmail);
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginMathod();
            }
        }

        private void btnPnlClose_Click(object sender, EventArgs e)
        {
            pnlEmail.Hide(); 
            pnlLogin.Show();
        }

        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

     
        
      
        

       

     
    }
}
