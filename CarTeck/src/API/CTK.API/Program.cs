using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Serilog;
using Serilog.Formatting.Compact;
using Serilog.Sinks.SystemConsole.Themes;

// Serilog Configuration // To Log to Console on starting the API
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console(new CompactJsonFormatter(),
         outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
         theme: AnsiConsoleTheme.Code)
    .WriteTo.File("logs/ctk-api.log",
        outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
    .CreateLogger();

Log.Information("Engine Startup");
Log.Information("Selamun Aleykum");

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// figerout on how to generate Nwsage api command base

builder.Services.AddOpenApiDocument(document =>
{
    document.Title = "CTK API";
    document.Version = "v1";
    document.Description = "The API for the CTK project";
});

// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi("v1");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    // Add OpenAPI 3.0 document serving middleware
    // Available at: http://localhost:<port>/swagger/v1/swagger.json
    app.UseOpenApi();

    // Add web UIs to interact with the document
    // Available at: http://localhost:<port>/swagger
    app.UseSwaggerUi(); // UseSwaggerUI Protected by if (env.IsDevelopment())
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers().RequireAuthorization();
app.MapHealthChecks("/api/health").RequireAuthorization();
app.MapHealthChecks("/api/health/ready", new HealthCheckOptions
{
    Predicate = (check) => check.Tags.Contains("ready"),
}).RequireAuthorization();

// research on how to implement it these hubs.
//app.MapHub<ChatHub>("/chatHub");
//app.MapHub<NotificationHub>("/notificationHub");

app.Run();
