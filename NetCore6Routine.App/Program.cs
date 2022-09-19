using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NetCore6Routine.App;
using NetCore6Routine.Domain;
using NetCore6Routine.Infra.IoC;
using NetCore6Routine.Services.Interfaces;

var builder = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json", optional: false);

IConfiguration config = builder.Build();

var services = new ServiceCollection();

services.AddOptions()
    .Configure<AppSettings>(options => config.GetSection("AppSettings").Bind(options))
    .AddInfrastructure()
    .AddServices();
    //.AddTransient<IBaseService, BeseService>();

services.BuildServiceProvider()
    .GetService<IBaseService>()!.Execute();