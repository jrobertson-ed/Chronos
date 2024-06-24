using System;

namespace Chronos.Core.Entities
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; } = default!;
        public Guid CreatedById { get; set; }
        public DateTime CreatedDateUtc { get; set; } = DateTime.UtcNow;
        public Guid ModifiedById { get; set; }
        public DateTime ModifiedDateUtc { get; set; } = DateTime.UtcNow;
    }
}