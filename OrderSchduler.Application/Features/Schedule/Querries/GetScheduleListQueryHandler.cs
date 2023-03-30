using AutoMapper;
using MediatR;
using OrderSchduler.Application.Features.Order;
using OrderScheduler.Application.Contracts;

namespace OrderSchduler.Application.Features.Schedule.Querries
{
    public class GetScheduleListQueryHandler : IRequestHandler<GetScheduleListQuery, List<ScheduleVm>>
    {
        private readonly IInMemorySchedules _reader;
        private readonly IMapper _mapper;

        public GetScheduleListQueryHandler(IMapper mapper, IInMemorySchedules reader)
        {
            _mapper = mapper;
            _reader = reader;
        }

        Task<List<ScheduleVm>> IRequestHandler<GetScheduleListQuery, List<ScheduleVm>>.Handle(GetScheduleListQuery request, CancellationToken cancellationToken)
        {
            var allSchedules = _reader.GetAllSchedules();
            return Task.FromResult(_mapper.Map<List<ScheduleVm>>(allSchedules));
        }
    }
}
