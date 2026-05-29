using Application.Contracts.Ahp.Models;
using Application.Contracts.Plant.Models;

namespace Application.Contracts.Ahp.Operations;

public class GetAhpWeightById
{
    public readonly record struct Request(Guid Id);

    public abstract record Response
    {
        private Response()
        {
        }

        public sealed record Success(AhpWeightDto Dto) : Response;

        public sealed record Failure(string Message) : Response;
    }
}