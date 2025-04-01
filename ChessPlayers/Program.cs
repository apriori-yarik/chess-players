// See https://aka.ms/new-console-template for more information
using ChessPlayers;
using LichessAPIConsumption;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;

var builder = Host.CreateApplicationBuilder(args);

IConfigurationRoot config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.Development.json")
    .Build();

builder.Configuration.AddConfiguration(config);

builder.Services
    .AddRefitClient<ILichessAPI>()
    .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://lichess.org/api"));

builder.Services.AddTransient<App>();

using var host = builder.Build();

var connString = config.GetConnectionString("MongoDB");
Console.WriteLine("Conn string: " + connString);

var app = host.Services.GetRequiredService<App>();

await app.RunAsync();