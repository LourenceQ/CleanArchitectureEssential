using Microsoft.Extensions.DependencyInjection;

namespace GloboTicket.TicketManagment.Application;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services
            .AddMediatR(config =>
            {
                config.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies());
            });

        return services;
    }
}
