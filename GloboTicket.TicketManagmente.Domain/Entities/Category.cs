using GloboTicket.TicketManagmente.Domain.Common;

namespace GloboTicket.TicketManagmente.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Order>?  Events{ get; set; }
    }
}