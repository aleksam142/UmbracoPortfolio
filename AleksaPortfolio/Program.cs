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
builder.Services.AddSingleton<IFormspreeFormModuleFactory, FormspreeFormModuleFactory>();
builder.Services.AddSingleton<ISocialIconFactory, SocialIconFactory>();
builder.Services.AddSingleton<ISocialModuleFactory, SocialModuleFactory>();
builder.Services.AddSingleton<IIntroLinkFactory, IntroLinkFactory>();
builder.Services.AddSingleton<IIntroTextModuleFactory, IntroTextModuleFactory>();
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
