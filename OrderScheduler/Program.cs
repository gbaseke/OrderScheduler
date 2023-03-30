using Microsoft.Extensions.Hosting;
using MediatR;
using OrderSchduler.Application.Features.Order;
using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using OrderSchduler.Application.Features.Schedule.Querries;
using OrderSchduler.Application.Features.Itinerary;

namespace OrderScheduler
{
    class Program
	{
		static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder(args)
                .ConfigureServices();

            var mediator = host.Services.GetRequiredService<IMediator>();

            var itineraryQuery = new GetItineraryListQuery();
            var itineraries = mediator.Send(itineraryQuery).Result;

            itineraries.ForEach(d => 
            {
                Console.WriteLine(d.ToString());
                d.Orders.ForEach(o => Console.WriteLine(o.ToString()));
                Console.WriteLine();
            });
        }
    }
}