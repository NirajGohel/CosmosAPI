using CosmosAPI.Repository;
using Microsoft.Azure.Cosmos;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//IConfiguration configuration;
builder.Services.AddSingleton(provier =>
{
    var cosmosClient = new CosmosClient(builder.Configuration.GetConnectionString("CosmosDB"));
    return new FormRepository(cosmosClient, "TestDB", "TestContainer");
});

var app = builder.Build();



// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

