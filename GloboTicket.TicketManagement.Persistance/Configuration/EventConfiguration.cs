using GloboTicket.TicketManagmente.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace GloboTicket.TicketManagement.Persistance.Configuration;
public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(50);
    }
}
