using AutoMapper;
using GloboTicket.TicketManagment.Application.Contracts.Persistance;
using MediatR;

namespace GloboTicket.TicketManagment.Application.Features.Events.Queries.GetEventList
{
    public class GetEventListQueryHandler : IRequestHandler<GetEventListQuery, List<EventListVm>>
    {
        private readonly IAsyncRepository<EventArgs> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventListQueryHandler(IAsyncRepository<EventArgs> eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }


        public async Task<List<EventListVm>> Handle(GetEventListQuery request, CancellationToken cancellationToken)
        {
            IReadOnlyList<EventArgs> allEvents = await _eventRepository.ListAllAsync();

            return _mapper.Map<List<EventListVm>>(allEvents);
        }
    }
}
