using System;

namespace Chronos.Core.Entities
{
    public class TimesheetEntry : TenantEntity<Guid>
    {
        public Guid ClientId { get; set; }
        public Client? Client { get; set; }
    }
}