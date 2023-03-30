using OrderScheduler.Domain.Entities;
using System.Collections.Generic;

namespace OrderScheduler.Application.Contracts
{
    public interface IInMemorySchedules
    {
        List<Schedule> GetAllSchedules();
    }
}
