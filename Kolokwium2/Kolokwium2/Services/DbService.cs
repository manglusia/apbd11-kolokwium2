using Kolokwium2.Data;
using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<ICollection<Character>> GetCharacter(int characterId)
    {
        return await _context.Characters
            .Include(e => e.CharacterTitles)
            .Include(e => e.Backpacks)
            .ThenInclude(e => e.Items)
            .Where(e => e.Id == characterId)
            .ToListAsync();
    }

    public async Task<bool> DoesCharacterExist(int characterId)
    {
        return await _context.Characters.AnyAsync(e => e.Id == characterId);
    }
    
}