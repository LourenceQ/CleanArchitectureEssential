using CleanArchMvc.Domain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Domain.Tests;

public class CategoryUnitTst1
{
    [Fact(DisplayName = "Crate Category With Valid State")]
    public void CreateCategory_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new  Category(1, "Category Name");
        action.Should()
            .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Crate Category With Valid State")]
    public void CreateCategory_NegativeIdValue_ResultObjectValidState()
    {
        Action action = () => new Category(-1, "Category Name");
        action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Id inv�lido.");
    }

    [Fact(DisplayName = "Crate Category With Valid State")]
    public void CreateCategory_WithNullNameValue_DomainExceptionInvalidName()
    {
        Action action = () => new Category(1, null);
        action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Crate Category With Valid State")]
    public void CreateCategory_ShortNameValue_DomainExceptionShortName()
    {
        Action action = () => new Category(1, "Ca");
        action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Nome inv�lido. M�nimo de 3 caracteres.");
    }

    [Fact(DisplayName = "Crate Category With Valid State")]
    public void CreateCategory_MissingNameValue_DomainExceptionRequiredName()
    {
        Action action = () => new Category(1, "");
        action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Nome inv�lido. Nome � obrigat�rio.");
    }
}