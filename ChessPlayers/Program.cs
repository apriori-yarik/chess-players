// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;

IConfigurationRoot config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.Development.json")
    .Build();

var connString = config.GetConnectionString("MongoDB");

Console.WriteLine(connString);
