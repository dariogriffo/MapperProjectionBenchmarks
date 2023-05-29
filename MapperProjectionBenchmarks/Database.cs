using Microsoft.EntityFrameworkCore;

public class Database : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options
            .UseNpgsql("Host=localhost; Database=automapper; Username=postgres; Password=postgres")
            .UseSnakeCaseNamingConvention();
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<PostsSummary> PostsSummaries { get; set; }
}