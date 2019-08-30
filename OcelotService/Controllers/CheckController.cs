using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace OcelotService.Controllers
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
