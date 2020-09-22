using Newtonsoft.Json;
using System;

namespace SwaggerApi.Controllers
{
    public partial class ResizedUrls
    {
        [JsonProperty("270x175")]
        public Uri _270X175 { get; set; }

        [JsonProperty("910x590")]
        public Uri _The910X590 { get; set; }
    }
}