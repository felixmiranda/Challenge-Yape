using YapeService.Core.DTOs;
using YapeService.Core.Ports;

namespace YapeService.Core.Services;

public class YapeService
{
    private readonly IUserValidator _userValidator;
    private readonly IClientRepository _clientRepository;

    public YapeService(IUserValidator userValidator, IClientRepository clientRepository)
    {
        _userValidator = userValidator;
        _clientRepository = clientRepository;
    }

    public async Task<CreateYapeClientResponse> CreateClient(CreateYapeClientRequest request)
    {
        // Validar el usuario
        var isValid = await _userValidator.ValidateUser(request.DocumentType, request.DocumentNumber);
        if (!isValid)
        {
            throw new InvalidOperationException("Invalid DocumentType or DocumentNumber");
        }

        // Registrar el cliente
        return await _clientRepository.CreateClient(request);
    }
}
