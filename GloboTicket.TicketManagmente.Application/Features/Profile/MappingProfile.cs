using GloboTicket.TicketManagment.Application.Features.Events;
using GloboTicket.TicketManagmente.Domain.Entities;

namespace GloboTicket.TicketManagment.Application.Features.Profile
{
    public class MappingProfile : AutoMapper.Profile
    {
        protected MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
        }
    }
}
