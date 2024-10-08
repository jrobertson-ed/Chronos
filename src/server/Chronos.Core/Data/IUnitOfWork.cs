using Chronos.Core.Entities;

namespace Chronos.Core.Data;

public interface IUnitOfWork
{
    void Add<TEntity>(TEntity entity) where TEntity : BaseEntity;
    void Update<TEntity>(TEntity entity) where TEntity : BaseEntity;
    void Delete<TEntity>(TEntity entity) where TEntity : BaseEntity;
    Task FlushAsync();
    Task CommitAsync();
}