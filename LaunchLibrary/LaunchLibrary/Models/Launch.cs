using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    public class Launch
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("windowstart")]
        public string Windowstart { get; set; }

        [JsonProperty("windowend")]
        public string Windowend { get; set; }

        [JsonProperty("net")]
        public string Net { get; set; }

        [JsonProperty("wsstamp")]
        public long Wsstamp { get; set; }

        [JsonProperty("westamp")]
        public long Westamp { get; set; }

        [JsonProperty("netstamp")]
        public long Netstamp { get; set; }

        [JsonProperty("isostart")]
        public string Isostart { get; set; }

        [JsonProperty("isoend")]
        public string Isoend { get; set; }

        [JsonProperty("isonet")]
        public string Isonet { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("inhold")]
        public long Inhold { get; set; }

        [JsonProperty("tbdtime")]
        public long Tbdtime { get; set; }

        [JsonProperty("vidURLs")]
        public Uri[] VidUrLs { get; set; }

        [JsonProperty("vidURL")]
        public object VidUrl { get; set; }

        [JsonProperty("infoURLs")]
        public object[] InfoUrLs { get; set; }

        [JsonProperty("infoURL")]
        public object InfoUrl { get; set; }

        [JsonProperty("holdreason")]
        public object Holdreason { get; set; }

        [JsonProperty("failreason")]
        public object Failreason { get; set; }

        [JsonProperty("tbddate")]
        public long Tbddate { get; set; }

        [JsonProperty("probability")]
        public long Probability { get; set; }

        [JsonProperty("hashtag")]
        public string Hashtag { get; set; }

        [JsonProperty("changed")]
        public DateTimeOffset Changed { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        [JsonProperty("rocket")]
        public Rocket Rocket { get; set; }

        [JsonProperty("missions")]
        public Mission[] Missions { get; set; }

        [JsonProperty("lsp")]
        public Lsp Lsp { get; set; }
    }
}
