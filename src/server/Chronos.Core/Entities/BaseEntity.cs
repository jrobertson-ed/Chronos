namespace Chronos.Core.Entities
{
    public abstract class BaseEntity
    {
        public required Guid Id { get; set; }
        public DateTime CreatedDateUtc { get; set; } = DateTime.UtcNow;
        public DateTime ModifiedDateUtc { get; set; } = DateTime.UtcNow;
    }
}