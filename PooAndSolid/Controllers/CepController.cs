using PooAndSolid.Adapter;
using PooAndSolid.Configuracao;
using PooAndSolid.Domain.Response;
using PooAndSolid.Service;
using Microsoft.AspNetCore.Mvc;
using PooAndSolid.Factory;

namespace PooAndSolid.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CepController : ControllerBase
    {
        private readonly IValidaEnderecoService validaEnderecoService;

        public CepController(IValidaEnderecoService validaEnderecoService)
        {
            this.validaEnderecoService = validaEnderecoService;
        }

        [HttpGet]
        [Route("api/ConsultaEntrega/{cep}/{token}")]
        public ResponseRealizaEntrega Get(string cep, int token)
        {
            return validaEnderecoService.RealizaEntrega(cep, token);
        }
    }
}
