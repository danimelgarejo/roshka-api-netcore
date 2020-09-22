using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerApi.Controllers
{
    public partial class Datos
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        //[JsonProperty("metadata")]
        //public Metadata Metadata { get; set; }

        //[JsonProperty("_id")]
        //public string Id { get; set; }
    }
}
