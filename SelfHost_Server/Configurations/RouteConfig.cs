using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHost_Server.Configurations
{
    public static class RouteConfig
    {
        public static void RegisterRoute(HttpConfiguration route)//Microsoft asp.net web API 2.2 core libraries
        {
            route.Routes.MapHttpRoute(
                name:"DefaultApi",
                routeTemplate:"api/{controller}/{id}",
                defaults:new { id=RouteParameter.Optional});
        }
    }
}
