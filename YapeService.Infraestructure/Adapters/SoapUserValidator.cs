using YapeService.Core.Ports;

namespace YapeService.Infraestructure.Adapters;

public class SoapUserValidator : IUserValidator
{
    //private readonly IPersonService
    public Task<bool> ValidateUser(string documentType, string documentNumber)
    {
        var request = new PersonRequest
    }
}
