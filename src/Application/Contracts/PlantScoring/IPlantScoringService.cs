using Application.Contracts.PlantScoring.Models;
using Domain.Models.Ahp;

namespace Application.Contracts.PlantScoring;

public interface IPlantScoringService
{
    IReadOnlyList<PlantScoreDto> GetBestPlants(EnvironmentProfile profile);
}