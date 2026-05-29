using Application.Contracts.Plant.Models;
using Domain.Models.Plant;

namespace Application.Common.Mapping;

public static class EcologicalTraitsMapper
{
    public static EcologicalTraits ToDomain(EcologicalTraitDto dto)
    {
        return new EcologicalTraits.Builder()
            .WithPollutionTolerance(dto.PollutionTolerance)
            .WithDustCapture(dto.DustCapture)
            .WithCO2Absorption(dto.CO2Absorption)
            .WithGasAbsorption(dto.GasAbsorption)
            .WithBiodiversitySupport(dto.BiodiversitySupport)
            .WithPollinatorSupport(dto.PollinatorSupport)
            .WithFoodValue(dto.FoodValue)
            .WithShelterValue(dto.ShelterValue)
            .Build();
    }

    public static EcologicalTraitDto ToDto(EcologicalTraits model)
    {
        return new EcologicalTraitDto(
            model.PollutionTolerance,
            model.DustCapture,
            model.CO2Absorption,
            model.GasAbsorption,
            model.BiodiversitySupport,
            model.PollinatorSupport,
            model.FoodValue,
            model.ShelterValue);
    }
}