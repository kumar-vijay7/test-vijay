using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AdoAssignment
{
    public partial class _Default : Page
    {

        SqlConnection conn = null;//this is the data provider sqlconnection object 
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Show_Data(object sender, EventArgs e)
        {
                Label1.Visible = true;
                Label1.Text = "Connected Architecture";
                Label2.Visible = false;
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString);
                conn.Open();
                conn.ChangeDatabase("BootCamp2020");
                SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES", conn);//this is command data provider object
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                conn.Close();
            }
            catch (SqlException se)
            {

                Console.WriteLine(se);
            }
            

        }

        protected void Disconnected_Click(object sender, EventArgs e)
        {
            if (Cache["EmployeeData"] == null)
            {
                Label1.Visible = true;
                Label1.Text = "Disconnected Architecture";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString))
                {
                    conn.Open();
                    conn.ChangeDatabase("BootCamp2020");
                    SqlCommand cmd = new SqlCommand("Select * from TBL_EMPLOYEES", conn);
                    cmd.CommandType = CommandType.Text;
                    sqlDataAdapter.SelectCommand = cmd;
                    sqlDataAdapter.Fill(dataset);
                    Cache["EmployeeData"] = dataset;
                    GridView1.DataSource = dataset.Tables[0];
                    GridView1.DataBind();
                }
            }
            else
            {
                Label2.Visible = true;
                Label2.Text = "Fetch from Cache";
                GridView1.DataSource = (DataSet)Cache["EmployeeData"];
                GridView1.DataBind();
            }
        }
    }
}