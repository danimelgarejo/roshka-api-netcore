using Newtonsoft.Json;

namespace SwaggerApi.Controllers
{
    public partial class PromoItems
    {
        [JsonProperty("basic", NullValueHandling = NullValueHandling.Ignore)]
        public Basic Basic { get; set; }
    }
}