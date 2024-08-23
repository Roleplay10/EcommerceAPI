namespace DataAccessLayer.Entities
{
    public class Variation
    {
        public required Guid Id { get; set; }
        public required Guid CategoryId { get; set; }
        public required string Name { get; set; }


        public ProductCategory ProductCategory { get; set; }
    }
}
