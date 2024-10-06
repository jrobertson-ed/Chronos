var builder = DistributedApplication.CreateBuilder(args);

var db = builder.AddPostgres("chronos-db")
    .WithDataVolume()
    .AddDatabase("Chronos");

var api = builder.AddProject<Projects.Chronos_Web>("chronos-api")
    .WithExternalHttpEndpoints()
    .WithReference(db);

builder.AddProject<Projects.Chronos_Bus>("chronos-bus")
    .WithReference(db);

builder.AddNpmApp("chronos-spa", "../../client")
    .WithReference(api)
    .WithHttpEndpoint(env: "PORT")
    .WithExternalHttpEndpoints()
    .PublishAsDockerFile();

builder.Build().Run();