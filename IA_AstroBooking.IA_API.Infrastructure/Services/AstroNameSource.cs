namespace IA_AstroBooking.IA_API.Infrastructure.Services;

public sealed class AstroNameSource : IAstroNameSource
{
    public Task<string> GetCurrentNameAsync(CancellationToken cancellationToken)
    {
        return Task.FromResult("AstroBooking AI");
    }
}
