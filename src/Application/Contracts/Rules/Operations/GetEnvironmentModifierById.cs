using Application.Contracts.Rules.Models;

namespace Application.Contracts.Rules.Operations;

public class GetEnvironmentModifierById
{
    public readonly record struct Request(Guid Id);

    public abstract record Response
    {
        private Response() { }

        public sealed record Success(EnvironmentModifierDto Dto) : Response;

        public sealed record Failure(string Message) : Response;
    }
}