using Chronos.Core.Entities;

namespace Chronos.Core.Results;

public class SearchResult<TEntity> where TEntity : TenantEntity
{
    public IEnumerable<TEntity> Results { get; set; } = new List<TEntity>();
    public int TotalRecords { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}