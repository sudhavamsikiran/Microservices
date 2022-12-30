using Cqrs.Hosts;
using Discount.grpc.Extensions;
using Discount.grpc.Repositories;
using Discount.Grpc.Services;
//using Discount.grpc.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IDiscountRepository, DiscountRepository>();

// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.AddGrpc();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseEndpoints(endpoints =>
{
    endpoints.MapGrpcService<DiscountService>();

    endpoints.MapGet("/", async context =>
    {
        await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
    });
});
app.MigrateDatabase<Program>();
app.Run();
