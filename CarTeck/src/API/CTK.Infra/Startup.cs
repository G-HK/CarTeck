using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

namespace CTK.Infrastructure;

public static class Startup
{
    private static readonly ILogger _logger = Log.ForContext(typeof(Startup));

    public static void ConfigureServices(this IServiceCollection services, IConfiguration config)
    {
        services.AddControllers();
        services.AddOpenApiDocument(document =>
        {
            document.Title = "CTK API";
            document.Version = "v1";
            document.Description = "The API for the CTK project";
        });

        // Removed the problematic line 'services.AddOpenApi("v1");' as it is not valid.
        // The AddOpenApiDocument method above already configures OpenAPI support.
    }

    public static void Configure(this IServiceCollection app, IConfiguration config)
    {
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers().RequireAuthorization();
        app.MapHealthChecks("/api/health").RequireAuthorization();
        app.MapHealthChecks("/api/health/ready", new HealthCheckOptions
        {
            Predicate = (check) => check.Tags.Contains("ready"),
        }).RequireAuthorization();
    }
}
