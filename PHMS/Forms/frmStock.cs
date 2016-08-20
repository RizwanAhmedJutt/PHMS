
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
    public partial class frmStock: Form
    {
        DbAdapter db = new DbAdapter();
        Validation validate = new Validation();
        DataTable dt;
        SqlDataReader reader;
        public frmStock()
        {
            InitializeComponent();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            dataGridViewPurchaseReturn.RowTemplate.MinimumHeight = 25;
            db.BindItems(ddItems);
        }
        public void BindCustomer(ComboBox customer)
        {
            try
            {
                string sql = "select AcTitle as CustomerName, ACCode As CustomerID from Accounts where AcType = 'Customer' OR AcType = 'Cash'";
                 dt = db.selectDatatable(sql);
                DataRow row = dt.NewRow();
                row["CustomerName"] = "Select Customer";
                row["CustomerID"] = 0;
                dt.Rows.InsertAt(row, 0);
                customer.DataSource = dt;
                customer.DisplayMember = "CustomerName";
                customer.ValueMember = "CustomerID";
                //this.comboCusName.SelectedIndexChanged += new EventHandler(comboCusName_SelectedIndexChanged_1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(db.cs))
                {
                    SqlCommand cmd = new SqlCommand("SP_GetStock", con);                
                    cmd.Parameters.AddWithValue("@ItemCode", string.IsNullOrEmpty(ddItems.SelectedValue.ToString()) ? (object)DBNull.Value : ddItems.SelectedValue);              
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    reader = cmd.ExecuteReader();
                    dataGridViewPurchaseReturn.Rows.Clear();
                    while (reader.Read())
                    {
                        dataGridViewPurchaseReturn.Rows.Add(reader["ItemCode"], reader["ItemName"], reader["purQty"], reader["saleQty"], reader["stockQty"]);
                    }
                    con.Close();
                }
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