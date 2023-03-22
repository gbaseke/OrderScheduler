using System.Collections.Generic;
using System.Linq;

namespace OrderScheduler
{
    public class Scheduler
	{
		private readonly List<Schedule> _schedules;

		private readonly Dictionary<string, Order> _orders;

		public Scheduler(List<Schedule> schedules, Dictionary<string, Order> orders)
		{
			_schedules = schedules;
			_orders = orders;
		}

		public void Schedule()
		{
			var iteneraries = CreateIteneraries();
			foreach (var order in _orders)
			{
				var itenerary = iteneraries
					.FirstOrDefault(i => i.Schedule.ArrivalCity == order.Value.ArrivalCity &&
						!i.IsFull());

				if (itenerary != null)
				{
					itenerary.Add(order.Key, order.Value);
				}
			}
		}

		private List<Itinerary> CreateIteneraries()
		{
			var iteneraries = new List<Itinerary>();
			foreach (var schedule in _schedules)
			{
				iteneraries.Add(new Itinerary() { Capacity = 20, Count = 0, Orders = new Dictionary<string, Order>(), Schedule = schedule });
			}

			return iteneraries;
		}
	}
}