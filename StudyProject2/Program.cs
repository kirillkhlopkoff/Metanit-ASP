var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.Map("/hello", (ILogger<Program> logger) =>
{
    logger.LogInformation($"Path: /hello  Time: {DateTime.Now.ToLongTimeString()}");
    return "Hello World";
});

app.Run();
