using PooAndSolid.Integration;

namespace PooAndSolid.Configuracao
{
    public interface IConfiguracaoCliente
    {
        ICepClientIntegration getConfig(string cep, int token);
    }
}
