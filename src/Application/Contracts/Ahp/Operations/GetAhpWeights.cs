using Application.Contracts.Ahp.Models;
using Application.Contracts.Plant.Models;

namespace Application.Contracts.Ahp.Operations;

public class GetAhpWeights
{
    public readonly record struct Request();

    public abstract record Response
    {
        private Response()
        {
        }

        public sealed record Success(IReadOnlyCollection<AhpWeightDto> Dto) : Response;

        public sealed record Failure(string Message) : Response;
    }
}