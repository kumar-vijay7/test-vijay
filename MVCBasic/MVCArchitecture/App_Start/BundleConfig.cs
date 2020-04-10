using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace MVCArchitecture.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                         "~/Scripts/jquery-3.0.0.min.js","~/Scripts/sitejs.js"));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/Site.css"
                ));


            // Code removed for clarity.
            BundleTable.EnableOptimizations = true;
        }
    }
}