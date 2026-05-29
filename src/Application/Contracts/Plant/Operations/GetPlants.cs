using Application.Contracts.Plant.Models;

namespace Application.Contracts.Plant.Operations;

public class GetPlants
{
    public readonly record struct Request();

    public abstract record Response
    {
        private Response()
        {
        }

        public sealed record Success(IReadOnlyCollection<PlantDto> Dto) : Response;

        public sealed record Failure(string Message) : Response;
    }
}