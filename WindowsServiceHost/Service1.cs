using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

[assembly: OwinStartup(typeof(WindowsServiceHost.Startup))]
namespace WindowsServiceHost
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }


       
    }

    class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.UseCors(CorsOptions.AllowAll);
            //app.MapSignalR();

            
        }
    }
}
