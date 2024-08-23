namespace DataAccessLayer.Entities
{
    public class Address
    {
        public required Guid Id { get; set; }
        public string UnitNumber { get; set; }
        public string StreetNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public required Guid CountryId { get; set; }

        public ICollection<User_Address> User_Addresses { get; set; }
        public Country Country { get; set; }
    }
}
