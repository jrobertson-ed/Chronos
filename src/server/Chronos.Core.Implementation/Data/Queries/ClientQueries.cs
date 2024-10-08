using Chronos.Core.Data.Queries;
using Chronos.Core.Entities;
using Chronos.Core.Implementation.Extensions;
using Chronos.Core.Results;
using Chronos.Core.SearchFilters;
using Microsoft.EntityFrameworkCore;

namespace Chronos.Core.Implementation.Data.Queries;

public class ClientQueries(ChronosDbContext context) : IClientQueries
{
    public async Task<Result<Client>> GetClientAsync(Guid id)
    {
        var client = await context.Clients.FindAsync(id);
        if (client == null)
        {
            return new NotFoundError($"Client with id {id} not found.");
        }

        return client;
    }

    public async Task<Result<SearchResult<Client>>> GetClientsAsync(ClientSearchFilters searchFilters)
    {
        var query = context.Clients.AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchFilters.Name))
        {
            query = query.Where(c => c.Name.Contains(searchFilters.Name));
        }
        
        return new SearchResult<Client>
        {
            Results = await query.ToPagedListAsync(searchFilters),
            TotalRecords = await context.Clients.CountAsync(),
            PageNumber = searchFilters.PageNumber,
            PageSize = searchFilters.PageSize
        };
    }
}