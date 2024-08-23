namespace DataAccessLayer.Entities
{
    public class OrderStatus
    {
        public required Guid Id { get; set; }
        public required string Status { get; set; }
    }
}
