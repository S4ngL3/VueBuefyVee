using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using log4net;
using Microsoft.AspNetCore.Mvc.Controllers;
using Newtonsoft.Json;

namespace Net5Template.Application.Helpers
{
    public class ActionFilterCommon : IAsyncActionFilter
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        //public static readonly List<string> AutoPassUrl = new List<string>()
        //{
        //    "Account_Login"
        //};

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var decriptor = (ControllerActionDescriptor)context.ActionDescriptor;
            var controllerName = decriptor.ControllerName;
            var actionName = decriptor.ActionName;

            #region start log
            var dataLog = "\n--------------------------------------------------------------------------------------------------------------------------------------------------------";
            dataLog += "\nStart: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            dataLog += "\n" + context.ActionDescriptor.DisplayName;
            dataLog += "\nControllerName: " + controllerName;
            dataLog += "\nActionName: " + actionName;
            dataLog += "\nParameter: ";

            if (context.ActionArguments.Count > 0)
            {
                var lstArguments = context.ActionArguments.ToList();
                foreach (var item in lstArguments)
                {
                    var data = item.Key + ": " + JsonConvert.SerializeObject(item.Value);
                    dataLog += data + (lstArguments.LastIndexOf(item) == (lstArguments.Count - 1) ? "\n--------------------------------------" : "\n");
                }
            }
            #endregion

            //var urlAction = controllerName + "_" + actionName;
            //if (AutoPassUrl.Exists(c => c == urlAction))
            //{
            //    await next();
            //    dataLog += "\nEnd: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //    dataLog += "\n--------------------------------------------------------------------------------------------------------------------------------------------------------";

            //    log.Info(dataLog);
            //    return;
            //}

            //var request = context.HttpContext.Request;

            //if (request.Headers["Authorization"].Count == 0)
            //{
            //    context.HttpContext.Response.ContentType = "text/plain";
            //    context.HttpContext.Response.StatusCode = 401;
            //    await context.HttpContext.Response.WriteAsync("Không có token để valid");
            //    //context.Result = new JsonResult(new ResultData()
            //    //{
            //    //    error_code = ((int)ConstantStatus.STATUS_API.FAILD_VALID_TOKEN).ToString(),
            //    //    error_detail = "Không có token để valid"
            //    //});
            //    dataLog += "\nKhông có token để valid";
            //    dataLog += "\nEnd: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //    dataLog += "\n--------------------------------------------------------------------------------------------------------------------------------------------------------";
            //    log.Info(dataLog);
            //    return;
            //}

            //var authorization = AuthenticationHeaderValue.Parse(request.Headers["Authorization"]);

            //if (authorization == null || authorization.Scheme != "Bearer")
            //{
            //    context.HttpContext.Response.ContentType = "text/plain";
            //    context.HttpContext.Response.StatusCode = 401;
            //    await context.HttpContext.Response.WriteAsync("Token không hợp lệ");
            //    //context.Result = new JsonResult(new ResultData()
            //    //{
            //    //    error_code = ((int)ConstantStatus.STATUS_API.FAILD_VALID_TOKEN).ToString(),
            //    //    error_detail = "Không có token để valid",
            //    //    error_message = "Request không hợp lệ"
            //    //});

            //    dataLog += "\nRequest không hợp lệ(token không tồn tại hoặc không đúng cấu trúc)";
            //    dataLog += "\nEnd: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //    dataLog += "\n--------------------------------------------------------------------------------------------------------------------------------------------------------";
            //    log.Info(dataLog);
            //    return;
            //}


            //if (string.IsNullOrEmpty(authorization.Parameter))
            //{
            //    context.HttpContext.Response.ContentType = "text/plain";
            //    context.HttpContext.Response.StatusCode = 401;
            //    await context.HttpContext.Response.WriteAsync("Token không hợp lệ");
            //    //context.Result = new JsonResult(new ResultData()
            //    //{
            //    //    error_code = ((int)ConstantStatus.STATUS_API.FAILD_VALID_TOKEN).ToString(),
            //    //    error_detail = "Không có token để valid",
            //    //    error_message = "Request không hợp lệ"
            //    //});

            //    dataLog += "\nKhông có token để valid";
            //    dataLog += "\nEnd: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //    dataLog += "\n--------------------------------------------------------------------------------------------------------------------------------------------------------";
            //    log.Info(dataLog);
            //    return;
            //}

            //var token = authorization.Parameter;
            //var principal = await AuthenticateJwtToken(token);

            //if (principal == null)
            //{
            //    context.HttpContext.Response.ContentType = "text/plain";
            //    context.HttpContext.Response.StatusCode = 401;
            //    await context.HttpContext.Response.WriteAsync("Token không hợp lệ");
            //    //context.Result = new JsonResult(new ResultData()
            //    //{
            //    //    error_code = ((int)ConstantStatus.STATUS_API.FAILD_VALID_TOKEN).ToString(),
            //    //    error_detail = "Token không hợp lệ",
            //    //    error_message = "Request không hợp lệ"
            //    //});

            //    dataLog += "\nValid token không hợp lệ";
            //    dataLog += "\nEnd: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            //    dataLog += "\n--------------------------------------------------------------------------------------------------------------------------------------------------------";
            //    log.Info(dataLog);
            //    return;
            //}

            await next();

            dataLog += "\nEnd: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            dataLog += "\n--------------------------------------------------------------------------------------------------------------------------------------------------------";
            log.Info(dataLog);
        }

        protected Task<IPrincipal> AuthenticateJwtToken(string token)
        {
            if (ValidateToken(token, out var username))
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, username)
                };

                var identity = new ClaimsIdentity(claims, "Jwt");
                IPrincipal user = new ClaimsPrincipal(identity);

                return Task.FromResult(user);
            }

            return Task.FromResult<IPrincipal>(null);
        }

        private bool ValidateToken(string token, out string username)
        {
            username = null;
            var simplePrinciple = JwtManager.GetPrincipal(token);
            var identity = simplePrinciple?.Identity as ClaimsIdentity;

            if (identity == null || !identity.IsAuthenticated)
            {
                return false;
            }

            var usernameClaim = identity.FindFirst(ClaimTypes.Name);
            username = usernameClaim?.Value;
            if (string.IsNullOrEmpty(username))
                return false;
            return true;
        }
    }
}
