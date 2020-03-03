using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class Adoconnect : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = null;

            try
            {
                using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES", conn);
                    GridView1.DataSource = cmd.ExecuteReader();
                    GridView1.DataBind();
                    conn.Close();

                }
            }
            catch(SqlException ex)
            {
                Response.Write(ex);
            }

            finally
            {
                conn.Close();
            }
        }
    }
}