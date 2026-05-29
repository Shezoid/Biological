using Application.Contracts.PlantScoring.Models;

namespace Application.Contracts.PlantScoring.Operations;

public class CalculatePlants
{
    public readonly record struct Request(EnvironmentProfile Profile);

    public abstract record Response
    {
        private Response() { }

        public sealed record Success(IReadOnlyCollection<PlantScoreDto> Dto) : Response;

        public sealed record Failure(string Message) : Response;
    }
}