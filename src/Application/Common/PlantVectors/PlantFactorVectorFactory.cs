using Application.Common.Normalization;
using Application.Contracts.PlantScoring.Models;
using Domain.Models.Ahp;
using Domain.Models.Plant;

namespace Application.Common.PlantVectors;

public class PlantFactorVectorFactory(INormalizer normalization) : IPlantFactorVectorFactory
{
    private const double MinStomataDensity = 50;
    private const double MaxStomataDensity = 1000;

    private const double MinCoverage = 0;
    private const double MaxCoverage = 30;

    private const double MinCO2 = 0;
    private const double MaxCO2 = 100;
    
    private const double MinDustCapture = 0;
    private const double MaxDustCapture = 500;

    public PlantFactorVector Create(Plant plant)
    {
        return new PlantFactorVector(
            new Dictionary<FactorType, double>
            {
                [FactorType.Transpiration] =
                    normalization.Normalize(
                        plant.Leaf.StomataDensity,
                        MinStomataDensity,
                        MaxStomataDensity),

                [FactorType.SolarAbsorption] =
                    plant.Leaf.PhotosyntheticPlasticity,

                [FactorType.Reflectivity] =
                    normalization.Normalize(
                        plant.Leaf.Reflectivity,
                        0,
                        100),

                [FactorType.Shading] =
                    normalization.Normalize(
                        plant.Crown.CoverageDegree,
                        MinCoverage,
                        MaxCoverage),

                [FactorType.ContinuousGreenCoverage] =
                    normalization.Normalize(
                        plant.Crown.GreenMass,
                        0,
                        100),

                [FactorType.WaterAbsorption] =
                    normalization.Normalize(
                        plant.Root.WaterAbsorption,
                        0,
                        100),

                [FactorType.WaterStorage] =
                    normalization.Normalize(
                        plant.Root.WaterStorage,
                        0,
                        100),

                [FactorType.PhytoExtraction] =
                    normalization.Normalize(
                        plant.Root.PhytoExtraction,
                        0,
                        100),

                [FactorType.PhytoStimulation] =
                    normalization.Normalize(
                        plant.Root.PhytoStimulation,
                        0,
                        100),

                [FactorType.CO2Absorption] =
                    normalization.Normalize(
                        plant.Ecology.CO2Absorption,
                        MinCO2,
                        MaxCO2),

                [FactorType.DustCapture] =
                    normalization.Normalize(
                        plant.Root.WaterStorage,
                        MinDustCapture,
                        MaxDustCapture),

                [FactorType.HabitatSupport] =
                    normalization.Normalize(
                        plant.Ecology.BiodiversitySupport,
                        0,
                        100),

                [FactorType.Thermoregulation] =
                    normalization.Normalize(
                        plant.Climate.ShadeTolerance,
                        100,
                        0),

                [FactorType.HumidityIncrease] =
                    normalization.Normalize(
                        (plant.Leaf.StomataDensity + plant.Root.WaterStorage) / 2.0,
                        MinStomataDensity,
                        MaxStomataDensity),

                [FactorType.Socialization] =
                    plant.Crown.Density * 0.8,

                [FactorType.Functionality] =
                    normalization.Normalize(
                        (plant.Ecology.CO2Absorption + plant.Ecology.DustCapture) / 2.0,
                        MinCO2,
                        MaxCO2)
                ,
                [FactorType.NoiseReduction] =
                    normalization.Normalize(
                        plant.Crown.Density,
                        0,
                        100),
            });
    }
}