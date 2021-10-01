using Castle.Core.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ResponseStates.Exceptions;
using ResponseStates.Extensions;
using ResponseStates.Models;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Api.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private static readonly Serilog.ILogger _logger = Log.ForContext<ExceptionHandlingMiddleware>();

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext, IWebHostEnvironment env)
        {
            try
            {
                var result = _next(httpContext);
                await result;
            }
            catch (StateException ex)
            {
                await HandleExceptionAsync(httpContext, ex, env);
            }
            catch (System.Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex, env);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, StateException exception, IWebHostEnvironment env)
        {
            var status = new ResponseState(exception.StateCode, exception.Messages);

            _logger.Error($"{DateTime.Now.ToString("HH:mm:ss")} : {exception}");

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = status.Status.StateCode.GetStateCode();
            return context.Response.WriteAsync(status.ToString());
        }

        private async Task HandleExceptionAsync(HttpContext context, System.Exception exception, IWebHostEnvironment env)
        {


            //context.Response.StatusCode = response.Status.Code;
            //if (context.Request.Body.CanSeek)
            //    context.Request.Body.Position = 0;

            ////Logging
            //logger.Error(response, "Error");

            _logger.Error($"{DateTime.Now.ToString("HH:mm:ss")} : {exception}");

            await _next(context);
        }              
    }    
}
