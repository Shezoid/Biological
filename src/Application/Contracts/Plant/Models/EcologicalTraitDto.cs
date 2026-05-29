namespace Application.Contracts.Plant.Models;

public record EcologicalTraitDto(
    double PollutionTolerance,
    double DustCapture,
    double CO2Absorption,
    double GasAbsorption,
    double BiodiversitySupport,
    double PollinatorSupport,
    double FoodValue,
    double ShelterValue);