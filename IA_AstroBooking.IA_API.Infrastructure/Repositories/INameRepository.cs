using IA_AstroBooking.IA_API.Application.Abstractions;
using IA_AstroBooking.IA_API.Domain.Contracts;

namespace IA_AstroBooking.IA_API.Infrastructure.Repositories;

public interface INameRepository : INameProvider
{
    new Task<INameInfo> GetNameAsync(CancellationToken cancellationToken);
}
