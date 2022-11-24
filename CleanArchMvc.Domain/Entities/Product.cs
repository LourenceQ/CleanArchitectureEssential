using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities;

public sealed class Product
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string Image { get; private set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    private void ValidateDomain(string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name)
            , "Nome inválido. Nome é obrigatório.");
    }
}
