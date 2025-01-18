﻿using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Megapix.Responses;

namespace Megapix.Exceptions
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
        }

        public async Task Invoke(HttpContext httpContext)
        {

            try
            {
                await _next(httpContext);
            }
            catch (CustomException ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, CustomException exception)
        {
            BaseErrorResponse result;
            context.Response.ContentType = "application/json";

            if (exception is CustomException)
            {
                result = new BaseErrorResponse() { Message = exception.Message, StatusCode = (int)exception.StatusCode };
                context.Response.StatusCode = (int)exception.StatusCode;
            }
            else
            {
                result = new BaseErrorResponse() { Message = "Runtime Error", StatusCode = (int)HttpStatusCode.InternalServerError };
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            await context.Response.WriteAsync(result.ToString());
            return;
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            BaseErrorResponse result;
            context.Response.ContentType = "application/json";

            result = new BaseErrorResponse() { Message = exception.Message, StatusCode = (int)HttpStatusCode.InternalServerError };
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            await context.Response.WriteAsync(result.ToString());
            return;
        }

    }

    public static class ExceptionHandlerMiddlewareExtensions
    {

        public static IApplicationBuilder UseExceptionHandlerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
