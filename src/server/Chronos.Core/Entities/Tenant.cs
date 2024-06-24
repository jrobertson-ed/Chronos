using System;

namespace Chronos.Core.Entities
{
    public class Tenant : BaseEntity<Guid>
    {
        public string Name { get; set; } = null!;
    }
}