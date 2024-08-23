namespace DataAccessLayer.Entities
{
    public class OrderLine
    {
        public required Guid Id { get; set; }
        public required Guid ProductItemId { get; set; }
        public required Guid OrderId { get; set; }
        public required int QTY { get; set; }
        public required float Price { get; set; }
    }
}
