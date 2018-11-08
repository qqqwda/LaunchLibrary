﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchLibrary.Models
{
    class Launchs
    {
        [JsonProperty("launches")]
        public Launch[] Launches { get; set; }

        [JsonProperty("total")]
        public long Total { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }
}
