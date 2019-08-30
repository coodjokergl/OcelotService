using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Service.AuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckController: ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "服务器时间", $@"{DateTime.Now}" };
        }
    }
}
