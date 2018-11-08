using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    public class Location
    {
        [JsonProperty("pads")]
        public Pad[] Pads { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("infoURL")]
        public string InfoUrl { get; set; }

        [JsonProperty("wikiURL")]
        public string WikiUrl { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}
