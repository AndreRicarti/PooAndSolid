using PooAndSolid.Domain.DTO;

namespace PooAndSolid.Integration
{
    public interface CepClientIntegration
    {
        ResponseCepKleberProfessor GetCep(string cep);
    }
}
