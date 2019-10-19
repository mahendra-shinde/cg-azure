using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_Demo1.Controllers
{
    public class ContactController : ApiController
    {
        [HttpGet]
        public String sayHello()
        {
            return "Hello World";
        }
    }
}
