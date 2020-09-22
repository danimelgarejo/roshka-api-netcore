using Newtonsoft.Json;
using System;

namespace SwaggerApi.Controllers
{
    public partial class Datum
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("_website_urls")]
        public string[] WebsiteUrls { get; set; }

        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("display_date")]
        public DateTimeOffset DisplayDate { get; set; }

        [JsonProperty("headlines")]
        public Description Headlines { get; set; }

        [JsonProperty("publish_date")]
        public DateTimeOffset PublishDate { get; set; }

        [JsonProperty("subheadlines")]
        public Description Subheadlines { get; set; }

        [JsonProperty("taxonomy")]
        public Taxonomy Taxonomy { get; set; }

        [JsonProperty("promo_items", NullValueHandling = NullValueHandling.Ignore)]
        public PromoItems PromoItems { get; set; }
    }
}