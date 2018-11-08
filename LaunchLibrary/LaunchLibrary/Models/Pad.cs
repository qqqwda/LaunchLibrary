using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    public class Pad
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("infoURL")]
        public string InfoUrl { get; set; }

        [JsonProperty("wikiURL")]
        public Uri WikiUrl { get; set; }

        [JsonProperty("mapURL")]
        public Uri MapUrl { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("agencies")]
        public Lsp[] Agencies { get; set; }
    }
}
