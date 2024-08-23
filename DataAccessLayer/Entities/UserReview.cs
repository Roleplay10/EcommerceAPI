namespace DataAccessLayer.Entities
{
    public class UserReview
    {
        public required Guid Id { get; set; }
        public required Guid UserId { get; set; }
        public required Guid OrderProductId { get; set; }
        public required float RatingValue { get; set; }
        public string? Comment { get; set; }

        public User User { get; set; }
    }
}
