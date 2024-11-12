using GloboTicket.TicketManagment.Application.Contracts.Persistance;

namespace GloboTicket.TicketManagement.Persistance.Repositories;

public class BaseRepository<T> : IAsyncRepository<T> where T : class
{
    protected readonly GloboTicketDbContext _dbContext;

    public BaseRepository(GloboTicketDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Task<T> AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> DeleteAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyList<T>> ListAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }
}