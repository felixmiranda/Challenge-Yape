using YapeService.Core.Ports;

namespace YapeService.Infraestructure.Adapters;

public class SoapUserValidator : IUserValidator
{
    //private readonly IPersonService
    public Task<bool> ValidateUser(string documentType, string documentNumber)
    {
        throw new NotImplementedException();
    }
}
