using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using TodoBackend.Application.Services.Interfaces;
using TodoBackend.Presentation.Helpers;

namespace TodoBackend.Presentation.Filters
{
    public class GlobalExceptionFilter(IErrorLoggingService errorLoggingService) : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            var result = new ObjectResult("System error, try again")
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };

            var error = context.Exception.Message;
            var user = HttpContextHelper.GetAuthUser(context.HttpContext);

            try
            {
                errorLoggingService.SaveError(error, user?.Id);
            }
            catch {
            }
            context.Result = result;
        }
    }
}
