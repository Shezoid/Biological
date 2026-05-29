using Application.Contracts.Ahp;
using Application.Contracts.Ahp.Operations;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/ahp")]
public class AhpController(IAhpService service) : ControllerBase
{
    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var result = service.GetAhpWeights(new GetAhpWeights.Request());

        return result switch
        {
            GetAhpWeights.Response.Success x => Ok(x.Dto),
            GetAhpWeights.Response.Failure x => BadRequest(x.Message),
            _ => BadRequest()
        };
    }

    [HttpGet("GetById")]
    public IActionResult GetById(Guid id)
    {
        var result = service.GetById(new GetAhpWeightById.Request(id));
        
        return result switch
        {
            GetAhpWeightById.Response.Success x => Ok(x.Dto),
            GetAhpWeightById.Response.Failure x => NotFound(x.Message),
            _ => BadRequest()
        };
    }

    [HttpPost("Create")]
    public IActionResult Create([FromBody] CreateAhpWeight.Request request)
    {
        var result = service.Create(request);

        return result switch
        {
            CreateAhpWeight.Response.Success x => Ok(x.Dto),
            CreateAhpWeight.Response.Failure x => BadRequest(x.Message),
            _ => BadRequest()
        };
    }

    [HttpPut("Update")]
    public IActionResult Update([FromBody] UpdateAhpWeight.Request request)
    {
        var result = service.Update(request);

        return result switch
        {
            UpdateAhpWeight.Response.Success x => Ok(x.Dto),
            UpdateAhpWeight.Response.Failure x => BadRequest(x.Message),
            _ => BadRequest()
        };
    }

    [HttpDelete("Delete")]
    public IActionResult Delete(Guid id)
    {
        var result = service.Delete(new DeleteAhpWeight.Request(id));

        return result switch
        {
            DeleteAhpWeight.Response.Success => NoContent(),
            DeleteAhpWeight.Response.Failure x => NotFound(x.Message),
            _ => BadRequest()
        };
    }
}