using SourceKit.Generators.Builder.Annotations;

namespace Domain.Models.Ahp;

[GenerateBuilder]
public partial record EnvironmentModifier(
    Guid Id,
    [RequiredValue] ConditionType Condition,
    [RequiredValue] double NumericValue,
    [RequiredValue] FactorType Factor,
    [RequiredValue] double Modifier);