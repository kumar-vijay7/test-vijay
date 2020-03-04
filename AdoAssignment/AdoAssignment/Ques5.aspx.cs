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
    public partial class Ques5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
            {
                conn.Open();
                conn.ChangeDatabase("Assignment");
                SqlCommand cmd = new SqlCommand("sp_product @p_id,@Product_name", conn);
                cmd.Parameters.AddWithValue("@p_id",TextBox1.Text);
                cmd.Parameters.AddWithValue("@Product_name", TextBox2.Text);
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();

            }
        }
    }
}