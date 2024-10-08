namespace Chronos.Core.Entities
{
    public class TimesheetEntry : TenantEntity
    {
        public required Guid ClientId { get; set; }
        public Client? Client { get; set; }
        public required DateTime DateTimeUtc { get; set; }
        public required int DurationSeconds { get; set; }
        public string? Comment { get; set; }
    }
}