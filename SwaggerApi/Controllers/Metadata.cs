using Newtonsoft.Json;

namespace SwaggerApi.Controllers
{
    public partial class Metadata
    {
        [JsonProperty("page")]
        //[JsonConverter(typeof(ParseStringConverter))]
        public long Page { get; set; }

        [JsonProperty("per_page")]
        public long PerPage { get; set; }

        [JsonProperty("q")]
        public string Q { get; set; }

        [JsonProperty("took")]
        public long Took { get; set; }

        [JsonProperty("total_hits")]
        public long TotalHits { get; set; }
    }
}