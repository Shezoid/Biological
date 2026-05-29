using Application.Contracts.Rules.Operations;

namespace Application.Contracts.Rules;

public interface IRuleService
{
    CreateEnvironmentModifier.Response Create(
        CreateEnvironmentModifier.Request request);

    UpdateEnvironmentModifier.Response Update(
        UpdateEnvironmentModifier.Request request);

    DeleteEnvironmentModifier.Response Delete(
        DeleteEnvironmentModifier.Request request);

    GetEnvironmentModifierById.Response GetById(
        GetEnvironmentModifierById.Request request);

    GetEnvironmentModifiers.Response GetAll(
        GetEnvironmentModifiers.Request request);
}