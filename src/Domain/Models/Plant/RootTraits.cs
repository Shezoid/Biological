using SourceKit.Generators.Builder.Annotations;

namespace Domain.Models.Plant;

[GenerateBuilder]
public partial record RootTraits(
    [RequiredValue] double Depth,
    [RequiredValue] double Branching,
    [RequiredValue] double SurfaceArea,
    [RequiredValue] double RhizosphereActivity,
    [RequiredValue] double WaterAbsorption,
    [RequiredValue] double WaterStorage,
    [RequiredValue] double PhytoExtraction,
    [RequiredValue] double PhytoStimulation)
{
}