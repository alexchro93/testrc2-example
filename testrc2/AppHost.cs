using Microsoft.Build.Evaluation;

var builder = DistributedApplication.CreateBuilder(args);

var sql = builder.AddSqlServer(name: "sql")
    .WithLifetime(lifetime: ContainerLifetime.Persistent)
    .AddDatabase(name: "appdb");

builder.AddSqlProject<Projects.testrc2_sql>(name: "sql-project")
    .WithReference(target: sql);

builder.Build().Run();
