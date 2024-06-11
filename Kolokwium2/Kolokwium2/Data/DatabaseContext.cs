using Kolokwium2.Models;
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
    
    public DbSet<Character> Characters { get; set; }
    public DbSet<Items> Items { get; set; }
    public DbSet<Titles> Titles { get; set; }
    public DbSet<CharacterTitles> CharacterTitles { get; set; }
    public DbSet<Backpacks> Backpacks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        //na przykład takie coś żeby zrobić inserty
        modelBuilder.Entity<Character>().HasData(new List<Character>
        {
            new Character {
                Id = 1,
                FirstName = "Jan",
                LastName = "Kowalski",
                CurrentWeight = 80,
                MaxWeight = 120
            },
            new Character {
                Id = 2,
                FirstName = "Anna",
                LastName = "Nowak",
                CurrentWeight = 60,
                MaxWeight = 90
            }
        });

        modelBuilder.Entity<Items>().HasData(new List<Items>
        {
            new Items
            {
                Id = 1,
                Name = "miecz",
                Weight = 8
            },
            new Items
            {
                Id = 2,
                Name = "Luk",
                Weight = 3
            }
        });

        modelBuilder.Entity<Titles>().HasData(new List<Titles>
        {
            new Titles
            {
                Id = 1,
                Name = "Lucznik"
            },
            new Titles
            {
                Id = 2,
                Name = "Rycerz"
            }
        });

        modelBuilder.Entity<Backpacks>().HasData(new List<Backpacks>
        {
            new Backpacks
            {
                CharacterId = 1,
                ItemId = 2,
                Amount = 1
            },
            new Backpacks
            {
                CharacterId = 2,
                ItemId = 1,
                Amount = 2
            }
        });

        modelBuilder.Entity<CharacterTitles>().HasData(new List<CharacterTitles>
        {
            new CharacterTitles
            {
                CharacterId = 1,
                TitleId = 2,
                AcquiredAt = DateTime.Parse("1250-09-21")
            },
            new CharacterTitles
            {
                CharacterId = 2,
                TitleId = 1,
                AcquiredAt = DateTime.Parse("1292-12-6")
            }
        });
    }

}