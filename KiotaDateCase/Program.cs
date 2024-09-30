using Example.Endpoint.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/api/example-endpoint", () =>
{
    return Results.Ok(value: "You can now start with the post request!");
})
    .WithName("ExampleEndpointGet");

app.MapPost("/api/example-endpoint", ([FromBody] ExampleData exampleData) =>
{
    return Results.Ok();
})
    .WithName("ExampleEndpointPost");

app.Run();
