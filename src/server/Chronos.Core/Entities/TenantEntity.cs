using System;

namespace Chronos.Core.Entities
{
    public abstract class TenantEntity<TId> : BaseEntity<TId>
    {
        public Guid TenantId { get; set; }
        public Tenant? Tenant { get; set; }
    }
}