namespace Application.Contracts.Rules.Operations;

public class DeleteEnvironmentModifier
{
    public readonly record struct Request(Guid Id);

    public abstract record Response
    {
        private Response() { }

        public sealed record Success() : Response;

        public sealed record Failure(string Message) : Response;
    }
}