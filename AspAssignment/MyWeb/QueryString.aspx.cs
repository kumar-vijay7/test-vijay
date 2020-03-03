using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn(object sender, EventArgs e)
        {
            Response.Redirect("HelloWorld.aspx?MyName=" + Server.UrlEncode(Name.Text));
        }
    }
}