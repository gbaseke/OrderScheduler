using MediatR;

namespace OrderSchduler.Application.Features.Order
{
    public class GetOrderListQuery : IRequest<List<OrderVm>>
    {

    }
}
