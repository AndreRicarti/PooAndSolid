using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PooAndSolid.Adapter;
using PooAndSolid.Configuracao;
using PooAndSolid.Domain.Response;
using PooAndSolid.Integration;
using PooAndSolid.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace PooAndSolid.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        readonly ValidaEnderecoService validaEnderecoService = null;
        readonly ConfiguracaoCliente configuracaoCliente = null;

        public WeatherForecastController()
        {
            configuracaoCliente = new ConfiguracaoClienteImp(new AdapterViaCep(), new AdapterWsApiCep());
            validaEnderecoService = new ValidaEnderecoServiceImp(configuracaoCliente);
        }

        [HttpGet]
        [Route("api/ConsultaEntrega/{cep}/{token}")]
        public ResponseRealizaEntrega Get(string cep, int token)
        {
            return validaEnderecoService.RealizaEntrega(cep, token);
        }
    }
}
