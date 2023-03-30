using Microsoft.Extensions.Hosting;
using OrderSchduler.Application;
using OrderScheduler.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderScheduler
{
    public static class StartupExtensions
    {
        public static IHost ConfigureServices(this IHostBuilder builder) 
        {
            builder.ConfigureServices(services =>
                services
                    .AddApplicationServices()
                    .AddInfrastructureServices()
            );

            return builder.Build();
        }
    }
}
