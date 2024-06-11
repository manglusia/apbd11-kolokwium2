using Kolokwium2.Models;
namespace Kolokwium2.Services;

public interface IDbService
{
    Task<ICollection<Character>> GetCharacter(int characterId);
    Task<bool> DoesCharacterExist(int characterId);
}