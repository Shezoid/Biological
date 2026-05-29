using Domain.Models.Ahp;
using SourceKit.Generators.Builder.Annotations;

namespace Application.Contracts.PlantScoring.Models;

[GenerateBuilder]
public partial record EnvironmentProfile(
    [RequiredValue] GoalType Goal,
    
    [RequiredValue] double Wall,
    
    [RequiredValue] double Pollution,
    
    [RequiredValue] double Humidity,
    
    [RequiredValue] double Temperature,
    
    [RequiredValue] double Wind);