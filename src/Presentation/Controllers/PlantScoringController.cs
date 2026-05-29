using Application.Contracts.PlantScoring;
using Application.Contracts.PlantScoring.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

[ApiController]
[Route("api/scoring")]
public class PlantScoringController(IPlantScoringService service) : ControllerBase
{
    [HttpPost("Calculate")]
    public IActionResult Calculate([FromBody] EnvironmentProfile profile)
    {
        var result = service.GetBestPlants(profile);

        return Ok(result);
    }
}