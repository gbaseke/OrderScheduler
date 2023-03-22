namespace OrderScheduler
{
    public class Schedule
	{
		public int ScheduleId { get; set; }
		public string DepartureCity { get; set; }
		public string ArrivalCity { get; set; }
		public int DayId { get; set; }

		public override string ToString()
		{
			return $"Flight: {ScheduleId}, departure: {DepartureCity}, arrival: {ArrivalCity}, day: {DayId}";
		}
	}
}