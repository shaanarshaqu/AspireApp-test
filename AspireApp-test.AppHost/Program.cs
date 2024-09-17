var builder = DistributedApplication.CreateBuilder(args);

//var apiService = builder.AddProject<Projects.AspireApp_test_ApiService>("apiservice");

//builder.AddProject<Projects.AspireApp_test_Web>("webfrontend")
//    .WithExternalHttpEndpoints()
//    .WithReference(apiService);

builder.Build().Run();
