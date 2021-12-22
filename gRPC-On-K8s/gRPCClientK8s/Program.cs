using Grpc.Core;
using Grpc.Net.Client;
using Grpc.Net.Client.Balancer;
using Grpc.Net.Client.Configuration;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddSingleton<ResolverFactory>(new DnsResolverFactory(refreshInterval: TimeSpan.FromSeconds(25)));


builder.Services.AddSingleton(channelService => {


     var methodConfig = new MethodConfig
     {
         Names = { MethodName.Default },
         RetryPolicy = new RetryPolicy
         {
             MaxAttempts = 5,
             InitialBackoff = TimeSpan.FromSeconds(1),
             MaxBackoff = TimeSpan.FromSeconds(5),
             BackoffMultiplier = 1.5,
             RetryableStatusCodes = { Grpc.Core.StatusCode.Unavailable }
         }
     };

     var configuration = builder.Configuration;


   return GrpcChannel.ForAddress(configuration.GetValue<string>("k8s-svc-url"), new GrpcChannelOptions

    {
        Credentials = ChannelCredentials.Insecure,
        ServiceConfig = new ServiceConfig { LoadBalancingConfigs = { new RoundRobinConfig() }, MethodConfigs = { methodConfig } },
        ServiceProvider = channelService

    });

      
});


var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
