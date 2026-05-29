using Application.Contracts.PlantScoring.Models;
using Domain.Models.Ahp;

namespace Application.Contracts.Rules.Models;


public record EnvironmentModifierDto(
    Guid Id,
    ConditionType Condition,
    double NumericValue,
    FactorType Factor,
    double Modifier);