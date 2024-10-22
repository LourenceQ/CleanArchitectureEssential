namespace GloboTicket.TicketManagment.Application.Features.Events
{
    public class EventListVm
    {
        public Guid EventID { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string? ImageUrl { get; set; }
    }
}