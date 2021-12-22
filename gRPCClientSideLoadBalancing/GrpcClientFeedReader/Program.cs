using Grpc.Core;
using Grpc.Net.Client;
using Grpc.Net.Client.Balancer;
using Grpc.Net.Client.Configuration;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();



var addressCollection = new StaticResolverFactory(address => new[]
    {
                new DnsEndPoint("localhost", 5244),
                new DnsEndPoint("localhost", 5135),
                new DnsEndPoint("localhost", 5155)
    });


builder.Services.AddSingleton<ResolverFactory>(addressCollection);



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

     
return GrpcChannel.ForAddress("static:///feed-host", new GrpcChannelOptions

{
    Credentials = ChannelCredentials.Insecure,
    ServiceConfig = new ServiceConfig { LoadBalancingConfigs = { new PickFirstConfig( ) }, MethodConfigs = { methodConfig } },
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
