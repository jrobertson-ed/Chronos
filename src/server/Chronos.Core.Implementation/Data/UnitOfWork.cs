using Chronos.Core.Data;
using Chronos.Core.Entities;

namespace Chronos.Core.Implementation.Data;

public class UnitOfWork(ChronosDbContext dbContext) : IUnitOfWork
{
    public void Add<TEntity>(TEntity entity) where TEntity : BaseEntity
    {
        dbContext.Add(entity);
    }

    public void Update<TEntity>(TEntity entity) where TEntity : BaseEntity
    {
        entity.ModifiedDateUtc = DateTime.UtcNow;
        dbContext.Update(entity);
    }

    public void Delete<TEntity>(TEntity entity) where TEntity : BaseEntity
    {
        dbContext.Remove(entity);
    }

    public async Task FlushAsync()
    {
        await dbContext.SaveChangesAsync();
    }

    public async Task CommitAsync()
    {
        await FlushAsync();
    }
}