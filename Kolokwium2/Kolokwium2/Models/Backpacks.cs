using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Models;

[PrimaryKey(nameof(CharacterId), nameof(ItemId))]
public class Backpacks
{
    public int CharacterId { get; set; }
    public int ItemId { get; set; }
    public int Amount { get; set; }

    [ForeignKey(nameof(CharacterId))] public Character Character { get; set; } = null!;

    [ForeignKey(nameof(ItemId))] public Items Items { get; set; } = null!;

    public ICollection<Items> ItemsCollection { get; set; } = null;

}