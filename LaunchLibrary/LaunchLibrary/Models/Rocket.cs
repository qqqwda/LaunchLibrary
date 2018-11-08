using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    public class Rocket
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("configuration")]
        public string Configuration { get; set; }

        [JsonProperty("familyname")]
        public string Familyname { get; set; }

        [JsonProperty("agencies")]
        public Lsp[] Agencies { get; set; }

        [JsonProperty("wikiURL")]
        public Uri WikiUrl { get; set; }

        [JsonProperty("infoURLs")]
        public object[] InfoUrLs { get; set; }

        [JsonProperty("imageSizes")]
        public long[] ImageSizes { get; set; }

        [JsonProperty("imageURL")]
        public Uri ImageUrl { get; set; }
    }
}
