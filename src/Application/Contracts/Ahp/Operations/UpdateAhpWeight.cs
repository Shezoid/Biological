using Application.Contracts.Ahp.Models;
using Domain.Models.Ahp;

namespace Application.Contracts.Ahp.Operations;

public class UpdateAhpWeight
{
    public readonly record struct Request(
        Guid Id,
        GoalType Goal,
        FactorType Factor,
        double Weight);

    public abstract record Response
    {
        private Response()
        {
        }

        public sealed record Success(AhpWeightDto Dto) : Response;

        public sealed record Failure(string Message) : Response;
    }
}