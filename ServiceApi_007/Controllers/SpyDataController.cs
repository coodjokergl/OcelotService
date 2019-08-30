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
    public class SpyDataController: ControllerBase
    {
        private static List<string> Skill = new List<string>()
        {
            "刀", "枪", "剑", "拳"
        };

        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            var s = Skill[(name?.Length??0) % Skill.Count];
            var item = new Spy()
            {
                Name = $@"特工名称:{name}",
                Skill = $"特技: 用 {s} 击败敌人",
            };
            return JsonConvert.SerializeObject(item);
        }
    }
}
