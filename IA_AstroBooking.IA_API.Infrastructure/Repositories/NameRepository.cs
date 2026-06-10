using IA_AstroBooking.IA_API.Domain.Contracts;
using IA_AstroBooking.IA_API.Domain.Entities;
using IA_AstroBooking.IA_API.Infrastructure.Services;

namespace IA_AstroBooking.IA_API.Infrastructure.Repositories;

public sealed class NameRepository : INameRepository
{
    private readonly IAstroNameSource _astroNameSource;

    public NameRepository(IAstroNameSource astroNameSource)
    {
        _astroNameSource = astroNameSource;
    }

    public async Task<INameInfo> GetNameAsync(CancellationToken cancellationToken)
    {
        var currentName = await _astroNameSource.GetCurrentNameAsync(cancellationToken);
        return new NameInfo(currentName);
    }
}
