using System.CodeDom.Compiler;
using SourceKit.Generators.Builder.Annotations;

namespace Domain.Models.Ahp;

[GenerateBuilder]
public partial record AhpWeight(
    Guid Id,
    [RequiredValue] string Indicator,
    [RequiredValue] string Factor,
    [RequiredValue] double Weight)
{
}