using Domain.Models.Plant;

namespace Application.Contracts.Plant.Models;

public record PlantDto(
    Guid Id,
    string NameRu,
    string NameLatin,
    double HeightMax,
    double GrowthRate,
    int Lifespan,
    LeafTraitDto Leaf,
    CrownTraitDto Crown,
    RootTraitDto Root,
    EcologicalTraitDto Ecology,
    ClimateTraitDto Climate );