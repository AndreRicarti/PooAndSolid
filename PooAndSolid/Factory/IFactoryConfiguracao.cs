using PooAndSolid.Configuracao;

namespace PooAndSolid.Factory
{
    public interface IFactoryConfiguracao
    {
        IConfiguracaoCliente Build(int token);
    }
}
