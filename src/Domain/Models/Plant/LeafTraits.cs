using SourceKit.Generators.Builder.Annotations;

namespace Domain.Models.Plant;

[GenerateBuilder]
public partial record LeafTraits(
    [RequiredValue] double Area,
    [RequiredValue] double Thickness,
    [RequiredValue] double Orientation,
    [RequiredValue] double Density,
    [RequiredValue] double SurfaceTexture,
    [RequiredValue] double Hairiness,
    [RequiredValue] double Wax,
    [RequiredValue] double StomataDensity,
    [RequiredValue] double WaterContent,
    [RequiredValue] double PhotosyntheticPlasticity,
    [RequiredValue] double Reflectivity,
    [RequiredValue] double Lightness);