using System;
using System.Collections.Generic;

namespace OrderScheduler
{
    public class Itinerary
	{
		public Schedule Schedule { get; set; }
		public Dictionary<string, Order> Orders { get; set; }
		public int Capacity { get; set; }
		public int Count { get; set; }

		public bool IsFull()
		{
			return Count == Capacity;
		}

		public bool Add(string orderName, Order order)
		{
			if (!IsFull())
			{
				Orders.Add(orderName, order);
				Count++;
				Console.WriteLine($"order: {orderName}, flightNumber: {Schedule.ScheduleId}, departure: {Schedule.DepartureCity}, arrival: {Schedule.ArrivalCity}, day: {Schedule.DayId}");
				return true;
			}

			Console.WriteLine($"order: {orderName}, flightNumber: not scheduled");
			return false;
		}
	}
}