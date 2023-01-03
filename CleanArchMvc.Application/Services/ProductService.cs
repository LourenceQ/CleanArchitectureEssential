using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;

namespace CleanArchMvc.Application.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;

    public ProductService(IMapper mapper
        , IProductRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public async Task Add(ProductDTO productDTO)
    {
        var prod = _mapper.Map<Product>(productDTO);

        await _repository.CreateAsync(prod);
    }

    public async Task<ProductDTO> GetById(int? id)
    {
        var product = await _repository.GetByIdAsync(id);

        return _mapper.Map<ProductDTO>(product);
    }

    public async Task<ProductDTO> GetProductCategory(int? id)
    {
        var productCategory = await _repository.GetProductCategoryAsync(id);

        return _mapper.Map<ProductDTO>(productCategory)
    }

    public async Task<IEnumerable<ProductDTO>> GetProducts()
    {
        var product = await _repository.GetProductsAsync();

        return _mapper.Map<IEnumerable<ProductDTO>>(product);
    }

    public async Task Remove(int? id)
    {
        var prod = _repository.GetByIdAsync(id).Result;   
        await _repository.RemoveAsync(prod);
    }

    public async Task Update(ProductDTO productDTO)
    {
        var prod = _mapper.Map<Product>(productDTO);

        await _repository.UpdateAsync(prod);
    }
}
