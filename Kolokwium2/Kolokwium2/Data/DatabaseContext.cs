using Microsoft.EntityFrameworkCore;
namespace Kolokwium2.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }
    
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    
    //na przykład takei coś
    public DbSet<Pastry> Pastries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        //na przykład takie coś żeby zrobić inserty
        modelBuilder.Entity<Client>().HasData(new List<Client>
        {
            new Client {
                Id = 1,
                FirstName = "Jan",
                LastName = "Kowalski"
            },
            new Client {
                Id = 2,
                FirstName = "Anna",
                LastName = "Nowak"
            }
        });
        
    }

}