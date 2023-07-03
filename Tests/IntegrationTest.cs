using System.Net;
using System.Net.Mime;
using System.Text;
using AutoFixture;
using Catalog.Controllers.Dtos;
using Catalog.Entities;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Tests;

public class IntegrationTest : IClassFixture<CustomWebApplicationFactory>
{
    private readonly HttpClient _client;

    private readonly IFixture _fixture = new Fixture();

    public IntegrationTest(CustomWebApplicationFactory factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task Categories_POST()
    {
        // Arrange
        var category = new CreateCategoryRequest { CategoryName = "Toys" };
        var categoryPayload = new StringContent(
            JsonSerializer.Serialize(category),
            Encoding.UTF8,
            MediaTypeNames.Application.Json);
        // Act
        var response = await _client.PostAsync("/categories", categoryPayload);
        // Asset
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }

    [Fact]
    public async Task Products_POST()
    {
        // Arrange
        var product = _fixture
            .Build<Product>()
            .With(x => x.CostPrice, 100)
            .With(x => x.SellingPrice, 200)
            .With(x => x.Count, 100)
            .Create();

        var productPayload = new StringContent(
            JsonSerializer.Serialize(product),
            Encoding.UTF8,
            MediaTypeNames.Application.Json);
        // Act
        var response = await _client.PostAsync("/products", productPayload);
        // Asset
        Assert.Equal(HttpStatusCode.OK, response.StatusCode);
    }
}