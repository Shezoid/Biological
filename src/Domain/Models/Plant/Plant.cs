using SourceKit.Generators.Builder.Annotations;

namespace Domain.Models.Plant;

[GenerateBuilder]
public partial record Plant(
    [RequiredValue] Guid Id,
    [RequiredValue] string NameRu,
    [RequiredValue] string NameLatin,
    [RequiredValue] PlantType Type,
    [RequiredValue] double HeightMax,
    [RequiredValue] double GrowthRate,
    [RequiredValue] int Lifespan,
    [RequiredValue] LeafTraits Leaf,
    [RequiredValue] CrownTraits Crown,
    [RequiredValue] RootTraits Root,
    [RequiredValue] EcologicalTraits Ecology,
    [RequiredValue] ClimateTraits Climate)
{
}