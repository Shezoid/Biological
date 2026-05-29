using SourceKit.Generators.Builder.Annotations;

namespace Domain.Models.Ahp;

[GenerateBuilder]
public partial record AhpWeight(
    Guid Id,
    [RequiredValue] GoalType Goal,
    [RequiredValue] FactorType Factor,
    [RequiredValue] double Weight);