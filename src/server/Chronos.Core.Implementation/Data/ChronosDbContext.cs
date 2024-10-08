using Chronos.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Chronos.Core.Implementation.Data;

public class ChronosDbContext : DbContext
{
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<Client> Clients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<TenantEntity>().HasQueryFilter(x => x.TenantId == Guid.Empty);
    }
}