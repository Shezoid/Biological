using Application.Contracts.Rules.Models;

namespace Application.Contracts.Rules.Operations;

public class GetEnvironmentModifiers
{
    public readonly record struct Request();

    public abstract record Response
    {
        private Response() { }

        public sealed record Success(IReadOnlyCollection<EnvironmentModifierDto> Dto) : Response;

        public sealed record Failure(string Message) : Response;
    }
}