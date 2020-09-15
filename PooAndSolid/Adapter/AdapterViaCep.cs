using PooAndSolid.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooAndSolid.Adapter
{
    public class AdapterViaCep : AdapterCep<ResponseViaCep>
    {
        public ResponseCepKleberProfessor Convert(ResponseViaCep t)
        {
            return new ResponseCepKleberProfessor
            {
                Logradouro = t.Logradouro,
                Uf =  t.Uf
            };
        }
    }
}
