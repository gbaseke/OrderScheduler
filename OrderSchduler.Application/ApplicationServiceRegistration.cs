using MediatR;
using Microsoft.Extensions.DependencyInjection;
using OrderSchduler.Application.Contracts;
using OrderSchduler.Application.Processes;
using System.Reflection;

namespace OrderSchduler.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ApplicationServiceRegistration).GetTypeInfo().Assembly));
            services.AddTransient<IScheduler, Scheduler>();

            return services;
        }
    }
}
