using Newtonsoft.Json;

namespace OrderScheduler.Infrastructure.Json
{
    public record OrderEntity
    {
        [JsonProperty("destination")]
        public string ArrivalCity { get; set; } = string.Empty!;
    }
}
