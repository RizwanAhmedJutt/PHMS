
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
    public partial class frmGeneralLager: Form
    {
        SqlDataReader reader;
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        public frmGeneralLager()
        {
            InitializeComponent();
        }

      private void btnPreview_Click(object sender, EventArgs e)
      {
          double debit =0,credit = 0;
            try
            {
                string sql2 = "select *  from GeneralLagerRpt where  VocDate between '" + dpTo.Value.ToString("yyyy-MM-dd") + "' and  '" + dpFrom.Value.ToString("yyyy-MM-dd") + "' order by SortBy";
                reader = db.selectQuery(sql2);
                Grid.Rows.Clear(); 
                while (reader.Read())
                {
                    Grid.Rows.Add(reader["VocType"] + "-" + reader["VocNo"], Convert.ToDateTime(reader["VocDate"]).ToString("dd-MM-yyyy"), reader["Narration"], String.Format("{0:0.00}",reader["Debit"]), String.Format("{0:0.00}",reader["Credit"]));
                    credit = credit + Convert.ToDouble(reader["Credit"]);
                    debit = debit + Convert.ToDouble(reader["Debit"]);
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
                
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            frm.Show();
            this.Close();
        }

        private void Grid_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            validate.DataGridSetColor2(Grid, Color.FromArgb(254, 182, 0));
            //validate.rowNumberMathod(e,Grid,this);
        }

        private void frmAccountLager_Load(object sender, EventArgs e)
        {
            Grid.RowTemplate.MinimumHeight = 30;
          
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
                    db.Execute("insert into showReport_tb (VocNo,VocDate,Naration,Debit,Credit,AcTitle,DateTo,DateFrom) values('" + Grid.Rows[i].Cells[0].Value + "','" + Grid.Rows[i].Cells[1].Value + "','" + Grid.Rows[i].Cells[2].Value + "'," + Grid.Rows[i].Cells[3].Value + "," + Grid.Rows[i].Cells[4].Value + ",'General Lager','"+dpTo.Value.ToString("yyyy-MM-dd")+"','"+dpFrom.Value.ToString("yyyy-MM-dd")+"')");
                }
                //frmReport frm = new frmReport();
                //frm.Text = "General Lager Report ";
                //frm.rptViewer.ReportSource = new AccountLagerRpt();
                //frm.Show();
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
