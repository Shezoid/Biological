using System.ComponentModel.DataAnnotations;
using Domain.Models.Ahp;

namespace Infrastructure.Entities;

public class AhpWeightEntity
{
    [Key]
    public Guid Id { get; set; }

    public GoalType GoalType { get; set; }

    public FactorType FactorName { get; set; }

    public double Weight { get; set; }
}