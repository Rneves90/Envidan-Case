namespace Onion.Application.Interfaces;

public interface IGreetingService
{
    Task<string> GenerateGreetingAsync(string name);
}
