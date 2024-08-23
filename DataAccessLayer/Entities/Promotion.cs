namespace DataAccessLayer.Entities
{
    public class Promotion
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string DiscountRate { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }


        public ICollection<PromotionCategory> PromotionCategories { get; set; }
    }
}
