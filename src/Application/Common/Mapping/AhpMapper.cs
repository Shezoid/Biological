using Application.Contracts.Ahp.Models;
using Domain.Models.Ahp;

namespace Application.Common.Mapping;

public static class AhpMapper
{
    public static AhpWeight ToDomain(AhpWeightDto dto)
    {
        return new AhpWeight.Builder()
            .WithId(dto.Id)
            .WithGoal(dto.Goal)
            .WithFactor(dto.Factor)
            .WithWeight(dto.Weight)
            .Build();
    }

    public static AhpWeightDto ToDto(AhpWeight model)
    {
        return new AhpWeightDto(
            model.Id,
            model.Goal,
            model.Factor,
            model.Weight);
    }
}