var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.NoDoubtsAPI>("backend");
builder.AddProject<Projects.NoDoubtsWeb>("frontend")
    .WaitFor(api);

builder.Build().Run();
