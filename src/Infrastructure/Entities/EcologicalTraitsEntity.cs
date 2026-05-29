using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class EcologicalTraitsEntity
{
    [Key]
    public Guid Id { get; set; }

    public Guid PlantId { get; set; }

    public double PollutionTolerance { get; set; }

    public double DustCapture { get; set; }

    public double CO2Absorption { get; set; }

    public double GasAbsorption { get; set; }

    public double BiodiversitySupport { get; set; }

    public double PollinatorSupport { get; set; }

    public double FoodValue { get; set; }

    public double ShelterValue { get; set; }

    public PlantEntity Plant { get; set; } = null!;
}