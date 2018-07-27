using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViberApi
{
    [JsonObject]
    public class ViberMessageResponse
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("status_message")]
        public string StatusMessage { get; set; }

        [JsonProperty("message_token")]
        public long MessageToken { get; set; }
    
    }
}
