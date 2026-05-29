namespace Application.Contracts.Ahp.Operations;

public class DeleteAhpWeight
{
    public readonly record struct Request(Guid Id);

    public abstract record Response
    {
        private Response() { }

        public sealed record Success() : Response;

        public sealed record Failure(string Message) : Response;
    }
}