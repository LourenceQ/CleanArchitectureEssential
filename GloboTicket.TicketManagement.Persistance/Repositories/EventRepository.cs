using GloboTicket.TicketManagment.Application.Contracts.Persistance;
using GloboTicket.TicketManagmente.Domain.Entities;

namespace GloboTicket.TicketManagement.Persistance.Repositories;

public class EventRepository : BaseRepository<Event>, IEventRepository
{
    public EventRepository(GloboTicketDbContext dbContext) : base(dbContext)
    {
    }

    public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
    {
        var matches = _dbContext.Events.Any(e => e.Name.Equals(name) && e.Date.Date.Equals(eventDate.Date));
        return Task.FromResult(matches);
    }
}
