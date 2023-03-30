using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OrderSchduler.Application.Features.Itinerary;
using System;

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