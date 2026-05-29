using Application.Abstractions.Repositories;
using Domain.Models.Ahp;
using Infrastructure.Mapping;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class RulesRepository(AppDbContext db) : IRulesRepository
{
    public EnvironmentModifier Add(EnvironmentModifier entity)
    {
        var dbEntity = EnvironmentModifierMapper.ToEntity(entity);

        db.EnvironmentModifiers.Add(dbEntity);
        db.SaveChanges();

        return entity with { Id = dbEntity.Id };
    }

    public ICollection<EnvironmentModifier> GetAll()
    {
        return db.EnvironmentModifiers
            .AsNoTracking()
            .Select(x => EnvironmentModifierMapper.ToDomain(x))
            .ToList();
    }

    public EnvironmentModifier? GetById(Guid id)
    {
        var entity = db.EnvironmentModifiers
            .AsNoTracking()
            .FirstOrDefault(x => x.Id == id);

        return entity is null
            ? null
            : EnvironmentModifierMapper.ToDomain(entity);
    }
    public EnvironmentModifier Update(EnvironmentModifier entity)
    {
        var dbEntity = db.EnvironmentModifiers.First(x => x.Id == entity.Id);

        dbEntity.ConditionType = entity.Condition;
        dbEntity.ConditionValue = entity.NumericValue;
        dbEntity.FactorName = entity.Factor;
        dbEntity.Modifier = entity.Modifier;

        db.SaveChanges();

        return entity;
    }

    public void Delete(Guid id)
    {
        var entity = db.EnvironmentModifiers.First(x => x.Id == id);

        db.EnvironmentModifiers.Remove(entity);

        db.SaveChanges();
    }
}