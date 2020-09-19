using PooAndSolid.Adapter;
using PooAndSolid.Domain.DTO;
using PooAndSolid.Domain.Response;
using PooAndSolid.Exception;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace PooAndSolid.Integration
{
    public class CepClientWsApiCepIntegration : ICepClientIntegration
    {
        private IAdapterCep<ResponseWsApiCep> adapterCep = null;

        public CepClientWsApiCepIntegration(IAdapterCep<ResponseWsApiCep> adapterCep)
        {
            this.adapterCep = adapterCep;
        }

        public ResponsePooAndSolid GetCep(string cep)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://ws.apicep.com/cep/{cep}.json");
            request.Method = "GET";
            request.ContentType = "application/json";

            ResponseWsApiCep response = null;

            try
            {
                WebResponse webResponse = request.GetResponse();
                using StreamReader responseReader = new StreamReader(webResponse.GetResponseStream() ?? Stream.Null);
                string json = responseReader.ReadToEnd();
                response = JsonConvert.DeserializeObject<ResponseWsApiCep>(json);

            }
            catch (System.Exception ex)
            {
                throw new InternalServerError(ex.Message);
            }

            return adapterCep.Convert(response);
        }
    }
}
