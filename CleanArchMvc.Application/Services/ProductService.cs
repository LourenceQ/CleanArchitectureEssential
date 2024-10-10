using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Application.Products.Queries;
using MediatR;

namespace CleanArchMvc.Application.Services;

public class ProductService : IProductService
{
    //private readonly IProductRepository _repository;
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public ProductService(IMapper mapper
        , IMediator mediator
        //, IProductRepository repository
        )
    {
        _mapper = mapper;
        _mediator = mediator;
        //_repository = repository;
    }

    public async Task Add(ProductDTO productDTO)
    {
        var p = _mapper.Map<ProductCreateCommand>(productDTO);

        await _mediator.Send(p);
    }

    public async Task<ProductDTO> GetById(int? id)
    {
        var p = new GetProductByIdQuery(id.Value);

        if (p == null)
            throw new Exception($"Entity coud not be loaded.");

        var result = await _mediator.Send(p);

        return _mapper.Map<ProductDTO>(result);

    }

    /*public async Task<ProductDTO> GetProductCategory(int? id)
    {
        var p = new GetProductByIdQuery(id.Value);

        if (p == null)
            throw new Exception($"Entity coud not be loaded.");

        var result = await _mediator.Send(p);

        return _mapper.Map<ProductDTO>(result);
    }*/

    public async Task<IEnumerable<ProductDTO>> GetProducts()
    {
        /*var product = await _repository.GetProductsAsync();

        return _mapper.Map<IEnumerable<ProductDTO>>(product);*/

        GetProductsQuery p = new();
        if (p == null) throw new Exception($"Entity could not be loaded.");

        var result = await _mediator.Send(p);

        return _mapper.Map<IEnumerable<ProductDTO>>(result);

    }

    public async Task Remove(int? id)
    {
        var p = new ProductRemoveCommand(id.Value);
        if (p == null)
            throw new Exception($"Entity coud not be loaded.");

        await _mediator.Send(p);
    }

    public async Task Update(ProductDTO productDTO)
    {
        var p = _mapper.Map<ProductUpdateCommand>(productDTO);

        await _mediator.Send(p);
    }
}
