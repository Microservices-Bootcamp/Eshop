using Catalog.Database;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Tests;

public class CustomWebApplicationFactory : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        base.ConfigureWebHost(builder);
        builder.UseEnvironment("Test");
        builder.ConfigureServices(services =>
        {
            var myCustomDbContext = services.SingleOrDefault(descriptor =>
                descriptor.ServiceType == typeof(DbContextOptions<EshopDatabase>));
            if (myCustomDbContext == null) return;
            services.Remove(myCustomDbContext);
            services.AddDbContext<EshopDatabase>(options => options.UseInMemoryDatabase("testing_db"));
        });
    }
}