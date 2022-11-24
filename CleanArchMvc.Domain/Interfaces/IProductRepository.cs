using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Category>> GetCategories();
    Task<Category> GetById(int? id); 
    Task<Category> Create(Category category);
    Task<Category> Update(Category category);
    Task<Category> Remove(Category category);
}
