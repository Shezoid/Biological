using Domain.Models.Plant;
using Infrastructure.Entities;

namespace Infrastructure.Mapping;

public static class EcologicalTraitsMapper
{
    public static EcologicalTraitsEntity ToEntity(EcologicalTraits model, Guid plantId)
    {
        return new EcologicalTraitsEntity
        {
            PlantId = plantId,
            PollutionTolerance = model.PollutionTolerance,
            DustCapture = model.DustCapture,
            CO2Absorption = model.CO2Absorption,
            GasAbsorption = model.GasAbsorption,
            BiodiversitySupport = model.BiodiversitySupport,
            PollinatorSupport = model.PollinatorSupport,
            FoodValue = model.FoodValue,
            ShelterValue = model.ShelterValue
        };
    }

    public static EcologicalTraits ToDomain(EcologicalTraitsEntity entity)
    {
        return new EcologicalTraits.Builder()
            .WithPollutionTolerance(entity.PollutionTolerance)
            .WithDustCapture(entity.DustCapture)
            .WithCO2Absorption(entity.CO2Absorption)
            .WithGasAbsorption(entity.GasAbsorption)
            .WithBiodiversitySupport(entity.BiodiversitySupport)
            .WithPollinatorSupport(entity.PollinatorSupport)
            .WithFoodValue(entity.FoodValue)
            .WithShelterValue(entity.ShelterValue)
            .Build();
    }
}