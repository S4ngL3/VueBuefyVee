using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Microsoft.AspNetCore.Http;

namespace Net5Template.Application.Helpers
{
    public class ErrorHandlingMiddleware
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private readonly RequestDelegate next;
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var dataLog = "Error: \n" + ex.Message;
            dataLog += "\nChi tiết: \n" + ex.StackTrace;
            log.Debug(dataLog);
            var code = 501;
            var message = ex.Message;
            if (ex is UnauthorizedAccessException) code = (int)HttpStatusCode.Unauthorized;
            //else if (ex is ArgumentException) code = (int)HttpStatusCode.BadRequest;
            context.Response.ContentType = "text/plain";
            context.Response.StatusCode = code;
            return context.Response.WriteAsync(message);
        }
    }
}
