var builder = DistributedApplication.CreateBuilder(args);

var redis = builder.AddRedis("redis").WithRedisInsight();

var api = builder.AddProject<Projects.Weatherforecast_Api>("weatherforecast-api")
    .WithReference(redis);

builder.AddProject<Projects.Weatherforecast_Web>("weatherforecast-web")
    .WithReference(api);

builder.Build().Run();
