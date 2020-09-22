using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;

namespace SwaggerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        [HttpGet("GetResponse")]
        public ActionResult GetResponse()
        {
            return Ok("Return Success");
        }

        [HttpGet("consulta")]
        //public IEnumerable<News> GetAllNews(string q)
        public dynamic GetAllNews(string q)
        {
            RestClient rClient = new RestClient();
            rClient.texto = q;

            string strResponse = string.Empty;

            strResponse = rClient.makeRequest();

            string notices = "globalContent=";
            String[] elements1 = System.Text.RegularExpressions.Regex.Split(strResponse, notices);
            notices = elements1[1];

            string noticesJson = ";Fusion.globalContentConfig=";
            String[] elements2 = System.Text.RegularExpressions.Regex.Split(notices, noticesJson);
            noticesJson = elements2[0];

            //var datosResponse = JsonConvert.DeserializeObject<dynamic>(noticesJson);
            var datosResponse = JsonConvert.DeserializeObject<Datos>(noticesJson);

            //fecha
            //enlace
            //enlace_foto
            //titulo
            //resumen
            //contenido_foto (BONO)
            //content_type_foto (BONO)

            for (int i = 0; i < datosResponse.Data.Length; i++)
            {
                Datum _data = new Datum()
                {
                    PublishDate = datosResponse.Data[i].PublishDate,
                    WebsiteUrls = datosResponse.Data[i].WebsiteUrls,
                    PromoItems = datosResponse.Data[i].PromoItems,
                    Headlines = datosResponse.Data[i].Headlines,
                    Subheadlines = datosResponse.Data[i].Subheadlines,
                };
            }
            return datosResponse.Data;
        }
    }
}
