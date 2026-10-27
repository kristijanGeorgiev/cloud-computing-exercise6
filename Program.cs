
var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        Message = "Welcome to Cloud Computing API!",
        Course = "Cloud Computing",
        Technology = "ASP.NET Core",
        Environment = app.Environment.EnvironmentName,
        Version = "2.0"
    });
});

app.MapGet("/api/products", () =>
{
    var products = new[]
    {
        new { Id = 1, Name = "Laptop", Price = 45000 },
        new { Id = 2, Name = "Monitor", Price = 12000 },
        new { Id = 3, Name = "Keyboard", Price = 2500 }
    };

    return Results.Ok(products);
});

app.Run();