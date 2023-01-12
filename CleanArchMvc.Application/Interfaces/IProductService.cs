using CleanArchMvc.Application.DTOs;

namespace CleanArchMvc.Application.Interfaces;

public interface IProductService
{
    Task<IEnumerable<ProductDTO>> GetProducts();
    /*Task<ProductDTO> GetById(int? id);
    Task Add(ProductDTO productDTO);
    Task<ProductDTO> GetProductCategory(int? id);
    Task Update(ProductDTO productDTO);
    Task Remove(int? id);*/
}
