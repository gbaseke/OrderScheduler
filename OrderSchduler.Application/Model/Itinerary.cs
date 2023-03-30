using OrderScheduler.Domain.Entities;

namespace OrderSchduler.Application.Model
{
    public class Itinerary
    {
        public Schedule Schedule { get; set; } = default!;
        public List<Order> Orders { get; set; } = new List<Order>();
        public int Capacity { get; set; }
        public int Count { get; set; }

        public bool IsFull()
        {
            return Count == Capacity;
        }

        public bool Add(Order order)
        {
            if (!IsFull())
            {
                Orders.Add(order);
                Count++;
                Console.WriteLine($"order: {order.Name}, flightNumber: {Schedule.ScheduleId}, departure: {Schedule.DepartureCity}, arrival: {Schedule.ArrivalCity}, day: {Schedule.DayId}");
                return true;
            }

            Console.WriteLine($"order: {order.Name}, flightNumber: not scheduled");
            return false;
        }
    }
}
