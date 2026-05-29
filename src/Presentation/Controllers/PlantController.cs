using Application.Contracts.Plant;
using Application.Contracts.Plant.Operations;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/plants")]
public class PlantsController(IPlantService plantService) : ControllerBase
{
    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var result = plantService.GetPlants(new GetPlants.Request());
        return result switch
        {
            GetPlants.Response.Success x => Ok(x.Dto),
            GetPlants.Response.Failure x => NotFound(x.Message),
            _ => BadRequest()
        };
    }

    [HttpGet("GetById")]
    public IActionResult GetById(Guid id)
    {
        var result = plantService.GetById(new GetPlantById.Request(id));

        return result switch
        {
            GetPlantById.Response.Success x => Ok(x.Dto),
            GetPlantById.Response.Failure x => NotFound(x.Message),
            _ => BadRequest()
        };
    }

    [HttpPost("Create")]
    public IActionResult Create([FromBody] CreatePlant.Request request)
    {
        var result = plantService.Create(request);

        return result switch
        {
            CreatePlant.Response.Success x => Ok(x.Dto),
            CreatePlant.Response.Failure x => BadRequest(x.Message),
            _ => BadRequest()
        };
    }

    [HttpPut("Update")]
    public IActionResult Update([FromBody] UpdatePlant.Request request)
    {
        var result = plantService.Update(request);

        return result switch
        {
            UpdatePlant.Response.Success x => Ok(x.Dto),
            UpdatePlant.Response.Failure x => BadRequest(x.Message),
            _ => BadRequest()
        };
    }

    [HttpDelete("Delete")]
    public IActionResult Delete(Guid id)
    {
        var result = plantService.Delete(new DeletePlant.Request(id));
        return result switch
        {
            DeletePlant.Response.Success => NoContent(),
            DeletePlant.Response.Failure x => NotFound(x.Message),
            _ => BadRequest()
        };
    }
}