 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
namespace PHMS
{
    class DbAdapter
    {
        public String cs = @"Data Source=HAIER-PC\SQLEXPRESS;Initial Catalog=PHMS;Integrated Security=True";
        Validation validate = new Validation();
        public SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

     
        /*#################################  Mathod For Deletion From Database  ################################### */
        public int Execute(String query)
        {
            int rowsAffected = 0;
            conn = new SqlConnection(cs);
            cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return rowsAffected;
        }      
        /*#################################   Mathod For Selection From Database  ################################### */
        public SqlDataReader selectQuery(String query)
        {
                conn = new SqlConnection(cs);
                cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    reader = cmd.ExecuteReader();
                    return reader;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
        }
        /*#################################   Mathod For Selection From Database  ################################### */
        public DataTable selectDatatable(String query)
        {
            using (conn = new SqlConnection(cs))
            {
                cmd = new SqlCommand(query, conn);
                try
                {
                    SqlDataAdapter adt = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adt.Fill(dt);
                    return dt;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public void ConnectionClose()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            else
                MessageBox.Show("Connection is Already Closed");
        }
        public void BindCompany(ComboBox company)
        {
            try
            {
                string sql = "Select CompanyID,CompanyName from Company order by CompanyID";
                DataTable dt = selectDatatable(sql);
                DataRow row = dt.NewRow();
                row["CompanyName"] = "Select Company";
                row["CompanyID"] = 0;
                dt.Rows.InsertAt(row, 0);
                company.DisplayMember = "CompanyName";
                company.ValueMember = "CompanyID";
                company.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindCategory(ComboBox category)
        {
            try
            {
                string sql = "Select CategoryID,CategoryName from Category order by CategoryID";
                DataTable dt = selectDatatable(sql);
                DataRow row = dt.NewRow();
                row["CategoryName"] = "Select Category";
                row["CategoryID"] = 0;
                dt.Rows.InsertAt(row, 0);
                category.DisplayMember = "CategoryName";
                category.ValueMember = "CategoryID";
                category.DataSource = dt;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void BindItems(ComboBox items)
        {
            try
            {
                DataTable dt = selectDatatable("select ItemCode,ItemName from Items");
                DataRow row = dt.NewRow();
                row["ItemName"] = "Select Item Name";
                row["ItemCode"] = "";
                dt.Rows.InsertAt(row, 0);
                items.DataSource = dt;
                items.DisplayMember = "ItemName";
                items.ValueMember = "ItemCode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }  // End Class }
}
