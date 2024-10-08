using System;

namespace Chronos.Core.Entities
{
    public class Tenant : BaseEntity
    {
        public string Name { get; set; } = null!;
    }
}