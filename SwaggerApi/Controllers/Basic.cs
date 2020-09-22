using Newtonsoft.Json;
using System;

namespace SwaggerApi.Controllers
{
    public partial class Basic
    {
        [JsonProperty("resized_urls")]
        public ResizedUrls ResizedUrls { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}