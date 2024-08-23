namespace DataAccessLayer.Entities
{
    public class ProductCategory
    {
        public required Guid Id { get; set; }
        public required Guid ParentCategoryId { get; set; }
        public required string Name { get; set; }

        public ProductCategory ParentCategory { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Variation> Variations { get; set; }

    }
}
