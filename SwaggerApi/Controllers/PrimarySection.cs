using Newtonsoft.Json;

namespace SwaggerApi.Controllers
{
    public partial class PrimarySection
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}