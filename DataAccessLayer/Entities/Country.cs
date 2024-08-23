namespace DataAccessLayer.Entities
{
    public class Country
    {
        public required Guid Id { get; set; }
        public required string Name { get; set; }


        public ICollection<Address> Address { get; set; }
    }
}
