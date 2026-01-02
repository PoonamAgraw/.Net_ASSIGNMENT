using _FilterSession.Logger;
using Microsoft.AspNetCore.Diagnostics;

namespace _FilterSession.Filters
{
    public class IETExExceptionFilter: IExceptionHandler
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
