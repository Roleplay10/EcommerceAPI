namespace DataAccessLayer.Entities
{
    public class ShoppingCartItem
    {
        public required Guid Id { get; set; }
        public required Guid CartId { get; set; }
        public required Guid ProductItemId { get; set; }
        public required int QTY { get; set; }
    }
}
