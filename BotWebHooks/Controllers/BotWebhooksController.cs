using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebHooks;

namespace BotWebHooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BotWebHooksController : ControllerBase
    {
        // GET api/health
        [HttpGet("health")]
        public ActionResult Health()
        {
                return Ok("BotWebhooks");
        }

        // POST api/values
        [HttpPost("SendWebHook")]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
