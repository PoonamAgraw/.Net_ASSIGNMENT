using _EF_Filter_Session_WEBApi.Logger;
using Microsoft.AspNetCore.Diagnostics;

namespace _EF_Filter_Session_WEBApi.Filters
{
    public class IETExExceptionFilter : IExceptionHandler
    {
        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            FileLogger.CurrentLogger.Log(exception.Message);

            httpContext.Response.Redirect("/Exception/Error");
            // We have handled exception with our custom filter
            return ValueTask.FromResult(true);
        }
    }
}
