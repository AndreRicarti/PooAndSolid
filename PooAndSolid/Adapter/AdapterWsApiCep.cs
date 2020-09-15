using PooAndSolid.Domain.DTO;
using PooAndSolid.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooAndSolid.Adapter
{
    public class AdapterWsApiCep : AdapterCep<ResponseWsApiCep>
    {
        public ResponseCepKleberProfessor Convert(ResponseWsApiCep t)
        {
            return new ResponseCepKleberProfessor
            {
                Logradouro = t.Address,
                Uf = t.State
            };
        }
    }
}
