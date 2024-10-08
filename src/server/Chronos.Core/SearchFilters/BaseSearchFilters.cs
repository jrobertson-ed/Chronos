namespace Chronos.Core.SearchFilters;

public abstract class BaseSearchFilters
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}