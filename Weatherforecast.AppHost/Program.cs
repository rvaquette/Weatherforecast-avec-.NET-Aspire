var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.Weatherforecast_Api>("weatherforecast-api");

builder.AddProject<Projects.Weatherforecast_Web>("weatherforecast-web")
    .WithReference(api);

builder.Build().Run();
