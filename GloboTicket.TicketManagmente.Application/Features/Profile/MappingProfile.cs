using GloboTicket.TicketManagment.Application.Features.Categories.Queries.GetCategoriesList;
using GloboTicket.TicketManagment.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using GloboTicket.TicketManagment.Application.Features.Events.Commands.CreateEvent;
using GloboTicket.TicketManagment.Application.Features.Events.Queries.GetEventDetail;
using GloboTicket.TicketManagment.Application.Features.Events.Queries.GetEventList;
using GloboTicket.TicketManagmente.Domain.Entities;

namespace GloboTicket.TicketManagment.Application.Features.Profile
{
    public class MappingProfile : AutoMapper.Profile
    {
        protected MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();

            CreateMap<Category, CategoryListVm>().ReverseMap();
            CreateMap<Category, CategoryEventListVm>().ReverseMap();

            CreateMap<Event, CreateEventCommand>().ReverseMap();
        }
    }
}
