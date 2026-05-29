using Application.Contracts.PlantScoring.Models;
using Domain.Models.Plant;

namespace Application.Common.PlantVectors;

public interface IPlantFactorVectorFactory
{
    PlantFactorVector Create(Plant plant);
}