using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities;

public sealed class Product : BaseEntity
{
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string Image { get; private set; }
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

    public Product(string name, string description, decimal price, int stock, string image)
    {
        ValidateDomain(name, description, price, stock, image);
    }

    public Product(int id, string name, string description, decimal price, int stock , string image) 
    {
        DomainExceptionValidation.When(id < 0, "Invalid Id value.");
        Id = id;
        ValidateDomain(name, description, price, stock, image);
    }

    public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
    {
        ValidateDomain(name, description, price, stock, image);
        CategoryId = categoryId;
    }

    private void ValidateDomain(string name, string description, decimal price, int stock, string image)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name)
            , "Nome inválido. Nome é obrigatório.");
        
        DomainExceptionValidation.When(name.Length < 3
            , "Nome inválido. Mínimo de 3 caracteres.");
        
        DomainExceptionValidation.When(string.IsNullOrEmpty(description)
            , "Nome inválido. Descrição é obrigatório.");
        
        DomainExceptionValidation.When(description.Length < 3
            , "Descrição inválida. Mínimo de 3 caracteres.");
        
        DomainExceptionValidation.When(price < 0
            , "Valor de preço inválido.");
        
        DomainExceptionValidation.When(stock < 0
            , "Valor de estoque inválido.");
        
        DomainExceptionValidation.When(image.Length > 199
            , "Nome inválido. Máximo de 200 caracteres.");

        Name = name;
        Description = description;
        Price = price;
        Stock = stock;
        Image = image;
    }
}
