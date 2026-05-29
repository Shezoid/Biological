using Application.Contracts.Plant.Operations;

namespace Application.Contracts.Plant;

public interface IPlantService
{
    CreatePlant.Response Create(CreatePlant.Request request);

    DeletePlant.Response Delete(DeletePlant.Request request);

    GetPlantById.Response GetById(GetPlantById.Request request);
    
    GetPlants.Response GetPlants(GetPlants.Request request);
    
    UpdatePlant.Response Update(UpdatePlant.Request request);
}