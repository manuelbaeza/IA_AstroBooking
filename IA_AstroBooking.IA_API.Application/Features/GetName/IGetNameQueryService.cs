namespace IA_AstroBooking.IA_API.Application.Features.GetName;

public interface IGetNameQueryService
{
    Task<GetNameResponse> ExecuteAsync(GetNameQuery query, CancellationToken cancellationToken);
}
