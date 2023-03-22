using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace OrderScheduler
{
    class Program
	{
		static void Main(string[] args)
		{
			var schedules = new List<Schedule>() {
				new Schedule() { ArrivalCity = "YYZ", DayId = 1, DepartureCity = "YUL", ScheduleId = 1},
				new Schedule() { ArrivalCity = "YYC", DayId = 1, DepartureCity = "YUL", ScheduleId = 2},
				new Schedule() { ArrivalCity = "YVR", DayId = 1, DepartureCity = "YUL", ScheduleId = 3},
				new Schedule() { ArrivalCity = "YYZ", DayId = 2, DepartureCity = "YUL", ScheduleId = 4},
				new Schedule() { ArrivalCity = "YYC", DayId = 2, DepartureCity = "YUL", ScheduleId = 4},
				new Schedule() { ArrivalCity = "YVR", DayId = 2, DepartureCity = "YUL", ScheduleId = 6}};

			foreach (var schedule in schedules)
			{
				Console.WriteLine(schedule.ToString());
			}

			using (var streamReader = new StreamReader(@"C:\Dev\github\OrderScheduler\coding-assigment-orders.json"))
			{
				string json = streamReader.ReadToEnd();
				Dictionary<string, Order> orders = JsonConvert.DeserializeObject<Dictionary<string, Order>>(json);

				new Scheduler(schedules, orders).Schedule();
			}
		}
	}
}