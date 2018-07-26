using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Microsoft.Owin.Cors;
using Owin;
using SelfHost_Server;
using SelfHost_Server.Configurations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

[assembly: OwinStartup(typeof(Startup))]
namespace SelfHost_Server//.Configurations
{
    public partial class Startup
    {
        //public void InitialConfig(IAppBuilder app)
        //{
           
        //}

        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration httpConfiguration = new HttpConfiguration();
            RouteConfig.RegisterRoute(httpConfiguration);
            app.UseCors(CorsOptions.AllowAll);//using Microsoft.Owin.Cors;
            app.Map("/signalr", map =>
            {
                HubConfiguration hcf = new HubConfiguration();
                map.RunSignalR();
            });
            app.UseWebApi(httpConfiguration);//Install-Package Microsoft.AspNet.WebApi.OwinSelfHost

        }
    }
}
