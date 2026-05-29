namespace Application.Contracts.Plant.Operations;

public class DeletePlant
{
    public readonly record struct Request(Guid Id);

    public abstract record Response
    {
        private Response() { }

        public sealed record Success() : Response;

        public sealed record Failure(string Message) : Response;
    }
}