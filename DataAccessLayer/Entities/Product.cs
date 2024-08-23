namespace DataAccessLayer.Entities
{
    public class Product
    {
        public required Guid Id { get; set; }
        public required Guid CategoryId { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ProductImagePath { get; set; }

        public ProductCategory ProductCategory { get; set; }
    }
}
