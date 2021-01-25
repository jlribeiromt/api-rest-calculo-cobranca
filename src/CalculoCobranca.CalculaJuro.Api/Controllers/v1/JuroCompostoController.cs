using CalculoCobranca.CalculaJuro.Api.Filters;
using CalculoCobranca.CalculaJuro.Api.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCobranca.CalculaJuro.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/taxa")]
    [Produces("application/json")]
    [ExceptionActionFilter]
    public class JuroCompostoController : ControllerBase
    {
        private readonly ICalculaJuroService _calculaJuroService;

        public JuroCompostoController(ICalculaJuroService calculaJuroService)
        {
            _calculaJuroService = calculaJuroService;
        }

        [Route("taxaJuros")]        
        [HttpGet]
        public ActionResult ObterValorCalculoJuroComposto(double valorInicial, int meses)
        {
            var resulDTO = _calculaJuroService.ObterValorJuroComposto(valorInicial, meses);

            if (resulDTO.OperationSuccess)
            {
                return Ok(new
                {
                    Success = resulDTO.OperationSuccess,
                    Data = new
                    {
                        Resultado = resulDTO.Data
                    }
                });
            }
            else
            {
                return BadRequest(new
                {
                    Success = resulDTO.OperationSuccess,
                    Data = new
                    {
                        Messages = resulDTO.Data
                    }
                });
            }
        }
    }
}
