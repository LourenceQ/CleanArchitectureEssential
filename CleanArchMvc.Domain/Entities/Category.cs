﻿using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities;

public sealed class Category : BaseEntity
{
    public string Name { get; private set; }
    public ICollection<Product> Products { get; private set; }

    public Category(string name)
    {
        ValidateDomain(name);
    }

    public Category(int id, string name)
    {
        DomainExceptionValidation.When(id < 0, "Id inválido.");
        Id = id;
        ValidateDomain(name);
    }

    public Category()
    {
    }

    private void ValidateDomain(string name)
    {
        DomainExceptionValidation.When(string.IsNullOrEmpty(name)
            , "Nome inválido. Nome é obrigatório.");

        DomainExceptionValidation.When(name.Length < 3
            , "Nome inválido. Mínimo de 3 caracteres.");
    }

    public void Update(string name)
    {
        ValidateDomain(name);
    }
}
