namespace DataAccessLayer.Entities
{
    public class ShippingMethod
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required float Price { get; set; }
    }
}
