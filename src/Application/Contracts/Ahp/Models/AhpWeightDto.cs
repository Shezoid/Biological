using Domain.Models.Ahp;

namespace Application.Contracts.Ahp.Models;

public record AhpWeightDto(
    Guid Id,
    GoalType Goal,
    FactorType Factor,
    double Weight);