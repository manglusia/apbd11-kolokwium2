using System.ComponentModel.DataAnnotations;

namespace Kolokwium2.Models;

public class Character
{
    [Key]
    public int Id { get; set; }
    [MaxLength(50)]
    public string? FirstName { get; set; }
    [MaxLength(120)]
    public string? LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }

    public ICollection<Backpacks> Backpacks { get; set; } = new HashSet<Backpacks>();
    public ICollection<CharacterTitles> CharacterTitles { get; set; } = new HashSet<CharacterTitles>();

    public ICollection<Items> Items { get; set; } = new HashSet<Items>();
}