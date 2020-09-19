using PooAndSolid.Adapter;
using PooAndSolid.Configuracao;
using PooAndSolid.Domain.Response;
using PooAndSolid.Service;
using Microsoft.AspNetCore.Mvc;

namespace PooAndSolid.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CepController : ControllerBase
    {
        private readonly IValidaEnderecoService validaEnderecoService;

        public CepController()
        {
            IConfiguracaoCliente configuracaoCliente = new ConfiguracaoClienteImp(new AdapterViaCep(), new AdapterWsApiCep());
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
