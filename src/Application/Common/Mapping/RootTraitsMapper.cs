using Application.Contracts.Plant.Models;
using Domain.Models.Plant;

namespace Application.Common.Mapping;

public static class RootTraitsMapper
{
    public static RootTraits ToDomain(RootTraitDto entity)
    {
        return new RootTraits.Builder()
            .WithDepth(entity.Depth)
            .WithBranching(entity.Branching)
            .WithSurfaceArea(entity.SurfaceArea)
            .WithRhizosphereActivity(entity.RhizosphereActivity)
            .WithWaterAbsorption(entity.WaterAbsorption)
            .WithWaterStorage(entity.WaterStorage)
            .WithPhytoExtraction(entity.PhytoExtraction)
            .WithPhytoStimulation(entity.PhytoStimulation)
            .Build();
    }

    public static RootTraitDto ToDto(RootTraits model)
    {
        return new RootTraitDto(
            model.Depth,
            model.Branching,
            model.SurfaceArea,
            model.RhizosphereActivity,
            model.WaterAbsorption,
            model.WaterStorage,
            model.PhytoExtraction,
            model.PhytoStimulation);
    }
}