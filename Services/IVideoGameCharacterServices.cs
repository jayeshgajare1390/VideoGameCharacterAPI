using VideoGameCharacterAPI.Dtos;
using VideoGameCharacterAPI.Models;

namespace VideoGameCharacterAPI.Services;

public interface IVideoGameCharacterServices
{
    Task<List<CharacterResponce>> GetAllCharactersAsync();
    Task<CharacterResponce> GetCharacterByIdAsync(int id);
    Task<Character> AddCharacterAsync(Character character);
    Task<bool > UpdateCharacterAsync(Character character);
    Task<bool> DeleteCharacterAsync(int id);
}