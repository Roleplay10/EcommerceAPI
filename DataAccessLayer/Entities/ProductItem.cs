namespace DataAccessLayer.Entities
{
    public class ProductItem
    {
        public required Guid Id { get; set; }
        public required Guid ProductId { get; set; }
        public required int SKU { get; set; }
        public required int QTYInStock { get; set; }
        public required string ProductImagePath { get; set; }
        public required float Price { get; set; }
    }
}
