using Application.Contracts.PlantScoring.Models;
using Domain.Models.Ahp;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<PlantEntity> Plants => Set<PlantEntity>();
    public DbSet<LeafTraitsEntity> LeafTraits => Set<LeafTraitsEntity>();
    public DbSet<CrownTraitsEntity> CrownTraits => Set<CrownTraitsEntity>();
    public DbSet<RootTraitsEntity> RootTraits => Set<RootTraitsEntity>();
    public DbSet<EcologicalTraitsEntity> EcologicalTraits => Set<EcologicalTraitsEntity>();
    public DbSet<ClimateTraitsEntity> ClimateTraits => Set<ClimateTraitsEntity>();

    public DbSet<AhpWeightEntity> AhpWeights => Set<AhpWeightEntity>();
    public DbSet<EnvironmentModifierEntity> EnvironmentModifiers => Set<EnvironmentModifierEntity>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<AhpWeightEntity>()
            .Property(x => x.GoalType)
            .HasConversion<int>();

        modelBuilder.Entity<AhpWeightEntity>()
            .Property(x => x.FactorName)
            .HasConversion<int>();
        
        modelBuilder.Entity<EnvironmentModifierEntity>()
            .Property(x => x.ConditionType)
            .HasConversion<int>();
        
        modelBuilder.Entity<PlantEntity>()
            .HasOne(p => p.Climate)
            .WithOne(c => c.Plant)
            .HasForeignKey<ClimateTraitsEntity>(c => c.PlantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PlantEntity>()
            .HasOne(p => p.Crown)
            .WithOne(c => c.Plant)
            .HasForeignKey<CrownTraitsEntity>(c => c.PlantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PlantEntity>()
            .HasOne(p => p.Root)
            .WithOne(r => r.Plant)
            .HasForeignKey<RootTraitsEntity>(r => r.PlantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PlantEntity>()
            .HasOne(p => p.Ecology)
            .WithOne(e => e.Plant)
            .HasForeignKey<EcologicalTraitsEntity>(e => e.PlantId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PlantEntity>()
            .HasOne(p => p.Leaf)
            .WithOne(l => l.Plant)
            .HasForeignKey<LeafTraitsEntity>(l => l.PlantId)
            .OnDelete(DeleteBehavior.Cascade);
    }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Database=bio_db;Username=admin;Password=admin");
        }
    }
}