using GloboTicket.TicketManagmente.Domain.Entities;

namespace GloboTicket.TicketManagment.Application.Contracts.Persistance;

public interface ICategoryRepository : IAsyncRepository<Category>
{
    Task<List<Category>> GetCategoriesListWithEventsQuery(bool includePassedEvents);
}
