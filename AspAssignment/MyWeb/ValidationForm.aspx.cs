
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
   /*-------------------Question 8 code--------------*/
    public partial class ValidationForm : System.Web.UI.Page
    {
        SqlConnection conn = null;//this is the sqlconnection object 
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
//----------------------registration button starts here----------------------
        protected void Register_Click(object sender, EventArgs e)
        {
            try { 
                using(conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
                {
                    try
                    {

                        //Connection object opened here
                        conn.Open();
                        //here database is changed because i am using the same connection string
                        conn.ChangeDatabase("Assignment");
                        //sql insert command in sqlcommand object
                        SqlCommand command = new SqlCommand("insert into Tbl_User values(@UserName,@Email,@Age,@Password)", conn);
                        //adding parameter with values  in command object 
                        command.Parameters.AddWithValue("@UserName", user.Text);
                        command.Parameters.AddWithValue("@Email", email.Text);
                        command.Parameters.AddWithValue("@Age", Age.Text);
                        command.Parameters.AddWithValue("@Password", password.Text);
                        //executing the query
                        command.ExecuteNonQuery();

                    }
                    catch (SqlException)
                    {

                        throw;
                    }               
                }
            }
            catch (SqlException sqleee)
            {
                //if any exception comes it will show the failed message to the user
                updation.Text="Connection Failed............." + sqleee;
            }
            finally
            {
                //show the successfull connection message to the user and connection closed
                updation.Text="Updated Successfully.....";
                conn.Close();
            }
        }
        /*-----------------------------------Login Method Starts Here----------------------------------*/
        protected void Login_Click(object sender, EventArgs e)
        {
            ViewState["email"] = lemail.Text;
            lemail.Text = ViewState["email"].ToString();
            try
            {
                Session["UserName"] = null;
                using (conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
                {

                    conn.Open();
                    conn.ChangeDatabase("assignment");

                    SqlCommand logincmd = new SqlCommand("Select * from Tbl_User where Email=@email and Password=@password", conn);
                    logincmd.Parameters.AddWithValue("@email", lemail.Text);
                    logincmd.Parameters.AddWithValue("@password", lpassword.Text);

                    SqlDataReader datareader = logincmd.ExecuteReader();
                    if (datareader.Read())
                    {
                        Session["UserName"] = datareader["UserName"];
                        Response.Redirect("dashboard.aspx");
                        Response.Write("login successful...");
                    }
                    else
                    {
                        Response.Write("login failed...");
                    }
                }
            }
            catch (SqlException sqlex)
            {

                Response.Write("connection error" + sqlex);
            }
            catch (Exception exce)
            {
                Response.Write("connection error" + exce);
            }


        }

        /*-----------------------------------Login Method Ends Here----------------------------------*/
    }
}