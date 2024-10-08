using Chronos.Core.SearchFilters;
using Microsoft.EntityFrameworkCore;

namespace Chronos.Core.Implementation.Extensions;

public static class QueryableExtensions
{
    public static async Task<IEnumerable<TEntity>> ToPagedListAsync<TEntity>(this IQueryable<TEntity> queryable, BaseSearchFilters searchFilters)
    {
        return await queryable
            .Skip((searchFilters.PageNumber - 1) * searchFilters.PageSize)
            .Take(searchFilters.PageSize)
            .ToListAsync();
    }
}