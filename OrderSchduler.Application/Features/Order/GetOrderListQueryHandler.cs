using AutoMapper;
using MediatR;
using OrderScheduler.Application.Contracts;

namespace OrderSchduler.Application.Features.Order
{
    public class GetOrderListQueryHandler : IRequestHandler<GetOrderListQuery, List<OrderVm>>
    {
        private readonly IJsonOrderReader _reader;
        private readonly IMapper _mapper;

        public GetOrderListQueryHandler(IMapper mapper, IJsonOrderReader reader)
        {
            _mapper = mapper;
            _reader = reader;
        }

        Task<List<OrderVm>> IRequestHandler<GetOrderListQuery, List<OrderVm>>.Handle(GetOrderListQuery request, CancellationToken cancellationToken)
        {
            var allOrders = _reader.GetOrders();
            return Task.FromResult(_mapper.Map<List<OrderVm>>(allOrders));
        }
    }
}
