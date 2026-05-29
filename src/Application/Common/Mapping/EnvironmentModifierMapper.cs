using Application.Contracts.Rules.Models;
using Domain.Models.Ahp;

namespace Application.Common.Mapping;

public static class EnvironmentModifierMapper
{
    public static EnvironmentModifier ToDomain(EnvironmentModifierDto dto)
    {
        return new EnvironmentModifier.Builder()
            .WithId(dto.Id)
            .WithCondition(dto.Condition)
            .WithNumericValue(dto.NumericValue)
            .WithFactor(dto.Factor)
            .WithModifier(dto.Modifier)
            .Build();
    }

    public static EnvironmentModifierDto ToDto(EnvironmentModifier model)
    {
        return new EnvironmentModifierDto(
            model.Id,
            model.Condition,
            model.NumericValue,
            model.Factor,
            model.Modifier);
    }
}