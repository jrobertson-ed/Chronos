var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Chronos_Web>("chronos-api");
builder.AddProject<Projects.Chronos_Bus>("chronos-bus");

builder.Build().Run();