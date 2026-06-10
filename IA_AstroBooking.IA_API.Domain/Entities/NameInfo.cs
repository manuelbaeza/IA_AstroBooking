using IA_AstroBooking.IA_API.Domain.Contracts;

namespace IA_AstroBooking.IA_API.Domain.Entities;

public sealed class NameInfo : INameInfo
{
    public NameInfo(string fullName)
    {
        FullName = fullName;
    }

    public string FullName { get; }
}
