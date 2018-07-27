using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;


namespace ViberApi
{
    [JsonObject]
    public class ViberMessage
    {
        [JsonProperty("receiver", Required = Required.Always)]
        public string Receiver { get; set; }

        [JsonProperty("min_api_version")]
        public int MinApiVersion { get; set; }

        [JsonProperty("sender", Required = Required.Always)]
        public Sender Sender { get; set; }

        [JsonProperty("tracking_data")]
        public string TrackingData { get; set; }

        [JsonProperty(PropertyName = "type", Required = Required.Always)]
        public Enums.ViberMessageType Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }


}
