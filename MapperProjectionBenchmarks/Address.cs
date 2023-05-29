public class Address
{
    public Address()
    {
        Users = new HashSet<User>();
    }
    public Guid Id { get; set; }
    public string FirstLine { get; set; }
    public string? SecondLine { get; set; }
    public string PostCode { get; set; }
    public ICollection<User> Users { get; set; } = null!;
}