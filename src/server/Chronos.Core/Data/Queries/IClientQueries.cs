using Chronos.Core.Entities;
using Chronos.Core.Results;
using Chronos.Core.SearchFilters;

namespace Chronos.Core.Data.Queries;

public interface IClientQueries
{
    Task<Result<Client>> GetClientAsync(Guid id);
    Task<Result<SearchResult<Client>>> GetClientsAsync(ClientSearchFilters searchFilters);
}