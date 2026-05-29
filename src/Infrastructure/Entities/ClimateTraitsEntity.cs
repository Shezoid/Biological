using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class ClimateTraitsEntity
{
    [Key]
    public Guid Id { get; set; }    
    
    public Guid PlantId { get; set; }
    
    public double HumidityAdaptation { get; set; }
    
    public double ShadeTolerance { get; set; }

    public double LightRequirement { get; set; }
    
    public PlantEntity Plant { get; set; } = null!;
}