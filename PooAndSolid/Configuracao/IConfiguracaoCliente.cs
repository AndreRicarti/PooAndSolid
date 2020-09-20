using PooAndSolid.Integration;

namespace PooAndSolid.Configuracao
{
    public interface IConfiguracaoCliente
    {
        ICepClientIntegration GetConfig(string cep);
    }
}
