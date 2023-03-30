using OrderSchduler.Application.Features.Order;
using OrderSchduler.Application.Features.Schedule.Querries;
using OrderScheduler.Domain.Entities;

namespace OrderSchduler.Application.Features.Itinerary
{
    public class ItineraryVm
    {
        public ScheduleVm Schedule { get; set; } = default!;
        public List<OrderVm> Orders { get; set; } = new List<OrderVm>();
        public int Capacity { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return $"order#: {Orders.Count}, flightNumber: {Schedule.ScheduleId}, departure: {Schedule.DepartureCity}, arrival: {Schedule.ArrivalCity}, day: {Schedule.DayId}";
        }
    }
}