using PooAndSolid.Domain.DTO;
using PooAndSolid.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooAndSolid.Adapter
{
    public class AdapterWsApiCep : IAdapterCep<ResponseWsApiCep>
    {
        public ResponsePooAndSolid Convert(ResponseWsApiCep t)
        {
            return new ResponsePooAndSolid
            {
                Logradouro = t.Address,
                Uf = t.State
            };
        }
    }
}
