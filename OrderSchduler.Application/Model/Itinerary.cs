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
                
                return true;
            }
            
            return false;
        }
    }
}
