using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OcelotService.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OpenController: ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1 from Ocelot", "value2 from Ocelot" };
        }

        // GET api/values/5
        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            return "value";
        }
    }
}
