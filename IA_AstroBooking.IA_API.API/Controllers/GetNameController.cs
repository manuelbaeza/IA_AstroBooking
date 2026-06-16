using IA_AstroBooking.IA_API.Application.Features.GetName;
using Microsoft.AspNetCore.Mvc;

namespace IA_AstroBooking.IA_API.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class GetNameController : ControllerBase
{
    private readonly IGetNameQueryService _getNameQueryService;

    /// <summary>
    /// Constructor for GetNameController.
    /// </summary>
    /// <param name="getNameQueryService"></param>
    public GetNameController(IGetNameQueryService getNameQueryService)
    {
        _getNameQueryService = getNameQueryService;
    }

    /// <summary>
    /// Get the name of the API.
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet]
    [ProducesResponseType(typeof(GetNameResponse), StatusCodes.Status200OK)]
    public async Task<ActionResult<GetNameResponse>> Get(CancellationToken cancellationToken)
    {
        var query = new GetNameQuery("API");
        var response = await _getNameQueryService.ExecuteAsync(query, cancellationToken);
        return Ok(response);
    }
}
