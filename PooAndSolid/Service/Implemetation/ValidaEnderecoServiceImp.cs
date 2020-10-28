using PooAndSolid.Configuracao;
using PooAndSolid.Domain.DTO;
using PooAndSolid.Domain.Response;
using PooAndSolid.Factory;
using PooAndSolid.Factory.Implementation;
using PooAndSolid.Integration;
using System;
using System.Collections.Generic;
namespace PooAndSolid.Service
{
    public class ValidaEnderecoServiceImp : IValidaEnderecoService
    {
        private readonly IFactoryConfiguracao factoryConfiguracao;

        public ValidaEnderecoServiceImp(IFactoryConfiguracao configuracaoCliente)
        {
            this.factoryConfiguracao = configuracaoCliente;
        }

        public ResponseRealizaEntrega RealizaEntrega(string cep, int token)
        {
            ICepClientIntegration cepClientIntegration = factoryConfiguracao.Build(token).GetConfig(cep);

            ResponsePooAndSolid responsePooAndSolid = cepClientIntegration.GetCep(cep);

            ResponseRealizaEntrega realizaEntrega = new ResponseRealizaEntrega
            {
                Endereco = responsePooAndSolid.Logradouro,
                RealizaEntrega = false,
                WilderLindao = true
            };

            if (responsePooAndSolid.Uf.Equals("SP") || responsePooAndSolid.Uf.Equals("RJ")
                || responsePooAndSolid.Uf.Equals("GO"))
            {
                realizaEntrega.RealizaEntrega = true;
            }

            return realizaEntrega;
        }
    }
}
