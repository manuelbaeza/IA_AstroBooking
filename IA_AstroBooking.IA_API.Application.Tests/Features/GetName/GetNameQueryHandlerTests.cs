using IA_AstroBooking.IA_API.Application.Abstractions;
using IA_AstroBooking.IA_API.Application.Features.GetName;
using IA_AstroBooking.IA_API.Domain.Contracts;
using IA_AstroBooking.IA_API.Domain.Entities;

namespace IA_AstroBooking.IA_API.Application.Tests.Features.GetName;

public sealed class GetNameQueryHandlerTests
{
    [Fact]
    public async Task HandleAsync_ReturnsExpectedResponse_WhenProviderReturnsName()
    {
        var fakeProvider = new FakeNameProvider(new NameInfo("AstroBooking AI"));
        var handler = new GetNameQueryHandler(fakeProvider);
        var query = new GetNameQuery("UnitTest");

        var result = await handler.HandleAsync(query, CancellationToken.None);

        Assert.Equal("AstroBooking AI", result.FullName);
        Assert.Equal("UnitTest", result.RequestedBy);
        Assert.True(result.RetrievedAtUtc <= DateTime.UtcNow);
    }

    [Fact]
    public async Task HandleAsync_InvokesProviderExactlyOnce()
    {
        var fakeProvider = new FakeNameProvider(new NameInfo("AstroBooking AI"));
        var handler = new GetNameQueryHandler(fakeProvider);

        _ = await handler.HandleAsync(new GetNameQuery("UnitTest"), CancellationToken.None);

        Assert.Equal(1, fakeProvider.CallsCount);
    }

    private sealed class FakeNameProvider : INameProvider
    {
        private readonly INameInfo _nameInfo;

        public FakeNameProvider(INameInfo nameInfo)
        {
            _nameInfo = nameInfo;
        }

        public int CallsCount { get; private set; }

        public Task<INameInfo> GetNameAsync(CancellationToken cancellationToken)
        {
            CallsCount++;
            return Task.FromResult(_nameInfo);
        }
    }
}
