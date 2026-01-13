using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// --- BAZA DANYCH (Lista w pamięci) ---
var products = new List<Product>
{
    new Product(1, "Laptop Gamingowy", 4500.00m),
    new Product(2, "Myszka Bezprzewodowa", 120.50m),
    new Product(3, "Klawiatura Mechaniczna", 350.00m),
    new Product(4, "Monitor 4K", 1200.00m)
};

// --- ENDPOINT 1: Strona Startowa ---
app.MapGet("/", () => "Witamy w API Sklepu! Przejdz do /products aby zobaczyc towar.");

// --- ENDPOINT 2: Lista Produktów ---
app.MapGet("/products", () => Results.Ok(products));

// --- ENDPOINT 3: Pojedynczy Produkt ---
app.MapGet("/products/{id}", (int id) =>
{
    var product = products.FirstOrDefault(p => p.Id == id);
    if (product == null) return Results.NotFound("Produkt nie istnieje");
    return Results.Ok(product);
});

app.Run();

// --- MODEL DANYCH ---
public record Product(int Id, string Name, decimal Price);

// --- !!! TO JEST KLUCZOWE DLA TESTÓW !!! ---
// Bez tej linijki testy widzą Program jako "internal" i wyrzucają błąd.
public partial class Program { }