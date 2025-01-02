using AleksaPortfolio.Models.Converter;
using AleksaPortfolio.Models.Factory;
using AleksaPortfolio.Models.Interfaces;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.CreateUmbracoBuilder()
    .AddBackOffice()
    .AddWebsite()
    .AddDeliveryApi()
    .AddComposers()
    .Build();

builder.Services.AddControllers();
builder.Services.AddTransient<IFormspreeFormModuleFactory, FormspreeFormModuleFactory>();
builder.Services.AddTransient<IIntroTextModuleFactory, IntroTextModuleFactory>();
builder.Services.AddTransient<IIntroLinkFactory, IntroLinkFactory>();
builder.Services.AddScoped<IModuleConverter, ModuleConverter>();

WebApplication app = builder.Build();

await app.BootUmbracoAsync();

app.UseHttpsRedirection();

app.UseUmbraco()
    .WithMiddleware(u =>
    {
        u.UseBackOffice();
        u.UseWebsite();
    })
    .WithEndpoints(u =>
    {
        u.UseInstallerEndpoints();
        u.UseBackOfficeEndpoints();
        u.UseWebsiteEndpoints();
    });

await app.RunAsync();
