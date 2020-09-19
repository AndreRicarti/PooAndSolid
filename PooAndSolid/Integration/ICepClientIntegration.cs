using PooAndSolid.Domain.DTO;

namespace PooAndSolid.Integration
{
    public interface ICepClientIntegration
    {
        ResponsePooAndSolid GetCep(string cep);
    }
}
