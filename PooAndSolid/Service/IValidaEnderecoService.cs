using PooAndSolid.Domain.Response;

namespace PooAndSolid.Service
{
    public interface IValidaEnderecoService
    {
        ResponseRealizaEntrega RealizaEntrega(string cep, int token);
    }
}
