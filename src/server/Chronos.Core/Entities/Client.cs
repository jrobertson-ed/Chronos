namespace Chronos.Core.Entities
{
    public class Client : TenantEntity
    {
        public required string Name { get; set; }
        public required Address Address { get; set; }
    }
}