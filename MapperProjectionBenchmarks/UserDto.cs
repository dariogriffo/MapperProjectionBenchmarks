public class UserDto
{
    public Guid Id { get; set; }

    public string DisplayName { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    public AddressDto Address { get; set; }

    public PostsSummaryDto PostsSummary { get; set; }
}