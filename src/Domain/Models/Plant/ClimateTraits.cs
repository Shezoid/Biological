using SourceKit.Generators.Builder.Annotations;

namespace Domain.Models.Plant;

[GenerateBuilder]
public partial record ClimateTraits(
    [RequiredValue] double WinterHardiness,
    [RequiredValue] double HumidityAdaptation,
    [RequiredValue] double WindResistance,
    [RequiredValue] double ShadeTolerance,
    [RequiredValue] double LightRequirement)
{
}