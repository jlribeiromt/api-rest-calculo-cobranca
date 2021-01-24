using CalculoCobranca.CalculaJuro.Api.Entites;
using Microsoft.AspNetCore.Mvc;

namespace CalculoCobranca.CalculaJuro.Api.Controllers.v1
{

    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/source")]
    [Produces("application/json")]
    public class SourceCodeController : ControllerBase
    {

        [Route("showmethecode")]
        [HttpGet]
        public IActionResult InfoSourceCode()
        {
            return Ok(new
            {
                Success = true,
                Data = new
                {
                    SourceCode.Url
                }
            });
        }
    }
}
