using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UkrPoshtaTestTask.Models;

namespace UkrPoshtaTestTask
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            bool messageStoreEmpty =
                 (System.Web.HttpContext.Current.Application["messagesStore"] == null) ;
            if (messageStoreEmpty)
            {
                System.Web.HttpContext.Current.Application["messagesStore"] = new MessagesStore();
            }
                
        }

        
    }
}
