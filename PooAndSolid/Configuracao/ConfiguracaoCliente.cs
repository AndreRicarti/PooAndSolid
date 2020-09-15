using PooAndSolid.Integration;

namespace PooAndSolid.Configuracao
{
    public interface ConfiguracaoCliente
    {
        CepClientIntegration getConfig(string cep, int token);
    }
}
