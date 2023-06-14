using Catalog.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<ICategoryRepository, CatetgoryInMemoryRepo>();
var app = builder.Build();
    
app.MapGet("/", () => "Catalog Module");

app.Run();

