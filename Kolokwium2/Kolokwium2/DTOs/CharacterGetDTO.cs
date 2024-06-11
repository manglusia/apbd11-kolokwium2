using Kolokwium2.Models;

namespace Kolokwium2.DTOs;

public class CharacterGetDTO
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int CurrentWeight { get; set; }
    public int MaxWeight { get; set; }
    public ICollection<GetBackpackDTO> Backpacks { get; set; } = new HashSet<GetBackpackDTO>();
    public ICollection<CharacterTitleDTO> Title { get; set; } = new HashSet<CharacterTitleDTO>();
    public ICollection<ItemDTO> Items { get; set; } = new HashSet<ItemDTO>();
}

public class GetBackpackDTO
{
    public int CharacterId { get; set; }
    public int ItemId { get; set; }
    public int Amount { get; set; }
}

public class ItemDTO
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Weight { get; set; }
}

public class CharacterTitleDTO
{
    public int CharacterId { get; set; }
    public int TitleId { get; set; }
    public DateTime AcquiredAt { get; set; }
}