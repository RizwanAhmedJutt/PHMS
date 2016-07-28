using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace PHMS
{
    class Validation
    {
        public void DecimalValiation(KeyPressEventArgs e, TextBox txtValidate)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
                txtValidate.BackColor = Color.Red;
                return;
            }
            else {
                txtValidate.BackColor = Color.White;
            }
            // only allow one decimal point
            if ((e.KeyChar == '.') && ((txtValidate.Text.IndexOf('.') > -1)))
            {
                e.Handled = true;
                txtValidate.BackColor = Color.Red;
            }
            else {
                txtValidate.BackColor = Color.White;
            }
        }
  /*#################################  Character Validation  ################################### */
        public void nameValidationMathod(KeyPressEventArgs e, TextBox txtValidate)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                txtValidate.BackColor = Color.Red;
                e.Handled = true;
            }
            else
                txtValidate.BackColor = Color.White;

        }


        /*#################################  Number  Validation   ################################### */
        public void digitValidationMathod(KeyPressEventArgs e, TextBox txtValidate)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                txtValidate.BackColor = Color.Red;
                e.Handled = true;
            }
            else
                txtValidate.BackColor = Color.White;
        }

        public void digitNameValidationMathod(KeyPressEventArgs e, TextBox txtValidate)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                txtValidate.BackColor = Color.Red;
                e.Handled = true;
            }
            else
                txtValidate.BackColor = Color.White;
        }

        /*#################################  gataGridView Row Number   ################################### */
        public void rowNumberMathod(DataGridViewRowPostPaintEventArgs e, DataGridView DataGridView1, Form frm)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, frm.Font);
            if (DataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                DataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, frm.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }
        /*#################################   Email Validation   ################################### */
        public void EmailValidationMathod(CancelEventArgs e , TextBox txtEmail)
        {
            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail.Text))
                {
                   // this.ErrorMsg("invalid email address");
                    txtEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }
        /*#################################   DataGridView Color Setting   ################################### */
        public void DataGridSetColor(DataGridView dataGrid)
        {
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.MultiSelect = false;

        }
        public void DataGridSetColor2(DataGridView dataGrid, Color color)
        {
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = color;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.MultiSelect = false;

        }  
        public void EnterKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");

            }
        }

    }
}
