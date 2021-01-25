using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace CalculoCobranca.CalculaJuro.Api.Filters
{
    public class ExceptionActionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var response = context.HttpContext.Response;
            response.ContentType = "application/json";

            response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Result = new JsonResult(context.Exception.InnerException.Message);
        }
    }
}