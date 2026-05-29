using Domain.Models.Plant;
using Infrastructure.Entities;

namespace Infrastructure.Mapping;

public static class CrownTraitsMapper
{
    public static CrownTraitsEntity ToEntity(CrownTraits model, Guid plantId)
    {
        return new CrownTraitsEntity
        {
            PlantId = plantId,
            CrownDensity = model.Density,
            CoverageDegree = model.CoverageDegree,
            Multilayer = model.Multilayer,
            GreenMass = model.GreenMass,
            Branching = model.Branching
        };
    }

    public static CrownTraits ToDomain(CrownTraitsEntity entity)
    {
        return new CrownTraits.Builder()
            .WithDensity(entity.CrownDensity)
            .WithCoverageDegree(entity.CoverageDegree)
            .WithMultilayer(entity.Multilayer)
            .WithGreenMass(entity.GreenMass)
            .WithBranching(entity.Branching)
            .Build();
    }
}