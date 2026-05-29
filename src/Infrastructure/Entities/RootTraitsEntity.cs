using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class RootTraitsEntity
{
    [Key]
    public Guid Id { get; set; }    
    
    public Guid PlantId { get; set; }

    public double RootDepth { get; set; }

    public double RootBranching { get; set; }

    public double RootSurfaceArea { get; set; }

    public double RhizosphereActivity { get; set; }

    public double WaterAbsorption { get; set; }

    public double WaterStorage { get; set; }

    public double Phytoextraction { get; set; }

    public double Phytostimulation { get; set; } 

    public PlantEntity Plant { get; set; } = null!;
}