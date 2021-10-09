using AutoMapper;
using GloboTicket.TicketManagment.Application.Features.Categories.Queries;
using GloboTicket.TicketManagment.Application.Features.Events;
using GloboTicket.TicketManagment.Application.Features.Events.Commands;
using GloboTicket.TicketManagment.Domain;

namespace GloboTicket.TicketManagment.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Events
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>();
            CreateMap<Event, UpdateEventCommand>();

            //Categories
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryEventListVm>();
        }
    }
}
