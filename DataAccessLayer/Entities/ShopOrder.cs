namespace DataAccessLayer.Entities
{
    public class ShopOrder
    {
        public required Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public required DateTime OrderDate { get; set; }
        public required Guid PaymentMethodId { get; set; }
        public required Guid ShippingAddressId { get; set; }
        public required Guid ShippingMethodId { get; set; }
        public required float OrderTotal { get; set; }
        public required Guid OrderStatusId { get; set; }


        public required User User { get; set; }
    }
}
