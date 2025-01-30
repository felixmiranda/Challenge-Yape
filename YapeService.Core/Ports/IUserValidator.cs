namespace YapeService.Core.Ports;

public interface IUserValidator
{
    Task<bool> ValidateUser(string documentType, string documentNumber);
}
