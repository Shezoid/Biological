using Application.Contracts.Plant.Models;
using Domain.Models.Plant;

namespace Application.Common.Mapping;

public static class PlantMapper
{
    public static Plant ToDomain(PlantDto dto)
    {
        return new Plant.Builder()
            .WithId(dto.Id)
            .WithNameRu(dto.NameRu)
            .WithNameLatin(dto.NameLatin)
            .WithHeightMax(dto.HeightMax)
            .WithGrowthRate(dto.GrowthRate)
            .WithLifespan(dto.Lifespan)
            .WithLeaf(LeafTraitsMapper.ToDomain(dto.Leaf))
            .WithCrown(CrownTraitsMapper.ToDomain(dto.Crown))
            .WithRoot(RootTraitsMapper.ToDomain(dto.Root))
            .WithEcology(EcologicalTraitsMapper.ToDomain(dto.Ecology))
            .WithClimate(ClimateTraitsMapper.ToDomain(dto.Climate))
            .Build();
    }

    public static PlantDto ToDto(Plant plant)
    {
        return new PlantDto(
            plant.Id,
            plant.NameRu,
            plant.NameLatin,
            plant.HeightMax,
            plant.GrowthRate,
            plant.Lifespan,
            LeafTraitsMapper.ToDto(plant.Leaf),
            CrownTraitsMapper.ToDto(plant.Crown),
            RootTraitsMapper.ToDto(plant.Root),
            EcologicalTraitsMapper.ToDto(plant.Ecology),
            ClimateTraitsMapper.ToDto(plant.Climate));
    }
}