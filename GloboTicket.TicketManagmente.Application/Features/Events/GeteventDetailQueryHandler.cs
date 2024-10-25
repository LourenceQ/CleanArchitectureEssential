using AutoMapper;
using GloboTicket.TicketManagment.Application.Contracts.Persistance;
using GloboTicket.TicketManagmente.Domain.Entities;
using MediatR;

namespace GloboTicket.TicketManagment.Application.Features.Events
{
    public class GeteventDetailQueryHandler : IRequestHandler<GetEventDetailQuery, EventDetailVm>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IMapper _mapper;

        public GeteventDetailQueryHandler(IAsyncRepository<Event> eventRepository
            , IAsyncRepository<Category> categoryRepository
            , IMapper mapper)
        {
            _eventRepository = eventRepository;
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public async Task<EventDetailVm> Handle(GetEventDetailQuery request, CancellationToken cancellationToken)
        {
            var @event = await _eventRepository.GetByIdAsync(request.Id);
            var eventDetailDto = _mapper.Map<EventDetailVm>(@event);

            var category = await _categoryRepository.GetByIdAsync(@event.CategoryId);

            eventDetailDto.Category = _mapper.Map<CategoryDto>(category);

            return eventDetailDto;
        }
    }
}
