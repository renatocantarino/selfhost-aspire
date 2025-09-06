var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.Car_Api>("api")
        .WithUrlForEndpoint("https", url => url.DisplayText = "Api (HTTPS)");

api.WithReference(api);

builder.Build().Run();