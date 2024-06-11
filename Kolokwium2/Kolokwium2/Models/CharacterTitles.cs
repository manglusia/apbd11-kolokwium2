using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Models;

[PrimaryKey(nameof(CharacterId),nameof(TitleId))]
public class CharacterTitles
{
    public int CharacterId { get; set; }
    public int TitleId { get; set; }
    public DateTime AcquiredAt { get; set; }

    [ForeignKey(nameof(CharacterId))] public Character Character { get; set; } = null!;

    [ForeignKey(nameof(TitleId))] public Items Items { get; set; } = null!;
}