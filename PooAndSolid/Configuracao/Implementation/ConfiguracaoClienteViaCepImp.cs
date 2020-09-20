using PooAndSolid.Adapter;
using PooAndSolid.Integration;
namespace PooAndSolid.Configuracao.Implementation
{
    public class ConfiguracaoClienteViaCepImp : IConfiguracaoCliente
    {
        private readonly IAdapterCep<ResponseViaCep> adapterCep;

        public ConfiguracaoClienteViaCepImp(IAdapterCep<ResponseViaCep> adapterCep)
        {
            this.adapterCep = adapterCep;
        }

        public ICepClientIntegration GetConfig(string cep)
        {
            return new CepClientViaCepIntegration(adapterCep);
        }
    }
}
