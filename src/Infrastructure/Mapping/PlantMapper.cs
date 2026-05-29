using Domain.Models.Plant;
using Infrastructure.Entities;

namespace Infrastructure.Mapping;

public static class PlantMapper
{
    public static PlantEntity ToEntity(Plant plant)
    {
        return new PlantEntity
        {
            Id = plant.Id,
            NameRu = plant.NameRu,
            NameLatin = plant.NameLatin,
            HeightMax = plant.HeightMax,
            GrowthRate = plant.GrowthRate,
            Lifespan = plant.Lifespan,
            Leaf = LeafTraitsMapper.ToEntity(plant.Leaf, plant.Id),
            Crown = CrownTraitsMapper.ToEntity(plant.Crown, plant.Id),
            Root = RootTraitsMapper.ToEntity(plant.Root, plant.Id),
            Ecology = EcologicalTraitsMapper.ToEntity(plant.Ecology, plant.Id),
            Climate = ClimateTraitsMapper.ToEntity(plant.Climate, plant.Id)
        };
    }

    public static Plant ToDomain(PlantEntity entity)
    {
        return new Plant.Builder()
            .WithId(entity.Id)
            .WithNameRu(entity.NameRu)
            .WithNameLatin(entity.NameLatin)
            .WithHeightMax(entity.HeightMax)
            .WithGrowthRate(entity.GrowthRate)
            .WithLifespan(entity.Lifespan)
            .WithLeaf(LeafTraitsMapper.ToDomain(entity.Leaf))
            .WithCrown(CrownTraitsMapper.ToDomain(entity.Crown))
            .WithRoot(RootTraitsMapper.ToDomain(entity.Root))
            .WithEcology(EcologicalTraitsMapper.ToDomain(entity.Ecology))
            .WithClimate(ClimateTraitsMapper.ToDomain(entity.Climate))
            .Build();
    }
    public static Plant ToDomain(
        PlantEntity entity,
        LeafTraitsEntity leaf,
        CrownTraitsEntity crown,
        RootTraitsEntity root,
        EcologicalTraitsEntity ecological,
        ClimateTraitsEntity climate)
    {
        return new Plant.Builder()
            .WithId(entity.Id)
            .WithNameRu(entity.NameRu)
            .WithNameLatin(entity.NameLatin)
            .WithHeightMax(entity.HeightMax)
            .WithGrowthRate(entity.GrowthRate)
            .WithLifespan(entity.Lifespan)
            .WithLeaf(LeafTraitsMapper.ToDomain(leaf))
            .WithCrown(CrownTraitsMapper.ToDomain(crown))
            .WithRoot(RootTraitsMapper.ToDomain(root))
            .WithEcology(EcologicalTraitsMapper.ToDomain(ecological))
            .WithClimate(ClimateTraitsMapper.ToDomain(climate))
            .Build();
    }
}