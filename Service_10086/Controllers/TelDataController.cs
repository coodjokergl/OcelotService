using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Ocelot.Common.Models;

namespace ServiceApi_10086.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TelDataController: ControllerBase
    {
        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            var item = new TelData()
            {
                Name = $@"姓名:{name}",
                Message = $"电话余额:{DateTime.Now.Second * 10}￥",
            };
            return JsonConvert.SerializeObject(item);
        }
    }
}
