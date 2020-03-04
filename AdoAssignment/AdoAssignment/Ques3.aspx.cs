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
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Insert":
                    {
                        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
                        {
                            conn.Open();
                            conn.ChangeDatabase("Assignment");
                            SqlCommand cmd = new SqlCommand("insert into Tbl_Product values(@Product_Name,@Product_sold,@Left_Product)", conn);
                            cmd.Parameters.AddWithValue("@Product_Name", TextBox2.Text);
                            cmd.Parameters.AddWithValue("@Product_sold", TextBox3.Text);
                            cmd.Parameters.AddWithValue("@Left_Product", TextBox4.Text);
                            cmd.ExecuteNonQuery();
                        }
                        break;
                    }

                case "edit":
                    {
                        if (e.CommandArgument.ToString() == "Delete")
                        {
                            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
                            {
                                conn.Open();
                                conn.ChangeDatabase("Assignment");
                                SqlCommand cmd = new SqlCommand("delete from Tbl_Product where Product_Name=@p_name", conn);
                                cmd.Parameters.AddWithValue("@p_name", TextBox2.Text);
                                cmd.ExecuteScalar();


                            }
                        }
                        else
                        {
                            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
                            {
                                conn.Open();
                                conn.ChangeDatabase("Assignment");
                                SqlCommand cmd = new SqlCommand("update Tbl_Product set Left_Product=@Left_Product where Product_Name=@Product_Name", conn);
                                cmd.Parameters.AddWithValue("@Left_Product", TextBox4.Text);
                                cmd.Parameters.AddWithValue("@Product_Name", TextBox2.Text);
                                cmd.ExecuteScalar();
                            }
                        }
                        break;
                    }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
            {
                conn.Open();
                conn.ChangeDatabase("Assignment");
                SqlCommand cmd = new SqlCommand("Select * from Tbl_Product", conn);
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                GridView1.Visible = true;

            }
        }
    }
}
