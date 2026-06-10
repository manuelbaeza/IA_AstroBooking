using IA_AstroBooking.IA_API.Application.Abstractions;
using IA_AstroBooking.IA_API.Application.Abstractions.CQRS;

namespace IA_AstroBooking.IA_API.Application.Features.GetName;

public sealed class GetNameQueryHandler : IQueryHandler<GetNameQuery, GetNameResponse>
{
    private readonly INameProvider _nameProvider;

    public GetNameQueryHandler(INameProvider nameProvider)
    {
        _nameProvider = nameProvider;
    }

    public async Task<GetNameResponse> HandleAsync(GetNameQuery query, CancellationToken cancellationToken)
    {
        var nameInfo = await _nameProvider.GetNameAsync(cancellationToken);

        return new GetNameResponse(
            nameInfo.FullName,
            query.RequestedBy,
            DateTime.UtcNow);
    }
}
