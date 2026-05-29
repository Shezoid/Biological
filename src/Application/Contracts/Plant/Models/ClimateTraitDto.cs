namespace Application.Contracts.Plant.Models;

public record ClimateTraitDto(
     double HumidityAdaptation,
     double ShadeTolerance,
     double LightRequirement
);