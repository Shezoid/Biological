using Domain.Models.Plant;
using Infrastructure.Entities;

namespace Infrastructure.Mapping;

public static class LeafTraitsMapper
{
    public static LeafTraitsEntity ToEntity(LeafTraits model, Guid plantId)
    {
        return new LeafTraitsEntity
        {
            PlantId = plantId,
            LeafArea = model.Area,
            LeafThickness = model.Thickness,
            LeafOrientation = model.Orientation,
            LeafDensity = model.Density,
            SurfaceTexture = model.SurfaceTexture,
            Hairiness = model.Hairiness,
            Wax = model.Wax,
            StomataDensity = model.StomataDensity,
            WaterContent = model.WaterContent,
            PhotosyntheticPlasticity = model.PhotosyntheticPlasticity,
            LeafLightness = model.Lightness,
            Reflectivity = model.Reflectivity
        };
    }

    public static LeafTraits ToDomain(LeafTraitsEntity entity)
    {
        return new LeafTraits.Builder()
            .WithArea(entity.LeafArea)
            .WithThickness(entity.LeafThickness)
            .WithOrientation(entity.LeafOrientation)
            .WithDensity(entity.LeafDensity)
            .WithSurfaceTexture(entity.SurfaceTexture)
            .WithHairiness(entity.Hairiness)
            .WithWax(entity.Wax)
            .WithStomataDensity(entity.StomataDensity)
            .WithWaterContent(entity.WaterContent)
            .WithPhotosyntheticPlasticity(entity.PhotosyntheticPlasticity)
            .WithLightness(entity.LeafLightness)
            .WithReflectivity(entity.Reflectivity)
            .Build();
    }
}