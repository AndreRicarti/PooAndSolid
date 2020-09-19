using PooAndSolid.Domain.DTO;

namespace PooAndSolid.Adapter
{
    public interface IAdapterCep<T>
    {
        ResponsePooAndSolid Convert(T t);
    }
}
