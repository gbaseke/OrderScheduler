using MediatR;
using OrderSchduler.Application.Features.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSchduler.Application.Features.Schedule.Querries
{
    public class GetScheduleListQuery : IRequest<List<ScheduleVm>>
    {
    }
}
