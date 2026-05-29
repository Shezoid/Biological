using Application.Contracts.PlantScoring;
using Application.Contracts.PlantScoring.Models;
using Application.Abstractions.Repositories;
using Application.Common.PlantVectors;
using Domain.Models.Ahp;
using Domain.Models.Plant;

namespace Application.Services;

public class PlantScoreService(
    IPlantRepository plantRepository,
    IAhpWeightRepository ahpRepository,
    IRulesRepository modifierRepository,
    IPlantFactorVectorFactory factorFactory) : IPlantScoringService
{
    public IReadOnlyList<PlantScoreDto> GetBestPlants(EnvironmentProfile profile)
    {
        var plants = plantRepository.GetAll();

        var weights = ahpRepository
            .GetAll()
            .Where(x => x.Goal.Equals(profile.Goal))
            .ToList();

        var modifiers = modifierRepository.GetAll();

        var result = new List<PlantScoreDto>();

        foreach (var plant in plants)
        {
            var score = CalculateScore(plant, profile, weights, modifiers);
            result.Add(new PlantScoreDto(plant.Id, plant.NameRu, score));
        }

        return result
            .OrderByDescending(x => x.Score)
            .ToList();
    }

    private double CalculateScore(
        Plant plant,
        EnvironmentProfile profile,
        IEnumerable<AhpWeight> weights,
        IEnumerable<EnvironmentModifier> modifiers)
    {
        var vector = factorFactory.Create(plant);

        double score = 0;

        foreach (var weight in weights)
        {
            var factorValue = vector.Factors[weight.Factor];
            var modifier = GetModifier(profile, modifiers, weight.Factor);
            score += factorValue * weight.Weight * modifier;
        }

        return score;
    }

    private double GetModifier(
        EnvironmentProfile profile,
        IEnumerable<EnvironmentModifier> modifiers,
        FactorType factor)
    {
        double modifierValue = 1;

        foreach (var modifier in modifiers)
        {
            if (modifier.Factor != factor) continue;

            var matchFactor = GetContinuousMatch(profile, modifier);
            modifierValue *= matchFactor;
        }

        return modifierValue;
    }

    private double GetContinuousMatch(EnvironmentProfile profile, EnvironmentModifier modifier)
    {
        var value = modifier.Condition switch
        {
            ConditionType.Humidity => profile.Humidity,
            ConditionType.Temperature => profile.Temperature,
            ConditionType.Wind => profile.Wind,
            ConditionType.Pollution => profile.Pollution,
            ConditionType.WallOrientation => profile.Wall,
            _ => 0
        };

        if (modifier.Condition == ConditionType.WallOrientation)
        {
            var diff = Math.Abs(value - modifier.NumericValue);
            diff = Math.Min(diff, 360 - diff);
            return 1.0 - 0.3 * Clamp((diff / 45.0),0,1);
        }

        var ratio = value / modifier.NumericValue;
        return 0.8 + 0.4 * ratio;
    }
    
    private static double Clamp(double value, double min, double max)
        => Math.Min(Math.Max(value, min), max);
}