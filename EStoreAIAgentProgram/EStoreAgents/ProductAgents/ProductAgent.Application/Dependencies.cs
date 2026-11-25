using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ProductAgent.Application
{
    public static class Dependencies
    {
        public static IServiceCollection
        RegisterServices(this IServiceCollection services)
        {

            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });


            return services;
        }
    }
}
