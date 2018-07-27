using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BotApi.Models
{
    [JsonObject]
    public class Message
    {
        [JsonProperty("Msisdn", Required = Required.Always)]
        public string Msisdn { get; set; }

        [JsonProperty("Text", Required = Required.Always)]
        public string Text { get; set; }

    }
}
