using Newtonsoft.Json;

namespace SwaggerApi.Controllers
{
    public partial class Description
    {
        [JsonProperty("basic")]
        public string Basic { get; set; }
    }
}