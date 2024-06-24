var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Chronos_Web>("chronos-api");

builder.Build().Run();