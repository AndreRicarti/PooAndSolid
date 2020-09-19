using PooAndSolid.Adapter;
using PooAndSolid.Domain.Response;
using PooAndSolid.Integration;

namespace PooAndSolid.Configuracao
{
    public class ConfiguracaoClienteImp : ConfiguracaoCliente
    {
        private readonly AdapterCep<ResponseViaCep> adapterViaCep;
        private readonly AdapterCep<ResponseWsApiCep> adapterWsApiCep;

        public ConfiguracaoClienteImp(AdapterCep<ResponseViaCep> adapterViaCep, AdapterCep<ResponseWsApiCep> adapterWsApiCep)
        {
            this.adapterViaCep = adapterViaCep;
            this.adapterWsApiCep = adapterWsApiCep;
        }

        public CepClientIntegration getConfig(string cep, int token)
        {
            CepClientIntegration cepClientIntegration;

            if (token < 5)
            {
                cepClientIntegration = new CepClientViaCepIntegration(adapterViaCep);
            } else
            {
                cepClientIntegration = new CepClientWsApiCepIntegration(adapterWsApiCep);
            }

            return cepClientIntegration;
        }
    }
}
