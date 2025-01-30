using YapeService.Core.DTOs;

namespace YapeService.Core.Ports;

public interface IClientRepository
{
    Task<CreateYapeClientResponse> CreateClient(CreateYapeClientRequest request);
}
