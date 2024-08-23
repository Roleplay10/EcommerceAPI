namespace DataAccessLayer.Entities
{
    public class ProductConfiguration
    {
        public required Guid ProductItemId { get; set; }
        public required Guid VariationOptionId { get; set; }
    }
}
