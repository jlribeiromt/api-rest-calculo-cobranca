using CalculoCobranca.TaxaJuro.Api.Interface;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCobranca.TaxaJuro.Api.Controllers.v1
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/taxa")]
    [Produces("application/json")]
    public class TaxaJuroController : ControllerBase
    {
        private readonly ITaxaJuroService _taxaJuroService;

        public TaxaJuroController(ITaxaJuroService taxaJuroService)
        {
            _taxaJuroService = taxaJuroService;
        }

        [Route("taxaJuros")]        
        [HttpGet]
        public ActionResult<double> ObterTaxaJuro()
        {
            return _taxaJuroService.ObterTaxaJuro();
        }       
    }
}
