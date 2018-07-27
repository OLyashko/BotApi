using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ViberApi
{
    [JsonObject]
    public class Sender
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }
}
