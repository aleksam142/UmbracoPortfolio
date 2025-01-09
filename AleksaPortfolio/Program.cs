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
builder.Services.AddSingleton<ISimpleHeadingModuleFactory, SimpleHeadingModuleFactory>();
builder.Services.AddSingleton<IPortfolioListingCardFactory, PortfolioListingCardFactory>();
builder.Services.AddSingleton<IPortfolioCardsModuleFactory, PortfolioCardsModuleFactory>();
builder.Services.AddSingleton<ISkillsModuleFactory, SkillsModuleFactory>();
builder.Services.AddSingleton<ISkillGroupFactory, SkillGroupFactory>();
builder.Services.AddSingleton<ILinkTextModuleFactory, LinkTextModuleFactory>();
builder.Services.AddSingleton<IProjectCardFactory, ProjectCardFactory>();
builder.Services.AddSingleton<IProjectsModuleFactory, ProjectsModuleFactory>();
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
