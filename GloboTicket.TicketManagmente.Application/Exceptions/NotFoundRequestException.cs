namespace GloboTicket.TicketManagment.Application.Exceptions;

public class NotFoundRequestException : Exception
{
    public NotFoundRequestException(string name, object key) : base($"{name} ({key}) is not found")
    {

    }
}
