namespace IA_AstroBooking.IA_API.Application.Features.GetName;

public sealed record GetNameResponse(string FullName, string RequestedBy, DateTime RetrievedAtUtc);
