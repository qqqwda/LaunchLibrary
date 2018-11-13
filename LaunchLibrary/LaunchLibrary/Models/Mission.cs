using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    public class Mission
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("agencies")]
        public object Agencies { get; set; }
    }
}
