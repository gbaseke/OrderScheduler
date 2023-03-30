using OrderScheduler.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSchduler.Application.Features.Order
{
    public class GetOrderListQuery
    {
        private readonly IJsonOrderReader orderReader;

        public GetOrderListQuery(IJsonOrderReader orderReader)
        {
            this.orderReader = orderReader;
        }

        // public List<Order> GetOrders() => orderReader.GetOrders();
    }
}
