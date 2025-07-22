using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection; // This comes part of the Serilog.AspNetCore package?? why not the Microsoft.AspNetCore package? or Extensions.DependencyInjection package?
using Microsoft.Extensions.Options;

namespace CTK.Infrastructure.Common.Logging;

public static class Startup
{
    internal static IServiceCollection AddRequestLogging(IServiceCollection services, IConfiguration config)
    {
        services.Configure<LoggerSettings>(config.GetSection(nameof(LoggerSettings)));
        return services;
    }

    internal static IApplicationBuilder UseRequestLogging(this IApplicationBuilder app)
    {
        var loggerSettings = app.ApplicationServices.GetRequiredService<IOptions<LoggerSettings>>().Value;
        if (loggerSettings.EnableRequestLogging)
        {
            // Configure request logging middleware here
            // For example, you can use Serilog or any other logging framework
            // app.UseMiddleware<RequestLoggingMiddleware>(loggerSettings);
        }
        return app;
    }
}

public class LoggerSettings
{
    public bool EnableRequestLogging { get; set; }
    public bool EnableResponseLogging { get; set; }
    public bool EnableExceptionLogging { get; set; }
    public bool EnableRequestBodyLogging { get; set; }
    public bool EnableResponseBodyLogging { get; set; }
    public bool EnableRequestHeadersLogging { get; set; }
    public bool EnableResponseHeadersLogging { get; set; }
    public bool EnableRequestQueryStringLogging { get; set; }
    public bool EnableResponseStatusCodeLogging { get; set; }
    public bool EnableRequestPathLogging { get; set; }
    public bool EnableResponseTimeLogging { get; set; }
    public string? LogFilePath { get; set; }
    public string? LogLevel { get; set; }
    public string? OutputTemplate { get; set; }
}