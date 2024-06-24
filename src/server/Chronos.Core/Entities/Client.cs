using System;

namespace Chronos.Core.Entities
{
    public class Client : TenantEntity<Guid>
    {
        public string Name { get; set; } = null!;
    }
}