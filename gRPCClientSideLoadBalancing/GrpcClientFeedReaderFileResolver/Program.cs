
using Grpc.Core;
using Grpc.Net.Client;
using Grpc.Net.Client.Balancer;
using Grpc.Net.Client.Configuration;
using GrpcClientFeedReaderFileResolver;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();



 

//Register custom resolver
builder.Services.AddSingleton<ResolverFactory, customFileResolver>();
 

builder.Services.AddSingleton(channelService => {


    return GrpcChannel.ForAddress("file:///c:/urls/addresses.xml", new GrpcChannelOptions

    {
        Credentials = ChannelCredentials.Insecure,
        ServiceConfig = new ServiceConfig { LoadBalancingConfigs = { new RoundRobinConfig() } },
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
