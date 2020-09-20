using PooAndSolid.Adapter;
using PooAndSolid.Domain.Response;
using PooAndSolid.Integration;

namespace PooAndSolid.Configuracao.Implementation
{
    public class ConfiguracaoClienteWsApiCepImp : IConfiguracaoCliente
    {
        private readonly IAdapterCep<ResponseWsApiCep> adapterCep;

        public ConfiguracaoClienteWsApiCepImp(IAdapterCep<ResponseWsApiCep> adapterCep)
        {
            this.adapterCep = adapterCep;
        }

        public ICepClientIntegration GetConfig(string cep)
        {
            return new CepClientWsApiCepIntegration(adapterCep);
        }
    }
}
