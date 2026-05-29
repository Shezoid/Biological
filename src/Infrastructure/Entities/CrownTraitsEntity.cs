using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class CrownTraitsEntity
{
    [Key]
    public Guid Id { get; set; }    
    
    public Guid PlantId { get; set; }

    public double CrownDensity { get; set; }

    public double CoverageDegree { get; set; }

    public double Multilayer { get; set; }

    public double GreenMass { get; set; }

    public double Branching { get; set; }

    public PlantEntity Plant { get; set; } = null!;
}