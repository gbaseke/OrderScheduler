using AutoMapper;
using OrderSchduler.Application.Features.Itinerary;
using OrderSchduler.Application.Features.Order;
using OrderSchduler.Application.Features.Schedule.Querries;
using OrderSchduler.Application.Model;
using OrderScheduler.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSchduler.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderVm>();
            CreateMap<Schedule, ScheduleVm>();
            CreateMap<Itinerary, ItineraryVm>();
        }
    }
}