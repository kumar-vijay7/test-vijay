using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAdvance.Common
{
    public class CustomFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            Debug.WriteLine(filterContext.Exception,"CustomFilter Found");
        }
    }
    public class CustomFilter2 : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            Debug.WriteLine(filterContext.Exception, "CustomFilter2 Found");
        }
    }
}