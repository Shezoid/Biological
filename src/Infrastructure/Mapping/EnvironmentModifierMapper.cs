using Domain.Models.Ahp;
using Infrastructure.Entities;

namespace Infrastructure.Mapping;

public static class EnvironmentModifierMapper
{
    public static EnvironmentModifierEntity ToEntity(EnvironmentModifier model)
    {
        return new EnvironmentModifierEntity
        {
            Id = model.Id,
            ConditionType = model.Condition,
            ConditionValue = model.NumericValue,
            FactorName = model.Factor,
            Modifier = model.Modifier
        };
    }

    public static EnvironmentModifier ToDomain(EnvironmentModifierEntity entity)
    {
        return new EnvironmentModifier.Builder()
            .WithId(entity.Id)
            .WithCondition(entity.ConditionType)
            .WithNumericValue(entity.ConditionValue)
            .WithFactor(entity.FactorName)
            .WithModifier(entity.Modifier)
            .Build();
    }
}