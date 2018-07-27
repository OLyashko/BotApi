using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ViberApi.Enums
{
    [JsonConverter(typeof(StringEnumConverter), true)]
    public enum ViberMessageType
    {
        [EnumMember(Value = "text")]
        Text,

        [EnumMember(Value = "picture")]
        Picture,

        [EnumMember(Value = "video")]
        Video,

        [EnumMember(Value = "file")]
        File,

        [EnumMember(Value = "location")]
        Location,

        [EnumMember(Value = "sticker")]
        Sticker,

        [EnumMember(Value = "contact")]
        Contact,

        [EnumMember(Value = "rich_media")]
        RichMedia,

        [EnumMember(Value = "url")]
        URL
    }
}
