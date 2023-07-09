using Microsoft.AspNetCore.HttpLogging;
using Serilog;
using Src.Database;
using Src.Repositories;
using Src.Security;
using Src.Services;

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
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection(JwtOptions.SectionName));
builder.Services.AddEshopAuthentication(builder.Configuration);
builder.Services.AddEshopDb(builder.Configuration);
builder.Services.AddTransient<ICategoryRepository, CategoryRepo>();
builder.Services.AddTransient<ICategoryService, CategoryService>();
builder.Services.AddTransient<JwtCreator>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<IProductRepository, ProductRepo>();

builder.Services.AddControllers();

var app = builder.Build();

app.UseHttpLogging();
app.MapGet("/", () => "Src Module");
// Use authentication and authorization
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();

namespace Src
{
    public partial class Program { }
}