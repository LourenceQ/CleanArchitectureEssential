using FluentValidation;
using GloboTicket.TicketManagment.Application.Features.Events.Commands.CreateEvent;

namespace GloboTicket.TicketManagment.Application.Features.Events.Commands.DeleteEvent;

public class CreateEventCommandValidator : AbstractValidator<CreateEventCommand>
{
    public CreateEventCommandValidator()
    {
        RuleFor(p => p.Name).NotEmpty().WithMessage("").NotNull().MaximumLength(50).WithMessage("");

        RuleFor(p => p.Date).NotEmpty().WithMessage("").NotNull().GreaterThan(DateTime.Now);

        RuleFor(p => p.Price).NotEmpty().WithMessage("").GreaterThan(0);
    }
}
