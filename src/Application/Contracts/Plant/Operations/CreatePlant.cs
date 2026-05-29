using Application.Contracts.Plant.Models;
using Domain.Models.Plant;

namespace Application.Contracts.Plant.Operations;

public abstract class CreatePlant
{
    public readonly record struct Request(
        string NameRu,
        string NameLatin,
        double HeightMax,
        double GrowthRate,
        int Lifespan,
        LeafTraitDto Leaf,
        CrownTraitDto Crown,
        RootTraitDto Root,
        EcologicalTraitDto Ecology,
        ClimateTraitDto Climate);

    public abstract record Response
    {
        private Response() { }

        public sealed record Success(PlantDto Dto) : Response;

        public sealed record Failure(string Message) : Response;
    }
}