using _EF_Filter_Session_WEBApi.Controllers;
using _EF_Filter_Session_WEBApi.Logger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Runtime.ConstrainedExecution;

namespace _EF_Filter_Session_WEBApi.Filters
{
    public class IETFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            FileLogger.CurrentLogger.Log($"Calling :{context.HttpContext.Request.Path.Value} ");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            FileLogger.CurrentLogger.Log($"Called:  {context.HttpContext.Request.Path.Value} ");
        }

        public override void OnResultExecuting(ResultExecutingContext context)
        {
            FileLogger.CurrentLogger.Log($"Generating View: {context.HttpContext.Request.Path.Value} ");
        }
        public override void OnResultExecuted(ResultExecutedContext context)
        {
            FileLogger.CurrentLogger.Log($"Generated View: {context.HttpContext.Request.Path.Value} ");
        }
    }
}
