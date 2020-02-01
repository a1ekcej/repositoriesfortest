using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Data.Entity;
using Srtoi_tech_App.Models;
using System.Collections.Generic;

namespace Srtoi_tech_App
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new UsersDbInitializer());



            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}