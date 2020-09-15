using PooAndSolid.Domain.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooAndSolid.Adapter
{
    public interface AdapterCep<T>
    {
        ResponseCepKleberProfessor Convert(T t);
    }
}
