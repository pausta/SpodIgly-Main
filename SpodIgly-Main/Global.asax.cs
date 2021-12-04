using SpodIgly_Main.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SpodIgly_Main
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Database.SetInitializer<StoreContext>(new StoreInitializer());  --> I sposob na poinformowanie, ¿e chcemy skorzystac z Inicjalizatora (II sposób w EntityFramework(webconfig)
        }
    }
}
