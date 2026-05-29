using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class PlantEntity
{
    [Key]
    public Guid Id { get; set; }

    public string NameRu { get; set; } = null!;

    public string NameLatin { get; set; } = null!;
    
    public double HeightMax { get; set; }

    public double GrowthRate { get; set; }

    public int Lifespan { get; set; }

    public DateTime CreatedAt { get; set; }

    public LeafTraitsEntity Leaf { get; set; } = null!;

    public CrownTraitsEntity Crown { get; set; } = null!;

    public RootTraitsEntity Root { get; set; } = null!;

    public EcologicalTraitsEntity Ecology { get; set; } = null!;

    public ClimateTraitsEntity Climate { get; set; } = null!;
}