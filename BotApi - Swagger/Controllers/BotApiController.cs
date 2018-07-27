using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using BotApi.Models;
using BotApi.Services;
using BotApi.Interfaces;

namespace BotApi.Controllers
{
    [Route("BotApi")]
    //[Route("[controller]")]
    //[ApiController]
    public class BotApiController : ControllerBase
    {
       


        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            Log.Information("simple post");
            //throw new Exception("Test exception from post");
        }

        [HttpPost("SendMessage")]
        public void SendMessage([FromBody] Message message)
        {
            //MessageSender send = new MessageSender();
            Log.Warning("send msg");

             //send.Send(message);
            Log.Warning("sent msg");
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
