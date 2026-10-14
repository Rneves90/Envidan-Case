using Microsoft.AspNetCore.Mvc;
using Onion.Application.DTOs;
using Onion.Application.Interfaces;

namespace Onion.Assignment.Controllers;

[Route("api/[controller]")]
public class GreetingController : ControllerBase
{
    private readonly IGreetingService _greetingService;

    public GreetingController(IGreetingService greetingService)
    {
        _greetingService = greetingService;
    }

    /// <summary>
    /// Get a greeting message for a given name.
    /// </summary>
    /// <param name="request">The greeting request containing the name.</param>
    /// <returns>A greeting message.</returns>
    /// <response code="200">Returns the greeting message</response>
    /// <response code="400">If the name is null or whitespace</response>
    [HttpGet("hello")]
    public async Task<ActionResult<string>> GetGreeting([FromQuery] GreetingRequest request)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(request.Name);
        var greeting = await _greetingService.GenerateGreetingAsync(request.Name);
        return Ok(greeting);
    }
}
