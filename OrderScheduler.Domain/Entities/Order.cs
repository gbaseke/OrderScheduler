using Newtonsoft.Json;

namespace OrderScheduler.Domain.Entities
{
    public record Order
    {
        public Order(string name, string arrivalCity)
        {
            Name = name;
            ArrivalCity = arrivalCity;
        }

        public string Name { get; init; }
        public string ArrivalCity { get; init; }
    }
}