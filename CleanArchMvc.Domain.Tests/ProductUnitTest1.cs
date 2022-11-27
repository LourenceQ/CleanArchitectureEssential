using CleanArchMvc.Domain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Domain.Tests;

public class ProductUnitTest1
{
    [Fact(DisplayName = "Crate Product With Valid State")]
    public void CreateProduct_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Product(1, "Product Name"
            , "Product Description", 9.9m, 99, "product image");
        action.Should()
            .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Crate Product With Valid State")]
    public void CreateProduct_NegativeIdValue_ResultObjectValidState()
    {
        Action action = () => new Product(-1, "Product Name"
            , "Product Description", 9.9m, 99, "prduct image");
        action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid Id value.");
    }

    [Fact(DisplayName = "Crate Product With Valid State")]
    public void CreateProduct_ShortNameValue_DomainExceptionShortName()
    {
        Action action = () => new Product(1, "Pr"
            , "Product Description", 9.9m, 99, "prduct image");
        action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Nome inválido. Mínimo de 3 caracteres.");
    }

    [Fact(DisplayName = "Crate Product With Valid State")]
    public void CreateProduct_LongImageName_DomainExceptionLongImageName()
    {
        Action action = () => new Product(1, "Product name"
            , "Product Description", 9.9m, 99
            , "imageimageimageimageimageimageimageimageimageimage"
            + "imageimageimageimageimageimageimageimageimageimageimage"
            + "imageimageimageimageimageimageimageimageimageimageimage"
            + "imageimageimageimageimageimageimageimage");
        action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Nome inválido. Máximo de 200 caracteres.");
    }

    [Fact(DisplayName = "Crate Product With Valid State")]
    public void CreateProduct_WithNullImageName_NoDomainExceptionInvalidName()
    {
        Action action = () => new Product(1, "Product name"
            , "Product Description", 9.9m, 99, null);
        action.Should()
            .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Crate Product With Valid State")]
    public void CreateProduct_WithEmptyImageName_DomainExceptionRequiredName()
    {
        Action action = () => new Product(1, "Pr"
            , "Product Description", 9.9m, 99, "");
        action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Nome inválido. Mínimo de 3 caracteres.");
    }

    [Fact(DisplayName = "Crate Product With Valid State")]
    public void CreateProduct_InvalidPriceValue_DomainExceptionRequiredName()
    {
        Action action = () => new Product(1, "Product name"
            , "Product Description", -9.9m, 99, "");
        action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Valor de preço inválido.");
    }

    [Theory]
    [InlineData (-5)]
    public void CreateProduct_WithInvalidStockValue_ExceptionDomainNegativeValue(int value)
    {
        Action action = () => new Product(1, "Pr"
            , "Product Description", 9.9m, value, "product image");
        action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Nome inválido. Mínimo de 3 caracteres.");
    }

}
