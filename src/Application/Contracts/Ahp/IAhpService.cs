using Application.Contracts.Ahp.Operations;

namespace Application.Contracts.Ahp;

public interface IAhpService
{
    CreateAhpWeight.Response Create(CreateAhpWeight.Request request);

    DeleteAhpWeight.Response Delete(DeleteAhpWeight.Request request);

    GetAhpWeightById.Response GetById(GetAhpWeightById.Request request);
    
    GetAhpWeights.Response GetAhpWeights(GetAhpWeights.Request request);
    
    UpdateAhpWeight.Response Update(UpdateAhpWeight.Request request);    
}