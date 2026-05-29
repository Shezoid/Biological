using Domain.Models.Plant;
using Infrastructure.Entities;

namespace Infrastructure.Mapping;

public static class ClimateTraitsMapper
{
    public static ClimateTraitsEntity ToEntity(ClimateTraits model, Guid plantId)
    {
        return new ClimateTraitsEntity
        {
            PlantId = plantId,
            HumidityAdaptation = model.HumidityAdaptation,
            ShadeTolerance = model.ShadeTolerance,
            LightRequirement = model.LightRequirement
        };
    }

    public static ClimateTraits ToDomain(ClimateTraitsEntity entity)
    {
        return new ClimateTraits.Builder()
            .WithHumidityAdaptation(entity.HumidityAdaptation)
            .WithShadeTolerance(entity.ShadeTolerance)
            .WithLightRequirement(entity.LightRequirement)
            .Build();
    }
}