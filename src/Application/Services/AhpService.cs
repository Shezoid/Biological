using Application.Abstractions.Repositories;
using Application.Common.Mapping;
using Application.Contracts.Ahp;
using Application.Contracts.Ahp.Operations;
using Domain.Models.Ahp;

namespace Application.Services;

public class AhpService(IAhpWeightRepository repository) : IAhpService
{
    public CreateAhpWeight.Response Create(CreateAhpWeight.Request request)
    {
        AhpWeight weight = new AhpWeight.Builder()
            .WithGoal(request.Goal)
            .WithFactor(request.Factor)
            .WithWeight(request.Weight)
            .Build();

        weight = repository.Add(weight);

        return new CreateAhpWeight.Response.Success(AhpMapper.ToDto(weight));
    }

    public DeleteAhpWeight.Response Delete(DeleteAhpWeight.Request request)
    {
        var existing = repository.GetById(request.Id);

        if (existing is null)
            return new DeleteAhpWeight.Response.Failure("AHP weight not found");

        repository.Delete(request.Id);

        return new DeleteAhpWeight.Response.Success();
    }

    public GetAhpWeightById.Response GetById(GetAhpWeightById.Request request)
    {
        var model = repository.GetById(request.Id);

        if (model is null)
            return new GetAhpWeightById.Response.Failure("AHP weight not found");


        return new GetAhpWeightById.Response.Success(AhpMapper.ToDto(model));
    }

    public GetAhpWeights.Response GetAhpWeights(GetAhpWeights.Request request)
    {
        var models = repository.GetAll();

        return new GetAhpWeights.Response.Success(
            models
                .Select(AhpMapper.ToDto)
                .ToList());
    }

    public UpdateAhpWeight.Response Update(UpdateAhpWeight.Request request)
    {
        var existing = repository.GetById(request.Id);

        if (existing is null)
            return new UpdateAhpWeight.Response.Failure("AHP weight not found");

        var updated = new AhpWeight.Builder()
            .WithGoal(request.Goal)
            .WithFactor(request.Factor)
            .WithWeight(request.Weight)
            .WithId(request.Id)
            .Build();

        updated = repository.Update(updated);

        return new UpdateAhpWeight.Response.Success(AhpMapper.ToDto(updated));
    }
}