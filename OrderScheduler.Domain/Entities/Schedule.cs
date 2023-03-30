using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderScheduler.Domain.Entities
{
    public class Schedule
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
