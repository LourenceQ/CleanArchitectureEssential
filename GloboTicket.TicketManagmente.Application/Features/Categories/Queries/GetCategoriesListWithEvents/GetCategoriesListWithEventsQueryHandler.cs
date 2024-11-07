using AutoMapper;
using GloboTicket.TicketManagment.Application.Contracts.Persistance;
using MediatR;

namespace GloboTicket.TicketManagment.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class GetCategoriesListWithEventsQueryHandler : IRequestHandler<GetCategoriesListWithEventsQuery
        , List<CategoryEventListVm>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public GetCategoriesListWithEventsQueryHandler(ICategoryRepository eventRepository, IMapper mapper)
        {
            _categoryRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<List<CategoryEventListVm>> Handle(GetCategoriesListWithEventsQuery request, CancellationToken cancellationToken)
        {
            List<TicketManagmente.Domain.Entities.Category> list = await _categoryRepository.GetCategoriesListWithEventsQuery(request.IncludeHistory);

            return _mapper.Map<List<CategoryEventListVm>>(list);
        }
    }
}
