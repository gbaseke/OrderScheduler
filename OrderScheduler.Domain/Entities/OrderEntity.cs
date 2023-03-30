using Newtonsoft.Json;

namespace OrderScheduler.Domain.Entities
{
    public record OrderEntity
    {
        [JsonProperty("destination")]
        public string ArrivalCity { get; set; } = string.Empty!;
    }
}
