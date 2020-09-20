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
            //switch (token)
            //{
            //    case int n when (n <= 5):
            //        return new ConfiguracaoClienteViaCepImp(new AdapterViaCep());
            //    default:
            //        return new ConfiguracaoClienteWsApiCepImp(new AdapterWsApiCep());
            //}

            return null;
        }
    }
}
