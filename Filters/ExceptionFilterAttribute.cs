using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace TelephoneDirectory.Filters
{
    public class ExceptionFilterAttribute : Attribute, IExceptionFilter
    {
       public void OnException(ExceptionContext context)
        {
            ILogger<ExceptionFilterAttribute> logger = context.HttpContext.RequestServices.GetRequiredService<ILogger<ExceptionFilterAttribute>>();

            string actionName = context.ActionDescriptor.DisplayName!;
            string exceptionStack = context.Exception.StackTrace!;
            string exceptionMessage = context.Exception.Message;

            logger.LogError($"An exception occurred in the {actionName} method: \n {exceptionMessage} \n {exceptionStack}");

            context.Result = new ContentResult
            {
                Content = "There has been a breakdown!",
            };

            context.ExceptionHandled = true;
        }
    }
}