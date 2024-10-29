using AutoMapper;
using GloboTicket.TicketManagment.Application.Contracts.Persistance;
using GloboTicket.TicketManagmente.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagment.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public CreateEventCommandHandler(IEventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = _mapper.Map<Event>(request);
            @event = await _eventRepository.AddAsync(@event);

            return @event.EventId;
        }
    }
}
