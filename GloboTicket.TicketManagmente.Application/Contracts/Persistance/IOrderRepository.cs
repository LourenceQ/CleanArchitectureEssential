using GloboTicket.TicketManagmente.Domain.Entities;

namespace GloboTicket.TicketManagment.Application.Contracts.Persistance
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
    }
}
