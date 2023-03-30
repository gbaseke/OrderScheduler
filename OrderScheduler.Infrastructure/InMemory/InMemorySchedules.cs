using OrderScheduler.Application.Contracts;
using OrderScheduler.Domain.Entities;

namespace OrderScheduler.Infrastructure.InMemory
{
    public class InMemorySchedules : IInMemorySchedules
    {
        public List<Schedule> GetAllSchedules()
        {
            var schedules = new List<Schedule>() {
                new Schedule() { ArrivalCity = "YYZ", DayId = 1, DepartureCity = "YUL", ScheduleId = 1},
                new Schedule() { ArrivalCity = "YYC", DayId = 1, DepartureCity = "YUL", ScheduleId = 2},
                new Schedule() { ArrivalCity = "YVR", DayId = 1, DepartureCity = "YUL", ScheduleId = 3},
                new Schedule() { ArrivalCity = "YYZ", DayId = 2, DepartureCity = "YUL", ScheduleId = 4},
                new Schedule() { ArrivalCity = "YYC", DayId = 2, DepartureCity = "YUL", ScheduleId = 4},
                new Schedule() { ArrivalCity = "YVR", DayId = 2, DepartureCity = "YUL", ScheduleId = 6}};

            return schedules;
        }
    }
}
