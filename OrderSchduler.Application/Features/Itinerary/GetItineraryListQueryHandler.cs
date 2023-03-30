using AutoMapper;
using MediatR;
using OrderSchduler.Application.Contracts;
using OrderSchduler.Application.Features.Order;
using OrderSchduler.Application.Features.Schedule.Querries;
using OrderScheduler.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OrderSchduler.Application.Features.Itinerary
{
    internal class GetItineraryListQueryHandler : IRequestHandler<GetItineraryListQuery, List<ItineraryVm>>
    {
        private readonly IMapper _mapper;
        private readonly IScheduler _scheduler;
        private readonly IInMemorySchedules _scheduleReader;
        private readonly IJsonOrderReader _orderReader;

        public GetItineraryListQueryHandler(IMapper mapper, IScheduler scheduler, IInMemorySchedules scheduleReader, IJsonOrderReader orderReader)
        {
            _mapper = mapper;
            _scheduler = scheduler;
            _scheduleReader = scheduleReader;
            _orderReader = orderReader;
        }

        public Task<List<ItineraryVm>> Handle(GetItineraryListQuery request, CancellationToken cancellationToken)
        {
            var allSchedules = _scheduleReader.GetAllSchedules();
            var allOrders = _orderReader.GetOrders();

            var itineraries = _scheduler.Schedule(allSchedules, allOrders);

            return Task.FromResult(_mapper.Map<List<ItineraryVm>>(itineraries));
        }
    }
}
