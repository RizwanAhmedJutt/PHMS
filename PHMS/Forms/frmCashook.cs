

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PHMS
{
    public partial class frmCashBook: Form
    {
        SqlDataReader reader;
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        public frmCashBook()
        {
            InitializeComponent();
        }
        private void btnPreview_Click_1(object sender, EventArgs e)
        {
            double debit = 0, credit = 0, balance = 0;
          try
          {
              string sql2 = "delete from Temp";
              db.Execute(sql2);
              sql2 = "insert into  Temp (f1)values(1)";
              db.Execute(sql2);
              if (chkPreBlnc.Checked != true)
              {
                  Grid.Rows.Clear();
                  Grid.Rows.Add();
                  Grid.Rows[0].Cells[0].Value = "-";
                  Grid.Rows[0].Cells[1].Value = "-";
                  Grid.Rows[0].Cells[2].Value = "Previous Balance";
                  Grid.Rows[0].Cells[3].Value = "0";
                  Grid.Rows[0].Cells[4].Value = "0";
                  string sql = "select sum(debit-Credit) As PreBal from LedgerRpt where AcCode=1 and VocDate < '" + dpTo.Value.ToString("yyyy-MM-dd") + "'";
                  reader = db.selectQuery(sql);
                  if (reader.Read())
                  {
                      if (Convert.ToString(reader[0]) != "")
                      {
                          Grid.Rows[0].Cells[5].Value = reader[0];
                          txtBalnce.Text = String.Format("{0:0.00}", Convert.ToDouble(reader[0]));
                      }
                      else
                      {
                          Grid.Rows[0].Cells[5].Value = "0";
                      }
                  }
              }
              else {
                  Grid.Rows.Clear();
                  Grid.Rows.Add();
                  Grid.Rows[0].Cells[0].Value = "-";
                  Grid.Rows[0].Cells[1].Value = "-";
                  Grid.Rows[0].Cells[2].Value = "Cash In Hand Without Previous Balance";
                  Grid.Rows[0].Cells[3].Value = "0";
                  Grid.Rows[0].Cells[4].Value = "0";
                  Grid.Rows[0].Cells[5].Value = "0";
              }
              int i = 1;
              sql2 = "select *  from LedgerRpt where AcCode=1 and VocDate between '" + dpTo.Value.ToString("yyyy-MM-dd") + "' AND '"+dpFrom.Value.ToString("yyyy-MM-dd")+"' order by SortBy";
              reader = db.selectQuery(sql2);
              while (reader.Read())
              {
                  Grid.Rows.Add();
                  Grid.Rows[i].Cells[0].Value = reader["VocType"] + "-" + reader["VocNo"];
                  Grid.Rows[i].Cells[1].Value = Convert.ToDateTime(reader["VocDate"]).ToShortDateString();
                  Grid.Rows[i].Cells[2].Value = reader["Narration"];
                  Grid.Rows[i].Cells[3].Value = String.Format("{0:0.00}",reader["Debit"]);
                  Grid.Rows[i].Cells[4].Value = String.Format("{0:0.00}",reader["Credit"]);
                  balance = Convert.ToDouble(Grid.Rows[i - 1].Cells[5].Value) + Convert.ToDouble(Grid.Rows[i].Cells[3].Value) - Convert.ToDouble(Grid.Rows[i].Cells[4].Value);
                  Grid.Rows[i].Cells[5].Value = String.Format("{0:0.00}",balance);
                  debit = debit + Convert.ToDouble(reader["Debit"]);
                  credit = credit + Convert.ToDouble(reader["Credit"]);
                  i++;
              }
              for (int a = 0; a <= Grid.RowCount - 1; a++)
              {
                  if (a % 2 != 0)
                  {
                      Grid.Rows[a].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                  }
              }
              txtCredit.Text = String.Format("{0:0.00}",credit);
              txtdebit.Text = String.Format("{0:0.00}",debit);
              txtBalnce.Text = String.Format("{0:0.00}",balance);
          }
          catch (Exception ex)
          {
              MessageBox.Show(ex.Message);
          }



        }

     
        private void Grid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            validate.DataGridSetColor2(Grid, Color.FromArgb(72, 180, 227));
            //validate.rowNumberMathod(e,Grid,this);
        }

        private void frmAccountLager_Load(object sender, EventArgs e)
        {
            Grid.RowTemplate.MinimumHeight = 30;
          
        }
       

        private void button5_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void Grid_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            validate.DataGridSetColor2(Grid, Color.FromArgb(72, 180, 227));
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (Grid.Rows.Count < 2)
            {
                MessageBox.Show("sorry!!!" + Environment.NewLine + "You Do Not Print This Reports", "Printing Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                db.Execute("delete from showReport_tb");
                for (int i = 0; i < Grid.Rows.Count; i++)
                {
                    db.Execute("insert into showReport_tb (VocNo,VocDate,Naration,Debit,Credit,Balance,AcTitle,DateTo,DateFrom) values('" + Grid.Rows[i].Cells[0].Value + "','" + Grid.Rows[i].Cells[1].Value + "','" + Grid.Rows[i].Cells[2].Value + "'," + Grid.Rows[i].Cells[3].Value + "," + Grid.Rows[i].Cells[4].Value + "," + Grid.Rows[i].Cells[5].Value + ",'Cash In Hand','" + dpTo.Value.ToString("yyyy-MM-dd") + "','" + dpFrom.Value.ToString("yyyy-MM-dd") + "')");
                }
                //frmReport frm = new frmReport();
                //frm.Text = "Cash Book Report";
                //frm.rptViewer.ReportSource = new AccountLagerRpt();
                //frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
