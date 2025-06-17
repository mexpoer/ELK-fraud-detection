using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

// Serve static files from wwwroot
app.UseDefaultFiles();
app.UseStaticFiles();

// Existing POST /transaction endpoint
app.MapPost("/transaction", async (HttpContext http) =>
{
    using var reader = new StreamReader(http.Request.Body);
    var body = await reader.ReadToEndAsync();
    Directory.CreateDirectory("../logs/apilogs");
    await File.AppendAllTextAsync("../logs/apilogs/app.log", $"{body}\n");
    return Results.Ok(new { status = "logged" });
});

app.Run("http://0.0.0.0:5000");