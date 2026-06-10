using IA_AstroBooking.IA_API.Domain.Contracts;

namespace IA_AstroBooking.IA_API.Application.Abstractions;

public interface INameProvider
{
    Task<INameInfo> GetNameAsync(CancellationToken cancellationToken);
}
