namespace DataAccessLayer.Entities
{
    public class ShoppingCart
    {
        public required Guid Id { get; set; }
        public required Guid UserId { get; set; }

        public User User { get; set; }
    }
}
