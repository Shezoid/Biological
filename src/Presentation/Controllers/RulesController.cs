using Application.Contracts.Rules;
using Application.Contracts.Rules.Operations;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/rules")]
public class RulesController(IRuleService ruleService) : ControllerBase
{
    [HttpGet("GetAll")]
    public IActionResult GetAll()
    {
        var result = ruleService.GetAll(new GetEnvironmentModifiers.Request());

        return result switch
        {
            GetEnvironmentModifiers.Response.Success x => Ok(x.Dto),
            GetEnvironmentModifiers.Response.Failure x => BadRequest(x.Message),
            _ => BadRequest()
        };
    }

    [HttpGet("GetById")]
    public IActionResult GetById(Guid id)
    {
        var result = ruleService.GetById(new GetEnvironmentModifierById.Request(id));

        return result switch
        {
            GetEnvironmentModifierById.Response.Success x => Ok(x.Dto),
            GetEnvironmentModifierById.Response.Failure x => NotFound(x.Message),
            _ => BadRequest()
        };
    }

    [HttpPost("Create")]
    public IActionResult Create(
        [FromBody] CreateEnvironmentModifier.Request request)
    {
        var result = ruleService.Create(request);

        return result switch
        {
            CreateEnvironmentModifier.Response.Success x => Ok(x.Dto),
            CreateEnvironmentModifier.Response.Failure x => BadRequest(x.Message),
            _ => BadRequest()
        };
    }

    [HttpPut("Update")]
    public IActionResult Update(
        [FromBody] UpdateEnvironmentModifier.Request request)
    {
        var result = ruleService.Update(request);

        return result switch
        {
            UpdateEnvironmentModifier.Response.Success x => Ok(x.Dto),
            UpdateEnvironmentModifier.Response.Failure x => BadRequest(x.Message),
            _ => BadRequest()
        };
    }

    [HttpDelete("Delete")]
    public IActionResult Delete(Guid id)
    {
        var result = ruleService.Delete(new DeleteEnvironmentModifier.Request(id));

        return result switch
        {
            DeleteEnvironmentModifier.Response.Success => NoContent(),
            DeleteEnvironmentModifier.Response.Failure x => NotFound(x.Message),
            _ => BadRequest()
        };
    }
}