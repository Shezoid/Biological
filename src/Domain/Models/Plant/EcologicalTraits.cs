using SourceKit.Generators.Builder.Annotations;

namespace Domain.Models.Plant;

[GenerateBuilder]
public partial record EcologicalTraits(
    [RequiredValue] double PollutionTolerance,
    [RequiredValue] double DustCapture,
    [RequiredValue] double Co2Absorption,
    [RequiredValue] double GasAbsorption,
    [RequiredValue] double BiodiversitySupport,
    [RequiredValue] double PollinatorSupport,
    [RequiredValue] double FoodValue,
    [RequiredValue] double ShelterValue)
{
}