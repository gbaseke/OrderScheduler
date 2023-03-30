using OrderSchduler.Application.Model;
using OrderScheduler.Domain.Entities;

namespace OrderSchduler.Application.Contracts
{
    public interface IScheduler
    {
        List<Itinerary> Schedule(List<Schedule> schedules, List<Order> orders);
    }
}