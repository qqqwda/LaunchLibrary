using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    public class RootAgencies
    {
        [JsonProperty("agencies")]
        public List<Agency> Agencies { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }
    }
}
