using Application.Abstractions.Repositories;
using Domain.Models.Ahp;
using Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AhpWeightRepository(AppDbContext db) : IAhpWeightRepository
{
    public AhpWeight Add(AhpWeight entity)
    {
        var dbEntity = AhpMapper.ToEntity(entity);

        db.AhpWeights.Add(dbEntity);
        db.SaveChanges();

        return entity with { Id = dbEntity.Id };
    }

    public ICollection<AhpWeight> GetAll()
    {
        return db.AhpWeights
            .AsNoTracking()
            .Select(x => AhpMapper.ToDomain(x))
            .ToList();
    }

    public AhpWeight? GetById(Guid id)
    {
        var entity = db.AhpWeights
            .AsNoTracking()
            .FirstOrDefault(x => x.Id == id);

        return entity is null ? null : AhpMapper.ToDomain(entity);
    }
    public AhpWeight Update(AhpWeight entity)
    {
        var dbEntity = db.AhpWeights.First(x => x.Id == entity.Id);

        dbEntity.GoalType = entity.Goal;
        dbEntity.FactorName = entity.Factor;
        dbEntity.Weight = entity.Weight;

        db.SaveChanges();

        return entity;
    }

    public void Delete(Guid id)
    {
        var entity = db.AhpWeights.First(x => x.Id == id);

        db.AhpWeights.Remove(entity);

        db.SaveChanges();
    }
}