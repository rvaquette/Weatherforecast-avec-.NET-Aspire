var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Weatherforecast_Api>("weatherforecast-api");

builder.AddProject<Projects.Weatherforecast_Web>("weatherforecast-web");

builder.Build().Run();
