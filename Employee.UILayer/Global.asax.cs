using Ninject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Employee.UILayer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Application_Error()
        {
            var error =  HttpContext.Current.Server.GetLastError();
           
            using(StreamWriter writer = new StreamWriter(@"D:\\Log_"+DateTime.Now.ToString("dd-MMM-yyyy")+".txt"))
            {
                writer.WriteLine("***********Error-" + DateTime.Now.ToString() + "*********");
                writer.WriteLine();
                writer.WriteLine("---------------------Error Message----------------------");
                writer.WriteLine(error.Message);
                writer.WriteLine("-----------------Error StackTrace----------------------");
                writer.WriteLine(error.StackTrace);
                writer.WriteLine("----------------------------------------------------------");
            }

          
        }
    }
}
