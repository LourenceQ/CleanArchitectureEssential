using CleanArchMvc.Domain.Entities;

namespace CleanArchMvc.Domain.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<Product>> GetProductsAsync();
    Task<Product> GetByIdAsync(int? id); 
    Task<Category> CreateAsync(Product category);
    Task<Product> UpdateAsync(Product category);
    Task<Product> RemoveAsync(Product category);
}
