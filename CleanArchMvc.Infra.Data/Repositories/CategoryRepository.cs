using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchMvc.Infra.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _contextCategory;

    public CategoryRepository(ApplicationDbContext contextCategory)
    {
        _contextCategory = contextCategory;
    }

    public async Task<Category> CreateAsync(Category category)
    {
        _contextCategory.Add(category);
        await _contextCategory.SaveChangesAsync();
        return category;
    }

    public async Task<Category> GetByIdAsync(int? id)
    {
        return await _contextCategory.Categories.FindAsync(id);
    }

    public async Task<IEnumerable<Category>> GetCategoriesAsync()
    {
        return await _contextCategory.Categories.ToListAsync();
    }

    public async Task<Category> RemoveAsync(Category category)
    {
        _contextCategory.Remove(category);
        await _contextCategory.SaveChangesAsync();
        return category;
    }

    public async Task<Category> UpdateAsync(Category category)
    {
        _contextCategory.Update(category);
        await _contextCategory.SaveChangesAsync();
        return category;
    }
}
