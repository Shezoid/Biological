using Application.Contracts.Plant.Models;
using Domain.Models.Plant;

namespace Application.Common.Mapping;

public static class ClimateTraitsMapper
{
    public static ClimateTraits ToDomain(ClimateTraitDto dto)
    {
        return new ClimateTraits.Builder()
            .WithHumidityAdaptation(dto.HumidityAdaptation)
            .WithShadeTolerance(dto.ShadeTolerance)
            .WithLightRequirement(dto.LightRequirement)
            .Build();
    }

    public static ClimateTraitDto ToDto(ClimateTraits model)
    {
        return new ClimateTraitDto(
            model.HumidityAdaptation,
            model.ShadeTolerance,
            model.LightRequirement);
    }
}