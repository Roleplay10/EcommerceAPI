namespace DataAccessLayer.Entities
{
    public class PromotionCategory
    {
        public required Guid CategoryId { get; set; }
        public required Guid PromotionId { get; set; }


        public Promotion Promotion { get; set; }
    }
}
