using Newtonsoft.Json;

namespace OrderScheduler
{
    public class Order
	{
		[JsonProperty("destination")]
		public string ArrivalCity { get; set; }
	}
}