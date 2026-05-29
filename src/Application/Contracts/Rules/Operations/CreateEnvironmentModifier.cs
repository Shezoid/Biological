using Application.Contracts.PlantScoring.Models;
using Application.Contracts.Rules.Models;
using Domain.Models.Ahp;

namespace Application.Contracts.Rules.Operations;

public class CreateEnvironmentModifier
{
    public readonly record struct Request(
        ConditionType Condition,
        double Value,
        FactorType Factor,
        double Modifier);

    public abstract record Response
    {
        private Response()
        {
        }

        public sealed record Success(EnvironmentModifierDto Dto) : Response;

        public sealed record Failure(string Message) : Response;
    }
}