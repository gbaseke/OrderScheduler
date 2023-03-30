namespace OrderSchduler.Application.Features.Schedule.Querries
{
    public class ScheduleVm
    {
        public int ScheduleId { get; set; }
        public string DepartureCity { get; set; } = string.Empty;
        public string ArrivalCity { get; set; } = string.Empty;
        public int DayId { get; set; }

        public override string ToString()
        {
            return $"Flight: {ScheduleId}, departure: {DepartureCity}, arrival: {ArrivalCity}, day: {DayId}";
        }
    }
}