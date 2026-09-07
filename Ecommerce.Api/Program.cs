var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/status", () => {
    return new { status = "Ecommerce API Online", version = "1.0.0" };
});

app.Run();