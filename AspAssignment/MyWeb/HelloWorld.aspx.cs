using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWeb
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet dataset = new DataSet();
                dataset.ReadXml(Server.MapPath("CountryData.xml"));
                CountryList.DataTextField = "CountryName";
                CountryList.DataValueField ="CountryId";
                CountryList.DataSource = dataset;
                CountryList.DataBind();
                ListItem listItem = new ListItem("Select", "-1");
                CountryList.Items.Insert(0, listItem);
            }
            String Stringvalue = Request.QueryString["MyName"];
            QueryName.Text = Stringvalue;

        }

        protected void Country(object sender, EventArgs e)
        {
            if (CountryList.SelectedValue != "-1") { 
            Hello.Text = CountryList.SelectedItem.ToString();
            }
            else
            {
                Hello.Text = "Select";
            }
        }
    }
}