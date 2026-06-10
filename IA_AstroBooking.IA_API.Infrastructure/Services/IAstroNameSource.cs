namespace IA_AstroBooking.IA_API.Infrastructure.Services;

public interface IAstroNameSource
{
    Task<string> GetCurrentNameAsync(CancellationToken cancellationToken);
}
