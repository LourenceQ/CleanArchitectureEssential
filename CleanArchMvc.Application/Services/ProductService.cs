using AutoMapper;
using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;

namespace CleanArchMvc.Application.Services;

public class ProductService : IProductRepository
{
    private readonly IProductRepository _repository;
    private readonly IMapper _mapper;

    public ProductService(IMapper mapper
        , IProductRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public Task<Product> CreateAsync(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetByIdAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetProductCategoryAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetProductsAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Product> RemoveAsync(Product product)
    {
        throw new NotImplementedException();
    }

    public Task<Product> UpdateAsync(Product product)
    {
        throw new NotImplementedException();
    }
}
