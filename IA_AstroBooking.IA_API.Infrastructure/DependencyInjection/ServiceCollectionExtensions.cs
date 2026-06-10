using IA_AstroBooking.IA_API.Application.Abstractions;
using IA_AstroBooking.IA_API.Infrastructure.Repositories;
using IA_AstroBooking.IA_API.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IA_AstroBooking.IA_API.Infrastructure.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<INameProvider, NameRepository>();
        services.AddScoped<INameRepository, NameRepository>();
        services.AddScoped<IAstroNameSource, AstroNameSource>();

        return services;
    }
}
