namespace DataAccessLayer.Entities
{
    public class VariationOption
    {
        public required Guid Id { get; set; }
        public required Guid VariantionId { get; set; }
        public required float Value { get; set; }
    }
}
