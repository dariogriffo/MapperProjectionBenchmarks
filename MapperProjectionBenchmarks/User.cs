public class User
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DisplayName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Guid AddressId { get; set; }
    
    public Address Address { get; set; }
    
    public PostsSummary PostsSummary { get; set; }
}