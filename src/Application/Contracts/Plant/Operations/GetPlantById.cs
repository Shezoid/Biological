using Application.Contracts.Plant.Models;

namespace Application.Contracts.Plant.Operations;

public class GetPlantById
{
    public readonly record struct Request(Guid Id);

    public abstract record Response
    {
        private Response()
        {
        }

        public sealed record Success(PlantDto Dto) : Response;

        public sealed record Failure(string Message) : Response;
    }
}