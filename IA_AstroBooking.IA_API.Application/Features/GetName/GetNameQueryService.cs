using IA_AstroBooking.IA_API.Application.Abstractions.CQRS;

namespace IA_AstroBooking.IA_API.Application.Features.GetName;

public sealed class GetNameQueryService : IGetNameQueryService
{
    private readonly IQueryHandler<GetNameQuery, GetNameResponse> _queryHandler;

    public GetNameQueryService(IQueryHandler<GetNameQuery, GetNameResponse> queryHandler)
    {
        _queryHandler = queryHandler;
    }

    public Task<GetNameResponse> ExecuteAsync(GetNameQuery query, CancellationToken cancellationToken)
    {
        return _queryHandler.HandleAsync(query, cancellationToken);
    }
}
