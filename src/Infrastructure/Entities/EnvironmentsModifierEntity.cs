using System.ComponentModel.DataAnnotations;
using Application.Contracts.PlantScoring.Models;
using Domain.Models.Ahp;

namespace Infrastructure.Entities;

public class EnvironmentModifierEntity
{
    [Key]
    public Guid Id { get; set; }

    public ConditionType ConditionType { get; set; }

    public double ConditionValue { get; set; }

    public FactorType FactorName { get; set; }

    public double Modifier { get; set; }
}