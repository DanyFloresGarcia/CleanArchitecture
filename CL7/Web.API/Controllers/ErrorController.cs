using ErrorOr;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Web.API.Common.Http;

namespace Web.API.Controllers;

public class ErrorController : ControllerBase
{
    [ApiExplorerSettings(IgnoreApi =true)]
    [Route("/error")]
    protected IActionResult Error()
    {
       Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        return Problem();
    }
}