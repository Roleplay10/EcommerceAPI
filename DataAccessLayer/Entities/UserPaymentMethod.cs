namespace DataAccessLayer.Entities
{
    public class UserPaymentMethod
    {
        public required Guid Id { get; set; }
        public required Guid UserId { get; set; }
        //public required Guid PaymentTypeId { get; set; }
        //public required string Provider {  get; set; }
        public required string AccountNumber { get; set; }
        public required DateTime ExpiryDate { get; set; }
        public required bool IsDefault { get; set; }

        public User User { get; set; }
    }
}
