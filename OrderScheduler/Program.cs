using OrderScheduler.Application.Contracts;
using OrderScheduler.Infrastructure.Json;
using OrderScheduler.Infrastructure.InMemory;
using OrderSchduler.Application.Processes;
using System;
using OrderSchduler.Application.Contracts;

namespace OrderScheduler
{
    class Program
	{
		static void Main(string[] args)
        {
            // root container
            IJsonOrderReader orderReader = new JsonOrderReader();
            IInMemorySchedules scheduleQuery = new InMemorySchedules();
            IScheduler scheduler = new Scheduler();

            // Get Schedules
            var schedules = scheduleQuery.GetAllSchedules();

            // Print schedules
            schedules.ForEach(schedule => Console.WriteLine(schedule.ToString()));

            // Get orders
            var orders = orderReader.GetOrders();

            // Schedule orders
            scheduler.Schedule(schedules, orders);
        }
    }
}