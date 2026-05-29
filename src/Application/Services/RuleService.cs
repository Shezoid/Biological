using Application.Abstractions.Repositories;
using Application.Common.Mapping;
using Application.Contracts.Rules;
using Application.Contracts.Rules.Operations;
using Domain.Models.Ahp;

namespace Application.Services;

public class RuleService(IRulesRepository repository) : IRuleService
{
    public CreateEnvironmentModifier.Response Create(CreateEnvironmentModifier.Request request)
    {
        EnvironmentModifier rule = new EnvironmentModifier.Builder()
            .WithCondition(request.Condition)
            .WithNumericValue(request.Value)
            .WithFactor(request.Factor)
            .WithModifier(request.Modifier)
            .Build();

        var created =
            repository.Add(rule);

        return new CreateEnvironmentModifier.Response.Success(EnvironmentModifierMapper.ToDto(created));
    }

    public UpdateEnvironmentModifier.Response Update(UpdateEnvironmentModifier.Request request)
    {
        var existing =
            repository.GetById(request.Id);

        if (existing is null)
            return new UpdateEnvironmentModifier.Response.Failure("Rule not found");

        var updated = new EnvironmentModifier.Builder()
            .WithNumericValue(request.Value)
            .WithFactor(request.Factor)
            .WithModifier(request.Modifier)
            .WithId(request.Id)
            .WithCondition(request.Condition)
            .Build();

        var saved = repository.Update(updated);

        return new UpdateEnvironmentModifier.Response.Success(EnvironmentModifierMapper.ToDto(saved));
    }

    public DeleteEnvironmentModifier.Response Delete(DeleteEnvironmentModifier.Request request)
    {
        var existing = repository.GetById(request.Id);

        if (existing is null)
            return new DeleteEnvironmentModifier.Response.Failure("Rule not found");

        repository.Delete(request.Id);

        return new DeleteEnvironmentModifier.Response.Success();
    }

    public GetEnvironmentModifierById.Response GetById(GetEnvironmentModifierById.Request request)
    {
        var rule =
            repository.GetById(request.Id);

        if (rule is null)
            return new GetEnvironmentModifierById.Response.Failure("Rule not found");

        return new GetEnvironmentModifierById.Response.Success(EnvironmentModifierMapper.ToDto(rule));
    }

    public GetEnvironmentModifiers.Response GetAll(
        GetEnvironmentModifiers.Request request)
    {
        var rules = repository.GetAll();

        return new GetEnvironmentModifiers.Response.Success(
            rules.Select(EnvironmentModifierMapper.ToDto).ToList());
    }
}