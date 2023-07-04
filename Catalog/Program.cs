using Catalog.Database;
using Catalog.Repositories;
using Catalog.Services;
using Microsoft.AspNetCore.HttpLogging;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
builder.Host.UseSerilog((context, services, configuration) =>
{
    configuration
        .ReadFrom.Configuration(context.Configuration)
        .ReadFrom.Services(services);
});
builder.Services.AddHttpLogging(options =>
{
    options.LoggingFields = HttpLoggingFields.All;
});
builder.Services.AddEshopDb(builder.Configuration);
builder.Services.AddTransient<ICategoryRepository, CategoryRepo>();
builder.Services.AddTransient<ICategoryService, CategoryService>();

builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IProductRepository, ProductRepo>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpLogging();
app.MapGet("/", () => "Catalog Module");
app.MapControllers();
app.Run();

public partial class Program { }