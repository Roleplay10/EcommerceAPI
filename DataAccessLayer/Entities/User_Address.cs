namespace DataAccessLayer.Entities
{
    public class User_Address
    {
        public required Guid UserId { get; set; }
        public required Guid AddressId { get; set; }
        public required bool IsDefault { get; set; }
        

        public User User { get; set; }
        public Address Address { get; set; }
    }
}
