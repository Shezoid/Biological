using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class LeafTraitsEntity
{
    [Key]
    public Guid Id { get; set; }    
    
    public Guid PlantId { get; set; }
    
    public double LeafArea { get; set; }

    public double LeafThickness { get; set; }

    public double LeafOrientation { get; set; }

    public double LeafDensity { get; set; }

    public double SurfaceTexture { get; set; }

    public double Hairiness { get; set; }

    public double Wax { get; set; }

    public double StomataDensity { get; set; }

    public double WaterContent { get; set; }

    public double PhotosyntheticPlasticity { get; set; }

    public double LeafLightness { get; set; }

    public double Reflectivity { get; set; }

    public PlantEntity Plant { get; set; } = null!;
}