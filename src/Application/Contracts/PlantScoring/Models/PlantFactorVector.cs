using Domain.Models.Ahp;

namespace Application.Contracts.PlantScoring.Models;

public record PlantFactorVector(IReadOnlyDictionary<FactorType,double> Factors);