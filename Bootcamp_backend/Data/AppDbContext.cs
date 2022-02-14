using Bootcamp_backend.Models;

namespace Bootcamp_backend.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
    public DbSet<User> userInfo { get; set; }
    public DbSet<Daire> daireInfo { get; set; }
}