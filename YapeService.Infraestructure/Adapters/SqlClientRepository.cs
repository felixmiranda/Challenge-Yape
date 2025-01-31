using YapeService.Core.DTOs;
using YapeService.Core.Ports;

namespace YapeService.Infraestructure.Adapters;

public class SqlClientRepository : IClientRepository
{
    private readonly string _connectionString;

    public Task<CreateYapeClientResponse> CreateClient(CreateYapeClientRequest request)
    {
        throw new NotImplementedException();
    }
}
