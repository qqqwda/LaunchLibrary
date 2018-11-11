using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    public class Mission
    {
        private string description = "";

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description {
            get
            {
                return description;
            }
            set
            { 
                    if (!string.IsNullOrEmpty(value))
                {
                    description = value;
                }
            }
        }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("wikiURL")]
        public string WikiUrl { get; set; }

        [JsonProperty("typeName")]
        public string TypeName { get; set; }

        [JsonProperty("agencies")]
        public object Agencies { get; set; }

        [JsonProperty("payloads")]
        public Payload[] Payloads { get; set; }
    }
}
