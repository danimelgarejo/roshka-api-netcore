using Newtonsoft.Json;

namespace SwaggerApi.Controllers
{
    public partial class Taxonomy
    {
        [JsonProperty("primary_section")]
        public PrimarySection PrimarySection { get; set; }
    }
}