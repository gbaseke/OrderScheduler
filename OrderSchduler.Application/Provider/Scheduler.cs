using System.Collections.Generic;
using System.Linq;
using OrderSchduler.Application.Contracts;
using OrderSchduler.Application.Model;
using OrderScheduler.Domain.Entities;

namespace OrderSchduler.Application.Provider
{
    public class Scheduler : IScheduler
    {
        public Scheduler()
        {
        }

        public List<Itinerary> Schedule(List<Schedule> schedules, List<Order> orders)
        {
            var iteneraries = CreateIteneraries(schedules);
            foreach (var order in orders)
            {
                var itenerary = iteneraries
                    .FirstOrDefault(i => i.Schedule.ArrivalCity == order.ArrivalCity &&
                        !i.IsFull());

                if (itenerary != null)
                {
                    itenerary.Add(order);
                }
            }

            return iteneraries;
        }

        private List<Itinerary> CreateIteneraries(List<Schedule> schedules)
        {
            var iteneraries = new List<Itinerary>();
            foreach (var schedule in schedules)
            {
                iteneraries.Add(new Itinerary() { Capacity = 20, Count = 0, Schedule = schedule });
            }

            return iteneraries;
        }
    }
}