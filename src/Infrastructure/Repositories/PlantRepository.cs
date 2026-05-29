using Application.Abstractions.Repositories;
using Domain.Models.Plant;
using Infrastructure.Entities;
using Infrastructure.Mapping;

namespace Infrastructure.Repositories;

public class PlantRepository(AppDbContext db) : IPlantRepository
{
    public Plant Add(Plant entity)
    {
        var result = InsertAggregate(entity, null);

        db.SaveChanges();

        return PlantMapper.ToDomain(result);
    }

    public Plant? GetById(Guid id)
    {
        var plantEntity = db.Plants.FirstOrDefault(x => x.Id.Equals(id));
        if (plantEntity is null)
            return null;

        var leafEntity = db.LeafTraits.First(x => x.PlantId.Equals(id));
        var crownEntity = db.CrownTraits.First(x => x.PlantId.Equals(id));
        var rootEntity = db.RootTraits.First(x => x.PlantId.Equals(id));
        var ecologyEntity = db.EcologicalTraits.First(x => x.PlantId.Equals(id));
        var climateEntity = db.ClimateTraits.First(x => x.PlantId.Equals(id));

        return PlantMapper.ToDomain(
            plantEntity,
            leafEntity,
            crownEntity,
            rootEntity,
            ecologyEntity,
            climateEntity
        );
    }

    public ICollection<Plant> GetAll()
    {
        var plants = db.Plants.ToList();
        var leafs = db.LeafTraits.ToList();
        var crowns = db.CrownTraits.ToList();
        var roots = db.RootTraits.ToList();
        var ecologies = db.EcologicalTraits.ToList();
        var climates = db.ClimateTraits.ToList();

        return plants
            .Select(plant =>
            {
                var leaf = leafs.First(x => x.PlantId.Equals(plant.Id));
                var crown = crowns.First(x => x.PlantId.Equals(plant.Id));
                var root = roots.First(x => x.PlantId.Equals(plant.Id));
                var ecology = ecologies.First(x => x.PlantId.Equals(plant.Id));
                var climate = climates.First(x => x.PlantId.Equals(plant.Id));

                return PlantMapper.ToDomain(
                    plant,
                    leaf,
                    crown,
                    root,
                    ecology,
                    climate);
            })
            .ToList();
    }

    public Plant Update(Plant entity)
    {
        var plant = db.Plants.First(x => x.Id.Equals(entity.Id));
        db.Plants.Remove(plant);

        db.SaveChanges();
        InsertAggregate(entity, entity.Id);

        db.SaveChanges();
        return entity;
    }

    public void Delete(Guid id)
    {
        var plant = db.Plants.FirstOrDefault(x => x.Id.Equals(id));

        if (plant is null)
            return;

        db.Plants.Remove(plant);
        db.SaveChanges();
    }

    private PlantEntity InsertAggregate(Plant entity, Guid? plantId)
    {
        var plantEntity = PlantMapper.ToEntity(entity);
        if (plantId is not null)
            plantEntity.Id = plantId.Value;

        db.Plants.Add(plantEntity);
        
        var leaf = db.LeafTraits.Add(LeafTraitsMapper.ToEntity(entity.Leaf, plantEntity.Id));
        var crown = db.CrownTraits.Add(CrownTraitsMapper.ToEntity(entity.Crown, plantEntity.Id));
        var root = db.RootTraits.Add(RootTraitsMapper.ToEntity(entity.Root, plantEntity.Id));
        var ecology = db.EcologicalTraits.Add(EcologicalTraitsMapper.ToEntity(entity.Ecology, plantEntity.Id));
        var climate = db.ClimateTraits.Add(ClimateTraitsMapper.ToEntity(entity.Climate, plantEntity.Id));

        plantEntity.Leaf =  leaf.Entity;
        plantEntity.Crown =  crown.Entity;
        plantEntity.Root =  root.Entity;
        plantEntity.Ecology =  ecology.Entity;
        plantEntity.Climate =  climate.Entity;
        
        return plantEntity;
    }
}