using SourceKit.Generators.Builder.Annotations;

namespace Domain.Models.Plant;

[GenerateBuilder]
public partial record CrownTraits(
    [RequiredValue] double Density,
    [RequiredValue] double CoverageDegree,
    [RequiredValue] double Multilayer,
    [RequiredValue] double GreenMass,
    [RequiredValue] double Branching);