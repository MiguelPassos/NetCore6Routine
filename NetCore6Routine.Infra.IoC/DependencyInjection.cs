using Microsoft.Extensions.DependencyInjection;
using NetCore6Routine.Domain;
using NetCore6Routine.Infra.Data;
using NetCore6Routine.Infra.Data.Interfaces;
using NetCore6Routine.Services;
using NetCore6Routine.Services.Interfaces;

namespace NetCore6Routine.Infra.IoC
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Used to inject the Repositories classes dependencies.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository, BaseRepository>();

            return services;
        }

        /// <summary>
        /// Used to inject the Business Services dependecies.
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IBaseService, BaseService>();

            return services;
        }
    }
}