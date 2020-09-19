using PooAndSolid.Adapter;
using PooAndSolid.Domain.DTO;
using PooAndSolid.Exception;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace PooAndSolid.Integration
{
    public class CepClientViaCepIntegration : ICepClientIntegration
    {
        private IAdapterCep<ResponseViaCep> adapterCep;

        public CepClientViaCepIntegration(IAdapterCep<ResponseViaCep> adapterCep)
        {
            this.adapterCep = adapterCep;
        }

        public ResponsePooAndSolid GetCep(string cep)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://viacep.com.br/ws/{cep}/json/");
            request.Method = "GET";
            request.ContentType = "application/json";

            ResponseViaCep response = null;

            try
            {
                WebResponse webResponse = request.GetResponse();
                using StreamReader responseReader = new StreamReader(webResponse.GetResponseStream() ?? Stream.Null);
                string json = responseReader.ReadToEnd();
                response = JsonConvert.DeserializeObject<ResponseViaCep>(json);
                
            }
            catch (System.Exception ex)
            {
                throw new InternalServerError(ex.Message);
            }

            return adapterCep.Convert(response);
        }
    }
}
