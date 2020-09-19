﻿using PooAndSolid.Configuracao;
using PooAndSolid.Domain.DTO;
using PooAndSolid.Domain.Response;
using PooAndSolid.Integration;
using System;
using System.Collections.Generic;
namespace PooAndSolid.Service
{
    public class ValidaEnderecoServiceImp : IValidaEnderecoService
    {
        private readonly IConfiguracaoCliente configuracaoCliente = null;

        public ValidaEnderecoServiceImp(IConfiguracaoCliente configuracaoCliente)
        {
            this.configuracaoCliente = configuracaoCliente;
        }

        public ResponseRealizaEntrega RealizaEntrega(string cep, int token)
        {
            ICepClientIntegration cepClientIntegration = configuracaoCliente.getConfig(cep, token);

            ResponsePooAndSolid responseCepKleberProfessor = cepClientIntegration.GetCep(cep);

            ResponseRealizaEntrega realizaEntrega = new ResponseRealizaEntrega
            {
                Endereco = responseCepKleberProfessor.Logradouro,
                RealizaEntrega = false,
                WilderLindao = true
            };

            if (responseCepKleberProfessor.Uf.Equals("SP") || responseCepKleberProfessor.Uf.Equals("RJ")
                || responseCepKleberProfessor.Uf.Equals("GO"))
            {
                realizaEntrega.RealizaEntrega = true;
            }

            return realizaEntrega;
        }
    }
}