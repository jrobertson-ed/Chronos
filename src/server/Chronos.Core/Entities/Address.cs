namespace Chronos.Core.Entities
{
    public class Address
    {
        public required string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public required string City { get; set; }
        public string? County { get; set; }
        public required string Country { get; set; }
        public required string PostalCode { get; set; }
    }
}