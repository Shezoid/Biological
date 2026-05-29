using Application.Contracts.Plant.Models;
using Domain.Models.Plant;

namespace Application.Common.Mapping;

public static class CrownTraitsMapper
{
    public static CrownTraits ToDomain(CrownTraitDto dto)
    {
        return new CrownTraits.Builder()
            .WithDensity(dto.Density)
            .WithCoverageDegree(dto.CoverageDegree)
            .WithMultilayer(dto.Multilayer)
            .WithGreenMass(dto.GreenMass)
            .WithBranching(dto.Branching)
            .Build();
    }

    public static CrownTraitDto ToDto(CrownTraits model)
    {
        return new CrownTraitDto(
            model.Density,
            model.CoverageDegree,
            model.Multilayer,
            model.GreenMass,
            model.Branching);
    }
}