using IA_AstroBooking.IA_API.Application.Abstractions.CQRS;
using IA_AstroBooking.IA_API.Application.Features.GetName;
using Microsoft.Extensions.DependencyInjection;

namespace IA_AstroBooking.IA_API.Application.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IGetNameQueryService, GetNameQueryService>();
        services.AddScoped<IQueryHandler<GetNameQuery, GetNameResponse>, GetNameQueryHandler>();

        return services;
    }
}
