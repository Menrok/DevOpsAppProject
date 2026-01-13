using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Threading.Tasks;
using Xunit;

// Namespace musi być taki sam jak w folderze
namespace SklepAPI.Tests;

public class StoreTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client;

    public StoreTests(WebApplicationFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    // TEST 1: Sprawdza czy lista produktów działa
    [Fact]
    public async Task Get_Products_ReturnsSuccessAndLaptop()
    {
        // Act
        var response = await _client.GetAsync("/products");

        // Assert
        response.EnsureSuccessStatusCode(); // Kod 200 OK
        var content = await response.Content.ReadAsStringAsync();

        Assert.Contains("Laptop Gamingowy", content);
    }

    // TEST 2: Sprawdza czy pojedynczy produkt (nr 3) to klawiatura
    [Fact]
    public async Task Get_SingleProduct_ReturnsKeyboard()
    {
        // Act
        var response = await _client.GetAsync("/products/3");

        // Assert
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();

        Assert.Contains("Klawiatura Mechaniczna", content);
    }
}