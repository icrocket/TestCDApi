using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestCDApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : ControllerBase
    {
        public DefaultController()
        {
            
        }

        [HttpGet]
        public string Get()
        {
            return "Ciao Randazzo 2";
        }
    }
}