using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHost_Server.Controllers
{
   public  class ProductController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] {"C","C++","Java","MVC" };
        }      
    }
}
