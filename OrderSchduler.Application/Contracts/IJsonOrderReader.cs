using OrderScheduler.Domain.Entities;

namespace OrderScheduler.Application.Contracts
{
    public interface IJsonOrderReader
    {
        List<Order> GetOrders();
    }
}
