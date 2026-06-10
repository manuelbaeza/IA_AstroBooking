using IA_AstroBooking.IA_API.Application.Abstractions.CQRS;

namespace IA_AstroBooking.IA_API.Application.Features.GetName;

public sealed record GetNameQuery(string RequestedBy) : IQuery<GetNameResponse>;
