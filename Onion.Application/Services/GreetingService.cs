using Onion.Application.Interfaces;

namespace Onion.Application.Services;

public class GreetingService : IGreetingService
{

    public async Task<string> GenerateGreetingAsync(string name)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(name);
        return $"Hello {name}, this is the new version";
    }
}
