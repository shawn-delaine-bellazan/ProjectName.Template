var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.ProjectName_Api>("projectname-api");

builder.Build().Run();
