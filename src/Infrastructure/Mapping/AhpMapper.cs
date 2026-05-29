using Domain.Models.Ahp;
using Infrastructure.Entities;

namespace Infrastructure.Mapping;

public static class AhpMapper
{
    public static AhpWeightEntity ToEntity(AhpWeight model)
    {
        return new AhpWeightEntity
        {
            Id = model.Id,
            GoalType = model.Goal,
            FactorName = model.Factor,
            Weight = model.Weight
        };
    }

    public static AhpWeight ToDomain(AhpWeightEntity entity)
    {
        return new AhpWeight.Builder()
            .WithId(entity.Id)
            .WithGoal(entity.GoalType)
            .WithFactor(entity.FactorName)
            .WithWeight(entity.Weight)
            .Build();
    }
}