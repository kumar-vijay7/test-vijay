using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class DashBoard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            apprun.Text = Application["Apps_running"].ToString();
            useron.Text = Application["NumberUser"].ToString();
            if(Session["UserName"]!=null)
            Username.Text = Session["UserName"].ToString();
           
        }
    }
}