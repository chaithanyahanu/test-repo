var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "welcome to Azure Kubernetes Service!");

app.Run();
