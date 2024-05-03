using Serilog;
using Serilog.Context;
using System.Text;

namespace Assignment3_Asp.Net_Core
{
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

            await _next(httpContext);
        }
        private async Task<string> GetRequestDataAsync(HttpContext httpContext)
        {
            var requestData = new StringBuilder();
            requestData.AppendLine($"Schema: {httpContext.Request.Scheme}");
            requestData.AppendLine($"Host: {httpContext.Request.Host}");
            requestData.AppendLine($"Path: {httpContext.Request.Path}");
            requestData.AppendLine($"QueryString: {httpContext.Request.QueryString}");

            httpContext.Request.EnableBuffering();

            var bodyStream = new StreamReader(httpContext.Request.Body);


            string requestBody = await bodyStream.ReadToEndAsync();


            if (string.IsNullOrEmpty(requestBody))
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

            return requestData.ToString();
        }
    }

    public static class LoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggingMiddleware>();
        }
    }

}
