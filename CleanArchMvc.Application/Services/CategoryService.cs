using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;

namespace CleanArchMvc.Application.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task Add(CategoryDTO categoryDTO)
    {
        var cat = _mapper.Map<Category>(categoryDTO);

        await _categoryRepository.CreateAsync(cat);
    }

    public async Task<CategoryDTO> GetById(int? id)
    {
        var cat = await _categoryRepository.GetByIdAsync(id);

        return _mapper.Map<CategoryDTO>(cat);
    }

    public async Task<IEnumerable<CategoryDTO>> GetCategories()
    {
        var cat = await _categoryRepository.GetCategoriesAsync();

        return _mapper.Map<IEnumerable<CategoryDTO>>(cat);
    }

    public async Task Remove(int? id)
    {
        var cat = _categoryRepository.GetByIdAsync(id).Result;
        await _categoryRepository.RemoveAsync(cat);
    }

    public async Task Update(CategoryDTO categoryDTO)
    {
        var cat = _mapper.Map<Category>(categoryDTO);

        await _categoryRepository.UpdateAsync(cat);
    }
}
