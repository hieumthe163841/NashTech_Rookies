using Serilog;
using Serilog.Context;
using System.Text;

namespace Assignment3_Asp.Net_Core
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public LoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            string requestData = await GetRequestDataAsync(httpContext);

            Log.Information(requestData.ToString());
            //Log.Information("Request received");

            await _next(httpContext);
        }
        private async Task<string> GetRequestDataAsync(HttpContext httpContext)
        {
            var requestData = new StringBuilder();

            //build up the request data data string

            requestData.AppendLine($"Schema: {httpContext.Request.Scheme}");
            requestData.AppendLine($"Host: {httpContext.Request.Host}");
            requestData.AppendLine($"Path: {httpContext.Request.Path}");
            requestData.AppendLine($"QueryString: {httpContext.Request.QueryString}");
            //using(LogContext.PushProperty("Schema ", httpContext.Request.Scheme));
            //using (LogContext.PushProperty("Host", httpContext.Request.Host));
            //using (LogContext.PushProperty("Path", httpContext.Request.Path));
            //using (LogContext.PushProperty("QueryString", httpContext.Request.QueryString));



            httpContext.Request.EnableBuffering();

            var bodyStream = new StreamReader(httpContext.Request.Body);


            string requestBody = await bodyStream.ReadToEndAsync();


            if(string.IsNullOrEmpty(requestBody))
            {
                requestBody = "No Request Body";
            }
            else
            {
                var reader = new StreamReader(httpContext.Request.Body);
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                requestBody = await reader.ReadToEndAsync();
            }

            httpContext.Request.Body.Position = 0;

            requestData.AppendLine($"RequestBody: {requestBody}");
            //LogContext.PushProperty("RequestBody", requestBody);


            return requestData.ToString();
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }

}
