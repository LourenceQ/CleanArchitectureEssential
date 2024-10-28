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
        }
    }
}
