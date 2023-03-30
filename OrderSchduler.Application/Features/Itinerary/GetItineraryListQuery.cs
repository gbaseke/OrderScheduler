using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSchduler.Application.Features.Itinerary
{
    public class GetItineraryListQuery : IRequest<List<ItineraryVm>>
    {
    }
}
