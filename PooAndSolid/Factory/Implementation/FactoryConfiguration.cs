using PooAndSolid.Adapter;
using PooAndSolid.Configuracao;
using PooAndSolid.Configuracao.Implementation;
using System.Collections;

namespace PooAndSolid.Factory.Implementation
{
    public class FactoryConfiguration : IFactoryConfiguracao
    {
        public IConfiguracaoCliente Build(int token)
        {
            return token switch
            {
                int n when (n <= 5) => new ConfiguracaoClienteViaCepImp(new AdapterViaCep()),
                _ => new ConfiguracaoClienteWsApiCepImp(new AdapterWsApiCep()),
            };
        }
    }
}
