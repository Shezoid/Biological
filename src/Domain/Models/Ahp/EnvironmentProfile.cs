using SourceKit.Generators.Builder.Annotations;

namespace Domain.Models.Ahp;

[GenerateBuilder]
public partial record EnvironmentProfile(
    [RequiredValue] WallOrientation Wall,
    [RequiredValue] double Humidity,
    [RequiredValue] double Temperature,
    [RequiredValue] double WindSpeed,
    [RequiredValue] PollutionLevel Pollution,
    [RequiredValue] GoalType Goal) { }