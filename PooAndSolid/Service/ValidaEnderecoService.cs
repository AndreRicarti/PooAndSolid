using PooAndSolid.Domain.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PooAndSolid.Service
{
    interface ValidaEnderecoService
    {
        ResponseRealizaEntrega RealizaEntrega(string cep, int token);
    }
}
