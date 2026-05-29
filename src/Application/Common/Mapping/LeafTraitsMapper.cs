

using Application.Contracts.Plant.Models;
using Domain.Models.Plant;

namespace Application.Common.Mapping;

public static class LeafTraitsMapper
{ 
    public static LeafTraits ToDomain(LeafTraitDto dto)
    {
        return new LeafTraits.Builder()
            .WithArea(dto.Area)
            .WithThickness(dto.Thickness)
            .WithOrientation(dto.Orientation)
            .WithDensity(dto.Density)
            .WithSurfaceTexture(dto.SurfaceTexture)
            .WithHairiness(dto.Hairiness)
            .WithWax(dto.Wax)
            .WithStomataDensity(dto.StomataDensity)
            .WithWaterContent(dto.WaterContent)
            .WithPhotosyntheticPlasticity(dto.PhotosyntheticPlasticity)
            .WithLightness(dto.Lightness)
            .WithReflectivity(dto.Reflectivity)
            .Build();
    }

    public static LeafTraitDto ToDto(LeafTraits model)
    {
        return new LeafTraitDto(
            model.Area,
            model.Thickness,
            model.Orientation,
            model.Density,
            model.SurfaceTexture,
            model.Hairiness,
            model.Wax,
            model.StomataDensity,
            model.WaterContent,
            model.PhotosyntheticPlasticity,
            model.Lightness,
            model.Reflectivity
        );
    }
}