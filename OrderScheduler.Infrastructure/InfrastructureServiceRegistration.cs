using Microsoft.Extensions.DependencyInjection;
using OrderScheduler.Application.Contracts;
using OrderScheduler.Infrastructure.InMemory;
using OrderScheduler.Infrastructure.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderScheduler.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IJsonOrderReader, JsonOrderReader>();
            services.AddTransient<IInMemorySchedules, InMemorySchedules>();

            return services;
        }
    }
}
