using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    class Payload
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
