using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SelfHost_ConsoleClient
{
    class Program
    {


        static string[]  GetFromServer()
        {
            var client = new HttpClient();
            var httpResponse = client.GetAsync("http://localhost:5050/api/Product").Result;
            var result = httpResponse.Content.ReadAsAsync<string[]>().Result;


            if(httpResponse.IssuccessStatusCode)
            {
                return result;
            }
            return null;
        }





        static void Main(string[] args)
        {

        }
    }
}
