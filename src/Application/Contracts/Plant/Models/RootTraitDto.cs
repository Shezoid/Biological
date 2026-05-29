namespace Application.Contracts.Plant.Models;

public record RootTraitDto(
    double Depth,
    double Branching,
    double SurfaceArea,
    double RhizosphereActivity,
    double WaterAbsorption,
    double WaterStorage,
    double PhytoExtraction,
    double PhytoStimulation);