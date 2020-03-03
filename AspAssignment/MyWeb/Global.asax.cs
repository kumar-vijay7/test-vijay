using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace MyWeb
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["Apps_running"] = 0;
            Application["NumberUser"] = 0;
            Application["Apps_running"] =(int) Application["Apps_running"]+ 1;
        }

        void Session_Start(object sender, EventArgs e)
        {
            Application["NumberUser"] = (int)Application["NumberUser"] + 1;
        }

        void Session_End(object sender, EventArgs e)
        {
            Application["NumberUser"] = (int)Application["NumberUser"] - 1;
        }
    }
}