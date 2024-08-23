namespace DataAccessLayer.Entities
{
    public class User
    {
        public required Guid Id { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public required string Password { get; set; }
        

        public ICollection<ShopOrder> ShopOrders { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public ICollection<User_Address> User_Adrdresses { get; set; }
        public ICollection<UserPaymentMethod> UserPaymentMethods { get; set; }
        public ICollection<UserReview> UserReviews { get; set; }
    }
}
