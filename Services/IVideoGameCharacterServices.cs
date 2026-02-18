using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services;

public interface IVideoGameCharacterServices
{
    Task<List<Character>> GetAllCharactersAsync();
    Task<Character> GetCharacterByIdAsync(int id);
    Task<Character> AddCharacterAsync(Character character);
    Task<bool > UpdateCharacterAsync(Character character);
    Task<bool> DeleteCharacterAsync(int id);
}