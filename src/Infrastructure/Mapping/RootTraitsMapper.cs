using Domain.Models.Plant;
using Infrastructure.Entities;

namespace Infrastructure.Mapping;

public static class RootTraitsMapper
{
    public static RootTraitsEntity ToEntity(RootTraits model, Guid plantId)
    {
        return new RootTraitsEntity
        {
            PlantId = plantId,
            RootDepth = model.Depth,
            RootBranching = model.Branching,
            RootSurfaceArea = model.SurfaceArea,
            RhizosphereActivity = model.RhizosphereActivity,
            WaterAbsorption = model.WaterAbsorption,
            WaterStorage = model.WaterStorage,
            Phytoextraction = model.PhytoExtraction,
            Phytostimulation = model.PhytoStimulation
        };
    }

    public static RootTraits ToDomain(RootTraitsEntity entity)
    {
        return new RootTraits.Builder()
            .WithDepth(entity.RootDepth)
            .WithBranching(entity.RootBranching)
            .WithSurfaceArea(entity.RootSurfaceArea)
            .WithRhizosphereActivity(entity.RhizosphereActivity)
            .WithWaterAbsorption(entity.WaterAbsorption)
            .WithWaterStorage(entity.WaterStorage)
            .WithPhytoExtraction(entity.Phytoextraction)
            .WithPhytoStimulation(entity.Phytostimulation)
            .Build();
    }
}