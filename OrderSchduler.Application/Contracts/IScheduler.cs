using OrderScheduler.Domain.Entities;

namespace OrderSchduler.Application.Contracts
{
    public interface IScheduler
    {
        void Schedule(List<Schedule> schedules, List<Order> orders);
    }
}