using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerApi.Controllers
{
    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
    class RestClient
    {
        public string texto { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient()
        {
            texto = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            string urlRequest = "https://www.abc.com.py/buscar/";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlRequest + texto);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    switch (response.StatusCode)
                    {
                        //Error 404
                        case HttpStatusCode.NotFound:
                            throw new ApplicationException("codigo: g267, " + "error: No se encuentran noticias para el texto: " + texto);
                        //Error 400
                        case HttpStatusCode.BadRequest:
                            throw new ApplicationException("codigo: g268, " + "error: Parámetros inválidos");
                        //Error 500
                        case HttpStatusCode.InternalServerError:
                            throw new ApplicationException("codigo: g100, " + "error: Error interno del servidor");
                    }
                }
                else
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader reader = new StreamReader(responseStream))
                            {
                                strResponseValue = reader.ReadToEnd();
                            }
                        }
                    }
                }
            }
            return strResponseValue;
        }
    }
}