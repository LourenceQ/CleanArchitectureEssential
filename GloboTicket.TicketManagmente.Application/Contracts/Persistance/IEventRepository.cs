using GloboTicket.TicketManagmente.Domain.Entities;

namespace GloboTicket.TicketManagment.Application.Contracts.Persistance;

public interface IEventRepository : IAsyncRepository<Event>
{
}
