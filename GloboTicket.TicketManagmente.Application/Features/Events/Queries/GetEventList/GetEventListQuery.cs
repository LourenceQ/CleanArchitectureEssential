using MediatR;

namespace GloboTicket.TicketManagment.Application.Features.Events.Queries.GetEventList
{
    public class GetEventListQuery : IRequest<List<EventListVm>>
    {
    }
}
