using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    public class Lsp
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("infoURL")]
        public object InfoUrl { get; set; }

        [JsonProperty("wikiURL")]
        public Uri WikiUrl { get; set; }

        [JsonProperty("infoURLs")]
        public Uri[] InfoUrLs { get; set; }
    }
}
