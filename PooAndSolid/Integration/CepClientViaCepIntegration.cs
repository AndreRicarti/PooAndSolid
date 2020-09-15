using PooAndSolid.Adapter;
using PooAndSolid.Domain.DTO;
using PooAndSolid.Exception;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace PooAndSolid.Integration
{
    public class CepClientViaCepIntegration : CepClientIntegration
    {
        private AdapterCep<ResponseViaCep> adapterCep;

        public CepClientViaCepIntegration(AdapterCep<ResponseViaCep> adapterCep)
        {
            this.adapterCep = adapterCep;
        }

        public ResponseCepKleberProfessor GetCep(string cep)
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
