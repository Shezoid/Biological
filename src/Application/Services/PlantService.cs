using Application.Abstractions.Repositories;
using Application.Common.Mapping;
using Application.Contracts.Plant;
using Application.Contracts.Plant.Operations;
using Domain.Models.Plant;

namespace Application.Services;

public class PlantService(IPlantRepository repository) : IPlantService
{
    public CreatePlant.Response Create(CreatePlant.Request request)
    {
        Plant plant = new Plant.Builder()
                .WithNameRu(request.NameRu)
                .WithNameLatin(request.NameLatin)
                .WithHeightMax(request.HeightMax)
                .WithGrowthRate(request.GrowthRate)
                .WithLifespan(request.Lifespan)
                .WithLeaf(LeafTraitsMapper.ToDomain(request.Leaf))
                .WithCrown(CrownTraitsMapper.ToDomain(request.Crown))
                .WithRoot(RootTraitsMapper.ToDomain(request.Root))
                .WithEcology(EcologicalTraitsMapper.ToDomain(request.Ecology))
                .WithClimate(ClimateTraitsMapper.ToDomain(request.Climate))
                .Build();

        var created = repository.Add(plant);

        return new CreatePlant.Response.Success(PlantMapper.ToDto(created));
    }

    public DeletePlant.Response Delete(DeletePlant.Request request)
    {
        var existing = repository.GetById(request.Id);

        if (existing is null)
            return new DeletePlant.Response.Failure("Plant not found");

        repository.Delete(request.Id);

        return new DeletePlant.Response.Success();
    }

    public GetPlantById.Response GetById(GetPlantById.Request request)
    {
        var plant = repository.GetById(request.Id);

        if (plant is null)
            return new GetPlantById.Response.Failure("Plant not found");

        return new GetPlantById.Response.Success(PlantMapper.ToDto(plant));
    }

    public GetPlants.Response GetPlants(GetPlants.Request request)
    {
        var plants = repository.GetAll();

        return new GetPlants.Response.Success(
            plants.Select(PlantMapper.ToDto).ToList());
    }

    public UpdatePlant.Response Update(UpdatePlant.Request request)
    {
        var existing = repository.GetById(request.Id);

        if (existing is null)
            return new UpdatePlant.Response.Failure("Plant not found");

        var updated = new Plant.Builder()
            .WithNameRu(request.NameRu)
            .WithClimate(ClimateTraitsMapper.ToDomain(request.Climate))
            .WithHeightMax(request.HeightMax)
            .WithGrowthRate(request.GrowthRate)
            .WithLeaf(LeafTraitsMapper.ToDomain(request.Leaf))
            .WithCrown(CrownTraitsMapper.ToDomain(request.Crown))
            .WithRoot(RootTraitsMapper.ToDomain(request.Root))
            .WithEcology(EcologicalTraitsMapper.ToDomain(request.Ecology))
            .WithNameLatin(request.NameLatin)
            .WithId(request.Id)
            .WithLifespan(request.Lifespan)
            .Build();

        updated = repository.Update(updated);

        return new UpdatePlant.Response.Success(PlantMapper.ToDto(updated));
    }
}