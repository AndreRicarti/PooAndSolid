using PooAndSolid.Adapter;
using PooAndSolid.Domain.Response;
using PooAndSolid.Integration;

namespace PooAndSolid.Configuracao
{
    public class ConfiguracaoClienteImp : IConfiguracaoCliente
    {
        private readonly IAdapterCep<ResponseViaCep> adapterViaCep;
        private readonly IAdapterCep<ResponseWsApiCep> adapterWsApiCep;

        public ConfiguracaoClienteImp(IAdapterCep<ResponseViaCep> adapterViaCep, IAdapterCep<ResponseWsApiCep> adapterWsApiCep)
        {
            this.adapterViaCep = adapterViaCep;
            this.adapterWsApiCep = adapterWsApiCep;
        }

        public ICepClientIntegration getConfig(string cep, int token)
        {
            ICepClientIntegration cepClientIntegration;

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
