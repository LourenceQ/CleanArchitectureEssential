﻿namespace CleanArchMvc.Domain.Entities;

public sealed class Product
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; private set; }
    public decimal Price { get; private set; }
    public int Stock { get; private set; }
    public string Image { get; private set; }
    public int CategoryId { get; private set; }
    public Category? Category { get; private set; }
}
