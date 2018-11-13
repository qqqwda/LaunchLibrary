using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    public class Agency
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("infoURL")]
        public string InfoUrl { get; set; }

        [JsonProperty("wikiURL")]
        public Uri WikiUrl { get; set; }

        [JsonProperty("infoURLs")]
        public List<object> InfoUrLs { get; set; }

        [JsonProperty("islsp")]
        public long Islsp { get; set; }

        [JsonProperty("changed")]
        public DateTimeOffset Changed { get; set; }
    }
}
