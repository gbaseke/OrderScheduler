using Newtonsoft.Json;
using OrderScheduler.Application.Contracts;
using OrderScheduler.Domain.Entities;

namespace OrderScheduler.Infrastructure.Json
{
    public class JsonOrderReader : IJsonOrderReader
    {
        public List<Order> GetOrders()
        {
            var orderEntities = new Dictionary<string, OrderEntity>();

            using (var streamReader = new StreamReader(@"C:\Users\gbase\source\repos\OrderScheduler\OrderScheduler\Data\coding-assigment-orders.json"))
            {
                string json = streamReader.ReadToEnd();
                orderEntities = JsonConvert.DeserializeObject<Dictionary<string, OrderEntity>>(json) ?? new Dictionary<string, OrderEntity>();
            }

            var orders = new List<Order>();

            foreach (var item in orderEntities)
            {
                orders.Add(new Order(item.Key, item.Value.ArrivalCity));
            }

            return orders;
        }
    }
}
