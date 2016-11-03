using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using TaskEntityFramework.DAL;

namespace TaskEntityFramework
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            
            System.Data.Entity.Database.SetInitializer(new Initializer());
            DatabaseContext db = new DatabaseContext();
            db.Database.Initialize(true);
        }
    }
}
