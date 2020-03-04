using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdoAssignment
{
    public partial class Ques6 : System.Web.UI.Page
    {
        SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Reload()
        {
            using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
            {
                SqlCommand sql = new SqlCommand("select * from Tbl_Product", conn);
                conn.Open();
                GridView1.DataSource = sql.ExecuteReader();
                GridView1.DataBind();
            }
           
        }
        protected void Purchase_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
            {
                conn.Open();
                SqlTransaction sqlTransaction =conn.BeginTransaction();
                try
                {
                    SqlCommand updatecmd = new SqlCommand("update Tbl_Product set Product_Sold=Product_Sold+1 where Product_Name=@Pname", conn, sqlTransaction);
                    updatecmd.Parameters.AddWithValue("@Pname", TextBox1.Text);
                    updatecmd.ExecuteNonQuery();
                    SqlCommand updatecmd2 = new SqlCommand("update Tbl_Product set Left_Product=Left_Product-1 where Product_Name=@Pname", conn, sqlTransaction);
                    updatecmd2.Parameters.AddWithValue("@Pname", TextBox1.Text);
                    updatecmd2.ExecuteNonQuery();
                    sqlTransaction.Commit();
                }
                catch 
                {
                    sqlTransaction.Rollback();
                    
                }
                Reload();

            }

        }
    }
}