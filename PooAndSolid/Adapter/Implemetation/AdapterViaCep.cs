using PooAndSolid.Domain.DTO;

namespace PooAndSolid.Adapter
{
    public class AdapterViaCep : IAdapterCep<ResponseViaCep>
    {
        public ResponsePooAndSolid Convert(ResponseViaCep t)
        {
            return new ResponsePooAndSolid
            {
                Logradouro = t.Logradouro,
                Uf =  t.Uf
            };
        }
    }
}
