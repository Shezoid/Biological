namespace Application.Contracts.PlantScoring.Models;

public record PlantScoreDto(
    Guid PlantId,
    string NameRu,
    double Score);