using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using SelfHost_Server;

[assembly:OwinStartup(typeof(StartUp))]//Microsoft.owin

namespace SelfHost_Server
{
    public partial class StartUp
    {
        public void Configuration(IAppBuilder app)
        {

        }
    }
}
