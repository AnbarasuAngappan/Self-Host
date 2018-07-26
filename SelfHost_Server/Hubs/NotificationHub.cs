using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SelfHost_Server.Hubs
{
    public class NotificationHub : Hub
    {
        public void ServerTime()
        {
            do
            {
                Clients.All.displayTime($"{DateTime.UtcNow:F}");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            } while (true);           
        }

        public IEnumerable<string> Get()
        {
            Console.WriteLine("Method Invoked From the Client");
            //Console.WriteLine(Clients.All.displayTime($"{DateTime.UtcNow:F}"));
            return new string[] { "C", "C++", "Java", "MVC" };
        }

        public string GetMessage()
        {
            return Environment.UserName;
        }

        public string GetArraymsg(string a)
        {
            return a + "HI";
        }
    }
}
